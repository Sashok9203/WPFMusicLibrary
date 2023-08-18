using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMusicLibrary.Entitys
{
    public class PlayList
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int CategorieId { get; set; }

        public Category Category { get; set; }

        public ICollection<Treck> Trecks { get; set; }
    }
}
