using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace FloraGotchiAppV2
{
    public class PlantContext
    {
        private readonly string _connectionString;
        public PlantContext(string connectionString)
        {
            _connectionString = connectionString;
        }


        private SqlConnection DatabaseConnection => new SqlConnection(_connectionString);

        public class PlaylistDto
        {
            public string Name { get; set; }
            public int OwnerId { get; set; }
            public DateTime CreationDate { get; set; }
            public int Id { get; set; }
        }



        public IEnumerable<PlaylistDto> GetAccesiblePlaylistsForUser(int userId)
        {
            List<PlaylistDto> playlists = new List<PlaylistDto>();
            using (var con = DatabaseConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spGetOwnedPlaylistsForUser", con))
                {
                    cmd.Parameters.AddWithValue("@owner_id", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        foreach (var row in reader)
                        {
                            playlists.Add(new PlaylistDto
                            {
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                CreationDate = reader.GetDateTime(reader.GetOrdinal("creation_date")),
                                OwnerId = reader.GetInt32(reader.GetOrdinal("official_owner_id"))
                            });
                        }
                    }
                }
            }

            return playlists;
        }

        public PlaylistDto GetPlantValues(int plant_id)
        {
            using (var con = DatabaseConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spGetOwnedPlaylistsForUser", con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@plant_id", plant_id);
                        if (reader.Read()) {
                            //read values
                            return new PlaylistDto
                            {
                                Name = reader.GetString(reader.GetOrdinal("name")),
                                Id = reader.GetInt32(reader.GetOrdinal("id")),
                                CreationDate = reader.GetDateTime(reader.GetOrdinal("creation_date")),
                                OwnerId = reader.GetInt32(reader.GetOrdinal("official_owner_id"))
                            };
                        }
                        else{
                            throw new Exception("record not found");
                        }
                            
                    }
                }
            }
        }

        public void UpdateTemp(int plantId,int temperatuur)
        {
            try
            {
                using (var con = DatabaseConnection)
                {
                    con.Open();
                    string query = "UPDATE current_situation SET temperature = @temperatuur WHERE plant = @plant_id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@plant_id", plantId);
                        cmd.Parameters.AddWithValue("@temperatuur", temperatuur);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool Exists(int playlistId)
        {
            using (var con = DatabaseConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spPlaylistExists", con) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@playlist_id", playlistId);

                    return (int)cmd.ExecuteScalar() != 0;
                }
            }
        }

    }


}
