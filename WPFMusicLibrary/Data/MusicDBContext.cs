using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WPFMusicLibrary.Entitys;

namespace WPFMusicLibrary.Data
{
    public class TR
    {
        public string Artist { get; set; }
        public string Track { get; set; }
        public TimeSpan Duration { get; set; }
        public TR(string tName, string aName,  TimeSpan dur)
        {
            Track = tName;
            Artist = aName;
            Duration = dur;
        }
    }

    public class MusicDBContext :DbContext
    {
        
        IEnumerable<TR> test;
        public MusicDBContext()
        {
          //  Database.EnsureDeleted();
            if (Database.EnsureCreated())
            {
                Trecks.AddRange(MDBData.TrecksData);
                foreach (var item in PlayLists)
                {
                    for (int i = 0; i < 15; i++)
                        item.Trecks.Add(MDBData.TrecksData[new Random().Next(0, 34)]);

                }
                SaveChanges();
            }
            test = Trecks.Select(n=> new TR(n.Name,n.Artist.Name + " " + n.Artist.Surname,n.Duration )).ToArray();

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
            modelBuilder.Entity<Category>().HasData(MDBData.CategorysData);
            modelBuilder.Entity<Countrie>().HasData(MDBData.CountriesData);
            modelBuilder.Entity<Genre>().HasData(MDBData.GenresData);
            modelBuilder.Entity<Artist>().HasData(MDBData.ArtistsData);
            modelBuilder.Entity<Album>().HasData(MDBData.AlbomsData);
            modelBuilder.Entity<PlayList>().HasData(MDBData.PlayListsData);
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Alboms { get; set; }
        public DbSet<Treck> Trecks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }

        public IEnumerable<TR>  TrecksView => test;


    }
}
