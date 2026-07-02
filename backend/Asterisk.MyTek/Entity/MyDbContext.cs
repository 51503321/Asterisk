using Microsoft.EntityFrameworkCore;

namespace Asterisk.MyTek.Entity;

public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
{
    public DbSet<Challenge> Challenges { get; set; }
    public DbSet<ChallengeConfig> ChallengeConfigs { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Challenge>()
            .HasMany(x => x.ChallengeConfigs)
            .WithOne()
            .HasForeignKey(x => x.ChallengeId);
    }
}
