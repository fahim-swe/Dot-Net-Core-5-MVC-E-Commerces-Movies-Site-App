using E_Commerce_App_Practices_1.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace E_Commerce_App_Practices_1.Controllers
{
    public class ActorsController : Controller
    {
        private readonly AppDbContext _context;

        public ActorsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Actors.ToList();
            return View();
        }
    }
}
