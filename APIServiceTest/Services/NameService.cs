using APIServiceTest.Interfaces;
using APIServiceTest.Managers;
using APIServiceTest.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APIServiceTest.Services
{
    public class NameService : INames
    {
        private readonly ApiDBContext _context;

        public NameService(ApiDBContext context)
        {
            Console.WriteLine("Connection String From Injected Class Is: " + ConfigurationManager.Configuration.GetSection("ConnectionStrings:ApiDB").Value);
            _context = context;
        }
        public List<Name> GetAll()
        {
            return _context.Names.ToList();
        }

        public async Task<List<Name>> GetAllAsync()
        {
            return await _context.Names.ToListAsync();
        }
    }
}
