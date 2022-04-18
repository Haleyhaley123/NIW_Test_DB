namespace TestBD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.ShowStudent = new System.Windows.Forms.TabPage();
            this.dtgStudent = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnShowStudent = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtStudentId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.btnScoreForm = new System.Windows.Forms.Button();
            this.btnSubjectForm = new System.Windows.Forms.Button();
            this.tabStudent.SuspendLayout();
            this.ShowStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.ShowStudent);
            this.tabStudent.Controls.Add(this.tabPage2);
            this.tabStudent.Location = new System.Drawing.Point(10, 10);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(881, 455);
            this.tabStudent.TabIndex = 0;
            // 
            // ShowStudent
            // 
            this.ShowStudent.BackColor = System.Drawing.Color.PeachPuff;
            this.ShowStudent.Controls.Add(this.panel9);
            this.ShowStudent.Controls.Add(this.dtgStudent);
            this.ShowStudent.Controls.Add(this.panel1);
            this.ShowStudent.Location = new System.Drawing.Point(4, 24);
            this.ShowStudent.Name = "ShowStudent";
            this.ShowStudent.Padding = new System.Windows.Forms.Padding(3);
            this.ShowStudent.Size = new System.Drawing.Size(873, 427);
            this.ShowStudent.TabIndex = 0;
            this.ShowStudent.Text = "Show Student";
            this.ShowStudent.Click += new System.EventHandler(this.ShowStudent_Click);
            // 
            // dtgStudent
            // 
            this.dtgStudent.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.StudentID,
            this.FullName,
            this.Address,
            this.NumberPhone,
            this.Email,
            this.Edit,
            this.Delete});
            this.dtgStudent.Location = new System.Drawing.Point(9, 87);
            this.dtgStudent.Name = "dtgStudent";
            this.dtgStudent.RowTemplate.Height = 25;
            this.dtgStudent.Size = new System.Drawing.Size(845, 344);
            this.dtgStudent.TabIndex = 1;
            // 
            // STT
            // 
            this.STT.HeaderText = "No.";
            this.STT.Name = "STT";
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Student ID";
            this.StudentID.Name = "StudentID";
            // 
            // FullName
            // 
            this.FullName.HeaderText = "FullName";
            this.FullName.Name = "FullName";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // NumberPhone
            // 
            this.NumberPhone.HeaderText = "NumberPhone";
            this.NumberPhone.Name = "NumberPhone";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // Edit
            // 
            this.Edit.HeaderText = "";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "";
            this.Delete.Name = "Delete";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnShowStudent);
            this.panel1.Location = new System.Drawing.Point(3, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 42);
            this.panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(200, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnShowStudent
            // 
            this.btnShowStudent.Location = new System.Drawing.Point(6, 12);
            this.btnShowStudent.Name = "btnShowStudent";
            this.btnShowStudent.Size = new System.Drawing.Size(75, 23);
            this.btnShowStudent.TabIndex = 0;
            this.btnShowStudent.Text = "Show";
            this.btnShowStudent.UseVisualStyleBackColor = true;
            this.btnShowStudent.Click += new System.EventHandler(this.btnShowStudent_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.MistyRose;
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(873, 427);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add, Edit, Delete";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(52, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(436, 331);
            this.panel2.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnDelete);
            this.panel7.Controls.Add(this.btnEx);
            this.panel7.Controls.Add(this.btnEdit);
            this.panel7.Controls.Add(this.btnAdd);
            this.panel7.Location = new System.Drawing.Point(32, 273);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 42);
            this.panel7.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(208, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(303, 12);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(75, 23);
            this.btnEx.TabIndex = 2;
            this.btnEx.Text = "Exit";
            this.btnEx.UseVisualStyleBackColor = true;
            this.btnEx.Click += new System.EventHandler(this.btnEx_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(108, 12);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(6, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtEmail);
            this.panel6.Controls.Add(this.label4);
            this.panel6.Location = new System.Drawing.Point(25, 214);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(388, 44);
            this.panel6.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 8);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(283, 22);
            this.txtEmail.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtNumberPhone);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Location = new System.Drawing.Point(25, 164);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(388, 44);
            this.panel5.TabIndex = 2;
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Location = new System.Drawing.Point(98, 8);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(283, 22);
            this.txtNumberPhone.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "PhoneNumber:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtAddress);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Location = new System.Drawing.Point(25, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(388, 44);
            this.panel4.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(98, 8);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(283, 22);
            this.txtAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Address:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtFullName);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(388, 44);
            this.panel3.TabIndex = 0;
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(98, 8);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(283, 22);
            this.txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FullName:";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtStudentId);
            this.panel8.Controls.Add(this.label5);
            this.panel8.Location = new System.Drawing.Point(25, 14);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(388, 44);
            this.panel8.TabIndex = 2;
            // 
            // txtStudentId
            // 
            this.txtStudentId.Location = new System.Drawing.Point(98, 8);
            this.txtStudentId.Name = "txtStudentId";
            this.txtStudentId.Size = new System.Drawing.Size(283, 22);
            this.txtStudentId.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "StudentId:";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnScoreForm);
            this.panel9.Controls.Add(this.btnSubjectForm);
            this.panel9.Location = new System.Drawing.Point(576, 39);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(278, 42);
            this.panel9.TabIndex = 2;
            // 
            // btnScoreForm
            // 
            this.btnScoreForm.Location = new System.Drawing.Point(148, 16);
            this.btnScoreForm.Name = "btnScoreForm";
            this.btnScoreForm.Size = new System.Drawing.Size(109, 23);
            this.btnScoreForm.TabIndex = 1;
            this.btnScoreForm.Text = "Score Form";
            this.btnScoreForm.UseVisualStyleBackColor = true;
            // 
            // btnSubjectForm
            // 
            this.btnSubjectForm.Location = new System.Drawing.Point(16, 16);
            this.btnSubjectForm.Name = "btnSubjectForm";
            this.btnSubjectForm.Size = new System.Drawing.Size(111, 23);
            this.btnSubjectForm.TabIndex = 0;
            this.btnSubjectForm.Text = "Subject Form";
            this.btnSubjectForm.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 460);
            this.Controls.Add(this.tabStudent);
            this.Name = "Form1";
            this.Text = "ShowStudent";
            this.tabStudent.ResumeLayout(false);
            this.ShowStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabStudent;
        private TabPage ShowStudent;
        private DataGridView dtgStudent;
        private DataGridViewTextBoxColumn STT;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn NumberPhone;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Edit;
        private DataGridViewTextBoxColumn Delete;
        private Panel panel1;
        private Button btnExit;
        private Button btnUpdate;
        private Button btnShowStudent;
        private TabPage tabPage2;
        private Panel panel2;
        private Panel panel7;
        private Button btnDelete;
        private Button btnEx;
        private Button btnEdit;
        private Button btnAdd;
        private Panel panel6;
        private TextBox txtEmail;
        private Label label4;
        private Panel panel5;
        private TextBox txtNumberPhone;
        private Label label3;
        private Panel panel4;
        private TextBox txtAddress;
        private Label label2;
        private Panel panel3;
        private TextBox txtFullName;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Panel panel8;
        private TextBox txtStudentId;
        private Label label5;
        private Panel panel9;
        private Button btnScoreForm;
        private Button btnSubjectForm;
    }
}