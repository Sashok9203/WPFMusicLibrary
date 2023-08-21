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
        public RelayCommand ShowTreckList { get; private set; }

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
            ShowTreckList  = new((o) => showTrecks(o));
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
            switch (o)
            {
                case Album album:
                    Albums.Remove(album);
                    SaveChanges();
                    OnPropertyChanged("AlbomsView");
                    OnPropertyChanged("TrecksView");
                    break;
                case PlayList playList:
                    PlayLists.Remove(playList);
                    SaveChanges();
                    OnPropertyChanged("PlayListsView");
                    break;
                default:
                    return;
               
            }
        }

        private void showTrecks(object o)
        {
            switch (o)
            {
                case Album album:
                    TreckList = TrecksView.Where(x => x.AlbumId == album.Id).ToArray();
                    break;
                case PlayList playList:
                    TreckList = TrecksView.Where(x => x.PlayLists.Contains(playList)).ToArray();
                    break;
                default:
                    return;

            }

            OnPropertyChanged("TreckList");
        }

        public DbSet<Category> Categorys { get; set; }
        public DbSet<Countrie> Countries { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Treck> Trecks { get; set; }
        public DbSet<PlayList> PlayLists { get; set; }

        public IEnumerable<Treck>  TrecksView => Trecks.Include(x => x.Artist).ToArray();
        public IEnumerable<Album>  AlbomsView => Albums.Include(x => x.Genre).Include(x => x.Artist).ToArray();
        public IEnumerable<Treck>? TreckList { get; set; }
        public IEnumerable<PlayList> PlayListsView => PlayLists.Include(x=>x.Category).ToArray();


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
