using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Models;


namespace E_Commerce_App_Practices_1.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context)
        {

        }
    }
}
