using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpot.Models
{
   public class ConsoleCreate
    {
        [Required]
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        
        public int YearOfRelease { get; set; }
        public string Description { get; set; }
    }
}
