
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbFields = new System.Windows.Forms.GroupBox();
            this.lblStudNumber = new System.Windows.Forms.Label();
            this.lblStudNames = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblModules = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(730, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // gbFields
            // 
            this.gbFields.Controls.Add(this.lblModules);
            this.gbFields.Controls.Add(this.lblAddress);
            this.gbFields.Controls.Add(this.lblPhone);
            this.gbFields.Controls.Add(this.lblGender);
            this.gbFields.Controls.Add(this.lblDOB);
            this.gbFields.Controls.Add(this.lbl);
            this.gbFields.Controls.Add(this.lblStudNames);
            this.gbFields.Controls.Add(this.lblStudNumber);
            this.gbFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFields.Location = new System.Drawing.Point(33, 289);
            this.gbFields.Name = "gbFields";
            this.gbFields.Size = new System.Drawing.Size(445, 232);
            this.gbFields.TabIndex = 1;
            this.gbFields.TabStop = false;
            this.gbFields.Text = "Student Information";
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
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(16, 102);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(45, 16);
            this.lbl.TabIndex = 2;
            this.lbl.Text = "label3";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(16, 138);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(40, 16);
            this.lblDOB.TabIndex = 3;
            this.lblDOB.Text = "DOB:";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(16, 179);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 16);
            this.lblGender.TabIndex = 4;
            this.lblGender.Text = "Gender:";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(308, 34);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(50, 16);
            this.lblPhone.TabIndex = 5;
            this.lblPhone.Text = "Phone:";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(308, 67);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(62, 16);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address:";
            // 
            // lblModules
            // 
            this.lblModules.AutoSize = true;
            this.lblModules.Location = new System.Drawing.Point(308, 102);
            this.lblModules.Name = "lblModules";
            this.lblModules.Size = new System.Drawing.Size(99, 16);
            this.lblModules.TabIndex = 7;
            this.lblModules.Text = "Module Codes:";
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 549);
            this.Controls.Add(this.gbFields);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDatabase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDatabase";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDatabase_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbFields.ResumeLayout(false);
            this.gbFields.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gbFields;
        private System.Windows.Forms.Label lblModules;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblStudNames;
        private System.Windows.Forms.Label lblStudNumber;
    }
}