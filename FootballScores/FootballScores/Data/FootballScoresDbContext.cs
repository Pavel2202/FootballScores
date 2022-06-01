namespace FootballScores.Data
{
    using FootballScores.Data.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class FootballScoresDbContext : IdentityDbContext<User>
    {
        public FootballScoresDbContext(DbContextOptions<FootballScoresDbContext> options)
            : base(options)
        {
        }

        public DbSet<Fixture> Fixtures { get; set; }

        public DbSet<Player> Players { get; set; }

        public DbSet<Team> Teams { get; set; }

        public DbSet<Tournament> Tournaments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Fixture>()
                .HasOne(x => x.AwayTeam)
                .WithMany(x => x.Fixtures)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Fixture>()
                .HasOne(x => x.Tournament)
                .WithMany(x => x.Fixtures)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Player>()
                .HasOne(x => x.Tournament)
                .WithMany(x => x.Players)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}