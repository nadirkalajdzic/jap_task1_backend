using AutoMapper;
using jap_task1_backend.Data;
using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace jap_task1_backend.Services.VideosService
{
    public class VideosService : IVideosService
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;

        public VideosService(IMapper mapper, DataContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<ServiceResponse<List<GetVideoDTO>>> GetTopVideos(int type)
        {
            var serviceResponse = new ServiceResponse<List<GetVideoDTO>>();

            var topMovies = await _context.Videos.Include(x => x.Ratings)
                                                 .AsSplitQuery()
                                                 .Where(x => x.Type == type)
                                                 .ToListAsync();

            var topMoviesDTO = topMovies.Select(x => _mapper.Map<GetVideoDTO>(x)).ToList();
            topMoviesDTO = topMoviesDTO.OrderByDescending(x => x.Ratings.Select(x => x.Value).Average()).ToList();
            
            serviceResponse.Data = topMoviesDTO;
            return serviceResponse;
        }

        public async Task<ServiceResponse<GetVideoFullInfoDTO>> GetVideo(int Id)
        {
            ServiceResponse<GetVideoFullInfoDTO> serviceResponse = new ServiceResponse<GetVideoFullInfoDTO>();

            var video = await _context.Videos
                .Include(x => x.Actors).AsSplitQuery()
                .Include(x => x.Categories).AsSplitQuery()
                .Include(x => x.Ratings).AsSplitQuery()
                .FirstOrDefaultAsync(x => x.Id == Id);

            serviceResponse.Data = _mapper.Map<GetVideoFullInfoDTO>(video);
            return serviceResponse;
        }

        public async Task<ServiceResponse<List<GetVideoDTO>>> GetFilteredVideos(string Search)
        {

            ServiceResponse<List<GetVideoDTO>> serviceResponse = new();

            var query = _context.Videos.AsQueryable();
            AddFiltersForVideoSearch(Search, ref query);

            var videos = (await query.ToListAsync())
                .OrderByDescending(x => x.Ratings.Select(x => x.Value)
                                                 .DefaultIfEmpty()
                                                 .Average());

            serviceResponse.Data = videos.Select(x => _mapper.Map<GetVideoDTO>(x)).ToList();
            return serviceResponse;
        }

        private void AddFiltersForVideoSearch(string Search, ref IQueryable<Video> query)
        {

            var searchQuery = Regex.Split(Search, @"\s+").ToList();

            if (searchQuery.Count < 2)
            {
                query = query.Where(x => x.Title.ToUpper().Contains(Search.ToUpper()));
                return;
            }

            bool containingStringStar(string s) => s.ToUpper().Equals("STAR") || s.ToUpper().Equals("STARS");
            bool containingStringYear(string s) => s.ToUpper().Equals("YEAR") || s.ToUpper().Equals("YEARS");

            if (searchQuery.Count == 2) 
            {
                if (searchQuery[0].ToUpper().Equals("AFTER") && int.TryParse(searchQuery[1], out int ratingForSearchAfter))
                    query = query.Where(x => x.ReleaseDate.Year > ratingForSearchAfter);
                else if (containingStringStar(searchQuery[1]) && float.TryParse(searchQuery[0], out float exactRating))
                    query = query.Where(x => x.Ratings.Select(x => x.Value).Average() == exactRating);
                else 
                    query = query.Where(x => x.Title.ToUpper().Contains(Search.ToUpper()));
            } 
            else if(searchQuery.Count == 4)
            {
                if (searchQuery[0].ToUpper().Equals("AT") && searchQuery[1].ToUpper().Equals("LEAST")
                 && float.TryParse(searchQuery[2], out float ratingForSearchAtLeast) 
                 && containingStringStar(searchQuery[3]))
                {
                    query = query.Where(x => x.Ratings.Select(x => x.Value).Average() >= ratingForSearchAtLeast);
                } 
                else if (searchQuery[0].ToUpper().Equals("OLDER") && searchQuery[1].ToUpper().Equals("THAN")
                        && int.TryParse(searchQuery[2], out int dateForSearchOlderThan) 
                        && containingStringYear(searchQuery[3]))
                {
                    query = query.Where(x => DateTime.Now.Year - x.ReleaseDate.Year > dateForSearchOlderThan);
                } 
            }
            else query = query.Where(x => x.Title.ToUpper().Contains(Search.ToUpper()));

        }



    }
}
