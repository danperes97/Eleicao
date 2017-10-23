using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace EleicaoPrefeito
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                DbConnection dbConnection = new DbConnection("User ID=root;Password=5632;Host=localhost;Port=3306;");
                dbConnection.InitializeElectionDb();
            }catch(Exception ex)
            {

            }
               
            
            // using (SqlDataReader reader = command.ExecuteReader())
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Carregamento());
        }
    }
}
