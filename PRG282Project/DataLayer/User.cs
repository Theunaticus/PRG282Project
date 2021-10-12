using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class User
    {
        string Username;
        string Password;

        public  User    (string _Username,string    _Password)
        {
            Username = _Username;
            Password = _Password;
        }

        public  bool    Validate    (string _Password)
        {
            return Password == _Password;
        }

        public  bool    Match   (string _Username)
        {
            return _Username == Username;
        }

        public  string  ToLine  ()
        {
            return "Username:" + Username + "|Password:" + Password;
        }
    }
}
