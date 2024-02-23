using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Services
{
    public class TeamService : ITeamService
    {
        public Task<List<Team>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Team> GetById(int teamId)
        {
            throw new NotImplementedException();
        }
    }
}
