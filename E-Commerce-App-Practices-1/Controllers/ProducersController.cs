using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Controllers
{
    public class ProducersController : Controller
    {
        private readonly IProducersService _service;

        public ProducersController(IProducersService service)
        {
            _service = service;
        }


        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.getAllAsync();
            return View(allProducers);
        }



       
    }
}
