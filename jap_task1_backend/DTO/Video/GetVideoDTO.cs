using jap_task1_backend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jap_task1_backend.DTO.Video
{
    public class GetVideoDTO
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image_Url { get; set; }
        public short Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
