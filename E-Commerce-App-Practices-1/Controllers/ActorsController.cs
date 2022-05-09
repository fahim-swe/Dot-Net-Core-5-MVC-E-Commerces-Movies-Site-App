using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Services;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Controllers
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
            var data = await _service.getAllAsync();
            return View(data);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }



        // Get : Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _service.getByIdAsync(id);
            if (actorDetails == null) return View("Empty");

            return View(actorDetails);
        }


        // Get : Actors/Edit/1
        public async Task<IActionResult> Edit(int id)
        {
            var actorDetails = await _service.getByIdAsync(id);
            if (actorDetails == null) return View("Empty");

            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id, FullName, ProfilePictureURL, Bio")] Actor actor)
        {
            if (!ModelState.IsValid)
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);
            return RedirectToAction(nameof(Index));
        }
    }
}
