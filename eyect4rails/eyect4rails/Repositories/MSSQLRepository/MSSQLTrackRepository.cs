using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eyect4rails.Classes;
using eyect4rails.IRepository;

namespace eyect4rails.Repositories.MSSQLRepository
{
    class MSSQLTrackRepository : Database, ITrackRepository
    {
        public List<Track> GetAll()
        {
            List<Track> tracks = new List<Track>();

            string query = "Select T.ID, T.ConductorRequired,T.Sectors, T.[Type] as TrackType From Track as T inner join Remise as R on R.ID = T.RemiseID inner join Address as AD on AD.ID = R.AddressID";

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Track track = new Track(Convert.ToInt32(reader["ID"]),
                                    Convert.ToBoolean(reader["ConductorRequired"]),
                                    Convert.ToInt32(reader["Sectors"]),
                                    reader["TrackType"].ToString());

                                tracks.Add(track);
                            }
                        }
                        Connection.Close();
                        return tracks;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public Track GetById(int id)
        {
            string query = $"Select T.ID, T.ConductorRequired,T.Sectors, T.[Type] as TrackType From Track as T inner join Remise as R on R.ID = T.RemiseID inner join Address as AD on AD.ID = R.AddressID WHERE T.ID = {id}";

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Track track = new Track(Convert.ToInt32(reader["ID"]),
                                    Convert.ToBoolean(reader["ConductorRequired"]),
                                    Convert.ToInt32(reader["Sectors"]),
                                    reader["TrackType"].ToString());

                                return track;
                            }
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
            return null;
        }

        public bool Insert(Track track)
        {
            // TODO: Use the MSSQLRemise instead of using a static variable for RemiseID
            string query = $"INSERT INTO Track(RemiseID, Type, ConductorRequired, Sectors) values(@remiseID,@type,@conductorRequired,@sectors)";

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        // TODO: Replace "1" with the result from RemiseID above
                        command.Parameters.AddWithValue("@remiseID", " 1");
                        command.Parameters.AddWithValue("@type", track.TrackType);
                        command.Parameters.AddWithValue("@conductorRequired", Convert.ToString(Convert.ToInt32(track.ConductorRequired)));
                        command.Parameters.AddWithValue("@sectors", Convert.ToString(track.Sectors));
                        try
                        {
                            command.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(int id, Track track)
        {
            string query = $"UPDATE Track SET RemiseID = @remiseID, Type = @type, ConductorRequired = @conductorRequired, Sectors = @sectors WHERE Track.ID = @ID";

            //UPDATE table_name
            //SET column1 = value1, column2 = value2,...
            //WHERE some_column = some_value;

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        // TODO: Replace "1" with the result from RemiseID above
                        command.Parameters.AddWithValue("@remiseID", " 1");
                        command.Parameters.AddWithValue("@type", track.TrackType);
                        command.Parameters.AddWithValue("@conductorRequired", Convert.ToString(Convert.ToInt32(track.ConductorRequired)));
                        command.Parameters.AddWithValue("@sectors", Convert.ToString(track.Sectors));
                        command.Parameters.AddWithValue("@ID", Convert.ToString(id));

                        try
                        {
                            command.ExecuteNonQuery();
                        }
                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                        }
                    }
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public bool Delete(int id)
        {
            string query = $"DELETE FROM TrackTram WHERE TrackID = @id DELETE FROM Track WHERE ID = @id";

            //DELETE FROM table_name
            //WHERE some_column = some_value;

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@id", id.ToString());
                        try
                        {
                            command.ExecuteNonQuery();
                            return true;
                        }
                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                            return false;
                        }
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (SqlException exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
