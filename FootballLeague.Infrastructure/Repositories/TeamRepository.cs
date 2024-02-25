using FootballLeague.Application.Dtos;
using FootballLeague.Application.Services;
using FootballLeague.Domain.Entities;
using FootballLeague.Domain.Interfaces;
using FootballLeague.Infrastructure.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IUserContextService _userContextService;

        public TeamRepository(ApplicationDbContext dbContext, IUserContextService userContextService )
        {
            _dbContext = dbContext;
            _userContextService = userContextService;
        }

        public async Task Add(int teamId)
        {
            var team = await _dbContext.Teams
                .FirstOrDefaultAsync(t => t.Id == teamId);

            var userId = _userContextService.LoggedUserId;

            var user = await _dbContext.Users
                .Include(t => t.Teams)
                .FirstOrDefaultAsync (u => u.Id == userId);

            if (user.Teams.Any(t => t.Id == teamId))
            {
                return;
            }

            user.Teams.Add(team);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(int teamId)
        {
            var team = await _dbContext.Teams
                 .FirstOrDefaultAsync(t => t.Id == teamId);
  
            var userId = _userContextService.LoggedUserId;

            var user = await _dbContext.Users
                .Include(t => t.Teams)
                .FirstOrDefaultAsync(u => u.Id == userId);

            user.Teams.Remove(team);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Team>> GetAll()
        {
            var userId = _userContextService.LoggedUserId;

            var user = await _dbContext.Users
                .Include(t => t.Teams)
                .FirstOrDefaultAsync(u => u.Id == userId);

            var teamList = user.Teams.ToList();

            return teamList;
        }

        public async Task<Team> GetById(int teamId)
        {
            var team = await _dbContext.Teams
                .Include(t => t.League)
                .Include(t => t.Matches)
                .FirstOrDefaultAsync(t => t.Id == teamId);

            return team;
        }
    }
}
