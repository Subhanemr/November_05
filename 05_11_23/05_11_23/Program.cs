using _05_11_23.Models;
using _05_11_23.Services;

namespace _05_11_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicServices musicServices = new MusicServices();

            Music music = new Music
            {
                Name = "Maks",
                Duration = 239,
                CategoryId = 3
            };
            musicServices.MusicAdd(music);

            List<Music> musicList = musicServices.MusicList();

            foreach (Music iteMusic in musicList)
            {
                Console.WriteLine($"Music Id: {iteMusic.MusicId}\n Music Name: {iteMusic.Name}\n  Duration: {iteMusic.Duration}\n  Category Id: {iteMusic.CategoryId}");
            }

            Music music2 = new Music
            {
                Name = "Frost",
                Duration = 289,
                CategoryId = 2
            };

            musicServices.MusicDelete(3);
            musicServices.MusicUpdate(music2, 3);

            ArtistServices artistServices = new ArtistServices();

            Artist artist = new Artist
            {
                Name = "Joe",
                Birthday = DateTime.Now,
                Gender = "Nword"
            };
            artistServices.ArtistAdd(artist);

            List<Artist> artistList = artistServices.ArtistList();

            foreach (Artist iteArtist in artistList)
            {
                Console.WriteLine($"Artist Id: {iteArtist.ArtistId}\n Artist Name: {iteArtist.Name}\n Artist Surname: {iteArtist.Surname}\n  Artist Birthday: {iteArtist.Birthday}\n  Artist Gender: {iteArtist.Gender}");
            }

            Artist artis2 = new Artist
            {
                Name = "Barbie",
                Surname = "Doll",
                Birthday = DateTime.Now,
                Gender = "Doll"
            };

            artistServices.ArtistDelete(2);
            artistServices.ArtistUpdate(artis2, 4);
        }
    }
}