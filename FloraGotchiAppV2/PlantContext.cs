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
        private List<string> results;

        private readonly string _connectionString;
        public PlantContext(string connectionString)
        {
            _connectionString = connectionString;
        }


        private SqlConnection MusicShareConnection => new SqlConnection(_connectionString);
        

        public List<string> Results
        {
            get { return results; }
            set { results = value; }
        }

        /*

        public IEnumerable<PlaylistDto> GetAccesiblePlaylistsForUser(int userId)
        {
            List<PlaylistDto> playlists = new List<PlaylistDto>();
            using (var con = MusicShareConnection)
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

    */


        public List<string> GetCurrentValues(int plant_id)
        {
            using (var con = MusicShareConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Temperature FROM Current_situation WHERE Planter_ID = @plant_id"))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@plant_id", plant_id);
                        if (reader.Read()) {
                            //read values
                            results.Add(reader.GetString(reader.GetOrdinal("temperature")));
                            return results;
                        }
                        else
                        {
                            throw new Exception("reord not found");
                        }
                            
                    }
                }
            }
        }



        /*
        public PlaylistDto GetCurrentValues(int plant_id)
        {
            using (var con = MusicShareConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Temperature FROM Current_situation WHERE Planter_ID = @plant_id"))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        cmd.Parameters.AddWithValue("@plant_id", plant_id);
                        if (reader.Read())
                        {
                            //read values
                            return new PlaylistDto
                            {
                                //  Name = reader.GetString(reader.GetOrdinal("name")),
                                Id = reader.GetInt32(reader.GetOrdinal("temperature")),
                                // CreationDate = reader.GetDateTime(reader.GetOrdinal("creation_date")),
                                //  OwnerId = reader.GetInt32(reader.GetOrdinal("official_owner_id"))
                            };
                        }
                        else
                        {
                            throw new Exception("reord not found");
                        }

                    }
                }
            }
        }


        public void UpdateTemp(int plantId,int teperatuur)
        {
            try
            {
                using (var con = MusicShareConnection)
                {
                    con.Open();
                    string query = "UPDATE current_situation SET Temperature = @teperatuur WHERE Planter_ID = @plant_id";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@plant_id", plantId);
                        cmd.Parameters.AddWithValue("@teperatuur", teperatuur);
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
            using (var con = MusicShareConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spPlaylistExists", con) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@playlist_id", playlistId);

                    return (int)cmd.ExecuteScalar() != 0;
                }
            }
        }
*/

    }


}
