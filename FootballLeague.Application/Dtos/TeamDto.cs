using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Dtos
{
    public class TeamDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string LogoUrl { get; set; } = default!;
        public List<Match> Matches { get; set; } = default!;
    }
}
