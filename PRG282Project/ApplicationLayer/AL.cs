using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataAccessLayer;
using PRG282Project.DataLayer;
using PRG282Project.PresentationLayer;

namespace PRG282Project.ApplicationLayer
{
    class AL
    {
        public static AL current;

        public  AL  ()
        {
            current = this;
        }

        public  LoginAttempt TryLogin   (string Username,string Password)
        {
            List<User> AllUsers = DataHandler.current.GetAllUsers();
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
            return new LoginAttempt(LoginType.NoMatch);
        }
    }
}
