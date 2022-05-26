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
        public IActionResult GetMatches()
        {
            var matches = _service.MatchService.GetAllMatches(trackChanges: false);

            return Ok(matches);
        }
        [HttpGet("{id:int}", Name ="MatchById")]
        public IActionResult GetMatch(int id)
        {
            var match = _service.MatchService.GetMatchById(id, trackChanges: false);
            return Ok(match);
        }
        [HttpPost]//Tar in vinnar Id och förlorar Id i body
        public IActionResult CreateMatch([FromBody] MatchForCreationDto match)
        {
            var createdMatch = _service.MatchService.CreateMatch(match);

            return CreatedAtRoute("MatchById", new { id = createdMatch.Id }, createdMatch);
        }
    }
}
