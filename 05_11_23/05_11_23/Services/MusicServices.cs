using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _05_11_23.Models;
using _05_11_23.SQLCLIENT;

namespace _05_11_23.Services
{
    internal class MusicServices
    {
        private SQLİnquiry _database = new SQLİnquiry();

        public void MusicAdd(Music music)
        {
            string cmd = $"INSERT INTO Musics ([Name], Duration, CategoryID) VALUES ('{music.Name}', {music.Duration}, {music.CategoryId})";
            int result=_database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Successfuly completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
        }

        public List<Music> MusicList()
        {
            string query = "SELECT * FROM Musics";
            DataTable table = _database.ExecuteQuery(query);
            List<Music> musics = new List<Music>();
            foreach (DataRow row in table.Rows)
            {
                Music music = new Music
                {
                    MusicId = Convert.ToInt32(row["MusicId"]),
                    Name = row["Name"].ToString(),
                    Duration = Convert.ToInt32(row["Duration"]),
                    CategoryId = Convert.ToInt32(row["CategoryId"]) 
                };
                musics.Add(music);
            }
            return musics;
        }

        public void MusicDelete(int id)
        {
            string cmd = $"DELETE FROM MusicArtist WHERE MusicId = {id}";
            int result = _database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Successfuly completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
            cmd = $"DELETE FROM Musics WHERE MusicId = {id}";
            result = _database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Successfuly completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
        }

        public void MusicUpdate(Music music, int id)
        {
            string cmd = $"UPDATE Musics SET [Name] = '{music.Name}', Duration = {music.Duration}, CategoryId = {music.CategoryId} WHERE MusicId = {id}";
            int result = _database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Successfuly completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
        }
    }
}
