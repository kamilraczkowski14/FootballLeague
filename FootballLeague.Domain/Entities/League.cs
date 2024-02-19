using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class League
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int SeasonId { get; set; } = default!;
        public Season Season { get; set; } = default!;
        public List<Team> Teams { get; set; } = default!;
        
    }
}
