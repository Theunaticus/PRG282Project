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
using PRG282Project.ApplicationLayer;
using PRG282Project.DataAccessLayer;
using PRG282Project.DataLayer;

namespace PRG282Project
{
    public partial class frmLogin : Form
    {
        public static frmLogin current;
        public bool Showing;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            current = this;
            new PL();
            new AL();
            new DL();
            new DataHandler();
            new FileHandler();
            new Userbase();
        }

        public void DisplayError(string Message)
        {
            MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void DisplayMessage(string Message)
        {
            MessageBox.Show(Message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmLogin_Shown(object sender, EventArgs e)
        {
            Showing = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAttempt Attempt = AL.current.TryLogin(txtUsername.Text, txtPassword.Text);
            switch (Attempt.Type)//Maybe move this to PL?
            {
                case LoginType.Success:
                    DisplayMessage("Successful Login");
                    HideMe();
                    frmDatabase DatabaseForm = new frmDatabase();
                    DatabaseForm.Show();
                    break;
                case LoginType.NoMatch:
                    DisplayError("Username was not found");
                    ClearBoxes();
                    txtUsername.Focus();
                    break;
                case LoginType.Invalid:
                    DisplayError("Invalid Password");
                    txtPassword.Clear();
                    txtPassword.Focus();
                    break;
                default:
                    break;
            }
        }

        void    ClearBoxes  ()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        void    HideMe  ()
        {
            Showing = false;
            current.Hide();
        }
    }
}
