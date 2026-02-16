using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using OpenTTRPG.Infrastructure;
using OpenTTRPG.Modules.Session.Domain.Interfaces;
using OpenTTRPG.Modules.Session.Infrastructure.Security.Authorization.Requirements;

namespace OpenTTRPG.Modules.Session.Infrastructure.Security.Authorization.Handlers;

public class DmAuthorizationHandler(
    IHttpContextAccessor httpContextAccessor,
    ISessionRepository repository) : AuthorizationHandler<DmRequirement>
{
    protected override async Task HandleRequirementAsync(AuthorizationHandlerContext context, DmRequirement requirement)
    {
        if (httpContextAccessor.HttpContext is not { } httpContext) return;

        var userId = httpContext.LoggedUserId;
        var sessionId = httpContext.CurrentSessionId;

        if (userId == Guid.Empty 
            || sessionId == Guid.Empty) return;

        if (await repository.IsDmAsync(sessionId, userId))
            context.Succeed(requirement);
    }
}