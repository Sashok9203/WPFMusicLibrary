using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using WPFMusicLibrary.Entitys;
using RCommand;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WPFMusicLibrary.Data
{
    
    public class MusicDBContext :DbContext,INotifyPropertyChanged
    {

        public RelayCommand DeleteAlbum  { get; private set; } 
        public RelayCommand ShowAlbumTrecks { get; private set; }

        public MusicDBContext()
        {
            Database.EnsureDeleted();
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

            DeleteAlbum = new ((o) => delAlbum(o));
            ShowAlbumTrecks  = new((o) => showTrecks(o));
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


        private void delAlbum(object o)
        {
            Albums.Remove(o as Album);
            SaveChanges();
            OnPropertyChanged("AlbomsView");
        }

        private void showTrecks(object o)
        {
            AlbomTreks = TrecksView.Where(x=>x.AlbumId == (int)o).ToArray();
            OnPropertyChanged("AlbomTreks");
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Treck> Trecks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }

        public IEnumerable<Treck>  TrecksView => Trecks.Include(x => x.Artist).ToList();

        public IEnumerable<Album>  AlbomsView => Albums.Include(x => x.Genre).Include(x => x.Artist).ToArray();

       
        public IEnumerable<Treck>? AlbomTreks { get; set; }



        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
