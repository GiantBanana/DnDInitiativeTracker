using System.Diagnostics.CodeAnalysis;
using DnDIniativeTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace DnDIniativeTracker.Data
{
    public class DnDContext : DbContext
    {
        public DnDContext([NotNullAttribute] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Game> Games { get; set; }
        public DbSet<Creature> Creatures { get; set; }
        public DbSet<CreatureInGame> CreaturesInGames { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CreatureInGame>()
                            .HasOne<Creature>(c => c.Creature)
                            .WithMany(c => c.CreatureInGames)
                            .HasForeignKey(c => c.CreatureId)
                            .OnDelete(DeleteBehavior.ClientCascade);
            modelBuilder.Entity<CreatureInGame>()
                            .HasOne<Game>(c => c.Game)
                            .WithMany(c => c.CreaturesInGame)
                            .HasForeignKey(c => c.GameId)
                            .OnDelete(DeleteBehavior.ClientCascade);
        }
    }
}