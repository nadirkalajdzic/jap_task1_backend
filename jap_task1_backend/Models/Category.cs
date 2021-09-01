using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jap_task1_backend.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CategoryVideo> CategoryVideos { get; set; } = new List<CategoryVideo>();
    }
}
