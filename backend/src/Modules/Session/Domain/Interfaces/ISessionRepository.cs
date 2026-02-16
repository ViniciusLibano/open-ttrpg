using OpenTTRPG.Core.Abstractions;
using OpenTTRPG.Modules.Session.Domain.Entities;

namespace OpenTTRPG.Modules.Session.Domain.Interfaces;

public interface ISessionRepository : IRepository<SessionEntity>
{
    Task<bool> IsDmAsync(Guid sessionId, Guid userId);
}