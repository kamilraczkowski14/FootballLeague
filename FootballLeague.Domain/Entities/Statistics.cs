using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class Statistics
    {
        public int Id { get; set; }
        public int NumberOfMatches { get; set; }
        public int TotalPoints { get; set; }
        public int NumberOfWins { get; set; }
        public int NumberOfDraws { get; set; }
        public int NumberOfDefeats { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
