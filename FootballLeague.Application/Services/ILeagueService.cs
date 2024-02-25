using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Services
{
    public interface ILeagueService
    {
        Task<LeagueDto> Get(int leagueId);
    }
}
