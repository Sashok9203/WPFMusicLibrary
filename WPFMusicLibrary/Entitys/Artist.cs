using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFMusicLibrary.Entitys
{
    public class Artist
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int CountrieId { get; set; }

        public Countrie Countrie { get; set; }

        public ICollection<Treck> Trecks { get; set; } = new HashSet<Treck>();

        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();

        [NotMapped]
        public string FullName => Name + " " + Surname;

    }
}
