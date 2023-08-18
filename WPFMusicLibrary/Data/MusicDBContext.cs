using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFMusicLibrary.Entitys;

namespace WPFMusicLibrary.Data
{
    internal class MusicDBContext :DbContext
    {
        public MusicDBContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            string connect = ConfigurationManager.ConnectionStrings["ConnectionStr"].ConnectionString;
            optionsBuilder.UseSqlServer(connect);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Countrie>().HasData(MDBData.CountriesData);
            modelBuilder.Entity<Category>().HasData(MDBData.CategorysData);
            modelBuilder.Entity<Genre>().HasData(MDBData.GenresData);
            modelBuilder.Entity<Treck>().HasData(MDBData.TrecksData);
            modelBuilder.Entity<Artist>().HasData(MDBData.ArtistsData);
            modelBuilder.Entity<Album>().HasData(MDBData.AlbomsData);
            modelBuilder.Entity<PlayList>().HasData(MDBData.PlayListsData);

        }

        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Alboms { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Treck> Trecks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }
    }
}
