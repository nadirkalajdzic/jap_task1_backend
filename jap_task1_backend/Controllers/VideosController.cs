using jap_task1_backend.DTO.Video;
using jap_task1_backend.Models;
using jap_task1_backend.Services.VideosService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace jap_task1_backend.Controllers
{
    [ApiController]
    [Route("/movies")]
    public class VideosController : ControllerBase
    {

        private readonly IVideosService _videosService;

        public VideosController(IVideosService videosService)
        {
            _videosService = videosService;
        }

        [HttpGet("/")]
        public async Task<ActionResult<ServiceResponse<List<GetVideoDTO>>>> Get()
        {
            return Ok(await _videosService.GetTopMovies());
        }
    }
}
