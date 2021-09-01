using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jap_task1_backend.Models
{
    public class CategoryVideo
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int VideoId { get; set; }
    }
}
