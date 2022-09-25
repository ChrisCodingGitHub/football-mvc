using football_mvc.Models;
using System.Text;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Mvc;

namespace football_mvc.Models.Services
{
    public class GamesService
    {
        private StreamReader sr = new StreamReader("Lib/Assets/Data/games-mock-data.json");
        public GamesService()
        {

        }
        public Game[] GetAllGames()
        {
            return JsonSerializer.Deserialize<APIResult<Game>>(sr.ReadToEnd()).Data;
        }
        [HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("Games/GetGameById/{gameId}")]
        public Game GetGameById(int gameId)
        {
            return JsonSerializer.Deserialize<APIResult<Game>>(sr.ReadToEnd()).Data.First(result => result.Id == gameId);
        }
    }
}
