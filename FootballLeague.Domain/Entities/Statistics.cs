using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class Statistics
    {
        public int NumberOfMatches { get; set; }
        public int TotalPoints { get; set; }
        public int ScoredGoals { get; set; }
        public int ConcededGoals { get; set; }
    }
}
