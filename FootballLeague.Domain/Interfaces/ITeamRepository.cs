using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Interfaces
{
    public interface ITeamRepository
    {
        Task<List<Team>> GetAll();
        Task<Team> GetById(int teamId);
        Task Add(int teamId);
        Task Delete(int teamId);
    }
}
