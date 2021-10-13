using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataAccessLayer;
using PRG282Project.DataLayer;
using PRG282Project.PresentationLayer;
using System.Windows.Forms;

namespace PRG282Project.ApplicationLayer
{
    class AL
    {
        public static AL current;
        public string LastImageFile;

        public AL()
        {
            current = this;
        }

        public bool ValidateComponent(TextBox Txt)
        {
            if (!(Txt.Text.Length > 0))
            {
                Txt.Focus();
            }
            return (Txt.Text.Length > 0);
        }

        public bool ValidateComponent(DateTimePicker DPT)
        {
            if (!(DPT.Value==null))
            {
                DPT.Focus();
            }
            return DPT.Value != null;
        }

        public bool ValidateComponent(ComboBox CBB)
        {
            if (!(CBB.SelectedIndex == -1))
            {
                CBB.Focus();
            }
            return CBB.SelectedIndex != -1;
        }

        public bool ValidateComponent(ListBox LB)
        {
            if (!(LB.SelectedIndex == -1))
            {
                LB.Focus();
            }
            return LB.SelectedIndex != -1;
        }

        public LoginAttempt TryLogin(string Username, string Password)
        {
            List<User> AllUsers = DataHandler.current.GetAllUsers();
            if (AllUsers != null)
            {
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    if (AllUsers[i].Match(Username))
                    {
                        if (AllUsers[i].Validate(Password))
                        {
                            return new LoginAttempt(LoginType.Success);
                        }
                        else
                        {
                            return new LoginAttempt(LoginType.Invalid);
                        }
                    }
                }
            }
            return new LoginAttempt(LoginType.NoMatch);
        }

        public bool TryCreateUser(string Username, string Password)
        {
            List<User> AllUsers = DataHandler.current.GetAllUsers();
            if (AllUsers != null)
            {
                for (int i = 0; i < AllUsers.Count; i++)
                {
                    if (AllUsers[i].Match(Username))
                    {
                        return false;
                    }
                }
            }
            Userbase.current.AddUser(new User(Username, Password));
            return true;
        }

        public  void    ImportPicture   (DialogResult Result, OpenFileDialog Dialog)
        {
            if (Result == DialogResult.OK)
            {
                LastImageFile = Dialog.FileName;
            }
        }
        
        public  void    UpdateRecord    (RecordData Data)
        {
            DataHandler.current.UpdateRecord(Data);
        }
        
        public  void    CreateRecord    (RecordData Data)
        {
            DataHandler.current.InsertRecord(Data);
        }

        public  bool ValidImage ()
        {
            return LastImageFile != null;
        }

        public  bool ValidNames (string Names)
        {
            int pos = Pos(" ",Names);
            if (pos>-1)
            {
                if (pos>0)
                {
                    if (pos<Names.Length-1)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public  string  GetName (string Names)
        {
            int pos = Pos(" ",Names);
            return Names.Substring(0, pos);
        }

        public  string  GetSurname  (string Names)
        {
            int pos = Pos(" ", Names);
            return Names.Substring(pos + 1, Names.Length - pos-1);
        }

        public  int Pos(string Substring, string String)
        {
            for (int i = 0; i < String.Length - Substring.Length + 1; i++)
            {
                if (String[i] == Substring[0])
                {
                    bool Valid = true;
                    for (int I = 0; I < Substring.Length; I++)
                    {
                        if (String[i + I] != Substring[I])
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
    }
}
