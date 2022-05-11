using E_Commerce_App_Practices_1.Data;
using E_Commerce_App_Practices_1.Data.Base;
using E_Commerce_App_Practices_1.Data.Services;
using E_Commerce_App_Practices_1.Models;

namespace E_Commerce_App_Practices_1.Data.Services
{
    public class ProducersService: EntityBaseRepository<Producer>, IProducersService
    {
        public ProducersService (AppDbContext context) : base(context)
        {

        }
    }
}


