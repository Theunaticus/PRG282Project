using PRG282Project.ApplicationLayer;
using PRG282Project.DataAccessLayer;
using PRG282Project.DataLayer;
using PRG282Project.PresentationLayer;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

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

        public void DisplayStudents()
        {
            dgvStudents.DataSource = DataHandler.current.GetStudents();
        }

        public void DisplayModules()
        {
            dgvModules.DataSource = DataHandler.current.GetModules();
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
            if (ValidateStudent() == -1)
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
                        string Codes = textBox2.Text;
                        string Path = AL.current.LastImageFile;
                        StudentData Data = new StudentData(Number, Name, Surname, DOB, Gender, Phone, Address, Codes, Path);
                        AL.current.CreateRecord(Data);
                        ClearStudents();
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

        void ClearStudents()
        {
            txtStudNumber.Clear();
            txtStudNames.Clear();
            AL.current.LastImageFile = null;
            cbbGender.SelectedIndex = -1;
            txtPhone.Clear();
            txtAddress.Clear();
            textBox2.Clear();
        }
        int ValidateStudent()
        {
            List<bool> Flags = new List<bool>();
            Flags.Add(AL.current.ValidateComponent(txtStudNumber));
            Flags.Add(AL.current.ValidateComponent(txtStudNames));
            //Flags.Add(AL.current.ValidateComponent(dtpDOB));
            Flags.Add(AL.current.ValidateComponent(cbbGender));
            Flags.Add(AL.current.ValidateComponent(txtPhone));
            Flags.Add(AL.current.ValidateComponent(textBox2));

            for (int i = 0; i < Flags.Count; i++)
            {
                if (Flags[i] == false)
                {
                    return i;
                }
            }

            return -1;
        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayRow(e.RowIndex);
        }

        void DisplayRow(int Index)
        {
            if (Index >= 0)
            {
                DataGridViewRow Row = dgvStudents.Rows[Index];

                txtStudNumber.Text = Row.Cells["StudentID"].Value.ToString();
                txtStudNames.Text = Row.Cells["Name"].Value.ToString();
                txtStudNames.Text += " "+Row.Cells["Surname"].Value.ToString();
                cbbGender.Text = Row.Cells["Gender"].Value.ToString();
                txtPhone.Text = Row.Cells["Phone"].Value.ToString();
                txtAddress.Text = Row.Cells["Address"].Value.ToString();
                AL.current.LastImageFile = Row.Cells["Student Picture"].Value.ToString();
                textBox2.Text   = Row.Cells["Module Codes"].Value.ToString();
            }
        }

        int ValidateModule()
        {
            List<bool> Flags = new List<bool>();
            Flags.Add(AL.current.ValidateComponent(txtModCode));
            Flags.Add(AL.current.ValidateComponent(txtModName));
            Flags.Add(AL.current.ValidateComponent(txtModDesc));
            Flags.Add(AL.current.ValidateComponent(txtModResources));

            for (int i = 0; i < Flags.Count; i++)
            {
                if (Flags[i] == false)
                {
                    return i;
                }
            }

            return -1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (ValidateModule() == -1)
            {
                string Code = txtModCode.Text;
                string Name = txtModName.Text;
                string Desc = txtModDesc.Text;
                string Resc = txtModResources.Text;

                ModuleData Data = new ModuleData(Code, Name, Desc, Resc);
                AL.current.CreateRecord(Data);
                ClearModule();
            }
            else
            {
                PL.current.DisplayError("This input does not contain a valid value");
            }
        }

        void ClearModule()
        {
            txtModCode.Clear();
            txtModName.Clear();
            txtModDesc.Clear();
            txtModResources.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ValidateModule() == -1)
            {
                string Code = txtModCode.Text;
                string Name = txtModName.Text;
                string Desc = txtModDesc.Text;
                string Resc = txtModResources.Text;

                ModuleData Data = new ModuleData(Code, Name, Desc, Resc);
                AL.current.UpdateRecord(Data);
                ClearModule();
            }
            else
            {
                PL.current.DisplayError("This input does not contain a valid value");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateStudent() == -1)
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
                        string Codes =  textBox2.Text;
                        string Path = AL.current.LastImageFile;
                        StudentData Data = new StudentData(Number, Name, Surname, DOB, Gender, Phone, Address, Codes, Path);
                        AL.current.UpdateRecord(Data);
                        ClearStudents();
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

        private void dgvModules_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DisplayModule(e.RowIndex);
        }

        void    DisplayModule   (int    Index)
        {
            if (Index >= 0)
            {
                DataGridViewRow Row = dgvModules.Rows[Index];

                txtModCode.Text = Row.Cells["Code"].Value.ToString();
                txtModName.Text = Row.Cells["Name"].Value.ToString();
                txtModDesc.Text = " " + Row.Cells["Description"].Value.ToString();
                txtModResources.Text = Row.Cells["Resources"].Value.ToString();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var data = new DataHandler();
            data.deleteRecord(txtStudNumber.Text, "tblStudents", "studentID");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var data = new DataHandler();
            data.deleteRecord(txtModCode.Text, "Modules", "Code");
        }
    }
}
