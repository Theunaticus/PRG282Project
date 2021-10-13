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
using PRG282Project.ApplicationLayer;
using PRG282Project.DataLayer;

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
            Showing = true;
        }

        private void frmDatabase_FormClosed(object sender, FormClosedEventArgs e)
        {
            Showing = false;
            frmLogin.current.Close();
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

        private void btnStudImage_Click(object sender, EventArgs e)
        {
            PL.current.ShowExplorer();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (ValidateStudent()==-1)
            {
                if (AL.current.ValidImage())
                {
                    if (AL.current.ValidNames(txtStudNames.Text))
                    {
                        string Number = txtStudNumber.Text;
                        string Name = AL.current.GetName(txtStudNames.Text);
                        string Surname = AL.current.GetSurname(txtStudNames.Text);
                        string DOB = dtpDOB.Value.ToString();
                        string Gender = cbbGender.SelectedItem.ToString();
                        string Phone = txtPhone.Text;
                        string Address = txtAddress.Text;
                        string Codes = lbCodes.Text;
                        string Path = AL.current.LastImageFile;
                        StudentData Data = new StudentData(Number,Name,Surname,DOB,Gender,Phone,Address,Codes,Path);
                        AL.current.CreateRecord(Data);
                    }
                    else
                    {
                        PL.current.DisplayError("Please enter a valid name and surname");
                    }
                }
                else
                {
                    PL.current.DisplayError("Please choose a valid student picture");
                }
            }
            else
            {
                PL.current.DisplayError("This input does not contain a valid value");
            }
        }

        int ValidateStudent()
        {
            List<bool> Flags = new List<bool>();
            Flags.Add(AL.current.ValidateComponent(txtStudNumber));
            Flags.Add(AL.current.ValidateComponent(txtStudNames));
            //Flags.Add(AL.current.ValidateComponent(dtpDOB));
            Flags.Add(AL.current.ValidateComponent(cbbGender));
            Flags.Add(AL.current.ValidateComponent(txtPhone));
            Flags.Add(AL.current.ValidateComponent(lbCodes));

            for (int i = 0; i < Flags.Count; i++)
            {
                if (Flags[i]==false)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
