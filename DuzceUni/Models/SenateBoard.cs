using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Models
{
    public class SenateBoard
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
       
        public int WorkId { get; set; }
        public Work Work { get; set; }
    }
}
