using E_Commerce_App_Practices_1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public interface IActorsService
    {
        Task<IEnumerable<Actor>> getAll();

        Actor getById(int id);
        void Add(Actor actor);
        Actor Update(int id, Actor newActor);
        void Delete(int id);
    }
}
