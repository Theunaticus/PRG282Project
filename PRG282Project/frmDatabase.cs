using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PRG282Project.PresentationLayer;
using PRG282Project.DataAccessLayer;

namespace PRG282Project
{
    public partial class frmDatabase : Form
    {
        public static frmDatabase current;
        public bool Showing;
        public frmDatabase()
        {
            InitializeComponent();
            current = this;
        }

        private void frmDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmLogin.current.Close();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            current = this;
        }

        private void frmDatabase_Shown(object sender, EventArgs e)
        {
            Showing = true;
        }

        public void DisplayError(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayMessage(string Message)
        {
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        public  void DisplayStudents    ()
        {
            dgvStudents.DataSource = DataHandler.current.GetStudents();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
