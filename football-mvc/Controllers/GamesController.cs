using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using football_mvc.Models.Services;
using football_mvc.Models;

namespace football_mvc.Controllers
{
    public class GamesController : Controller
    {
        private GamesService _gamesService = new GamesService();
        public IActionResult Index()
        {
            ViewData["AllGames"] = _gamesService.GetAllGames();
            return View();
        }
        public IActionResult Game(int gameId)
        {
            ViewData["Game"] = _gamesService.GetGameById(gameId);
            return View();
        }
    }
}
