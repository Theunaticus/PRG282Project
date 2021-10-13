using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.ApplicationLayer;

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
            frmDatabase.current.DisplayModules();
        }

        public  void DisplaySuccess(string Message)
        {
            if (frmLogin.current.Showing)
            {
                frmLogin.current.DisplayMessage(Message);
                return;
            }
            if (frmDatabase.current.Showing)
            {
                frmDatabase.current.DisplayMessage(Message);
                return;
            }
            MessageBox.Show(Message);
        }

        public  void    ShowExplorer    ()
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            AL.current.ImportPicture(fdlg.ShowDialog(),fdlg);
        }
    }
}
