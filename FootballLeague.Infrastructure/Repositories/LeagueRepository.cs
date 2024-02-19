using FootballLeague.Domain.Interfaces;
using FootballLeague.Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Repositories
{
    internal class LeagueRepository : ILeagueRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public LeagueRepository(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }
    }
}
