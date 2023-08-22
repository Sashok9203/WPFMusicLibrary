using System.Collections.Generic;

namespace WPFMusicLibrary.Entitys
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<PlayList> PlayLists { get; set; } = new HashSet<PlayList>();
    }
}
