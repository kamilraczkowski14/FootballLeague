using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;

namespace FootballLeague.Application.Services
{
    public class LeagueService : ILeagueService
    {
        private readonly ILeagueRepository _leagueRepository;
        private readonly IMapper _mapper;

        public LeagueService(ILeagueRepository leagueRepository, IMapper mapper)
        {
            _leagueRepository = leagueRepository;
            _mapper = mapper;
        }

        public async Task<LeagueDto> Get(int leagueId)
        {
            var league = await _leagueRepository.Get(leagueId);

            var leagueDto = _mapper.Map<LeagueDto>(league);

            return leagueDto;
        }
    }
}
