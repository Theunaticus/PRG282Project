using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataLayer;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace PRG282Project.DataAccessLayer
{
    class DataHandler
    {
        public static DataHandler current;

        public void ConnectDatabase()
        {
            String Connect;
            SqlConnection connection;

            Connect = @"Server=LAPTOP-H72V6H51\SQLEXPRESS; Initial Catalog=PRG282Project; Integrated Security=SSPI";

            connection = new SqlConnection(Connect);

            connection.Open();
            MessageBox.Show("Database Open!!!");
            connection.Close();
            MessageBox.Show("Database closed!!!");
        }

        public  DataHandler ()
        {
            current = this;
        }

        public List<User> GetAllUsers()
        {
            return Userbase.current.GetAllUsers();
        }
    }
}
