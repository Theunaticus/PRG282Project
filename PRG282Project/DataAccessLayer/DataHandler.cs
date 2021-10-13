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
        //armandt se rekenaar: LAPTOP-H72V6H51\SQLEXPRESS
        //theuns se rekenaar: Data Source=DESKTOP-M2MPA17\SQLEXPRESS;Initial Catalog=PRG282Project;Integrated Security=True
        //Francois se rekenaar: DESKTOP-M2MPA17\SQLEXPRESS
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
            try
            {
                if (Data.GetType() == typeof(StudentData))
                {
                    StudentData NewData = (StudentData)Data;
                    if (searchStudent(NewData.StNumber) == -1)
                    {
                        PL.current.DisplayError("Record does not exist");
                        return;
                    }
                    string c = "','";
                    string Insert = @"INSERT INTO tblStudents (Name, Surname, DOB, Gender, Phone, Address, [Module Codes],StudentID, [Student Picture])";
                    Insert += " Values ('" + NewData.StName + c + NewData.Surname + c + NewData.DOB + c + NewData.Gender + c + NewData.Phone + c + NewData.Address + c + NewData.ModuleCodes + c + NewData.StNumber + c + NewData.ImagePath;
                    Insert += "')";
                    executecommand(Insert);
                }
                if (Data.GetType()==typeof(ModuleData))
                {
                    ModuleData NewData = (ModuleData)Data;
                    if (searchStudent(NewData.Code) == -1)
                    {
                        PL.current.DisplayError("Record does not exist");
                        return;
                    }
                    string c = "','";
                    string Insert = @"INSERT INTO Modules (Code, Name, Description, Resources)";
                    Insert += " Values ('" + NewData.Code + c + NewData.Name + c + NewData.Description + c + NewData.ResourceLink;
                    Insert += "')";
                    executecommand(Insert);
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
            try
            {
                if (Data.GetType() == typeof(StudentData))
                {
                    StudentData NewData = (StudentData)Data;
                    if (searchStudent(NewData.StNumber)==-1)
                    {
                        PL.current.DisplayError("Record does not exist");
                        return;
                    }
                    string Update = @"UPDATE tblStudents SET ";
                    Update += "Name = '" + NewData.StName+"',";
                    Update += "Surname = '" + NewData.Surname+"',";
                    Update += "DOB = '" + NewData.DOB+"',";
                    Update += "Gender = '" + NewData.Gender+"',";
                    Update += "Phone = '" + NewData.Phone+"',";
                    Update += "Address = '" + NewData.Address+"',";
                    Update += "[Module Codes] = '" + NewData.ModuleCodes+"',";
                    Update += "[Student Picture] = '" + NewData.ImagePath+"'";
                    Update += " Where StudentID = '" + NewData.StNumber+"'";
                    executecommand(Update);
                }
                if (Data.GetType() == typeof(ModuleData))
                {
                    ModuleData NewData = (ModuleData)Data;
                    if (searchStudent(NewData.Code) == -1)
                    {
                        PL.current.DisplayError("Record does not exist");
                        return;
                    }
                    string Update = @"UPDATE Modules SET ";
                    Update +=  "Name = '"+NewData.Name +"',";
                    Update +=  "Description = '"+NewData.Description +"',";
                    Update +=  "Resources = '"+NewData.ResourceLink+"'";
                    Update += " Where Code = '" + NewData.Code + "'";
                    executecommand(Update);
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
        public int searchModule(string modCode)
        {
            {
                try
                {
                    DataTable Table = GetModules();
                    for (int i = 0; i < Table.Rows.Count; i++)
                    {
                        if (Table.Rows[i]["Code"].ToString() == modCode)
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

        public void deleteRecord(String StudentID, string module, string ID)
        {
            string message = "delete from "+ module +" where "+ ID +" = '"+StudentID+"'";
            executecommand(message);
        }

        public void executecommand(String message)
        {
            try
            {
                SqlConnection connection = new SqlConnection(ConnectionString);
                string Insert = message;
                SqlCommand InsertCMD = new SqlCommand(Insert, connection);
                connection.Open();
                InsertCMD.ExecuteNonQuery();
                connection.Close();
                PL.current.DisplaySuccess("command successfully executed!!!");
            }
            catch (Exception e)
            {
                MessageBox.Show("problem, uuhm... : " + e);
                throw;
            }
           
        }
    }
}
