using BoardGamesCatalog.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BoardGamesCatalog.Data
{
    public class BoardGamesContext : DbContext
    {
        public BoardGamesContext(DbContextOptions<BoardGamesContext> options)
            : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Boardgame> Boardgames { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Creator> Creators { get; set; }
        public DbSet<PlayerRange> PlayerRanges { get; set; }
        public DbSet<CreatorBoardgame> CreatorBoardgames { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Many-to-many composite key
            modelBuilder.Entity<CreatorBoardgame>()
                .HasKey(cb => new { cb.CreatorId, cb.BoardgameId });

            base.OnModelCreating(modelBuilder);
        }
    }
}
