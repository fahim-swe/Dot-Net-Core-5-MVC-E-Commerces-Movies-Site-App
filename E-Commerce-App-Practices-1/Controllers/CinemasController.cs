using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Services;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Controllers
{
    public class CinemasController : Controller
    {
        private readonly ICinemasService _service;

        public CinemasController(ICinemasService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var allCinema = await _service.getAllAsync();
            return View(allCinema);
        }


        // Get/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var cinemasDetails = await _service.getByIdAsync(id);
            if(cinemasDetails == null)
            {
                return View("NotFound");
            }
            return View(cinemasDetails);
        }



        // create Cinemas
        // Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("Logo, Name , Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }
            await _service.AddAsync(cinema);
            return RedirectToAction(nameof(Index));
        }


        // Edit/Details/1
        public async Task<IActionResult> Edit(int id)
        {
            var cinemaDetails = await _service.getByIdAsync(id);
            if (cinemaDetails == null) return View("NotFound");
            return View(cinemaDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, Logo, Name, Description")] Cinema cinema)
        {
            if (!ModelState.IsValid)
            {
                return View(cinema);
            }

            if(id == cinema.Id)
            {
                await _service.UpdateAsync(id, cinema);
                return RedirectToAction(nameof(Index));
            }

            return View(cinema);
        }

    }
}
