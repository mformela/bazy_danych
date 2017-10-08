using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class Album
    {
        public int AlbumId { get; set; }
        public string AlbumName { get; set; }
        public string Artist { get; set; }
    }

    internal class Track
    {
        public int AlbumId { get; set; }
        public string TrackName { get; set; }
        public TimeSpan Duration { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {

            CreateAlbumAndTracks();

        }

        private static void CreateAlbumAndTracks()
        {

            var albums = new Album[]
            {
                new Album()
                {
                    AlbumId = 1,
                    AlbumName = "Thriller",
                    Artist = "Micheal Jackson"
                }
            };
            var tracks = new Track[]
            {
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Wanna Be Startin’ Somethin’",
                    Duration = new TimeSpan(0,6,4)
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Baby Be Mine",
                    Duration = TimeSpan.ParseExact("04:21", @"mm\:ss", CultureInfo.InvariantCulture)
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "The Girl Is Mine",
                    Duration = TimeSpan.Parse("0:3:43")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Thriller",
                    Duration = TimeSpan.Parse("0:5:58")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Beat It",
                    Duration=TimeSpan.Parse("0:4:18")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Billie Jean",
                    Duration = TimeSpan.Parse("0:4:54")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Human Nature",
                    Duration = TimeSpan.Parse("0:4:07")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "P.Y.T. (Pretty Young Thing)",
                    Duration = TimeSpan.Parse("0:3:58")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "The Lady in My Life",
                    Duration = TimeSpan.Parse("0:4:59")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Someone in the Dark",
                    Duration = TimeSpan.Parse("0:2:18")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Billie Jean (Home Demo)",
                    Duration = TimeSpan.Parse("0:4:48")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Voice over Session from Thriller",
                    Duration = TimeSpan.Parse("0:2:04")
                },
                new Track()
                {
                    AlbumId = 1,
                    TrackName = "Carousel",
                    Duration = TimeSpan.Parse("0:2:20")
                }
            };




            var albums = new Album[]
           {
                new Album()
                {
                    AlbumId = 2,
                    AlbumName = "La Maison De Mon Reve",
                    Artist = "CocoRosie"
                }
           };
            var tracks = new Track[]
            {
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Terrible Angels",
                    Duration = new TimeSpan(0,4,10)
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "By Your Side",
                    Duration = TimeSpan.Parse("0:3:59")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "TJesus Loves Me",
                    Duration = TimeSpan.Parse("0:3:09")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Good Friday",
                    Duration = TimeSpan.Parse("0:4:20")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Not For Sale",
                    Duration=TimeSpan.Parse("0:1:19")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Tahiti Rain Song",
                    Duration = TimeSpan.Parse("0:3:37")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Candyland",
                    Duration = TimeSpan.Parse("0:4:06")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Butterscotch",
                    Duration = TimeSpan.Parse("0:3:08")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "West Side",
                    Duration = TimeSpan.Parse("0:1:24")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Madonna",
                    Duration = TimeSpan.Parse("0:3:47")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Haitian Love Songs",
                    Duration = TimeSpan.Parse("0:4:56")
                },
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Lyla",
                    Duration = TimeSpan.Parse("0:4:04")
                },
                
            };
        }
    }
}
