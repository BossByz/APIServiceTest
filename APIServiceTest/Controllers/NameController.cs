using APIServiceTest.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace APIServiceTest.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class NameController : ControllerBase
    {
        private readonly INames _nameService;
        public NameController(INames nameService)
        {
            _nameService = nameService;
        }

        [HttpGet]
        [Route("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_nameService.GetAll());
        }

        [HttpGet]
        [Route("GetAllAsync")]
        public IActionResult GetAllAsync()
        {
            return Ok(_nameService.GetAllAsync().Result);
        }
    }
}
