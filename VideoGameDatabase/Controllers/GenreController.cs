using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoGameDatabase.Models;

namespace VideoGameDatabase.Controllers
{
    public class GenreController : Controller
    {
        public async Task<IActionResult> Index()
        {
            GenreList genres = await GameDetailsAPI.GetGenreList();
            genres.results = genres.results.OrderBy(o => o.name).ToList();

            return View(genres);
        }

        public async Task<IActionResult> TopPage(int id)
        {
            APIListGames games = await GameDetailsAPI.GetTopRated(id);
            string name = await GameDetailsAPI.GetGenreName(id);
            ViewBag.name = name;
            return View(games);
        }
    }
}
