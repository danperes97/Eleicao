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
            DbConnection con = new DbConnection("User ID=root;Password=5632;Host=localhost;Port=3306;");
            con.OpenConnection();

            using (MySqlCommand command = new MySqlCommand("Use database eleicao;", con.SqlConnection)) ;
            using (MySqlCommand command = new MySqlCommand("create table candidates(id INT NOT NULL auto_increment PRIMARY KEY,name VARCHAR(255));", con.SqlConnection));
            // using (SqlDataReader reader = command.ExecuteReader())
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Carregamento());
        }
    }
}
