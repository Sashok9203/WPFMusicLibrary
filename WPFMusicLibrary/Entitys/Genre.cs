using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class Genre
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
    }
}
