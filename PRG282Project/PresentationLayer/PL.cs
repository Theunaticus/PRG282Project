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

        public  void    DisplayError    (string Message)
        {
            if (frmLogin.current.Showing)
            {
                frmLogin.current.DisplayError(Message);
                return;
            }
            if (frmDatabase.current.Showing)
            {
                frmDatabase.current.DisplayError(Message);
            }
        }

        public  void DisplayDatabase    ()
        {
            frmDatabase.current.DisplayStudents();
        }
    }
}
