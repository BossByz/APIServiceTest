using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIServiceTest.Interfaces
{
    public interface ILookupRepository<TEntity>
    {
        List<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        Task<int> AddEntryAsync(TEntity e);
    }
}
