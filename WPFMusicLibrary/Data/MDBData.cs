using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WPFMusicLibrary.Entitys;

namespace WPFMusicLibrary.Data
{
    public static  class MDBData
    {
        public readonly static Countrie[] CountriesData =
        {
            new Countrie(){ Id = 1,Name = "Ukraine"  },
            new Countrie(){ Id = 2,Name = "USA"  },
            new Countrie(){ Id = 3,Name = "Germany"  },
            new Countrie(){ Id = 4,Name = "Italy"  },
            new Countrie(){ Id = 5,Name = "Poland"  },
            new Countrie(){ Id = 6,Name = "France"  },
            new Countrie(){ Id = 7,Name = "China"  },
        };

        public readonly static Genre[] GenresData =
        {
            new Genre(){ Id = 1,Name = "Pop"  },
            new Genre(){ Id = 2,Name = "Rock"  },
            new Genre(){ Id = 3,Name = "Electronic Music"  },
            new Genre(){ Id = 4,Name = "Hip-Hop"  },
            new Genre(){ Id = 5,Name = "Classical Music"  },
            new Genre(){ Id = 6,Name = "Jazz"  },
            new Genre(){ Id = 7,Name = "Country Music"  },
        };

        public readonly static Category[] CategorysData =
        {
            new Category(){ Id = 1,Name = "Studio Album" },
            new Category(){ Id = 2,Name = "Live Recording" },
            new Category(){ Id = 3,Name = "Greatest Hits Compilation" },
            new Category(){ Id = 4,Name = "Concept Album" },
            new Category(){ Id = 5,Name = "Acoustic Album" },
            new Category(){ Id = 6,Name = "Remix Album" },
            new Category(){ Id = 7,Name = "Debut Album" },
        };

        public readonly static Artist[] ArtistsData =
        {
            new Artist(){ Id = 1,Name = "Ruslana" ,Surname = "Lyzhychko" ,CountrieId = 1},
            new Artist(){ Id = 2,Name = "Freddie" ,Surname = "Mercury",CountrieId = 2},
            new Artist(){ Id = 3,Name = "Till" ,Surname = " Lindemann",CountrieId = 3},
            new Artist(){ Id = 4,Name = "Andrea" ,Surname = "Bocelli",CountrieId = 4},
            new Artist(){ Id = 5,Name = "Frederic",Surname = "Chopin", CountrieId = 5},
            new Artist(){ Id = 6,Name = "Édith" ,Surname = "Piaf" , CountrieId = 6},
            new Artist(){ Id = 7,Name = "Jay" ,Surname = "Chou" , CountrieId = 7},
        };

