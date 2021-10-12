using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataAccessLayer
{
    class FileHandler
    {
        public static FileHandler current;

        public  FileHandler ()
        {
            current = this;
        }
    }
}
