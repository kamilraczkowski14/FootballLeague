using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;

namespace FootballLeague.Application.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;

        public LeagueService(ILeagueRepository leagueRepository)
        {
            _leagueRepository = leagueRepository;
        }

        public async Task<League> Get(int leagueId)
        {
            var league = await _leagueRepository.Get(leagueId);
            return league;
        }
    }
}
