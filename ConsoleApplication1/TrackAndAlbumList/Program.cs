using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAlbumsAndTracks();
        }

        private static void CreateAlbumsAndTracks()
        {
            #region albums
            var albums = new Album[]
            {
                new Album()
                {
                    AlbumId = 1,
                    AlbumName = "Thriller",
                    Artist = "Micheal Jackson"
                },
                new Album()
                {
                    AlbumId=20,
                    AlbumName = "dasdd",
                    Artist = "Artysta"
                },
                new Album()
                {
                    AlbumId = 6,
                    AlbumName = "Muzeum",
                    Artist = "Jacek Kaczmarski"
                },
                new Album()
                {
                    AlbumId = 13,
                    AlbumName = "Life is Peachy",
                    Artist = "KoRn"
                },
                new Album() {
                    AlbumId = 10,
                    AlbumName = "SuperAlbum",
                    Artist = "Muzykant"
                },
                new Album()
                {
                    AlbumId = 3,
                    AlbumName = "NolDresNolStres",
                    Artist = "LoKi"
                },
                new Album()
                {
                    AlbumId = 8,
                    AlbumName = "Queen Rock Montreal",
                    Artist = "Queen"
                },
                new Album()
                {
                    AlbumId = 12,
                    AlbumName = "Lungs",
                    Artist = "Florence and the Machine"
                },
                new Album()
                {
                    AlbumId = 7,
                    AlbumName = "Kind Of Blue",
                    Artist = "Miles Davis"
                },
                new Album()
                {
                    AlbumId = 11,
                    AlbumName = "The Pick of Destiny",
                    Artist = "Tenacious D"
                },
                new Album()
                {
                    AlbumId = 4,
                    AlbumName = "Jerry",
                    Artist = "Chopin"
                },
                new Album()
                {
                    AlbumId = 9,
                    AlbumName = "Shogun",
                    Artist = "Trivium"
                },
                new Album()
                {
                    AlbumId = 5,
                    AlbumName = "Księga Tajemnicza. Prolog",
                    Artist = "Kaliber 44"
                },
                new Album()
                {
                    AlbumId = 2,
                    AlbumName = "La Maison De Mon Reve",
                    Artist = "CocoRosie"
                },
            };
            #endregion

            #region tracks
            var tracks = new Track[]
            {
                new Track()
                {
                    AlbumId = 2,
                    TrackName = "Terrible Angels",
                    Duration = TimeSpan.Parse("0:4:10")
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
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Wejście",
                    Duration = new TimeSpan(0,0,19)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Nasze mózgi wypełnione są marią",
                    Duration = new TimeSpan(0,3,50)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Usłysz mój głos",
                    Duration = new TimeSpan(0,2,7)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Brat nie ma już miłości dla mnie",
                    Duration = new TimeSpan(0,4,4)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Psychoza",
                    Duration = new TimeSpan(0,4,12)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "To czyni mnie innym od was wszystkich",
                    Duration = new TimeSpan(0,4,23)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Więcej szmalu 2",
                    Duration = new TimeSpan(0,3,58)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Do boju zakon marii",
                    Duration = new TimeSpan(0,3,56)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Bierz mój miecz i masz",
                    Duration = new TimeSpan(0,4,15)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Plus i minus",
                    Duration = new TimeSpan(0,4,55)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Moja obawa (bądź a klęknę)",
                    Duration = new TimeSpan(0,4,01)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Psychodela",
                    Duration = new TimeSpan(0,5,48)
                },
                new Track()
                {
                    AlbumId = 5,
                    TrackName = "Bez wyjścia",
                    Duration = new TimeSpan(0,0,31)
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Kirisute Gomen",
                    Duration = TimeSpan.Parse("0:6:27")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Torn Between Scylla and Charybdis",
                    Duration = TimeSpan.Parse("0:6:49")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Down from the Sky",
                    Duration = TimeSpan.Parse("0:5:34")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Into the Mouth of Hell We March",
                    Duration = TimeSpan.Parse("0:5:52")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Throes of Perdition",
                    Duration = TimeSpan.Parse("0:5:54")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Insurrection",
                    Duration = TimeSpan.Parse("0:4:57")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "The Calamity",
                    Duration = TimeSpan.Parse("0:4:58")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "He Who Spawned the Furies",
                    Duration = TimeSpan.Parse("0:4:07")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Of Prometheus and the Crucifix",
                    Duration = TimeSpan.Parse("0:4:40")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "Like Callisto to a Star in Heaven",
                    Duration = TimeSpan.Parse("0:5:25")
                },
                new Track()
                {
                    AlbumId = 9,
                    TrackName = "ShogunTrack",
                    Duration = TimeSpan.Parse("0:11:54")
                },
                new Track()
                {
                    AlbumId = 4,
                    TrackName = "F-mol",
                    Duration = new TimeSpan(0,6,4)
                },
                 new Track()
                {
                    AlbumId = 4,
                    TrackName = "G-dur",
                    Duration = new TimeSpan(0,7,4)

                },
                 new Track()
                {
                    AlbumId = 4,
                    TrackName = "C-dur",
                    Duration = new TimeSpan(0,5,6)

                },
                 new Track()
                {
                    AlbumId = 4,
                    TrackName = "D-mol",
                    Duration = new TimeSpan(0,11,3)

                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Kickapoo",
                    Duration = new TimeSpan(0,4,14)
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Classico",
                    Duration = new TimeSpan(0,0,58)
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Baby",
                    Duration = new TimeSpan(0,1,36)
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Destiny",
                    Duration = new TimeSpan(0,0,37)
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "History",
                    Duration=TimeSpan.Parse("0:1:42")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "The Government Totally Sucks",
                    Duration=TimeSpan.Parse("0:1:34")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Master Exploder",
                    Duration = TimeSpan.Parse("0:2:24")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "The Divide",
                    Duration = TimeSpan.Parse("0:0:22")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Papagenu (He's My Sassafrass)",
                    Duration = TimeSpan.Parse("0:2:24")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Dude (I Totally Miss You)",
                    Duration = TimeSpan.Parse("0:2:53")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Break In-City (Storm the Gate!)",
                    Duration = TimeSpan.Parse("0:1:22")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Car Chase City",
                    Duration = TimeSpan.Parse("0:2:42")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "Beelzeboss (The Final Showdown)",
                    Duration = TimeSpan.Parse("0:5:35")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "POD",
                    Duration = TimeSpan.Parse("0:2:32")
                },
                new Track()
                {
                    AlbumId = 11,
                    TrackName = "The Metal",
                    Duration = TimeSpan.Parse("0:2:45")
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "So What",
                    Duration = new TimeSpan(0,9,4)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Freddie Freeloader",
                    Duration = new TimeSpan(0,9,34)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Blue In Green",
                    Duration = new TimeSpan(0,5,27)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "All Blues",
                    Duration = new TimeSpan(0,11,33)
                },
                new Track()
                {
                    AlbumId = 7,
                    TrackName = "Flamenco SKetches",
                    Duration = new TimeSpan(0,9,26)
                },
                new Track()
                {
                    AlbumId = 12,
                    TrackName = "Dog Days Are Over",
                    Duration = new TimeSpan(0,4,12)
                },
                new Track()
                {
                    AlbumId = 12,
                    TrackName = "Rabbit Heart (Raise It Up)",
                    Duration = new TimeSpan(0,3,52)
                },
                new Track()
                {
                    AlbumId = 12,
                    TrackName = "I'm Not Calling You a Liar",
                    Duration = new TimeSpan(0,3,5)
                },

               new Track()
                {
                    AlbumId = 12,
                    TrackName = "Howl",
                    Duration = new TimeSpan(0,3,34)
                },
                new Track()
                {
                    AlbumId = 12,
                    TrackName = "Kiss with a Fist",
                    Duration = new TimeSpan(0,2,4)
                },

               new Track()
                {
                    AlbumId = 12,
                    TrackName = "Girl with One Eye",
                    Duration = new TimeSpan(0,3,38)
                },
                 new Track()
                {
                    AlbumId = 12,
                    TrackName = "Drumming Song",
                    Duration = new TimeSpan(0,3,43)
                },
                  new Track()
                {
                    AlbumId = 12,
                    TrackName = "Between Two Lungs",
                    Duration = new TimeSpan(0,4,9)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Intro",
                    Duration = new TimeSpan(0,1,59)   //spojrzeć na przeciążenia TimeSpan!
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "We Will Rock You (Fast)",
                    Duration = new TimeSpan(0,3,6)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Let Me Entertain You",
                    Duration = new TimeSpan(0,2,49)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Play The Game",
                    Duration = new TimeSpan(0,3,57)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Somebody To Love",
                    Duration = new TimeSpan(0,7,53)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Killer Queen",
                    Duration = new TimeSpan(0,2,0)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "I'm In Love With My Car",
                    Duration = new TimeSpan(0,2,3)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Get Down, Make Love",
                    Duration = new TimeSpan(0,4,46)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Save Me",
                    Duration = new TimeSpan(0,4,15)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Now I'm Here",
                    Duration = new TimeSpan(0,5,32)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Dragon Attack",
                    Duration = new TimeSpan(0,3,12)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Now I'm Here (Reprise)",
                    Duration = new TimeSpan(0,1,53)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Love Of My Life",
                    Duration = new TimeSpan(0,3,57)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Under Pressure",
                    Duration = new TimeSpan(0,3,50)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Keep Yourself Alive",
                    Duration = new TimeSpan(0,3,29)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Drum And Tympani Solo",
                    Duration = new TimeSpan(0,3,0)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Guitar Solo",
                    Duration = new TimeSpan(0,5,11)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Flash",
                    Duration = new TimeSpan(0,2,11)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "The Hero",
                    Duration = new TimeSpan(0,1,51)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Crazy Little Thing Called Love",
                    Duration = new TimeSpan(0,4,16)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Jailhouse Rock",
                    Duration = new TimeSpan(0,2,33)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Bohemian Rhapsody",
                    Duration = new TimeSpan(0,5,29)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Tie Your Mother Down",
                    Duration = new TimeSpan(0,3,53)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Another Bites The Dust",
                    Duration = new TimeSpan(0,4,1)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "Sheer Heart Attack",
                    Duration = new TimeSpan(0,3,54)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "We Will Rock You",
                    Duration = new TimeSpan(0,2,9)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "We Are The Champions",
                    Duration = new TimeSpan(0,3,28)
                },
                new Track()
                {
                    AlbumId = 8,
                    TrackName = "God Save The Queen",
                    Duration = new TimeSpan(0,1,28)
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Czerwona jajecznica 01",
                    Duration = TimeSpan.Parse("0:6:48")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Babcia ciagnie z wiadra  02",
                    Duration = TimeSpan.Parse("0:1:58")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Ej Ty 03",
                    Duration = TimeSpan.Parse("0:7:28")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Biust 04",
                    Duration = TimeSpan.Parse("0:11:58")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Twoj Stary 05",
                    Duration = TimeSpan.Parse("0:9:18")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Dobranoc 06",
                    Duration = TimeSpan.Parse("0:10:08")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Kawa i fajeczka 07",
                    Duration = TimeSpan.Parse("0:4:48")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Melepeta 08",
                    Duration = TimeSpan.Parse("0:21:58")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Ciec Malinowy 09",
                    Duration = TimeSpan.Parse("0:14:28")
                },
                new Track()
                {
                    AlbumId = 3,
                    TrackName = "Czeresnie 10",
                    Duration = TimeSpan.Parse("0:11:18")
                },
                new Track()
                {
                    AlbumId=20,
                    Duration = new TimeSpan(0, 4, 28),
                    TrackName = "dasdsa"
                },
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
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Modlitwa o wschodzie słońca",
                    Duration = TimeSpan.Parse("0:3:10")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Szturm",
                    Duration = TimeSpan.Parse("0:1:56")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Stańczyk",
                    Duration = TimeSpan.Parse("0:4:5")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Rejtan, czyli raport ambasadora",
                    Duration = TimeSpan.Parse("0:3:24")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Wieszanie zdrajców",
                    Duration = TimeSpan.Parse("0:2:13")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Pikieta powstańcza",
                    Duration = TimeSpan.Parse("0:3:15")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Somosierra",
                    Duration = TimeSpan.Parse("0:2:33")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Zesłanie studentów",
                    Duration = TimeSpan.Parse("0:4:29")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Zatruta studnia",
                    Duration = TimeSpan.Parse("0:4:6")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Wigilia na Syberii",
                    Duration = TimeSpan.Parse("0:5:21")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Powrót z Syberii",
                    Duration = TimeSpan.Parse("0:3:24")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Wiosna 1905",
                    Duration = TimeSpan.Parse("0:3:18")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Ballada o spalonej synagodze",
                    Duration = TimeSpan.Parse("0:2:38")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Autoportret Witkacego",
                    Duration = TimeSpan.Parse("0:4:53")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Rozstrzelanie",
                    Duration = TimeSpan.Parse("0:1:23")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Birkenau",
                    Duration = TimeSpan.Parse("0:6:18")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Czerwony autobus",
                    Duration = TimeSpan.Parse("0:2:12")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Osły i ludzie",
                    Duration = TimeSpan.Parse("0:4:14")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Kanapka z człowiekiem",
                    Duration = TimeSpan.Parse("0:2:56")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Wariacje dla Grażynki",
                    Duration = TimeSpan.Parse("0:2:40")
                },
                new Track()
                {
                    AlbumId = 6,
                    TrackName = "Arka Noego",
                    Duration = TimeSpan.Parse("0:3:19")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Twist",
                    Duration = new TimeSpan(0,0,49)
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Chi",
                    Duration = TimeSpan.ParseExact("03:54", @"mm\:ss", CultureInfo.InvariantCulture)
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Lost",
                    Duration = TimeSpan.Parse("0:2:55")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Swallow",
                    Duration = TimeSpan.Parse("0:3:38")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Porno Creep",
                    Duration=TimeSpan.Parse("0:2:01")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Good God",
                    Duration = TimeSpan.Parse("0:3:20")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Mr. Rogers",
                    Duration = TimeSpan.Parse("0:5:10")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "K@#Ø%!",
                    Duration = TimeSpan.Parse("0:3:02")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "No Place to Hide",
                    Duration = TimeSpan.Parse("0:3:31")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Wicked",
                    Duration = TimeSpan.Parse("0:3:58")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "A.D.I.D.A.S.",
                    Duration = TimeSpan.Parse("0:2:32")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Lowrider",
                    Duration = TimeSpan.Parse("0:0:58")
                },
                new Track()
                {
                    AlbumId = 13,
                    TrackName = "Ass Itch",
                    Duration = TimeSpan.Parse("0:3:39")
                },
                 new Track()
                {
                    AlbumId = 13,
                    TrackName = "Kill You",
                    Duration = TimeSpan.Parse("0:8:37")
                },
                 new Track()
                {
                    AlbumId = 10,
                    TrackName = "Pioseneczka",
                    Duration = new TimeSpan(0,3,43)
                },
                new Track()
                {
                    AlbumId = 10,
                    TrackName = "Muzyczka",
                    Duration = new TimeSpan(0,2,49)
                },
                new Track()
                {
                    AlbumId = 10,
                    TrackName = "Tralala",
                    Duration = new TimeSpan(0,6,10)
                },
                new Track()
                {
                    AlbumId = 10,
                    TrackName = "SzafaGra",
                    Duration = new TimeSpan(0,4,01)
                },
                new Track()
                {
                    AlbumId = 10,
                    TrackName = "Wlazł Kotek Na Płotek i Spadł",
                    Duration = new TimeSpan(0,4,0)
                },
                new Track()
                {
                    AlbumId = 10,
                    TrackName = "nutka",
                    Duration = new TimeSpan(0,2,50)
                },
            };
            #endregion


           var tracksOfParticularAlbum = tracks.Where(t => t.AlbumId == 12);
            foreach(var song in tracksOfParticularAlbum)
            {
                Console.WriteLine($"{song.TrackName, -35} | Duration: {song.Duration}");
            }

        }
    }

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
}