        public readonly static Treck[] TrecksData =
        {
            new Treck(){ Id = 1,ArtisId = 1, Name = "Wild Dances" ,AlbomId = 1 ,Duration = new(0,3,10)},
            new Treck(){ Id = 2,ArtisId = 1, Name = "Heart on Fire" ,AlbomId = 1,Duration = new(0,4,20)},
            new Treck(){ Id = 3,ArtisId = 1, Name = "Dance with the Wolves" ,AlbomId = 1,Duration = new(0,2,56)},
            new Treck(){ Id = 4,ArtisId = 1, Name = "Shooting Star" ,AlbomId = 1,Duration = new(0,4,1)},
            new Treck(){ Id = 5,ArtisId = 1, Name = "The Same Star",AlbomId = 1,Duration = new(0,4,49)},

            new Treck(){ Id = 6,ArtisId = 2, Name = "Bohemian Rhapsody" ,AlbomId = 2 ,Duration = new(0,2,50)},
            new Treck(){ Id = 7,ArtisId = 2, Name = "Don't Stop Me Now" ,AlbomId = 2,Duration = new(0,4,00)},
            new Treck(){ Id = 8,ArtisId = 2, Name = "Somebody to Love" ,AlbomId = 2,Duration = new(0,3,33)},
            new Treck(){ Id = 9,ArtisId = 2, Name = "We Will Rock You" ,AlbomId = 2,Duration = new(0,5,1)},
            new Treck(){ Id = 10,ArtisId = 2, Name = "Radio Ga Ga",AlbomId = 2,Duration = new(0,3,49)},

            new Treck(){ Id = 11,ArtisId = 3, Name = "Praise Abort" ,AlbomId = 3 ,Duration = new(0,3,50)},
            new Treck(){ Id = 12,ArtisId = 3, Name = "Steh auf" ,AlbomId = 3,Duration = new(0,3,00)},
            new Treck(){ Id = 13,ArtisId = 3, Name = "Skills in Pills" ,AlbomId = 3,Duration = new(0,4,33)},
            new Treck(){ Id = 14,ArtisId = 3, Name = "Fish On" ,AlbomId = 3,Duration = new(0,4,1)},
            new Treck(){ Id = 15,ArtisId = 3, Name = "Knebel",AlbomId = 3,Duration = new(0,3,49)},

            new Treck(){ Id = 16,ArtisId = 4, Name = "Time to Say Goodbye" ,AlbomId = 4 ,Duration = new(0,4,30)},
            new Treck(){ Id = 17,ArtisId = 4, Name = "I Live for Her" ,AlbomId = 4,Duration = new(0,5,23)},
            new Treck(){ Id = 18,ArtisId = 4, Name = "The Prayer" ,AlbomId = 4,Duration = new(0,6,3)},
            new Treck(){ Id = 19,ArtisId = 4, Name = "I Will Fly for You" ,AlbomId = 4,Duration = new(0,5,12)},
            new Treck(){ Id = 20,ArtisId = 4, Name = "Besame Mucho",AlbomId = 4,Duration = new(0,4,45)},

            new Treck(){ Id = 21,ArtisId = 5, Name = "Nocturne in E-flat Major" ,AlbomId = 5 ,Duration = new(0,4,0)},
            new Treck(){ Id = 22,ArtisId = 5, Name = "Ballade No. 1 in G minor" ,AlbomId = 5,Duration = new(0,3,25)},
            new Treck(){ Id = 23,ArtisId = 5, Name = "Prelude in D-flat Major" ,AlbomId = 5,Duration = new(0,5,32)},
            new Treck(){ Id = 24,ArtisId = 5, Name = "Waltz in C-sharp minor," ,AlbomId = 5,Duration = new(0,4,38)},
            new Treck(){ Id = 25,ArtisId = 5, Name = "Polonaise in A-flat Major",AlbomId = 5,Duration = new(0,4,25)},

            new Treck(){ Id = 26,ArtisId = 6, Name = "Nocturne in E-flat Major" ,AlbomId = 6 ,Duration = new(0,4,10)},
            new Treck(){ Id = 27,ArtisId = 6, Name = "Ballade No. 1 in G minor" ,AlbomId = 6,Duration = new(0,4,25)},
            new Treck(){ Id = 28,ArtisId = 6, Name = "Prelude in D-flat Major" ,AlbomId = 6,Duration = new(0,6,32)},
            new Treck(){ Id = 29,ArtisId = 6, Name = "Waltz in C-sharp minor" ,AlbomId = 6,Duration = new(0,5,30)},
            new Treck(){ Id = 30,ArtisId = 6, Name = "Polonaise in A-flat Major",AlbomId = 6,Duration = new(0,5,25)},

            new Treck(){ Id = 31,ArtisId = 7, Name = "Blue and White Porcelain" ,AlbomId = 7 ,Duration = new(0,3,50)},
            new Treck(){ Id = 32,ArtisId = 7, Name = "Fragrant Rice" ,AlbomId = 7,Duration = new(0,4,30)},
            new Treck(){ Id = 33,ArtisId = 7, Name = "Clear Day" ,AlbomId = 7,Duration = new(0,5,32)},
            new Treck(){ Id = 34,ArtisId = 7, Name = "Jasmine Fragrance" ,AlbomId = 7,Duration = new(0,4,30)},
            new Treck(){ Id = 35,ArtisId = 7, Name = "Nocturne",AlbomId = 7,Duration = new(0,3,25)},

        };

        public readonly static Album[] AlbomsData =
        {

        };

        public readonly static PlayList[] PlayListsData =
        {

        };
    }
}
