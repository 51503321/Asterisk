namespace Asterisk.MyTek.Entity;

public class DevelopmentStage
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public List<MappingChallenge> MappingChallenges { get; set; }
}
