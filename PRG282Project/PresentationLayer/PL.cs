using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG282Project.PresentationLayer
{
    class PL
    {
        public static PL current;

        public  PL  ()
        {
            current = this;
        }
    }
}
