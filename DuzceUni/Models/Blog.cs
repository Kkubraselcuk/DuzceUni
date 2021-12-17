using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Models
{
    public class Blog
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Short_Description { get; set; }
        public string Description { get; set; }
        public string Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
