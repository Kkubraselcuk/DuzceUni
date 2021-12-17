using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DuzceUni.Models
{
    public class Work
    {
        [Key]
        public int WorkId { get; set; }
        public string WorkName { get; set; }
        public List<SenateBoard> SenateBoard { get; } = new List<SenateBoard>();
        public List<DirectorBoard> DirectorBoard { get; } = new List<DirectorBoard>();
    }

}
