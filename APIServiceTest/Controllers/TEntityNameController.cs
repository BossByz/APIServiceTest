using APIServiceTest.Interfaces;
using APIServiceTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace APIServiceTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TEntityNameController : ControllerBase
    {
        private readonly ILookupService<Name> _lookupService;
        public TEntityNameController(ILookupService<Name> lookupService)
        {
            _lookupService = lookupService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_lookupService.GetAll());
        }

        [HttpGet]
        [Route("GetAllAsync")]
        public IActionResult GetAllAsync()
        {
            return Ok(_lookupService.GetAllAsync().Result);
        }
    }
}
