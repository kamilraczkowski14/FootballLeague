﻿using FootballLeague.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Interfaces
{
    public interface ILeagueRepository
    {
        Task<League> Get(int leagueId);
    }
}
