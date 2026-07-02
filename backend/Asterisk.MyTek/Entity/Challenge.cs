namespace Asterisk.MyTek.Entity;

public class Challenge
{
    public Guid Id { get; set; }
    public List<ChallengeConfig> ChallengeConfigs { get; set; }
}