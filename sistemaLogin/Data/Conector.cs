using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace sistemaLogin
{
    internal class Conector
    {
        public static String server = "127.0.0.1";
        public static String dataBase = "login";
        public static String user = "root";
        public static String psw = "12345678";

        public static MySqlConnection connMaster;
        public static void OpenConnection()
        {
            String connectionString = $"server={server}; database={dataBase}; user={user}; password={psw};";
            connMaster = new MySqlConnection(connectionString);
            connMaster.Open();
            if(connMaster.State == ConnectionState.Open)
            {
                MessageBox.Show("Conexión establecida");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }
        public void CloseConnection() 
        { 

        }
    }
}
