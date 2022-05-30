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
        [HttpGet]//Tar fram alla Hamstrar
        public IActionResult GetHamsters()
        {

            var hamsters = _service.HamsterService.GetAllHamsters(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name = "HamsterById")] // Tar fram Hamster efter Id 
        public IActionResult GetHamster(int id)
        {
            var hamster = _service.HamsterService.GetHamsterById(id, trackChanges: false);

            return Ok(hamster);
        }
        [HttpPost] //Skapar ny hamster 
        public IActionResult CreateHamster([FromBody] HamsterForCreationDto hamster)
        {
            if (hamster is null)
            {
                return BadRequest("Hamster Object is null.");
            }
            var createdHamster = _service.HamsterService.CreateHamster(hamster);
            return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
        }

        [HttpPut("{id:int}")]
        public IActionResult UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamsterForUpdateDto)
        {
            _service.HamsterService.UpdateHamsterGames(id, hamsterForUpdateDto, trackChanges: true);
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public IActionResult DeleteHamster(int id)
        {
            _service.HamsterService.DeleteHamsterById(id, trackChanges: true);

            return Ok();
        }
        [HttpGet]
        [Route("/winners")]
        public IActionResult GetWinners()
        {
            var hamsters = _service.HamsterService.GetWinners(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet]
        [Route("/losers")]
        public IActionResult GetLosers()
        {
            var hamsters = _service.HamsterService.GetLosers(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet]
        [Route("/random")]
        public IActionResult RandomHamster()
        {
            var hamster = _service.HamsterService.GetRandomHamster(trackChanges: false);

            return CreatedAtRoute("HamsterById", new { id = hamster.Id }, hamster);
        }

    }

}
