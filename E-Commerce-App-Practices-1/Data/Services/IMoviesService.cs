using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Data.ViewModels;
using E_Commerce_App_Practices_1.Models;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public interface IMoviesService : IEntityBaseRepository<Movie>
    {
        Task<Movie> GetMovieByIdAsync(int id);
        Task<NewMovieDropdownsVM> GetNewMovieDropdownValues();

        Task AddNewMovie(NewMovieVM data);
    }
}
