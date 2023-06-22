using eMovieTickets.Data;
using eMovieTickets.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eMovieTickets.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _service;

        public ActorsController(IActorsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allActors = await _service.GetAll();
            return View(allActors);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
