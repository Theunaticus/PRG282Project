using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataLayer;
using PRG282Project.PresentationLayer;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace PRG282Project.DataAccessLayer
{
    class DataHandler
    {
        public static DataHandler current;//Data Source=DESKTOP-M2MPA17\SQLEXPRESS;Initial Catalog=PRG282Project;Integrated Security=True
        string ConnectionString = @"Data Source=DESKTOP-68BFB0T\PRG282SQL;Initial Catalog=PRG282Project;Integrated Security=True";

        public bool ConnectDatabase()
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception e)
            {
                PL.current.DisplayError(e.Message);
                return false;
            }
        }

        public  DataHandler ()
        {
            current = this;
        }

        public List<User> GetAllUsers()
        {
            return Userbase.current.GetAllUsers();
        }

        public  DataTable   GetStudents ()
        {
            string Query = @"SELECT * FROM tblStudents";
            SqlDataAdapter DA = new SqlDataAdapter(Query,ConnectionString);
            DataTable Result = new DataTable();
            DA.Fill(Result);
            return Result;
        }

        public  void    InsertRecord(RecordData Data)
        {
            if (Data.GetType()==typeof(StudentData))
            {

            }
        }


        public string searchStudent(int StudID)
        {
            {
                try
                {
                    DataTable Table = GetStudents();
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        if (Table.Rows[i]["StudentID"].ToString() == StudID)
                        {
                            return i;
                        }
                    }
                }
                catch (Exception e)
                {
                    DBForm.current.DisplayError(e.Message);
                }
                return -1;
            }

        }

        public enum TableChoice
        {
            tblStudents,
            tblModules,
        }
    }
}
