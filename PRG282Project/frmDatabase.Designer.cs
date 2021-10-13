
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
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.button5 = new System.Windows.Forms.Button();
            this.gbModFields = new System.Windows.Forms.GroupBox();
            this.txtModResources = new System.Windows.Forms.TextBox();
            this.lblResources = new System.Windows.Forms.Label();
            this.txtModDesc = new System.Windows.Forms.TextBox();
            this.txtModName = new System.Windows.Forms.TextBox();
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
            this.dgvStudents.Location = new System.Drawing.Point(21, 65);
            this.dgvStudents.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.RowHeadersVisible = false;
            this.dgvStudents.RowHeadersWidth = 51;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(681, 292);
            this.dgvStudents.TabIndex = 0;
            this.dgvStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudents_CellContentClick);
            // 
            // lblStudNumber
            // 
            this.lblStudNumber.AutoSize = true;
            this.lblStudNumber.Location = new System.Drawing.Point(21, 42);
            this.lblStudNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudNumber.Name = "lblStudNumber";
            this.lblStudNumber.Size = new System.Drawing.Size(135, 20);
            this.lblStudNumber.TabIndex = 0;
            this.lblStudNumber.Text = "Student Number:";
            // 
            // lblStudNames
            // 
            this.lblStudNames.AutoSize = true;
            this.lblStudNames.Location = new System.Drawing.Point(21, 82);
            this.lblStudNames.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudNames.Name = "lblStudNames";
            this.lblStudNames.Size = new System.Drawing.Size(145, 20);
            this.lblStudNames.TabIndex = 1;
            this.lblStudNames.Text = "Name + Surname:";
            // 
            // lblStudImage
            // 
            this.lblStudImage.AutoSize = true;
            this.lblStudImage.Location = new System.Drawing.Point(21, 126);
            this.lblStudImage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudImage.Name = "lblStudImage";
            this.lblStudImage.Size = new System.Drawing.Size(121, 20);
            this.lblStudImage.TabIndex = 2;
            this.lblStudImage.Text = "Student Image:";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(97, 170);
            this.lblDOB.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(52, 20);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(76, 214);
            this.lblGender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(69, 20);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(385, 42);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(61, 20);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(385, 82);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(76, 20);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Location = new System.Drawing.Point(336, 126);
            this.lblModules.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(121, 20);
            this.lblModules.TabIndex = 7;
            this.lblModules.Text = "Module Codes:";
            // 
            // txtStudNumber
            // 
            this.txtStudNumber.Location = new System.Drawing.Point(184, 38);
            this.txtStudNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudNumber.Name = "txtStudNumber";
            this.txtStudNumber.Size = new System.Drawing.Size(171, 26);
            this.txtStudNumber.TabIndex = 8;
            // 
            // txtStudNames
            // 
            this.txtStudNames.Location = new System.Drawing.Point(184, 79);
            this.txtStudNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStudNames.Name = "txtStudNames";
            this.txtStudNames.Size = new System.Drawing.Size(171, 26);
            this.txtStudNames.TabIndex = 9;
            // 
            // gbStudFields
            // 
            this.gbStudFields.Controls.Add(this.textBox2);
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
            this.gbStudFields.Location = new System.Drawing.Point(21, 377);
            this.gbStudFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudFields.Name = "gbStudFields";
            this.gbStudFields.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudFields.Size = new System.Drawing.Size(681, 268);
            this.gbStudFields.TabIndex = 1;
            this.gbStudFields.TabStop = false;
            this.gbStudFields.Text = "Student Information";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(377, 164);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(276, 26);
            this.textBox2.TabIndex = 15;
            this.textBox2.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(483, 82);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(171, 26);
            this.txtAddress.TabIndex = 14;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(483, 38);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(171, 26);
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
            this.cbbGender.Location = new System.Drawing.Point(184, 210);
            this.cbbGender.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbbGender.Name = "cbbGender";
            this.cbbGender.Size = new System.Drawing.Size(171, 28);
            this.cbbGender.TabIndex = 12;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDOB.Location = new System.Drawing.Point(184, 164);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(171, 26);
            this.dtpDOB.TabIndex = 11;
            // 
            // btnStudImage
            // 
            this.btnStudImage.BackColor = System.Drawing.Color.Black;
            this.btnStudImage.FlatAppearance.BorderSize = 0;
            this.btnStudImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStudImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudImage.ForeColor = System.Drawing.Color.White;
            this.btnStudImage.Location = new System.Drawing.Point(184, 117);
            this.btnStudImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnStudImage.Name = "btnStudImage";
            this.btnStudImage.Size = new System.Drawing.Size(128, 34);
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
            this.gbStudControls.Controls.Add(this.btnCreate);
            this.gbStudControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbStudControls.Location = new System.Drawing.Point(21, 652);
            this.gbStudControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudControls.Name = "gbStudControls";
            this.gbStudControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbStudControls.Size = new System.Drawing.Size(681, 145);
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
            this.btnSearch.Location = new System.Drawing.Point(389, 91);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(207, 34);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(485, 43);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(168, 26);
            this.txtSearch.TabIndex = 5;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(317, 47);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(155, 20);
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
            this.btnDelete.Location = new System.Drawing.Point(165, 91);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 34);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(25, 91);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 34);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(61)))), ((int)(((byte)(58)))));
            this.btnCreate.FlatAppearance.BorderSize = 0;
            this.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.White;
            this.btnCreate.Location = new System.Drawing.Point(25, 38);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(265, 34);
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
            this.lblStudents.Location = new System.Drawing.Point(301, 26);
            this.lblStudents.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStudents.Name = "lblStudents";
            this.lblStudents.Size = new System.Drawing.Size(107, 29);
            this.lblStudents.TabIndex = 3;
            this.lblStudents.Text = "Students";
            // 
            // dgvModules
            // 
            this.dgvModules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModules.Location = new System.Drawing.Point(716, 65);
            this.dgvModules.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvModules.Name = "dgvModules";
            this.dgvModules.RowHeadersWidth = 51;
            this.dgvModules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModules.Size = new System.Drawing.Size(516, 292);
            this.dgvModules.TabIndex = 4;
            this.dgvModules.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModules_CellContentClick);
            // 
            // lblMods
            // 
            this.lblMods.AutoSize = true;
            this.lblMods.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMods.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblMods.Location = new System.Drawing.Point(913, 26);
            this.lblMods.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMods.Name = "lblMods";
            this.lblMods.Size = new System.Drawing.Size(106, 29);
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
            this.gbModControls.Controls.Add(this.button5);
            this.gbModControls.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModControls.Location = new System.Drawing.Point(716, 652);
            this.gbModControls.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModControls.Name = "gbModControls";
            this.gbModControls.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModControls.Size = new System.Drawing.Size(516, 145);
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
            this.button1.Location = new System.Drawing.Point(299, 91);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(324, 39);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
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
            this.button2.Location = new System.Drawing.Point(165, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(25, 91);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(125, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(198)))), ((int)(((byte)(35)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(25, 38);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(265, 34);
            this.button5.TabIndex = 0;
            this.button5.Text = "Create";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // gbModFields
            // 
            this.gbModFields.Controls.Add(this.txtModResources);
            this.gbModFields.Controls.Add(this.lblResources);
            this.gbModFields.Controls.Add(this.txtModDesc);
            this.gbModFields.Controls.Add(this.txtModName);
            this.gbModFields.Controls.Add(this.txtModCode);
            this.gbModFields.Controls.Add(this.lblModDesc);
            this.gbModFields.Controls.Add(this.lblModName);
            this.gbModFields.Controls.Add(this.lblModCode);
            this.gbModFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbModFields.Location = new System.Drawing.Point(716, 377);
            this.gbModFields.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModFields.Name = "gbModFields";
            this.gbModFields.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbModFields.Size = new System.Drawing.Size(516, 268);
            this.gbModFields.TabIndex = 7;
            this.gbModFields.TabStop = false;
            this.gbModFields.Text = "Module Information";
            // 
            // txtModResources
            // 
            this.txtModResources.Location = new System.Drawing.Point(215, 171);
            this.txtModResources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModResources.Name = "txtModResources";
            this.txtModResources.Size = new System.Drawing.Size(275, 26);
            this.txtModResources.TabIndex = 15;
            // 
            // lblResources
            // 
            this.lblResources.AutoSize = true;
            this.lblResources.Location = new System.Drawing.Point(21, 171);
            this.lblResources.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResources.Name = "lblResources";
            this.lblResources.Size = new System.Drawing.Size(154, 20);
            this.lblResources.TabIndex = 14;
            this.lblResources.Text = "Module Resources:";
            // 
            // txtModDesc
            // 
            this.txtModDesc.Location = new System.Drawing.Point(215, 124);
            this.txtModDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModDesc.Name = "txtModDesc";
            this.txtModDesc.Size = new System.Drawing.Size(275, 26);
            this.txtModDesc.TabIndex = 13;
            // 
            // txtModName
            // 
            this.txtModName.Location = new System.Drawing.Point(215, 79);
            this.txtModName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModName.Name = "txtModName";
            this.txtModName.Size = new System.Drawing.Size(217, 26);
            this.txtModName.TabIndex = 9;
            // 
            // txtModCode
            // 
            this.txtModCode.Location = new System.Drawing.Point(215, 38);
            this.txtModCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtModCode.Name = "txtModCode";
            this.txtModCode.Size = new System.Drawing.Size(171, 26);
            this.txtModCode.TabIndex = 8;
            // 
            // lblModDesc
            // 
            this.lblModDesc.AutoSize = true;
            this.lblModDesc.Location = new System.Drawing.Point(21, 126);
            this.lblModDesc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModDesc.Name = "lblModDesc";
            this.lblModDesc.Size = new System.Drawing.Size(159, 20);
            this.lblModDesc.TabIndex = 3;
            this.lblModDesc.Text = "Module Description:";
            // 
            // lblModName
            // 
            this.lblModName.AutoSize = true;
            this.lblModName.Location = new System.Drawing.Point(21, 82);
            this.lblModName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModName.Name = "lblModName";
            this.lblModName.Size = new System.Drawing.Size(117, 20);
            this.lblModName.TabIndex = 1;
            this.lblModName.Text = "Module Name:";
            // 
            // lblModCode
            // 
            this.lblModCode.AutoSize = true;
            this.lblModCode.Location = new System.Drawing.Point(21, 42);
            this.lblModCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblModCode.Name = "lblModCode";
            this.lblModCode.Size = new System.Drawing.Size(112, 20);
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
            this.btnExit.Location = new System.Drawing.Point(1208, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(43, 34);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1255, 827);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbbGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Button btnStudImage;
        private System.Windows.Forms.OpenFileDialog openImage;
        private System.Windows.Forms.GroupBox gbStudControls;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox gbModFields;
        private System.Windows.Forms.Label lblResources;
        private System.Windows.Forms.TextBox txtModDesc;
        private System.Windows.Forms.TextBox txtModName;
        private System.Windows.Forms.TextBox txtModCode;
        private System.Windows.Forms.Label lblModDesc;
        private System.Windows.Forms.Label lblModName;
        private System.Windows.Forms.Label lblModCode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtModResources;
        private System.Windows.Forms.TextBox textBox2;
    }
}