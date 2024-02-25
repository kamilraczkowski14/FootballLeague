using AutoMapper;
using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _repository;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Add(int teamId)
        {
            await _repository.Add(teamId);
        }

        public async Task Delete(int teamId)
        {
            await _repository.Delete(teamId);
        }

        public async Task<List<TeamDto>> GetAll()
        {
            var teams = await _repository.GetAll();

            var teamsDto = _mapper.Map<List<TeamDto>>(teams);

            return teamsDto;
        }

        public async Task<TeamDto> GetById(int teamId)
        {
            var team = await _repository.GetById(teamId);
            var teamDto = _mapper.Map<TeamDto>(team);
            return teamDto;
        }
    }
}
