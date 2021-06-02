using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VideoGameDatabase.Models;

namespace VideoGameDatabase.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            //List<GameDetails> games = new List<GameDetails>();
            //int start = 200;
            //int end = 200;
            //for (int i = start; i <= end; i++)
            //{
            //    GameDetails game = await GameDetailsAPI.GetGame(i);
            //    games.Add(game);
            //}

            APIListGames theList = await GameDetailsAPI.GetListbyGenre();

            return View(theList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
