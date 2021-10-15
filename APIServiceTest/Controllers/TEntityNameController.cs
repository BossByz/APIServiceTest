using APIServiceTest.Interfaces;
using APIServiceTest.Models;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpPost]
        [Route("AddEntryAsync")]
        public IActionResult AddEntryAsync(string name)
        {
            try
            {
                return Ok(_lookupService.AddEntryAsync(new Name() { Name1 = name }));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}
