namespace Asterisk.MyTek.Entity;

public class ChallengeConfig
{
    public Guid Id { get; set; }
    public Guid ChallengeId { get; set; }
    public Challenge Challenge { get; set; }
}