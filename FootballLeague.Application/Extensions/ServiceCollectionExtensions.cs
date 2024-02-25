using FootballLeague.Application.Services;
using FootballLeague.Application.Tools;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ILeagueService, LeagueService>();
            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUserContextService, UserContextService>();
        }
    }
}
