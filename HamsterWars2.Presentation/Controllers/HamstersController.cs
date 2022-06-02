using HamsterWars2.Presentation.ActionFilters;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

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
        public async Task<IActionResult> GetHamsters()
        {

            var hamsters = await _service.HamsterService.GetAllHamstersAsync(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet("{id:int}", Name = "HamsterById")] // Tar fram Hamster efter Id 
        public async Task<IActionResult> GetHamster(int id)
        {
            var hamster = await _service.HamsterService.GetHamsterByIdAsync(id, trackChanges: false);

            return Ok(hamster);
        }
        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]//Skapar ny hamster 
        public async Task<IActionResult> CreateHamster([FromBody] HamsterForCreationDto hamster)
        {
            //if (hamster is null)
            //{
            //    return BadRequest("Hamster Object is null.");
            //}
            var createdHamster = await _service.HamsterService.CreateHamsterAsync(hamster);

            return CreatedAtRoute("HamsterById", new { id = createdHamster.Id }, createdHamster);
        }

        [HttpPut("{id:int}")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> UpdateHamster(int id, [FromBody] HamsterForUpdateDto hamsterForUpdateDto)
        {
           await _service.HamsterService.UpdateHamsterGamesAsync(id, hamsterForUpdateDto, trackChanges: true);
            return NoContent();
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteHamster(int id)
        {
            await _service.HamsterService.DeleteHamsterByIdAsync(id, trackChanges: true);

            return Ok();
        }
        [HttpGet]
        [Route("/winners")]
        public async Task<IActionResult> GetWinners()
        {
            var hamsters = await _service.HamsterService.GetWinnersAsync(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet]
        [Route("/losers")]
        public async Task<IActionResult> GetLosers()
        {
            var hamsters = await _service.HamsterService.GetLosersAsync(trackChanges: false);

            return Ok(hamsters);
        }
        [HttpGet]
        [Route("/random")]
        public async Task<IActionResult> RandomHamster()
        {
            var hamster = await _service.HamsterService.GetRandomHamsterAsync(trackChanges: false);

            return CreatedAtRoute("HamsterById", new { id = hamster.Id }, hamster);
        }

    }

}
