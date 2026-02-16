using Microsoft.AspNetCore.Http;
using OpenTTRPG.Core.Abstractions;

namespace OpenTTRPG.Infrastructure.Security.Authorization;

public class CurrentUser(IHttpContextAccessor httpContextAcessor) : ICurrentUser
{
    public Guid UserId { get; }
    public string Email { get; }
    public bool IsAuthenticated { get; }
}