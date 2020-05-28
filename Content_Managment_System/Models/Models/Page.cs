using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Content_Managment_System.Models.Models
{
    public class Page:BaseEntity
    {
        [Required]
        [MinLength(2,ErrorMessage ="Minumum Length is 2")]
        public string Title { get; set; }
        public string Slug { get; set; }

        [Required]
        [MinLength(4, ErrorMessage = "Minumum Length is 4")]
        public string Content { get; set; }
        public int Sorting { get; set; }

    }
}
