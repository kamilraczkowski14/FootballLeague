using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FootballLeague.Domain.Interfaces;

namespace FootballLeague.Application.Services
{
    public interface ILeagueService
    {

    }
    public class LeagueService : ILeagueService
    {
        public LeagueService(ILeagueRepository leagueRepository)
        {
                
        }
    }
}
