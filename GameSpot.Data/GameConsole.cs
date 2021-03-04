using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpot.Data
{
    public class GameConsole
    {
        [Key]
        public int GameConsoleId { get; set; }
        public string Console { get; set; }
        public string Manufacturer { get; set; }
       
    }
}
