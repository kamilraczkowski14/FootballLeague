using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string LogoUrl { get; set; } = default!;
        public int LeagueId { get; set; }
        public League League { get; set; } = default!;
        public List<Match> Matches { get; set; }
    }
}
