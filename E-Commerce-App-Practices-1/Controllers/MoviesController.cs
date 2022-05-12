using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Services;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Create()
        {
            ViewData["Name"] = "Spider No Way Home";
            ViewBag.Description = "This is Spider Man No Way Home";
            return View();
        }
    }
}
