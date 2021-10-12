using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataAccessLayer;

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
            for (int i = 0; i < Lines.Length; i++)
            {
                int StartPos = Pos(":", Lines[i]);
                int EndPos = Pos("|", Lines[i]);
                if (StartPos>0 && EndPos>StartPos)
                {
                    string UserName = Lines[i].Substring(StartPos + 1, EndPos - StartPos - 1);

                    string Line = Lines[i].Substring(EndPos + 1, Lines[i].Length - EndPos - 1);
                    StartPos = Pos(":", Line);
                    if (StartPos>0)
                    {
                        string Password = Line.Substring(StartPos + 1, Line.Length - StartPos - 1);
                        AllUsers.Add(new User(UserName,Password));
                    }
                }
            }
        }

        int Pos (string Substring,string String)
        {
            for (int i = 0; i < String.Length-Substring.Length+1; i++)
            {
                if (String[i]==Substring[0])
                {
                    bool Valid = true;
                    for (int I = 0; I < Substring.Length; I++)
                    {
                        if (String[i+I]!=Substring[I])
                        {
                            Valid = false;
                            break;
                        }
                    }
                    if (Valid)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }

        public  List<User>  GetAllUsers ()
        {
            return AllUsers;
        }
    }
}
