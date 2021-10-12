using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class LoginAttempt
    {
        public LoginType Type;
        public  LoginAttempt    (LoginType _Type)
        {
            Type = _Type;
        }
    }

    public enum LoginType
    {
        Success,
        NoMatch,
        Invalid,
    }
}
