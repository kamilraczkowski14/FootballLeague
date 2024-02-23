using FootballLeague.Application.UserContext;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Application.User
{
    public interface IUserContextService
    {
        LoggedUser GetLoggedUser();
    }

    public class UserContextService : IUserContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }
        public LoggedUser GetLoggedUser()
        {
            var user = _httpContextAccessor.HttpContext?.User;

            var id = user.FindFirst(u => u.Type == ClaimTypes.NameIdentifier)!.Value;
            var email = user.FindFirst(u => u.Type == ClaimTypes.Email)!.Value;

            var loggedUser = new LoggedUser(id, email);

            return loggedUser;

        }
    }
}
