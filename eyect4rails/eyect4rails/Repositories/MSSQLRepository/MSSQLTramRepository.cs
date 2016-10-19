using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using eyect4rails.IRepository;
using eyect4rails.Classes;
using System.Windows.Forms;



namespace eyect4rails.Repositories.MSSQLRepository
{
    class MSSQLTramRepository : Database, ITramRepository
    {
        /// <summary>
        /// Gets a list of every tram in the database, 
        /// </summary>
        /// <returns>Returns a list of trams</returns>
        public List<Tram> GetAll()
        {
            List<Tram> trams = new List<Tram>();
            string query =
                $"SELECT Tram.ID as TramID, Tram.Status as Status, Tram.Sectors as Sectors, Tram.Type as Type FROM Tram";

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
                                Tram tram = new Tram(
                                    Convert.ToInt32(reader["TramID"]),
                                    reader["Type"].ToString(),
                                    Convert.ToInt32(reader["Sectors"]),
                                    reader["Status"].ToString());
                                trams.Add(tram);

                            }
                        }

                        CloseConnection();
                        return trams;


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
                Connection.Close();
            }

        }
    

    /// <summary>
        /// Inserts a new tram into the database
        /// </summary>
        /// <param name="tram"> the tram that is going to be inserted in the database</param>
        /// <returns> returns a true or false value, true when the tram is succesfully inserted, false when not</returns>
        public bool Insert(Tram tram)
        {

            string query = "INSERT INTO Tram (Status, Sectors, Type) values(@TramId, @Status, @Sectors, @Type)";

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@Sectors", tram.Sectors);
                            command.Parameters.AddWithValue("@Sectors", tram.Sectors);
                            command.Parameters.AddWithValue("@Type", tram.TramType);
                            command.ExecuteNonQuery();
                            return true;
                        }

                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                            CloseConnection();
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

        /// <summary>
        /// Updates the value of the tram in the database
        /// </summary>
        /// <param name="tram">the tram that needs to be updated in the database</param>
        /// <param name="id">the id of the tram that needs to be updated</param>
        public void Update(int id, Tram tram)
        {
            string query = "Update Tram SET Status = @Status, Sectors = @Sectors, Type = @Type WHERE ID = @Id";
            try
            {
                if (OpenConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@Status", tram.Status);
                            command.Parameters.AddWithValue("@Sectors", tram.Sectors);
                            command.Parameters.AddWithValue("@Type", tram.TramType);
                            command.Parameters.AddWithValue("@Id", id);
                            command.ExecuteNonQuery();
                        }

                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.ToString());
                            CloseConnection();
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

        /// <summary>
        /// Deletes a tram from the database
        /// </summary>
        /// <param name="id">The id of the tram that needs to be deleted</param>
        /// <returns>returns true when the tram is deleted from the database and false if it's not</returns>
        public bool Delete(int id)
        {
            string query =
                "DELETE FROM Tram WHERE ID = @Id  DELETE FROM TrackTram WHERE TramID = @Id  DELETE FROM TaskExecution WHERE TramID = @Id";
            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@Id", id);
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

        /// <summary>
        /// Searches the database for a specific tram and returns the tram
        /// </summary>
        /// <param name="id"> the id of the tram you want to find</param>
        /// <returns> returns a tram that matches the id given by the paramater</returns>
        public Tram GetById(int id)
        {
            Tram tram = null;
            string query =
                "SELECT Tram.ID as TramID, Tram.Status as Status, Tram.Sectors as Sectors, Tram.Type as Type FROM Tram WHERE Tram.ID = @id";

            try
            {
                if (OpenConnection() == true)
                {
                    using (SqlCommand command = new SqlCommand(query, Connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        try
                        {
                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                try
                                {
                                    while (reader.Read() == true)
                                    {

                                        Tram SelectedTram = new Tram(
                                            Convert.ToInt32(reader["TramID"]),
                                            reader["Type"].ToString(),
                                            Convert.ToInt32(reader["Sectors"]),
                                            reader["Status"].ToString());
                                        tram = SelectedTram;

                                    }
                                }
                                catch (SqlException exception)
                                {
                                    MessageBox.Show(exception.Message);
                                    CloseConnection();
                                }

                            }
                        }
                        catch (SqlException exception)
                        {
                            MessageBox.Show(exception.Message);
                            CloseConnection();
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

            return tram;
        }
    }
}

