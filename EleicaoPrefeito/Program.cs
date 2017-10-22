using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            DbConnection con = new DbConnection('connection')
            con.OpenConnection();

            using (SqlCommand command = new SqlCommand("Create Database Election", con.sqlConnection))
            // using (SqlDataReader reader = command.ExecuteReader())
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Carregamento());
        }
    }
}
