using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;

namespace OpenTTRPG.Infrastructure;

public static class Extensions
{
    extension(HttpContext context)
    {
        public Guid CurrentSessionId => 
            context.GetRouteValue("sessionId") is string s 
            && Guid.TryParse(s, out var id) 
                ? id 
                : Guid.Empty;

        public Guid LoggedUserId => Guid.TryParse(
            context.User.FindFirst(ClaimTypes.NameIdentifier)?.Value, 
            out var userId) 
            ? userId 
            : Guid.Empty;
    }
}