using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend.Services.VideosService
{
    public interface IVideosService
    {
        Task<ServiceResponse<List<GetVideoDTO>>> GetTopVideos(int type);
        Task<ServiceResponse<Video>> GetVideo(int Id);
    }
}
