using E_Commerce_App_Practices_1.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public class ActorsService : IActorsService
    {
        
        private readonly AppDbContext _context;

        public ActorsService(AppDbContext context)
        {
            _context = context;
        }


        public async Task AddAsync(Actor actor)
        {
            await _context.Actors.AddAsync(actor);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Actor>> getAllAsync()
        {
            var result = await _context.Actors.ToListAsync();

            return result;
        }

        public async Task<Actor> getByIdAsync(int id)
        {
            var resutl = await _context.Actors.FirstOrDefaultAsync(n => n.Id == id);
            return resutl;
        }

        public async Task<Actor> UpdateAsync(int id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
    }
}
