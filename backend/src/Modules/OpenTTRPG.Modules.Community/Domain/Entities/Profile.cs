using OpenTTRPG.Modules.Community.Domain.Enums;

namespace OpenTTRPG.Modules.Community.Domain.Entities;

public class Profile
{
  public Guid UserId { get; set; }

  public string? Bio { get; set; }
  public string? Availability { get; set; }
  public Dictionary<string, string> SocialMedias { get; set; } = [];
  public List<string> PreferredSystems { get; set; } = [];

  public int ReputationPoints { get; set; } = 0;

  public ProfileStatus DefaultStatus { get; set; } = ProfileStatus.Online;
}