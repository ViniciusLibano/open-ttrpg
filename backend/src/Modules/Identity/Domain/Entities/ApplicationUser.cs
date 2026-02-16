using Microsoft.AspNetCore.Identity;

namespace OpenTTRPG.Modules.Identity.Domain.Entities;

public class ApplicationUser : IdentityUser<Guid>
{
    [PersonalData] 
    public DateTime BirthDay { get; set; }
    
    // Caso os termos de uso tenham sidos atualizados
    public bool TermsVersionAccepted { get; set; }
    public DateTime TermsAcceptedAt { get; set; }
    
    public string? DisplayName { get; set; }
    public string? AvatarUrl { get; set; }

    public string TimeZoneId { get; set; } = "UTC";
    
    public DateTime CreatedAt { get; set; }
    public DateTime LastLoginAt { get; set; }

    public bool IsActive { get; set; } = true;

    protected ApplicationUser()
    {
    }

    public ApplicationUser(string username) : base(username)
    {
    }
}