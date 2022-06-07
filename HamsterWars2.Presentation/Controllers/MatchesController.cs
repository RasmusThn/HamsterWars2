using HamsterWars2.Presentation.ActionFilters;
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
    [Route("api/matches")]
    [ApiController]
    public class MatchesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public MatchesController(IServiceManager service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetMatches()
        {
            var matches = await _service.MatchService.GetAllMatchesAsync(trackChanges: false);

            return Ok(matches);
        }
        [HttpGet("{id:int}", Name ="MatchById")]
        public async Task<IActionResult> GetMatch(int id)
        {
            var match = await _service.MatchService.GetMatchByIdAsync(id, trackChanges: false);
            return Ok(match);
        }
        [HttpPost]//Tar in vinnar-Id och förlorar-Id i body
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateMatch([FromBody] MatchForCreationDto match)
        {
            var createdMatch = await _service.MatchService.CreateMatchAsync(match);

            return CreatedAtRoute("MatchById", new { id = createdMatch.Id }, createdMatch);
        }
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMatch(int id)
        {
            await _service.MatchService.DeleteMatchByIdAsync(id,trackChanges:false);
            return Ok();
        }
        [HttpGet]
        [Route("/matchwinners/{id:int}")]
        public async Task<IActionResult> GetAllMatchesForHamsterById(int id)
        {
            var hamsterMatches = await _service.MatchService.GetAllMatchesByHamsterIdAsync(id, trackChanges:false);

            return Ok(hamsterMatches);
        }
        //TODO: En likadan fast för förlorade matcher.
    }
}
