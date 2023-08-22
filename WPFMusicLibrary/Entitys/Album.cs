using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class Album
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Year { get; set; }

        public int  ArtistId { get; set; }

        public Artist Artist { get; set;}

        public int GenreId { get; set; }

        public Genre Genre { get; set; }

        public string ImagePath { get; set; }

        public ICollection<Treck> Trecks { get; set; } = new HashSet<Treck>();
    }
}
