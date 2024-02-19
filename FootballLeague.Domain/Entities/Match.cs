using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public int HomeTeamId {  get; set; }
        public int AwayTeamId { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get;set; }
        public int MatchDayId { get; set; }
        public Matchday Matchday { get; set; } = default!;

    }
}
