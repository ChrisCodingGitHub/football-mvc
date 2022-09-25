using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace football_mvc.Models
{
    public class Game
    {
        public int Id { get; set; }
        public Matchup Matchup { get; set; }
        public Scoreboard Scoreboard { get; set; }
        public string Status { get; set; }
        public string Summary { get; set; }
    }
}
