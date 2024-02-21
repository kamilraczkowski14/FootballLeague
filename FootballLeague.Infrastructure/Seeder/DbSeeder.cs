using FootballLeague.Domain.Entities;
using FootballLeague.Infrastructure.Db;
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


                    var league = new League()
                    {
                        Name = "Jupiler League",
                        SeasonId = season.Id
                    };

                   

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

                    _dbContext.Seasons.Add(season);
                    _dbContext.Leagues.Add(league);
                    _dbContext.Teams.AddRange(teams);
                    league.Teams.AddRange(teams);
                    await _dbContext.SaveChangesAsync();

                }
            }
        }
    }
}
