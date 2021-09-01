using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using jap_task1_backend.Services.VideosService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend.Controllers
{
    [ApiController]
    [Route("videos")]
    public class VideosController : ControllerBase
    {

        private readonly IVideosService _videosService;

        public VideosController(IVideosService videosService)
        {
            _videosService = videosService;
        }

        [HttpGet("top_movies")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopMovies()
        {
            return Ok(await _videosService.GetTopVideos(0));
        }

        [HttpGet("top_shows")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> GetTopShows()
        {
            return Ok(await _videosService.GetTopVideos(1));
        }
    }
}
