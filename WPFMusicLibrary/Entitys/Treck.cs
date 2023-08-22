using System;
using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class Treck
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int? AlbumId { get; set; }

        public Album? Album { get; set; }

        public int? ArtistId { get; set; }

        public Artist? Artist { get; set; }

        public TimeSpan Duration { get; set; }

        public ICollection<PlayList> PlayLists { get; set; } = new HashSet<PlayList>();
    }
}
