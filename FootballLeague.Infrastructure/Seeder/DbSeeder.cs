using AutoMapper;
using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using FootballLeague.Infrastructure.Db;
using Microsoft.AspNetCore.Mvc;
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
        private readonly IMapper _mapper;

        public DbSeeder(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task Seed()
        {
            if (await _dbContext.Database.CanConnectAsync())
            {
                if (!_dbContext.Seasons.Any())
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
                          LeagueId = league.Id,
                          Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 75,
                                ScoredGoals = 78,
                                ConcededGoals = 37
                            }
                        },


                        new Team
                        {
                            Name = "Royale Union SG",
                            Description = "Klub założony w 1897 roku",
                            LogoUrl = "/images/royaleunion.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 75,
                                ScoredGoals = 70,
                                ConcededGoals = 41
                            }

                        },
                        new Team
                        {
                            Name = "Antwerp",
                            Description = "Klub założony w 1887 roku",
                            LogoUrl = "/images/antwerp.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 72,
                                ScoredGoals = 59,
                                ConcededGoals = 26
                            }
                        },
                        new Team
                        {
                            Name = "Club Brugge",
                            Description = "Klub założony w 1891 roku",
                            LogoUrl = "/images/clubbrugge.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 59,
                                ScoredGoals = 61,
                                ConcededGoals = 36
                            }

                        },
                        new Team
                        {
                            Name = "Gent",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/gent.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 56,
                                ScoredGoals = 64,
                                ConcededGoals = 38
                            }

                        },
                        new Team
                        {
                            Name = "St Liege",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/stliege.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 55,
                                ScoredGoals = 58,
                                ConcededGoals = 45
                            }

                        },
                        new Team
                        {
                            Name = "Westerlo",
                            Description = "Klub założony w 1933 roku",
                            LogoUrl = "/images/westerlo.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 51,
                                ScoredGoals = 61,
                                ConcededGoals = 53
                            }

                        },
                        new Team
                        {
                            Name = "Cercle Brugge",
                            Description = "Klub założony w 1899 roku",
                            LogoUrl = "/images/cerclebrugge.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 50,
                                ScoredGoals = 50,
                                ConcededGoals = 46
                            }

                        },
                        new Team
                        {
                            Name = "Charleroi",
                            Description = "Klub założony w 1904 roku",
                            LogoUrl = "/images/charleroi.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 48,
                                ScoredGoals = 45,
                                ConcededGoals = 52
                            }

                        },
                        new Team
                        {
                            Name = "Leuven",
                            Description = "Klub założony w 1903 roku",
                            LogoUrl = "/images/leuven.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 48,
                                ScoredGoals = 56,
                                ConcededGoals = 48
                            }

                        },
                        new Team
                        {

                            Name = "Anderlecht",
                            Description = "Klub założony w 1908 roku",
                            LogoUrl = "/images/anderlecht.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 46,
                                ScoredGoals = 49,
                                ConcededGoals = 46
                            }

                        },
                        new Team
                        {
                            Name = "St Truiden",
                            Description = "Klub założony w 1924 roku",
                            LogoUrl = "/images/sttruiden.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 42,
                                ScoredGoals = 37,
                                ConcededGoals = 40
                            }

                        },
                        new Team
                        {
                            Name = "KV Mechelen",
                            Description = "Klub założony w 1904 roku",
                            LogoUrl = "/images/kvmechelen.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 40,
                                ScoredGoals = 49,
                                ConcededGoals = 63
                            }

                        },
                        new Team
                        {
                            Name = "Kortrijk",
                            Description = "Klub założony w 1901 roku",
                            LogoUrl = "/images/kortrijk.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 31,
                                ScoredGoals = 37,
                                ConcededGoals = 61
                            }

                        },
                        new Team
                        {
                            Name = "Eupen",
                            Description = "Klub założony w 1945 roku",
                            LogoUrl = "/images/eupen.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 28,
                                ScoredGoals = 40,
                                ConcededGoals = 75
                            }

                        },
                        new Team
                        {
                            Name = "Oostende",
                            Description = "Klub założony w 1904 roku",
                            LogoUrl = "/images/oostende.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 27,
                                ScoredGoals = 37,
                                ConcededGoals = 76
                            }

                        },
                        new Team
                        {
                            Name = "Waregem",
                            Description = "Klub założony w 1950 roku",
                            LogoUrl = "/images/waregem.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 27,
                                ScoredGoals = 50,
                                ConcededGoals = 78
                            }

                        },
                        new Team
                        {
                            Name = "Seraing",
                            Description = "Klub założony w 1904 roku",
                            LogoUrl = "/images/seraing.png",
                            LeagueId = league.Id,
                            Statistics = new()
                            {
                                NumberOfMatches = 34,
                                TotalPoints = 20,
                                ScoredGoals = 28,
                                ConcededGoals = 68
                            }
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
                            _dbContext.SaveChanges();
                        }
                    }



                    foreach (var match in matches)
                    {
                        
                        var currentMatch = new Match
                        {
                            HomeTeamId = match.HomeTeamId,
                            AwayTeamId = match.AwayTeamId,
                            HomeTeamName = match.HomeTeamName,
                            AwayTeamName = match.AwayTeamName,
                            MatchDayId = match.MatchDayId,
                            HomeTeamLogoUrl = match.HomeTeamLogoUrl,
                            HomeTeamScore = match.HomeTeamScore,
                            AwayTeamLogoUrl = match.AwayTeamLogoUrl,
                            AwayTeamScore = match.AwayTeamScore,
                        };
                        
                        var homeTeam = _dbContext.Teams
                                .Include(t => t.Matches)
                                .FirstOrDefault(t => t.Id == currentMatch.HomeTeamId);

                        var awayTeam = _dbContext.Teams
                            .Include(t => t.Matches)
                            .FirstOrDefault(t => t.Id == currentMatch.AwayTeamId);

                        if (homeTeam != null)
                        {
                            currentMatch.HomeTeamName = homeTeam.Name;
                            currentMatch.HomeTeamLogoUrl = homeTeam.LogoUrl;
                            currentMatch.AwayTeamName = awayTeam.Name;
                            currentMatch.AwayTeamLogoUrl = awayTeam.LogoUrl;
                            homeTeam.Matches.Add(currentMatch);

                        }

                    }

                    _dbContext.SaveChanges();




                    foreach (var match in matches)
                    {
                        var currentMatch = new Match
                        {
                            HomeTeamId = match.HomeTeamId,
                            AwayTeamId = match.AwayTeamId,
                            HomeTeamName = match.HomeTeamName,
                            AwayTeamName = match.AwayTeamName,
                            MatchDayId = match.MatchDayId,
                            HomeTeamLogoUrl = match.HomeTeamLogoUrl,
                            HomeTeamScore = match.HomeTeamScore,
                            AwayTeamLogoUrl = match.AwayTeamLogoUrl,
                            AwayTeamScore = match.AwayTeamScore,
                        };

                        var awayTeam = _dbContext.Teams
                                .Include(t => t.Matches)
                                .FirstOrDefault(t => t.Id == currentMatch.AwayTeamId);

                        var homeTeam = _dbContext.Teams
                            .Include(t => t.Matches)
                            .FirstOrDefault(t => t.Id == currentMatch.HomeTeamId);

                        if (awayTeam != null)
                        {
                            currentMatch.AwayTeamName = awayTeam.Name;
                            currentMatch.AwayTeamLogoUrl = awayTeam.LogoUrl;
                            currentMatch.HomeTeamName = homeTeam.Name;
                            currentMatch.HomeTeamLogoUrl = homeTeam.LogoUrl;
                            awayTeam.Matches.Add(currentMatch);
                        }
                    }

                    _dbContext.SaveChanges();



                }
            }
               
        }
    }
}
