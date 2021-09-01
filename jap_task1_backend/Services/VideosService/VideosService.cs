using jap_task1_backend.Data;
using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend.Services.VideosService
{
    public class VideosService : IVideosService
    {
        private readonly DataContext _context;

        public VideosService(DataContext context)
        {            
            _context = context;
        }

        public async Task<ServiceResponse<List<GetVideoDTO>>> GetTopMovies()
        {
            var serviceResponse = new ServiceResponse<List<GetVideoDTO>>();

            return serviceResponse;
        }

        
    }
}
