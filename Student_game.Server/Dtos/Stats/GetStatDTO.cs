using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Student_game.Server.Dtos.Stats
{
    public class GetStatDTO
    {
        public int Id { get; set;}

        [Required]
        public string Nickname { get; set;} = string.Empty;

        [Required]
        public int Fights { get; set; } = 0;
        
        [Required]
        public int Victories { get; set; } = 0;
        
        [Required]
        public int Defeats { get; set; } = 0;

        public Ranks? Rank { get; set; } = null;
    }
}