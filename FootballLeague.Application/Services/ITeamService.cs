using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Services
{
    public interface ITeamService
    {
        Task<List<TeamDto>> GetAll();
        Task<TeamDto> GetById(int teamId);
        Task Add(int teamId);
        Task Delete(int teamId);
    }
}
