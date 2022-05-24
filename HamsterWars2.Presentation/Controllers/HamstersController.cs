using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWars2.Presentation.Controllers
{
    [Route("api/hamsters")]
    [ApiController]
    public class HamstersController : ControllerBase
    {
        private readonly IServiceManager _service;

        public HamstersController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult GetHamsters()
        {
            
            var hamsters = _service.HamsterService.GetAllHamsters(trackChanges: false);

                return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name ="HamsterById")]
        public IActionResult GetHamster(int id)
        {
            var hamster = _service.HamsterService.GetHamsterById(id,trackChanges:false);

            return Ok(hamster);
        }
        [HttpPost]
        public IActionResult CreateHamster([FromBody] HamsterForCreationDto hamster)
        {
            if (hamster is null)
            {
                return BadRequest("Hamster Object is null.");
            }
            var createdHamster = _service.HamsterService.CreateHamster(hamster);
            return CreatedAtRoute("HamsterById", new {id = createdHamster.Id},createdHamster);
        }
    }
}
