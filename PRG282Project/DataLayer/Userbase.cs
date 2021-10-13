using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataAccessLayer;
using PRG282Project.ApplicationLayer;

namespace PRG282Project.DataLayer
{
    class Userbase
    {
        public static   Userbase current;

        List<User> AllUsers;
        public int UserCount
        {
            get { 
                return AllUsers.Count;
            }
        }

        public  Userbase    ()
        {
            current = this;
            AllUsers = new List<User>();
            string[] Lines = FileHandler.current.ReadAllFormFile();
            if (Lines!=null)
            {
                for (int i = 0; i < Lines.Length; i++)
                {
                    int StartPos = AL.current.Pos(":", Lines[i]);
                    int EndPos = AL.current.Pos("|", Lines[i]);
                    if (StartPos > 0 && EndPos > StartPos)
                    {
                        string UserName = Lines[i].Substring(StartPos + 1, EndPos - StartPos - 1);

                        string Line = Lines[i].Substring(EndPos + 1, Lines[i].Length - EndPos - 1);
                        StartPos = AL.current.Pos(":", Line);
                        if (StartPos > 0)
                        {
                            string Password = Line.Substring(StartPos + 1, Line.Length - StartPos - 1);
                            AllUsers.Add(new User(UserName, Password));
                        }
                    }
                }
            }
        }

        public  List<User>  GetAllUsers ()
        {
            return AllUsers;
        }

        public  void AddUser    (User newUser)
        {
            AllUsers.Add(newUser);
        }

        public  void Close  ()
        {
            FileHandler.current.Clear();
            for (int i = 0; i < AllUsers.Count; i++)
            {
                FileHandler.current.SaveToFile(AllUsers[i].ToLine());
            }
        }
    }
}
