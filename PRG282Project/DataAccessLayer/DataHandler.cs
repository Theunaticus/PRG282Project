using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataAccessLayer
{
    class DataHandler
    {
        public static DataHandler current;

        public  DataHandler ()
        {
            current = this;
        }
    }
}
