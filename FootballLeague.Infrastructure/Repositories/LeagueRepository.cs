
using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;
using FootballLeague.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
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

        public async Task<League> Get(int leagueId)
        {
            var league = await _dbContext.Leagues
                .Include(l => l.Teams)
                .FirstOrDefaultAsync(l => l.Id == leagueId);
            return league;
        }
    }
}
