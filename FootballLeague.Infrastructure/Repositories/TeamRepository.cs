using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;
using FootballLeague.Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeamRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

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
