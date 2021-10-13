using APIServiceTest.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APIServiceTest.Interfaces
{
    public interface INames
    {
        List<Name> GetAll();

        Task<List<Name>> GetAllAsync();
    }
}
