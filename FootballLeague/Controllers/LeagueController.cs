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

        [HttpGet]
        public async Task<IActionResult> Index(int leagueId=1)
        {
            var league = await _service.Get(leagueId);
            return View(league);
        }
    }
}
