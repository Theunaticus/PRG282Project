using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.DataLayer
{
    class DL
    {
        public static DL current;

        public DL()
        {
            current = this;
        }
    }
}
