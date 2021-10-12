using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PRG282Project.DataLayer;

namespace PRG282Project.DataAccessLayer
{
    class DataHandler
    {
        public static DataHandler current;

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
