using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.ApplicationLayer
{
    class AL
    {
        public static AL current;

        public  AL  ()
        {
            current = this;
        }
    }
}
