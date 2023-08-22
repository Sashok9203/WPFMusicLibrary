using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.IO;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Shapes;
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
            new Category(){ Id = 1,Name = "Studio" },
            new Category(){ Id = 2,Name = "Live Recording" },
            new Category(){ Id = 3,Name = "Greatest Hits Compilation" },
            new Category(){ Id = 4,Name = "Concept" },
            new Category(){ Id = 5,Name = "Acoustic" },
            new Category(){ Id = 6,Name = "Remix" },
            new Category(){ Id = 7,Name = "Debut" },
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
            new Treck(){ /*Id = 1,*/ArtistId = 1, Name = "Wild Dances" ,AlbumId = 1 ,Duration = new(0,3,10)},
            new Treck(){ /*Id = 2,*/ArtistId = 1, Name = "Heart on Fire" ,AlbumId = 1,Duration = new(0,4,20)},
            new Treck(){ /*Id = 3,*/ArtistId = 1, Name = "Dance with the Wolves" ,AlbumId = 1,Duration = new(0,2,56)},
            new Treck(){ /*Id = 4,*/ArtistId = 1, Name = "Shooting Star" ,AlbumId = 1,Duration = new(0,4,1)},
            new Treck(){ /*Id = 5,*/ArtistId = 1, Name = "The Same Star",AlbumId = 1,Duration = new(0,4,49)},

            new Treck(){ /*Id = 6,*/ArtistId = 2, Name = "Bohemian Rhapsody" ,AlbumId = 2 ,Duration = new(0,2,50)},
            new Treck(){ /*Id = 7,*/ArtistId = 2, Name = "Don't Stop Me Now" ,AlbumId = 2,Duration = new(0,4,00)},
            new Treck(){ /*Id = 8,*/ArtistId = 2, Name = "Somebody to Love" ,AlbumId = 2,Duration = new(0,3,33)},
            new Treck(){ /*Id = 9,*/ArtistId = 2, Name = "We Will Rock You" ,AlbumId = 2,Duration = new(0,5,1)},
            new Treck(){ /*Id = 10,*/ArtistId = 2, Name = "Radio Ga Ga",AlbumId = 2,Duration = new(0,3,49)},

            new Treck(){ /*Id = 11,*/ArtistId = 3, Name = "Praise Abort" ,AlbumId = 3 ,Duration = new(0,3,50)},
            new Treck(){ /*Id = 12,*/ArtistId = 3, Name = "Steh auf" ,AlbumId = 3,Duration = new(0,3,00)},
            new Treck(){ /*Id = 13,*/ArtistId = 3, Name = "Skills in Pills" ,AlbumId = 3,Duration = new(0,4,33)},
            new Treck(){ /*Id = 14,*/ArtistId = 3, Name = "Fish On" ,AlbumId = 3,Duration = new(0,4,1)},
            new Treck(){ /*Id = 15,*/ArtistId = 3, Name = "Knebel",AlbumId = 3,Duration = new(0,3,49)},

            new Treck(){ /*Id = 16,*/ArtistId = 4, Name = "Time to Say Goodbye" ,AlbumId = 4 ,Duration = new(0,4,30)},
            new Treck(){ /*Id = 17,*/ArtistId = 4, Name = "I Live for Her" ,AlbumId = 4,Duration = new(0,5,23)},
            new Treck(){ /*Id = 18,*/ArtistId = 4, Name = "The Prayer" ,AlbumId = 4,Duration = new(0,6,3)},
            new Treck(){ /*Id = 19,*/ArtistId = 4, Name = "I Will Fly for You" ,AlbumId = 4,Duration = new(0,5,12)},
            new Treck(){ /*Id = 20,*/ArtistId = 4, Name = "Besame Mucho",AlbumId = 4,Duration = new(0,4,45)},

            new Treck(){ /*Id = 21,*/ArtistId = 5, Name = "Nocturne in E-flat Major" ,AlbumId = 5 ,Duration = new(0,4,0)},
            new Treck(){ /*Id = 22,*/ArtistId = 5, Name = "Ballade No. 1 in G minor" ,AlbumId = 5,Duration = new(0,3,25)},
            new Treck(){ /*Id = 23,*/ArtistId = 5, Name = "Prelude in D-flat Major" ,AlbumId = 5,Duration = new(0,5,32)},
            new Treck(){ /*Id = 24,*/ArtistId = 5, Name = "Waltz in C-sharp minor," ,AlbumId = 5,Duration = new(0,4,38)},
            new Treck(){ /*Id = 25,*/ArtistId = 5, Name = "Polonaise in A-flat Major",AlbumId = 5,Duration = new(0,4,25)},

            new Treck(){ /*Id = 26,*/ArtistId = 6, Name = "Nocturne in E-flat Major" ,AlbumId = 6 ,Duration = new(0,4,10)},
            new Treck(){ /*Id = 27,*/ArtistId = 6, Name = "Ballade No. 1 in G minor" ,AlbumId = 6,Duration = new(0,4,25)},
            new Treck(){ /*Id = 28,*/ArtistId = 6, Name = "Prelude in D-flat Major" ,AlbumId = 6,Duration = new(0,6,32)},
            new Treck(){ /*Id = 29,*/ArtistId = 6, Name = "Waltz in C-sharp minor" ,AlbumId = 6,Duration = new(0,5,30)},
            new Treck(){ /*Id = 30,*/ArtistId = 6, Name = "Polonaise in A-flat Major",AlbumId = 6,Duration = new(0,5,25)},

            new Treck(){ /*Id = 31,*/ArtistId = 7, Name = "Blue and White Porcelain" ,AlbumId = 7 ,Duration = new(0,3,50)},
            new Treck(){ /*Id = 32,*/ArtistId = 7, Name = "Fragrant Rice" ,AlbumId = 7,Duration = new(0,4,30)},
            new Treck(){ /*Id = 33,*/ArtistId = 7, Name = "Clear Day" ,AlbumId = 7,Duration = new(0,5,32)},
            new Treck(){ /*Id = 34,*/ArtistId = 7, Name = "Jasmine Fragrance" ,AlbumId = 7,Duration = new(0,4,30)},
            new Treck(){ /*Id = 35,*/ArtistId = 7, Name = "Nocturne",AlbumId = 7,Duration = new(0,3,25)},

        };

        public readonly static Album[] AlbomsData =
        {
            new Album(){ Id = 1,Name = "Wild Energy",ArtistId = 1,GenreId = 1,Year = 2008, ImagePath  = System.IO.Path.Combine("Images","Albums","RLWE.jpg")},
            new Album(){ Id = 2,Name = "The Freddie Mercury Album",ArtistId = 2,GenreId = 1,Year = 1992 ,ImagePath  = System.IO.Path.Combine("Images","Albums","TheFMalbum.jpg")},
            new Album(){ Id = 3,Name = "Mutter",ArtistId = 3,GenreId = 1,Year = 2001 ,ImagePath  = System.IO.Path.Combine("Images","Albums","RMAlbum.jpg")},
            new Album(){ Id = 4,Name = "Amore",ArtistId = 4,GenreId = 1,Year = 2006,ImagePath  = System.IO.Path.Combine("Images","Albums","ABAlbum.jpg")},
            new Album(){ Id = 5,Name = "The Complete Nocturnes",ArtistId = 5,GenreId = 1,Year = 2001,ImagePath  = System.IO.Path.Combine("Images","Albums","TCNAlbum.png")},
            new Album(){ Id = 6,Name = "Chansons Parisiennes",ArtistId = 6,GenreId = 1,Year = 1954,ImagePath  = System.IO.Path.Combine("Images","Albums","EPAlbum.png")},
            new Album(){ Id = 7,Name = "Fantasy",ArtistId = 7,GenreId = 1,Year = 2001 ,ImagePath  = System.IO.Path.Combine("Images","Albums","JCFantasy.jpg")},
        };

        public readonly static PlayList[] PlayListsData =
        {
            new PlayList(){ Id = 1,Name = "Music for soul",CategoryId = 1 ,ImagePath  = System.IO.Path.Combine("Images","PlayLists","PL.png")},
            new PlayList(){ Id = 2,Name = "Music in auto",CategoryId = 2,ImagePath  = System.IO.Path.Combine("Images","PlayLists","PL2.jpg")},
            new PlayList(){ Id = 3,Name = "Danсing", CategoryId = 3,ImagePath  = System.IO.Path.Combine("Images","PlayLists","PL.png")},

        };

       
    }
}
