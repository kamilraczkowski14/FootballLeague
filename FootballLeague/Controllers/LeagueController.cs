using FootballLeague.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeague.Controllers
{  
    public class LeagueController : Controller
    {
        private readonly ILeagueService _service;

        public LeagueController(ILeagueService service)
        {
            _service = service;
        }

        [HttpGet("League/{leagueId}")]
        public async Task<IActionResult> Index(int leagueId)
        {
            var league = await _service.Get(leagueId);
            return View(league);
        }
    }
}
