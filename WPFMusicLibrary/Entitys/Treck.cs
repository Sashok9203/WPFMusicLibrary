using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMusicLibrary.Entitys
{
    public class Treck
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int AlbomId { get; set; }

        public Album Albom { get; set; }

        public int ArtisId { get; set; }

        public Artist Artis { get; set; }

        public TimeSpan Duration { get; set; }

        public ICollection<PlayList> PlayLists { get; set; }
    }
}
