using _05_11_23.Models;
using _05_11_23.SQLCLIENT;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_11_23.Services
{
    internal class ArtistServices
    {
        private SQLİnquiry _database = new SQLİnquiry();

        public void ArtistAdd(Artist artist)
        {
            string cmd;
            if (artist.Surname == "XXX")
            {
                cmd = $"INSERT INTO Artists ([Name], Birthday, Gender) VALUES ('{artist.Name}', '{artist.Birthday}', '{artist.Gender}')";
            }
            else
            {
                cmd = $"INSERT INTO Artists ([Name], Surname, Birthday, Gender) VALUES ('{artist.Name}', '{artist.Surname}','{artist.Birthday}', '{artist.Gender}')";

            }
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

        public List<Artist> ArtistList()
        {
            string query = "SELECT * FROM Artists";
            DataTable table = _database.ExecuteQuery(query);
            List<Artist> artists = new List<Artist>();
            foreach (DataRow row in table.Rows)
            {
                Artist artist = new Artist
                {
                    ArtistId = Convert.ToInt32(row["ArtistId"]),
                    Name = row["Name"].ToString(),
                    Surname = row["Surname"].ToString(),
                    Birthday = (DateTime)row["Birthday"],
                    Gender = row["Gender"].ToString()
                };
                artists.Add(artist);
            }
            return artists;
        }

        public void ArtistDelete(int id)
        {
            string cmd = $"DELETE FROM MusicArtist WHERE ArtistId = {id}";
            int result = _database.ExecuteCommand(cmd);
            if (result > 0)
            {
                Console.WriteLine("Successfuly completed");
            }
            else
            {
                Console.WriteLine("Error occured");
            }
            cmd = $"DELETE FROM Artists WHERE ArtistId = {id}";
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

        public void ArtistUpdate(Artist artist, int id)
        {
            string cmd = $"UPDATE Artists SET [Name] = '{artist.Name}', Surname = '{artist.Surname}', Birthday = '{artist.Birthday}', Gender = '{artist.Gender}' WHERE ArtistId = {id}";
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
