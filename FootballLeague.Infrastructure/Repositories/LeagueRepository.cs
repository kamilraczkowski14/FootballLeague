
using AutoMapper;
using FootballLeague.Application.Dtos;
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
        private readonly IMapper _mapper;

        public LeagueRepository(ApplicationDbContext dbContext, IMapper mapper) 
        {
            _dbContext = dbContext;
            _mapper = mapper;
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
