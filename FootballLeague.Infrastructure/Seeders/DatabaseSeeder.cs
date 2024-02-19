using FootballLeague.Domain.Entities;
using FootballLeague.Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Seeders
{
    public class DatabaseSeeder
    {
        private readonly ApplicationDbContext _dbContext;

        public DatabaseSeeder(ApplicationDbContext dbContext) 
        {
            _dbContext = dbContext;
        }

        
        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            {
                    var season = new Season()
                    {
                        Id = 1,
                        StartYear = 2022,
                        EndYear = 2023
                    };

                    var league = new League()
                    {
                        Id = 1,
                        Name = "Jupiler League",
                        SeasonId = 1
                    };

                    var teams = new List<Team>
                    {
                        new Team 
                        { 
                            Id = 1, 
                            Name = "Genk", 
                            Description = "Klub założony w 1988 roku", 
                            LogoUrl = "/images/genk.png",
                            LeagueId = 1,
                            Statistics = new()
                            {
                                NumberOfDefeats = 15,
                                NumberOfDraws = 4,
                                NumberOfMatches = 34,
                                NumberOfWins = 15,
                                TotalPoints = 60,
                            }
                        },
                        new Team 
                        { 
                            Id = 2, 
                            Name = "Royale Union SG", 
                            Description = "Klub założony w 1897 roku", 
                            LogoUrl = "/images/royaleuniong.png",
                            LeagueId = 1 
                        },
                        new Team
                        {
                            Id = 3,
                            Name = "Antwerp",
                            Description = "test",
                            LogoUrl = "/images/antwerp.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 4,
                            Name = "Club Brugge",
                            Description = "Description of Team B",
                            LogoUrl = "/images/clubbrugge.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 5,
                            Name = "Gent",
                            Description = "Description of Team B",
                            LogoUrl = "/images/gent.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 6,
                            Name = "St Liege",
                            Description = "Description of Team B",
                            LogoUrl = "/images/stliege.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 7,
                            Name = "Westerlo",
                            Description = "Description of Team B",
                            LogoUrl = "/images/westerlo.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 8,
                            Name = "Cercle Brugge",
                            Description = "Description of Team B",
                            LogoUrl = "/images/cerclebrugge.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 9,
                            Name = "Charleroi",
                            Description = "Description of Team B",
                            LogoUrl = "/images/charleroi.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 10,
                            Name = "Leuven",
                            Description = "Description of Team B",
                            LogoUrl = "/images/leuven.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 11,
                            Name = "Anderlecht",
                            Description = "Description of Team B",
                            LogoUrl = "/images/anderlecht.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 12,
                            Name = "St Truiden",
                            Description = "Description of Team B",
                            LogoUrl = "/images/sttruiden.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 13,
                            Name = "KV Mechelen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kvmechelen.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 14,
                            Name = "Kortrijk",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kortrijk.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 15,
                            Name = "Eupen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/eupen.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 16,
                            Name = "Oostende",
                            Description = "Description of Team B",
                            LogoUrl = "/images/oostende.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 17,
                            Name = "Waregem",
                            Description = "",
                            LogoUrl = "/images/waregem.png",
                            LeagueId = 1
                        },
                        new Team
                        {
                            Id = 18,
                            Name = "Seraing",
                            Description = "Description of Team B",
                            LogoUrl = "/images/seraing.png",
                            LeagueId = 1
                        },
                    };

                var matchDays = new List<Matchday>()
                {
                    new Matchday()
                    {
                        Id = 1,
                        Number = 33,
                        LeagueId = 1,
                    },
                    new Matchday()
                    {
                        Id = 2,
                        Number = 34,
                        LeagueId = 1,
                    }
                };

                var matches = new List<Match>()
                {
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 2,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 3,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 4,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 5,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 6,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 7,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 8,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 9,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 1,
                        HomeTeamId = 1,
                        AwayTeamId = = 2,
                        HomeTeamScore = 3,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },

                };

                    _dbContext.Seasons.Add(season);
                    await _dbContext.SaveChangesAsync();
                
            }
        }
    }
}
