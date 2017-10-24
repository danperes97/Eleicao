using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

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

        public void InitializeElectionDb()
        {
            MySqlConnection con = new MySqlConnection(this.ConnetionString);
            con.Open();

            if (BaseExists(con) == false) {
                CreateDbElection(con);
                UseDbElection(con);

                CreateTablesParties(con);
                CreateTableCandidates(con);
            }
        }

        public void CreateDbElection(MySqlConnection mySqlConnection){
            String sql_query = "CREATE DATABASE election;";
            MySqlCommand command = new MySqlCommand(sql_query, mySqlConnection);
            try
            {
                command.ExecuteNonQuery();
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void UseDbElection(MySqlConnection mySqlConnection)
        {
            String sql_query = "USE election;";
            MySqlCommand command = new MySqlCommand(sql_query, mySqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateTableCandidates(MySqlConnection mySqlConnection)
        {
            String sql_query = 
                "CREATE TABLE CANDIDATES(id INT NOT NULL auto_increment PRIMARY KEY," +
                "name VARCHAR(255)," +
                "votes INT DEFAULT 1," +
                "party_id INT,"+
                "FOREIGN KEY (party_id) REFERENCES Parties(id));";
            MySqlCommand command = new MySqlCommand(sql_query, mySqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CreateTablesParties(MySqlConnection mySqlConnection)
        {
            String sql_query = 
                "CREATE TABLE PARTIES(id INT NOT NULL auto_increment PRIMARY KEY," +
                "name VARCHAR(255)," +
                " initials VARCHAR(255));";
            MySqlCommand command = new MySqlCommand(sql_query, mySqlConnection);
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool BaseExists(MySqlConnection mySqlConnection)
        {
            MySqlCommand cmd = new MySqlCommand(MySqlCommandSchemaExists(), mySqlConnection);
            return cmd.ExecuteScalar().ToString() == "1";
        }

        public string MySqlCommandSchemaExists() {
            return "SELECT COUNT(*) " +
                   "SCHEMA_NAME FROM " +
                   "INFORMATION_SCHEMA.SCHEMATA " +
                   "WHERE SCHEMA_NAME='election'";
        }

    }
}
