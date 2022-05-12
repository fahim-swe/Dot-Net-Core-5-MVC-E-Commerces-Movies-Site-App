using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Data.ViewModels;
using E_Commerce_App_Practices_1.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public class MoviesService: EntityBaseRepository<Movie>, IMoviesService
    {
        private readonly AppDbContext _context;
        public MoviesService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task<Movie> GetMovieByIdAsync(int id)
        {
            var movieDetails = _context.Movies.Include(c => c.Cinema)
                .Include(p => p.Producer)
                .Include(am => am.Actors_Movies)
                .ThenInclude(a => a.Actor)
                .FirstOrDefaultAsync(n => n.Id == id);

            return await movieDetails;
        }

        public async Task<NewMovieDropdownsVM> GetNewMovieDropdownValues()
        {
            var response = new NewMovieDropdownsVM()
            {
                Actors = await _context.Actors.OrderBy( n => n.FullName).ToListAsync(),
                Cinemas = await _context.Cinema.OrderBy( c => c.Name).ToListAsync(),
                Producers  = await _context.Producers.OrderBy( p => p.FullName).ToListAsync()
            };

            return response;
        }
    }
}
