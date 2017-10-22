using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleicaoPrefeito
{
    public class DbConnection
    {
        private string connetionString;
        private SqlConnection sqlConnection;

        public string ConnetionString { get; private set; }

        public DbConnection(string connetionString)
        {
            this.ConnetionString = connetionString;
            this.sqlConnection = new SqlConnection(connetionString);
        }

        public void OpenConnection(){
          try{
            this.sqlConnection.Open();
          }
          catch(Exception ex){
            MessageBox.Show("Cannot open a connection!");
          }
        }

        public void CloseConnection(){
          try{
            this.sqlConnection.Close();
          }
          catch(Exception ex){
            MessageBox.Show("Cannot close a connection!");
          }
        }
      }
}
