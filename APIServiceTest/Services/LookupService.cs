using APIServiceTest.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIServiceTest.Services
{
    public class LookupService<TEntity> : ILookupService<TEntity>
    {
        private readonly ILookupRepository<TEntity> _lookupRepository;
        public LookupService(ILookupRepository<TEntity> lookupRepository)
        {
            _lookupRepository = lookupRepository;
        }

        public async Task<int> AddEntryAsync(TEntity e)
        {
            return await _lookupRepository.AddEntryAsync(e);
        }

        public List<TEntity> GetAll()
        {
            return _lookupRepository.GetAll();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _lookupRepository.GetAllAsync();
        }
    }
}
