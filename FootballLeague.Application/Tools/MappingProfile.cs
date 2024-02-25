using AutoMapper;
using FootballLeague.Application.Dtos;
using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Tools
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Team, TeamDto>();
            CreateMap<League, LeagueDto>();
        }

    }
}
