using AutoMapper;
using jap_task1_backend.Data;
using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
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
                .Include(x => x.Actors)
                .Include(x => x.Categories)
                .Include(x => x.Ratings)
                .FirstOrDefaultAsync(x => x.Id == Id);

            serviceResponse.Data = _mapper.Map<GetVideoFullInfoDTO>(video);
            return serviceResponse;
        }



    }
}
