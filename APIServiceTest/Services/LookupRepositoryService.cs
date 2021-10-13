using APIServiceTest.Interfaces;
using APIServiceTest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServiceTest.Services
{
    public class LookupRepository<TEntity> : ILookupRepository<TEntity> where TEntity : class
    {
        private readonly ApiDBContext _context;
        public LookupRepository(ApiDBContext context)
        {
            _context = context;
        }

        public List<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }
    }
}
