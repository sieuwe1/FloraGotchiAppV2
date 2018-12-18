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


        private SqlConnection MusicShareConnection => new SqlConnection(_connectionString);

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
            using (var con = MusicShareConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spGetOwnedPlaylistsForUser", con) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@owner_id", userId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        foreach (var row in reader)
                        {
                            playlists.Add( new PlaylistDto
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

        public PlaylistDto UpdateTemp(int plantId,int temperature)
        {
            try
            {
                using (var con = MusicShareConnection)
                {
                    con.Open();
                    string 
                    using (SqlCommand cmd = new SqlCommand("", con) { CommandType = CommandType.StoredProcedure })
                    {
                        cmd.Parameters.AddWithValue("@playlist_name", name);
                        cmd.Parameters.AddWithValue("@owner_id", ownerId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new PlaylistDto
                                {
                                    Name = reader.GetString(reader.GetOrdinal("name")),
                                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                                    CreationDate = reader.GetDateTime(reader.GetOrdinal("creation_date")),
                                    OwnerId = reader.GetInt32(reader.GetOrdinal("official_owner_id"))
                                };
                            }
                            throw new Exception("no response retrieved...");

                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void AddTrackToPlaylist(int playlistId, int trackId)
        {
            try
            {
                using (var con = MusicShareConnection)
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("spAddTrackToPlaylist", con) { CommandType = CommandType.StoredProcedure })
                    {
                        cmd.Parameters.AddWithValue("@playlist_id", playlistId);
                        cmd.Parameters.AddWithValue("@track_id", trackId);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
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

        public bool UserOwnsPlaylist(int playlistId, int ownerId)
        {
            using (var con = MusicShareConnection)
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand("spUserOwnsPlaylist", con) { CommandType = CommandType.StoredProcedure })
                {
                    cmd.Parameters.AddWithValue("@playlist_id", playlistId);
                    cmd.Parameters.AddWithValue("@user_id", ownerId);

                    return (int)cmd.ExecuteScalar() == 1;
                }
            }
        }
    }


}
