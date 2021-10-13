
namespace PRG282Project
{
    partial class frmDatabase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.lblStudNumber = new System.Windows.Forms.Label();
            this.lblStudNames = new System.Windows.Forms.Label();
            this.lblStudImage = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            this.txtStudNumber = new System.Windows.Forms.TextBox();
            this.txtStudNames = new System.Windows.Forms.TextBox();
            this.gbStudFields = new System.Windows.Forms.GroupBox();
            this.lbCodes = new System.Windows.Forms.ListBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbbGender = new System.Windows.Forms.ComboBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.btnStudImage = new System.Windows.Forms.Button();
            this.openImage = new System.Windows.Forms.OpenFileDialog();
            this.gbStudControls = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.lblStudents = new System.Windows.Forms.Label();
            this.dgvModules = new System.Windows.Forms.DataGridView();
            this.lblMods = new System.Windows.Forms.Label();
            this.gbModControls = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.gbModFields = new System.Windows.Forms.GroupBox();
            this.lbResources = new System.Windows.Forms.ListBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtModCode = new System.Windows.Forms.TextBox();
            this.lblModDesc = new System.Windows.Forms.Label();
            this.lblModName = new System.Windows.Forms.Label();
            this.lblModCode = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.gbStudFields.SuspendLayout();
            this.gbStudControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).BeginInit();
            this.gbModControls.SuspendLayout();
            this.gbModFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvStudents
            // 
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(16, 53);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(511, 237);
            this.dgvStudents.TabIndex = 0;
            // 
            // lblStudNumber
            // 
            this.lblStudNumber.AutoSize = true;
            this.lblStudNumber.Location = new System.Drawing.Point(16, 34);
            this.lblStudNumber.Name = "lblStudNumber";
            this.lblStudNumber.Size = new System.Drawing.Size(107, 16);
            this.lblStudNumber.TabIndex = 0;
            this.lblStudNumber.Text = "Student Number:";
            // 
            // lblStudNames
            // 
            this.lblStudNames.AutoSize = true;
            this.lblStudNames.Location = new System.Drawing.Point(16, 67);
            this.lblStudNames.Name = "lblStudNames";
            this.lblStudNames.Size = new System.Drawing.Size(115, 16);
            this.lblStudNames.TabIndex = 1;
            this.lblStudNames.Text = "Name + Surname:";
            // 
            // lblStudImage
            // 
            this.lblStudImage.AutoSize = true;
            this.lblStudImage.Location = new System.Drawing.Point(16, 102);
            this.lblStudImage.Name = "lblStudImage";
            this.lblStudImage.Size = new System.Drawing.Size(97, 16);
            this.lblStudImage.TabIndex = 2;
            this.lblStudImage.Text = "Student Image:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(73, 138);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(40, 16);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(57, 174);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(289, 34);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(289, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Location = new System.Drawing.Point(252, 102);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(99, 16);
            this.lblModules.TabIndex = 7;
            this.lblModules.Text = "Module Codes:";
            // 
            // txtStudNumber
            // 
            this.txtStudNumber.Location = new System.Drawing.Point(138, 31);
            this.txtStudNumber.Name = "txtStudNumber";
            this.txtStudNumber.Size = new System.Drawing.Size(129, 22);
            this.txtStudNumber.TabIndex = 8;
            // 
            // txtStudNames
            // 
            this.txtStudNames.Location = new System.Drawing.Point(138, 64);
            this.txtStudNames.Name = "txtStudNames";
            this.txtStudNames.Size = new System.Drawing.Size(129, 22);
            this.txtStudNames.TabIndex = 9;
            // 
            // gbStudFields
            // 
            this.gbStudFields.Controls.Add(this.lbCodes);
            this.gbStudFields.Controls.Add(this.txtAddress);
            this.gbStudFields.Controls.Add(this.txtPhone);
            this.gbStudFields.Controls.Add(this.cbbGender);
            this.gbStudFields.Controls.Add(this.dtpDOB);
            this.gbStudFields.Controls.Add(this.btnStudImage);
            this.gbStudFields.Controls.Add(this.txtStudNames);
            this.gbStudFields.Controls.Add(this.txtStudNumber);
            this.gbStudFields.Controls.Add(this.lblModules);
            this.gbStudFields.Controls.Add(this.lblAddress);
            this.gbStudFields.Controls.Add(this.lblPhone);
            this.gbStudFields.Controls.Add(this.lblGender);
            this.gbStudFields.Controls.Add(this.lblDOB);
            this.gbStudFields.Controls.Add(this.lblStudImage);
            this.gbStudFields.Controls.Add(this.lblStudNames);
            this.gbStudFields.Controls.Add(this.lblStudNumber);
            this.gbStudFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudFields.Location = new System.Drawing.Point(16, 306);
            this.gbStudFields.Name = "gbStudFields";
            this.gbStudFields.Size = new System.Drawing.Size(511, 218);
            this.gbStudFields.TabIndex = 1;
            this.gbStudFields.TabStop = false;
            this.gbStudFields.Text = "Student Information";
            // 
            // lbCodes
            // 
            this.lbCodes.FormattingEnabled = true;
            this.lbCodes.ItemHeight = 16;
            this.lbCodes.Location = new System.Drawing.Point(362, 111);
            this.lbCodes.Name = "lbCodes";
            this.lbCodes.Size = new System.Drawing.Size(129, 84);
            this.lbCodes.TabIndex = 15;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(362, 67);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 22);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(362, 31);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(129, 22);
            this.txtPhone.TabIndex = 13;
            // 
            // cbbGender
            // 
            this.cbbGender.AllowDrop = true;
            this.cbbGender.FormattingEnabled = true;
            this.cbbGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.cbbGender.Location = new System.Drawing.Point(138, 171);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(129, 24);
            this.cbbGender.TabIndex = 12;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(138, 133);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(129, 22);
            this.dtpDOB.TabIndex = 11;
            // 
            // btnStudImage
            // 
            this.btnStudImage.BackColor = System.Drawing.Color.Black;
            this.btnStudImage.FlatAppearance.BorderSize = 0;
            this.btnStudImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudImage.ForeColor = System.Drawing.Color.White;
            this.btnStudImage.Location = new System.Drawing.Point(138, 95);
            this.btnStudImage.Name = "btnStudImage";
            this.btnStudImage.Size = new System.Drawing.Size(96, 28);
            this.btnStudImage.TabIndex = 10;
            this.btnStudImage.Text = "Add";
            this.btnStudImage.UseVisualStyleBackColor = false;
            this.btnStudImage.Click += new System.EventHandler(this.btnStudImage_Click);
            // 
            // openImage
            // 
            this.openImage.FileName = "openFileDialog1";
            // 
            // gbStudControls
            // 
            this.gbStudControls.Controls.Add(this.btnSearch);
            this.gbStudControls.Controls.Add(this.txtSearch);
            this.gbStudControls.Controls.Add(this.lblSearch);
            this.gbStudControls.Controls.Add(this.btnDelete);
            this.gbStudControls.Controls.Add(this.btnUpdate);
            this.gbStudControls.Controls.Add(this.btnRead);
            this.gbStudControls.Controls.Add(this.btnCreate);
            this.gbStudControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudControls.Location = new System.Drawing.Point(16, 530);
            this.gbStudControls.Name = "gbStudControls";
            this.gbStudControls.Size = new System.Drawing.Size(511, 118);
            this.gbStudControls.TabIndex = 2;
            this.gbStudControls.TabStop = false;
            this.gbStudControls.Text = "Student Operations:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Black;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(292, 74);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(155, 28);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(364, 35);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(127, 22);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(238, 38);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(120, 16);
            this.lblSearch.TabIndex = 4;
            this.lblSearch.Text = "Search (Student #):";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(124, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 28);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(19, 74);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.btnRead.FlatAppearance.BorderSize = 0;
            this.btnRead.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.ForeColor = System.Drawing.Color.White;
            this.btnRead.Location = new System.Drawing.Point(124, 31);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(94, 28);
            this.btnRead.TabIndex = 1;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(19, 31);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(94, 28);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lblStudents
            // 
            this.lblStudents.AutoSize = true;
            this.lblStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudents.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblStudents.Location = new System.Drawing.Point(226, 21);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(83, 24);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Students";
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(537, 53);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.Size = new System.Drawing.Size(387, 237);
            this.dgvModules.TabIndex = 4;
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMods.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMods.Location = new System.Drawing.Point(685, 21);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(83, 24);
            this.lblMods.TabIndex = 5;
            this.lblMods.Text = "Modules";
            // 
            // gbModControls
            // 
            this.gbModControls.Controls.Add(this.button1);
            this.gbModControls.Controls.Add(this.textBox1);
            this.gbModControls.Controls.Add(this.label1);
            this.gbModControls.Controls.Add(this.button2);
            this.gbModControls.Controls.Add(this.button3);
            this.gbModControls.Controls.Add(this.button4);
            this.gbModControls.Controls.Add(this.button5);
            this.gbModControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModControls.Location = new System.Drawing.Point(537, 530);
            this.gbModControls.Name = "gbModControls";
            this.gbModControls.Size = new System.Drawing.Size(387, 118);
            this.gbModControls.TabIndex = 6;
            this.gbModControls.TabStop = false;
            this.gbModControls.Text = "Module Operations:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(224, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(243, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 22);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(240, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search (Mod Code):";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(124, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 28);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(19, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 28);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(124, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 28);
            this.button4.TabIndex = 1;
            this.button4.Text = "Read";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(19, 31);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(94, 28);
            this.button5.TabIndex = 0;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // gbModFields
            // 
            this.gbModFields.Controls.Add(this.lbResources);
            this.gbModFields.Controls.Add(this.lblResources);
            this.gbModFields.Controls.Add(this.textBox2);
            this.gbModFields.Controls.Add(this.textBox4);
            this.gbModFields.Controls.Add(this.txtModCode);
            this.gbModFields.Controls.Add(this.lblModDesc);
            this.gbModFields.Controls.Add(this.lblModName);
            this.gbModFields.Controls.Add(this.lblModCode);
            this.gbModFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModFields.Location = new System.Drawing.Point(537, 306);
            this.gbModFields.Name = "gbModFields";
            this.gbModFields.Size = new System.Drawing.Size(387, 218);
            this.gbModFields.TabIndex = 7;
            this.gbModFields.TabStop = false;
            this.gbModFields.Text = "Module Information";
            // 
            // lbResources
            // 
            this.lbResources.FormattingEnabled = true;
            this.lbResources.ItemHeight = 16;
            this.lbResources.Location = new System.Drawing.Point(161, 133);
            this.lbResources.Name = "lbResources";
            this.lbResources.Size = new System.Drawing.Size(207, 68);
            this.lbResources.TabIndex = 16;
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(16, 139);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(125, 16);
            this.lblResources.TabIndex = 14;
            this.lblResources.Text = "Module Resources:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(161, 101);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(207, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(161, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(164, 22);
            this.textBox4.TabIndex = 9;
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(161, 31);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(129, 22);
            this.txtModCode.TabIndex = 8;
            // 
            // lblModDesc
            // 
            this.lblModDesc.AutoSize = true;
            this.lblModDesc.Location = new System.Drawing.Point(16, 102);
            this.lblModDesc.Name = "lblModDesc";
            this.lblModDesc.Size = new System.Drawing.Size(127, 16);
            this.lblModDesc.TabIndex = 3;
            this.lblModDesc.Text = "Module Description:";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(16, 67);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(96, 16);
            this.lblModName.TabIndex = 1;
            this.lblModName.Text = "Module Name:";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(16, 34);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(92, 16);
            this.lblModCode.TabIndex = 0;
            this.lblModCode.Text = "Module Code:";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(906, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 28);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 672);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.gbModFields);
            this.Controls.Add(this.gbModControls);
            this.Controls.Add(this.lblMods);
            this.Controls.Add(this.dgvModules);
            this.Controls.Add(this.lblStudents);
            this.Controls.Add(this.gbStudControls);
            this.Controls.Add(this.gbStudFields);
            this.Controls.Add(this.dgvStudents);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatabase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatabase_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.gbStudFields.ResumeLayout(false);
            this.gbStudFields.PerformLayout();
            this.gbStudControls.ResumeLayout(false);
            this.gbStudControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModules)).EndInit();
            this.gbModControls.ResumeLayout(false);
            this.gbModControls.PerformLayout();
            this.gbModFields.ResumeLayout(false);
            this.gbModFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.Label lblStudNumber;
        private System.Windows.Forms.Label lblStudNames;
        private System.Windows.Forms.Label lblStudImage;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.TextBox txtStudNumber;
        private System.Windows.Forms.TextBox txtStudNames;
        private System.Windows.Forms.GroupBox gbStudFields;
        private System.Windows.Forms.ListBox lbCodes;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnStudImage;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.GroupBox gbStudControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lblStudents;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvModules;
        private System.Windows.Forms.Label lblMods;
        private System.Windows.Forms.GroupBox gbModControls;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gbModFields;
        private System.Windows.Forms.ListBox lbResources;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Label lblModDesc;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Button btnExit;
    }
}