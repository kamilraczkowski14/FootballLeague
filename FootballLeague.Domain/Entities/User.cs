using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Domain.Entities
{
    public class User : IdentityUser
    {
        public List<Team> Teams { get; set; } = default!;
    }
}
