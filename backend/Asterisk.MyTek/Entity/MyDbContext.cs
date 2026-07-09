using Microsoft.EntityFrameworkCore;

namespace Asterisk.MyTek.Entity;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<ChallengeConfig> ChallengeConfigs { get; set; }
    public DbSet<DevelopmentStage> DevelopmentStages { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ChallengeConfig>()
            .HasOne(x => x.Challenge)
            .WithMany(x => x.ChallengeConfigs)
            .HasForeignKey(x => x.ChallengeId);

        modelBuilder.Entity<Challenge>()
            .HasMany(x => x.MappingChallenges)
            .WithOne()
            .HasForeignKey(x => x.ChallengeId);

        modelBuilder.Entity<DevelopmentStage>()
            .HasMany(x => x.MappingChallenges)
            .WithOne()
            .HasForeignKey(x => x.DevelopmentStageId);
    }
}
