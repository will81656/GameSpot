using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSpot.Data
{
    public enum MaturityRating { EC = 1, E, T, M, RP, AO }
    public enum Genre { Sandbox = 1, RTS, FPS, MOBA, RPG, Sports, Puzzle, Party, Adventure, Survival, Horror, Platformer }
    public class Game
    {
        [Key]
        public int GameId { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string Name { get; set; }

        [Required]
        [Range(1950, 3000, ErrorMessage = "please choose a year after c")]
        public int YearOfRelease { get; set; }
        [Required]
        public string GameDescription { get; set; }

        public virtual List<string> ListofGames { get; }

    }
}
