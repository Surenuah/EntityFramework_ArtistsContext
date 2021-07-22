using ConsoleApp11.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class ArtistContext : DbContext
    {
        public DbSet<Artists> Artists { get; set; }
        public DbSet<Countries> Countries { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Albums> Albums { get; set; }
        public DbSet<AlbumsSongs> AlbumsSongs { get; set; }
        public DbSet<Groups> Groups { get; set; }
        public DbSet<Persons> Persons { get; set; }
        public DbSet<Songs> Songs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder
                .UseSqlServer("Data Source=WIN-0TNQQV8DGU0;Initial Catalog=Artists Context;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artists>().HasKey(x => new { x.ArtistId, x.CountryId });

            modelBuilder.Entity<Countries>().HasOne(x => x.CountryName);

            modelBuilder.Entity<Genres>().HasOne(x => x.GenreName);

            modelBuilder.Entity<Albums>().HasOne(x => x.AlbumTitle);

            modelBuilder.Entity<AlbumsSongs>().HasKey(x => x.AlbumId);

            modelBuilder.Entity<Groups>().HasOne(x => x.GroupName);

            modelBuilder.Entity<Persons>().HasOne(x => new { x.FirstName, x.LastName });

            modelBuilder.Entity<Songs>().HasOne(x => x.SongTitle);
        }
    }
}
