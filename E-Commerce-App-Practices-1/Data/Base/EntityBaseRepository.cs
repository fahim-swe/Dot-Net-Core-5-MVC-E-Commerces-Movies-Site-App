using System.Collections.Generic;
using System.Threading.Tasks;

namespace E_Commerce_App_Practices_1.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        public Task AddAsync(T entity)
        {
            throw new System.NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<T>> getAllAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<T> getByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
