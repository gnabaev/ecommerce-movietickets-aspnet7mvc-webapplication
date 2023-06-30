using eMovieTickets.Data;
using eMovieTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Controllers
{
    public class MoviesController : Controller
    {
        private readonly IMoviesService _service;

        public MoviesController(IMoviesService service)
        {
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var allMovies = await _service.GetAllAsync(n => n.Cinema);
            return View(allMovies);
        }

        //Get: Movies/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var moviesDetails = await _service.GetMovieByIdAsync(id);
            return View(moviesDetails);
        }

        //Get: Movies/Create
        public IActionResult Create()
        {
            ViewData["Welcome"] = "Welcome to our store";
            ViewBag.Description = "This is the store description";
            return View();
        }

    }
}
