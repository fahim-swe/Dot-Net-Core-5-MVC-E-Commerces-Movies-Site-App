using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Services;
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
            var data = await _service.getAll();
            return View(data);
        }
    }
}
