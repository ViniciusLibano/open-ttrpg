using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace OpenTTRPG.Modules.Identity.Infrastructure.Database;

public class IdentityDbContext(DbContextOptions<IdentityDbContext> options) : Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityDbContext(options)
{
    
}