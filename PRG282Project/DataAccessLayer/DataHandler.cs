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
        string ConnectionString = @"Data Source=DESKTOP-M2MPA17\SQLEXPRESS;Initial Catalog=PRG282Project;Integrated Security=True";

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

        public DataTable GetModules()
        {
            string Query = @"SELECT * FROM Modules";
            SqlDataAdapter DA = new SqlDataAdapter(Query, ConnectionString);
            DataTable Result = new DataTable();
            DA.Fill(Result);
            return Result;
        }

        public  void    InsertRecord(RecordData Data)
        {
            //Check if record exists
            //!!!!!!!!!!!!!!!!!!!!!!!!
            //
            try
            {
                if (Data.GetType() == typeof(StudentData))
                {
                    StudentData NewData = (StudentData)Data;
                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string c = "','";
                    string Insert = @"INSERT INTO tblStudents (Name, Surname, DOB, Gender, Phone, Address, [Module Codes],StudentID, [Student Picture])";
                    Insert += " Values ('" + NewData.StName + c + NewData.Surname + c + NewData.DOB + c + NewData.Gender + c + NewData.Phone + c + NewData.Address + c + NewData.ModuleCodes + c + NewData.StNumber + c + NewData.ImagePath;
                    Insert += "')";
                    SqlCommand InsertCMD = new SqlCommand(Insert, connection);
                    connection.Open();
                    InsertCMD.ExecuteNonQuery();
                    connection.Close();
                    PL.current.DisplaySuccess("Record successfully inserted");
                }
                if (Data.GetType()==typeof(ModuleData))
                {
                    ModuleData NewData = (ModuleData)Data;
                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string c = "','";
                    string Insert = @"INSERT INTO Modules (Code, Name, Description, Resources)";
                    Insert += " Values ('" + NewData.Code + c + NewData.Name + c + NewData.Description + c + NewData.ResourceLink;
                    Insert += "')";
                    SqlCommand InsertCMD = new SqlCommand(Insert, connection);
                    connection.Open();
                    InsertCMD.ExecuteNonQuery();
                    connection.Close();
                    PL.current.DisplaySuccess("Record successfully inserted");
                }
            }
            catch (Exception e)
            {
                PL.current.DisplayError(e.Message);
            }
            PL.current.DisplayDatabase();
        }

        public void UpdateRecord(RecordData Data)
        {
            //Check if record exists
            //!!!!!!!!!!!!!!!!!!!!!!!!
            //
            try
            {
                if (Data.GetType() == typeof(StudentData))
                {
                    StudentData NewData = (StudentData)Data;
                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string Insert = @"UPDATE tblStudents SET ";//, Surname, DOB, Gender, Phone, Address, [Module Codes],StudentID, [Student Picture])";
                    Insert += "Name = '" + NewData.StName+"',";
                    Insert += "Surname = '" + NewData.Surname+"',";
                    Insert += "DOB = '" + NewData.DOB+"',";
                    Insert += "Gender = '" + NewData.Gender+"',";
                    Insert += "Phone = '" + NewData.Phone+"',";
                    Insert += "Address = '" + NewData.Address+"',";
                    Insert += "[Module Codes] = '" + NewData.ModuleCodes+"',";
                    Insert += "[Student Picture] = '" + NewData.ImagePath+"'";
                    Insert  += " Where StudentID = '" + NewData.StNumber+"'";
                    SqlCommand UpdateCMD = new SqlCommand(Insert, connection);
                    connection.Open();
                    UpdateCMD.ExecuteNonQuery();
                    connection.Close();
                    PL.current.DisplaySuccess("Record successfully updated");
                }
                if (Data.GetType() == typeof(ModuleData))
                {
                    ModuleData NewData = (ModuleData)Data;
                    SqlConnection connection = new SqlConnection(ConnectionString);
                    string Insert = @"UPDATE Modules SET ";
                    Insert +=  "Name = '"+NewData.Name +"',";
                    Insert +=  "Description = '"+NewData.Description +"',";
                    Insert +=  "Resources = '"+NewData.ResourceLink+"'";
                    Insert += " Where Code = '" + NewData.Code + "'";
                    SqlCommand InsertCMD = new SqlCommand(Insert, connection);
                    connection.Open();
                    InsertCMD.ExecuteNonQuery();
                    connection.Close();
                    PL.current.DisplaySuccess("Record successfully inserted");
                }
            }
            catch (Exception e)
            {
                PL.current.DisplayError(e.Message);
            }
            PL.current.DisplayDatabase();
        }


        public int searchStudent(string StudID)
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
                    frmDatabase.current.DisplayError(e.Message);
                }
                return -1;
            }

        }

        public enum TableChoice
        {
            tblStudents,
            tblModules,
        }

        public void deleteRecord(String StudentID)
        {
            string message = "delete from tblStudents where studentID = '"+StudentID+"'";
            executecommand(message);
        }

        public void executecommand(String message)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            string Insert = message;
            SqlCommand InsertCMD = new SqlCommand(Insert, connection);
            connection.Open();
            InsertCMD.ExecuteNonQuery();
            connection.Close();
            PL.current.DisplaySuccess("command successfully executed!!!");
        }
    }
}
