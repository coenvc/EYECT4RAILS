using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; 
using System.Windows.Forms;

namespace eyect4rails.Classes
{
    class Database
    {
        public string Server;
        public string DB;
        public string Uid;
        public string Password;
        public SqlConnection Connection;

        /// <summary>
        /// Opens a connection to the database
        /// </summary>
        /// <returns>true on success false on failure</returns>
        public bool OpenConnection()
        {
            Server = "mssql.fhict.local";
            DB = "dbi354261";
            Uid = "dbi354261";
            Password = "EYECT4RAILS";
            string connectionString;
            connectionString = "SERVER=" + Server + ";" + "DATABASE=" +
            DB + ";" + "UID=" + Uid + ";" + "PASSWORD=" + Password + ";";

            Connection = new SqlConnection(connectionString); 

            try
            {
                Connection.Open();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        /// <summary>
        /// Closes a connection to the database 
        /// </summary>
        /// <returns>true on success false on failure</returns>
        public bool CloseConnection()
        {
            try
            {
                Connection.Close();
                return true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

    }
}
