using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class Countrie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection< Artist> Artists { get; set; }  = new HashSet< Artist>();
    }
}
