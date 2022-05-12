using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Services;
using E_Commerce_App_Practices_1.Data.ViewModels;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;


namespace E_Commerce_App_Practices_1.Controllers
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
            var moviesList = await _service.getAllAsync();
            return View(moviesList);
        }


        public async Task<IActionResult> Details(int id)
        {
            var movieDetails = await _service.GetMovieByIdAsync(id);
            if(movieDetails == null)
            {
                return View("NotFound");
            }
            return View(movieDetails);
        }
        

        // Get/Create
        public async Task<IActionResult> Create()
        {

            var movieDropdownsData = await _service.GetNewMovieDropdownValues();

            ViewBag.Cinemas = new SelectList(movieDropdownsData.Cinemas, "Id", "Name");
            ViewBag.Producers = new SelectList(movieDropdownsData.Producers, "Id", "FullName");
            ViewBag.Actors = new SelectList(movieDropdownsData.Actors, "Id", "FullName");

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create(NewMovieVM movie)
        {
            if (!ModelState.IsValid)
            {
                return View(movie);
            }

            await _service.AddNewMovie(movie);
            return RedirectToAction(nameof(Index));
        }
    }
}
