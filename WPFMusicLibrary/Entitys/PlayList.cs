using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class PlayList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public string ImagePath { get; set; }

        public ICollection<Treck> Trecks { get; set; } = new HashSet<Treck>();
    }
}
