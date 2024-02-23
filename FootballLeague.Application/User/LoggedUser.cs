using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.UserContext
{
    public class LoggedUser
    {
        public LoggedUser(string id, string email)
        {
            Id = id;
            Email = email;
        }
        public string Id { get; set; }
        public string Email { get; set; }


    }
}
