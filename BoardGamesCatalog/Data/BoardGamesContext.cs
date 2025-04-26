using BoardGamesCatalog.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BoardGamesCatalog.Data
{
    //public class BoardGamesContext : DbContext
    //{
    //    public BoardGamesContext()
    //    {
    //    }

    //    public BoardGamesContext(DbContextOptions options)
    //        : base(options)
    //    {
    //    }

    //    public DbSet<Boardgame> Boardgames { get; set; }
    //    public DbSet<Address> Addresses { get; set; }

    //    public DbSet<Category> Categories { get; set; }

    //    public DbSet<CreatorBoardgame> CreatorBoardgames { get; set; }

    //    public DbSet<PlayerRange> PlayerRanges { get; set; }
    //    public DbSet<Publisher> Publishers { get; set; }

    //    public DbSet<Creator> Creators { get; set; }


    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        if (!optionsBuilder.IsConfigured)
    //        {
    //            optionsBuilder
    //                .UseSqlServer(Configoration.ConnectionString);
    //        }
    //    }

    //    protected override void OnModelCreating(ModelBuilder modelBuilder)
    //    {
    //        modelBuilder.Entity<CreatorBoardgame>(e =>
    //        {
    //            e.HasKey(bs => new { bs.BoardgameId, bs.CreatorId });
    //        });
    //    }
    //}
}
