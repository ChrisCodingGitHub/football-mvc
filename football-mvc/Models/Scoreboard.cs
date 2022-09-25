using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace football_mvc.Models
{
    public class Scoreboard
    {
        public int Away { get; set; }
        public int Home { get; set; }
        public int Period { get; set; }
        public int RemainingTime { get; set; }
    }
}
