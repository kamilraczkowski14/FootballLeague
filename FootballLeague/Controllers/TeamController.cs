using FootballLeague.Application.Services;
using FootballLeague.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Newtonsoft.Json;

namespace FootballLeague.Controllers
{
    [Authorize]
    public class TeamController : Controller
    {
        private readonly ITeamService _service;

        public TeamController(ITeamService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var teams = await _service.GetAll();
            return View(teams);
        }


        [HttpGet("Team/TeamDetail")]
        [AllowAnonymous]
        public async Task<IActionResult> TeamDetail(int teamId)
        {
            var team = await _service.GetById(teamId);
            return PartialView("_TeamDetails", team);
        }

        [HttpPost]
        public async Task<IActionResult> Add(int teamId)
        {
            await _service.Add(teamId);

            return RedirectToAction("Index", "League");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int teamId)
        {
            await _service.Delete(teamId);

            return Ok(new { success = true });
        }
    }
}
