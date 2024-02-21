using FootballLeague.Domain.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Infrastructure.Db
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
            
     
        public DbSet<Season> Seasons { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Matchday> Matchdays { get; set; }
        public DbSet<Match> Matches { get; set; }

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Team>().OwnsOne(t => t.Statistics);

            modelBuilder.Entity<League>()
    .HasMany(l => l.Teams)
    .WithOne(t => t.League)
    .HasForeignKey(t => t.LeagueId);


            modelBuilder.Entity<Season>().HasData(
                 new Season()
                 {
                     Id = 1,
                     StartYear = 2022,
                     EndYear = 2023
                 }
           );

            modelBuilder.Entity<League>().HasData(
                new League()
                {
                    Id = 1,
                    Name = "Jupiler League",
                    SeasonId = 1,
                    Teams = new List<Team>()
                    {
                        new Team()
                        {
                            Id = 1,
                            Name = "Genk",
                            Description = "Klub założony w 1988 roku",
                            LogoUrl = "/images/genk.png",
                             LeagueId = 1,
                        }
                    }
                }
             );


            modelBuilder.Entity<Team>().HasData(
              new Team
              {
                  Id = 1,
                  Name = "Genk",
                  Description = "Klub założony w 1988 roku",
                  LogoUrl = "/images/genk.png",
                  LeagueId = 1,
              },
              
              
                        new Team
                        {
                            Id = 2,
                            Name = "Royale Union SG",
                            Description = "Klub założony w 1897 roku",
                            LogoUrl = "/images/royaleuniong.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 3,
                            Name = "Antwerp",
                            Description = "Klub założony w 1887 roku",
                            LogoUrl = "/images/antwerp.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 4,
                            Name = "Club Brugge",
                            Description = "Klub założony w 1891 roku",
                            LogoUrl = "/images/clubbrugge.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 5,
                            Name = "Gent",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/gent.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 6,
                            Name = "St Liege",
                            Description = "Klub założony w 1900 roku",
                            LogoUrl = "/images/stliege.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 7,
                            Name = "Westerlo",
                            Description = "Description of Team B",
                            LogoUrl = "/images/westerlo.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 8,
                            Name = "Cercle Brugge",
                            Description = "Description of Team B",
                            LogoUrl = "/images/cerclebrugge.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 9,
                            Name = "Charleroi",
                            Description = "Description of Team B",
                            LogoUrl = "/images/charleroi.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 10,
                            Name = "Leuven",
                            Description = "Description of Team B",
                            LogoUrl = "/images/leuven.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 11,
                            Name = "Anderlecht",
                            Description = "Description of Team B",
                            LogoUrl = "/images/anderlecht.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 12,
                            Name = "St Truiden",
                            Description = "Description of Team B",
                            LogoUrl = "/images/sttruiden.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 13,
                            Name = "KV Mechelen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kvmechelen.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 14,
                            Name = "Kortrijk",
                            Description = "Description of Team B",
                            LogoUrl = "/images/kortrijk.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 15,
                            Name = "Eupen",
                            Description = "Description of Team B",
                            LogoUrl = "/images/eupen.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 16,
                            Name = "Oostende",
                            Description = "Description of Team B",
                            LogoUrl = "/images/oostende.png",
                            LeagueId = 1,
                           
                        },
                        new Team
                        {
                            Id = 17,
                            Name = "Waregem",
                            Description = "",
                            LogoUrl = "/images/waregem.png",
                            LeagueId = 1,
                            
                        },
                        new Team
                        {
                            Id = 18,
                            Name = "Seraing",
                            Description = "Description of Team B",
                            LogoUrl = "/images/seraing.png",
                            LeagueId = 1,
                            
                        }
                    
           );

            modelBuilder.Entity<Matchday>().HasData(
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
          );

            modelBuilder.Entity<Match>().HasData(
           new Match()
           {
               Id = 1,
               HomeTeamId = 2,
               AwayTeamId = 18,
               HomeTeamScore = 2,
               AwayTeamScore = 1,
               MatchDayId = 1,
           },
                    new Match()
                    {
                        Id = 2,
                        HomeTeamId = 3,
                        AwayTeamId = 14,
                        HomeTeamScore = 1,
                        AwayTeamScore = 0,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 3,
                        HomeTeamId = 13,
                        AwayTeamId = 5,
                        HomeTeamScore = 1,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 4,
                        HomeTeamId = 1,
                        AwayTeamId = 11,
                        HomeTeamScore = 5,
                        AwayTeamScore = 2,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 5,
                        HomeTeamId = 7,
                        AwayTeamId = 4,
                        HomeTeamScore = 0,
                        AwayTeamScore = 0,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 6,
                        HomeTeamId = 8,
                        AwayTeamId = 12,
                        HomeTeamScore = 3,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 7,
                        HomeTeamId = 16,
                        AwayTeamId = 10,
                        HomeTeamScore = 0,
                        AwayTeamScore = 4,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 8,
                        HomeTeamId = 15,
                        AwayTeamId = 17,
                        HomeTeamScore = 1,
                        AwayTeamScore = 5,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 9,
                        HomeTeamId = 6,
                        AwayTeamId = 9,
                        HomeTeamScore = 3,
                        AwayTeamScore = 1,
                        MatchDayId = 1,
                    },
                    new Match()
                    {
                        Id = 10,
                        HomeTeamId = 4,
                        AwayTeamId = 15,
                        HomeTeamScore = 7,
                        AwayTeamScore = 0,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 11,
                        HomeTeamId = 11,
                        AwayTeamId = 13,
                        HomeTeamScore = 2,
                        AwayTeamScore = 3,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 12,
                        HomeTeamId = 5,
                        AwayTeamId = 16,
                        HomeTeamScore = 1,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 13,
                        HomeTeamId = 10,
                        AwayTeamId = 6,
                        HomeTeamScore = 3,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 14,
                        HomeTeamId = 14,
                        AwayTeamId = 2,
                        HomeTeamScore = 2,
                        AwayTeamScore = 4,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 15,
                        HomeTeamId = 17,
                        AwayTeamId = 8,
                        HomeTeamScore = 2,
                        AwayTeamScore = 3,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 16,
                        HomeTeamId = 9,
                        AwayTeamId = 1,
                        HomeTeamScore = 2,
                        AwayTeamScore = 2,
                        MatchDayId = 2,
                    },
                    new Match()
                    {
                        Id = 17,
                        HomeTeamId = 12,
                        AwayTeamId = 3,
                        HomeTeamScore = 0,
                        AwayTeamScore = 1,
                        MatchDayId = 2,
                    },

                    new Match()
                    {
                        Id = 18,
                        HomeTeamId = 18,
                        AwayTeamId = 7,
                        HomeTeamScore = 1,
                        AwayTeamScore = 1,
                        MatchDayId = 2,
                    }
         );
            




        }
        */
    }
}