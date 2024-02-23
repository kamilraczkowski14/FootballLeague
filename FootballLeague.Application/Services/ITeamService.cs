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
        Task<List<Team>> GetAll();
        Task<Team> GetById(int teamId);
    }
}
