using System;
using System.Collections.Generic;

namespace jap_task1_backend.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image_Url { get; set; }
        public short Type { get; set; }
        public DateTime ReleaseDate { get; set; }
        public List<ActorVideo> ActorVideos { get; set; } = new List<ActorVideo>();
        public List<CategoryVideo> CategoryVideos { get; set; } = new List<CategoryVideo>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }
}
