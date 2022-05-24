using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
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
        public IActionResult GetMatch(int matchId)
        {
            var match = _service.MatchService.GetMatchById(matchId, trackChanges: false);
            return Ok(match);
        }
        [HttpPost("{winId:int}")]//TODO:Fortsätt här, ska skicka in 2 st olika hamster id. 
    }
}
