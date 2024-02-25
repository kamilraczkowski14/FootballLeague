using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.Services
{
    public interface IUserContextService
    {
        ClaimsPrincipal User { get; }
        string? LoggedUserId { get; }

    }
}
