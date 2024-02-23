using FootballLeague.Domain.Entities;
using FootballLeague.Infrastructure.Db;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Seeder
{
    public class DbSeeder
    {
        private readonly ApplicationDbContext _dbContext;

        public DbSeeder(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                if(!_dbContext.Seasons.Any())
                {
                    var season = new Season()
                    {
                        StartYear = 2022,
                        EndYear = 2023
                    };

                    _dbContext.Seasons.Add(season);
                    await _dbContext.SaveChangesAsync();

                    
                    var league = new League()
                    {
                        Name = "Jupiler League",
                        SeasonId = season.Id
                    };

                    _dbContext.Leagues.Add(league);
                    season.Leagues.Add(league);
                    await _dbContext.SaveChangesAsync();
                    
                    var teams = new List<Team>()
                    {
                        new Team
                        {
                          Name = "Genk",
                          Description = "Klub założony w 1988 roku",
                          LogoUrl = "/images/genk.png",
                          LeagueId = league.Id
                        },


                        new Team
                        {
                            Name = "Royale Union SG",
                            Description = "Klub założony w 1897 roku",
                            LogoUrl = "/images/royaleunion.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Antwerp",
                            Description = "Klub założony w 1887 roku",
                            LogoUrl = "/images/antwerp.png",
                            LeagueId = league.Id
                        },
                        new Team
                        {
                            Name = "Club Brugge",
                            Description = "Klub założony w 1891 roku",
                            LogoUrl = "/images/clubbrugge.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Gent",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/gent.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "St Liege",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/stliege.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Westerlo",
                            Description = "Description of Team B",
                            LogoUrl = "/images/westerlo.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Cercle Brugge",
                            Description = "Description of Team B",
                            LogoUrl = "/images/cerclebrugge.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Charleroi",
                            Description = "Description of Team B",
                            LogoUrl = "/images/charleroi.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Leuven",
                            Description = "Description of Team B",
                            LogoUrl = "/images/leuven.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {

                            Name = "Anderlecht",
                            Description = "Description of Team B",
                            LogoUrl = "/images/anderlecht.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "St Truiden",
                            Description = "Description of Team B",
                            LogoUrl = "/images/sttruiden.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "KV Mechelen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kvmechelen.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Kortrijk",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kortrijk.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Eupen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/eupen.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Oostende",
                            Description = "Description of Team B",
                            LogoUrl = "/images/oostende.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Waregem",
                            Description = "",
                            LogoUrl = "/images/waregem.png",
                            LeagueId = league.Id

                        },
                        new Team
                        {
                            Name = "Seraing",
                            Description = "Description of Team B",
                            LogoUrl = "/images/seraing.png",
                            LeagueId = league.Id
                        }
                    };

                    _dbContext.Teams.AddRange(teams);
                    league.Teams.AddRange(teams);
                    await _dbContext.SaveChangesAsync();


                    var matchdays = new List<Matchday>()
                    {
                         new Matchday()
                         {
                            Number = 33,
                            LeagueId = league.Id
                         },
                        new Matchday()
                        {
                            Number = 34,
                            LeagueId = league.Id
                        }
                    };

                    _dbContext.Matchdays.AddRange(matchdays);
                    league.Matchdays.AddRange(matchdays);
                    await _dbContext.SaveChangesAsync();
                    
                    
                    
                    var matches = new List<Match>()
                    {
                     new Match()
                        {
                           HomeTeamId = 2,
                           AwayTeamId = 18,
                           HomeTeamScore = 2,
                           AwayTeamScore = 1,
                           MatchDayId = 1,
                       },
                    new Match()
                    {
  
                        HomeTeamId = 3,
                        AwayTeamId = 14,
                        HomeTeamScore = 1,
                        AwayTeamScore = 0,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
   
                        HomeTeamId = 13,
                        AwayTeamId = 5,
                        HomeTeamScore = 1,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
   
                        HomeTeamId = 1,
                        AwayTeamId = 11,
                        HomeTeamScore = 5,
                        AwayTeamScore = 2,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 7,
                        AwayTeamId = 4,
                        HomeTeamScore = 0,
                        AwayTeamScore = 0,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 8,
                        AwayTeamId = 12,
                        HomeTeamScore = 3,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 16,
                        AwayTeamId = 10,
                        HomeTeamScore = 0,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 15,
                        AwayTeamId = 17,
                        HomeTeamScore = 1,
                        AwayTeamScore = 5,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 6,
                        AwayTeamId = 9,
                        HomeTeamScore = 3,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        HomeTeamId = 4,
                        AwayTeamId = 15,
                        HomeTeamScore = 7,
                        AwayTeamScore = 0,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 11,
                        AwayTeamId = 13,
                        HomeTeamScore = 2,
                        AwayTeamScore = 3,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 5,
                        AwayTeamId = 16,
                        HomeTeamScore = 1,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 10,
                        AwayTeamId = 6,
                        HomeTeamScore = 3,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 14,
                        AwayTeamId = 2,
                        HomeTeamScore = 2,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 17,
                        AwayTeamId = 8,
                        HomeTeamScore = 2,
                        AwayTeamScore = 3,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 9,
                        AwayTeamId = 1,
                        HomeTeamScore = 2,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        HomeTeamId = 12,
                        AwayTeamId = 3,
                        HomeTeamScore = 0,
                        AwayTeamScore = 1,
                        MatchDayId = 2,
                    },

                    new Match()
                    {
                        HomeTeamId = 18,
                        AwayTeamId = 7,
                        HomeTeamScore = 1,
                        AwayTeamScore = 1,
                        MatchDayId = 2,
                    }
                    };

                    _dbContext.Matches.AddRange(matches);
                    await _dbContext.SaveChangesAsync();
                    

                    
                    foreach (var match in matches)
                    {
                        var matchday = _dbContext.Matchdays
                            .Include(m => m.Matches)
                            .FirstOrDefault(m => m.Id == match.MatchDayId);

                        if (matchday != null)
                        {
                            matchday.Matches.Add(match);
                        }


                        var homeTeam = _dbContext.Teams
                            .Include(t => t.Matches)
                            .FirstOrDefault(t => t.Id == match.HomeTeamId);

                        var awayTeam = _dbContext.Teams
                            .Include(t => t.Matches)
                            .FirstOrDefault(t => t.Id == match.AwayTeamId);

                        if (homeTeam != null)
                        {
                            homeTeam.Matches.Add(match);
                            _dbContext.Update(homeTeam);
                        }

                        if (awayTeam != null)
                        {
                            awayTeam.Matches.Add(match);
                            _dbContext.Update(awayTeam);
                        }
                    }  
                    
                    await _dbContext.SaveChangesAsync();
                  
                    
                }


            }
        }
    }
}
