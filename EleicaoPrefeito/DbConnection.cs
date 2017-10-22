using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EleicaoPrefeito
{
    public class DbConnection
    {
        private string connetionString;
        private MySqlConnection sqlConnection;

        public string ConnetionString { get; private set; }
        public MySqlConnection SqlConnection { get; }


        public DbConnection(string connetionString)
        {
            this.ConnetionString = connetionString;
            this.sqlConnection = new MySqlConnection(connetionString);
        }

        public void OpenConnection()
        {
            try
            {
                this.sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open a connection!");
            }
        }

        public void CloseConnection()
        {
            try
            {
                this.sqlConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot close a connection!");
            }
        }
    }
}
