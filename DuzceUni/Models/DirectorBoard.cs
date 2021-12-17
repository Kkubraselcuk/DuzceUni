using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Models
{
    public class DirectorBoard
    {
        [Key]
        public int DirectorBoardId { get; set; }
        public string DirectorBoardName { get; set; }

        public int WorkId { get; set; }
        public Work Work { get; set; }
    }
}
