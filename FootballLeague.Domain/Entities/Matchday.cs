using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class Matchday
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int LeagueId { get; set; } 
        public League League { get; set; } = default!;
        public List<Match> Matches { get; set; } = default!;
    }
}
