using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iut_dbm_lw4
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        static void Main()
        {
            string connstring = string.Format("Server={0}; database={1}; UID={2}; password={3}", "-", "-", "-", "-");
            using (MySqlConnection conn = new MySqlConnection(connstring))
            {
                conn.Open();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form1(conn));
            }
        }
    }
}
