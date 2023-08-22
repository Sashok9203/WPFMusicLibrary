using Microsoft.EntityFrameworkCore;
using Microsoft.Win32;
using RCommand;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using WPFMusicLibrary.Data;
using WPFMusicLibrary.Entitys;

namespace WPFMusicLibrary.Models
{
    public class MusicDBModel:IDisposable, INotifyPropertyChanged
    {
        private readonly MusicDBContext MDBContext;

        private string? imagePath;

        private string? newName;

        private readonly List<Treck> trecksView;

        private readonly List<Album> albomsView;

        private readonly List<PlayList> playListsView;

        private readonly List<Category> categoriesView;
        private bool disposedValue;

        private void getImagePath()
        {
            OpenFileDialog ofd = new() { Filter = "Image Files|*.jpg;*.jpeg;*.png;" };
            if (ofd.ShowDialog() == true)  NewImagePath = Path.Combine(ofd.FileName);
        }

        private bool isNameUnique(string name)
        {
            foreach (var item in playListsView)
                if (item.Name == name) return false;
            return true;
        }

        private void addPlayList()
        {
            PlayListAddWindow playListAddWindow = new() { DataContext = this, };
            playListAddWindow.ShowDialog();
        }

        private void savePlayList(object o)
        {
            PlayList pl = new()
            {
                ImagePath = String.IsNullOrEmpty(NewImagePath) ? System.IO.Path.Combine("Images", "PlayLists", "PL.png") : NewImagePath,
                Category = NewCategory,
                Name = NewPLName,
            };
            foreach (Treck item in (IList)o) pl.Trecks.Add(item);
            MDBContext.PlayLists.Add(pl);
            playListsView.Add(pl);
            MDBContext.SaveChanges();
            NewImagePath = string.Empty;
            NewPLName = string.Empty;
            OnPropertyChanged("PlayListsView");
        }

        private void delAlbum(object o)
        {
            switch (o)
            {
                case Album album:
                    MDBContext.Albums.Remove(album);
                    albomsView.Remove(album);
                    MDBContext.SaveChanges();
                    OnPropertyChanged("AlbomsView");
                    OnPropertyChanged("TrecksView");
                    break;
                case PlayList playList:
                    MDBContext.PlayLists.Remove(playList);
                    playListsView.Remove(playList);
                    MDBContext.SaveChanges();
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
                    TreckList = album.Trecks;
                    break;
                case PlayList playList:
                    TreckList = playList.Trecks;
                    break;
                default:
                    return;
            }
            OnPropertyChanged("TreckList");
        }

        public MusicDBModel()
        {
            MDBContext = new();
            trecksView = MDBContext.Trecks.Include(x => x.Artist).ToList();
            albomsView = MDBContext.Albums.Include(x => x.Genre).ToList();
            playListsView = MDBContext.PlayLists.Include(x => x.Category).Include(x => x.Trecks).ToList();
            categoriesView = MDBContext.Categories.ToList();
            DeleteAlbum = new((o) => delAlbum(o));
            ShowTreckList = new((o) => showTrecks(o));
            AddPlayList = new((o) => addPlayList());
            SavePlayList = new((o) => savePlayList(o), (o) => !String.IsNullOrEmpty(NewPLName) && isNameUnique(NewPLName));
            GetImagePath = new((o) => getImagePath());
        }

        public string? NewPLName
        {
            get => newName;
            set
            {
                newName = value;
                OnPropertyChanged();
            }
        }

        public Category? NewCategory { get; set; }

        public string? NewImagePath
        {
            get => imagePath;
            set
            {
                imagePath = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand DeleteAlbum { get; private set; }
        public RelayCommand ShowTreckList { get; private set; }
        public RelayCommand AddPlayList { get; private set; }
        public RelayCommand SavePlayList { get; private set; }
        public RelayCommand GetImagePath { get; private set; }

        

        public IEnumerable<Treck> TrecksView => trecksView;
        public IEnumerable<Album> AlbomsView => albomsView.ToArray();
        public IEnumerable<Treck>? TreckList { get; set; }
        public IEnumerable<PlayList> PlayListsView => playListsView.ToArray();
        public IEnumerable<Category> CategoriesView => categoriesView;


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: освободить управляемое состояние (управляемые объекты)
                    MDBContext.Dispose();
                }

                // TODO: освободить неуправляемые ресурсы (неуправляемые объекты) и переопределить метод завершения
                // TODO: установить значение NULL для больших полей
                disposedValue = true;
            }
        }

        
        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
