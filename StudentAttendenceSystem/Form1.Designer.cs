namespace StudentAttendenceSystem
{
    partial class btnStudentAttendnceSystem
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
            lblStudentID = new Label();
            lblStudentName = new Label();
            txtStudentID = new TextBox();
            txtStudentName = new TextBox();
            btnAddStudent = new Button();
            lblHeading = new Label();
            dgvStudents = new DataGridView();
            StudentID = new DataGridViewTextBoxColumn();
            StudentName = new DataGridViewTextBoxColumn();
            Attendence = new DataGridViewTextBoxColumn();
            btnPresent = new Button();
            btnAbsent = new Button();
            btnDeleteStudent = new Button();
            btnClear = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(0, 72);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(91, 25);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = "StudentID";
            lblStudentID.Click += label1_Click;
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(0, 139);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(125, 25);
            lblStudentName.TabIndex = 1;
            lblStudentName.Text = "Student Name";
            lblStudentName.Click += label2_Click;
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(123, 72);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(318, 31);
            txtStudentID.TabIndex = 2;
            txtStudentID.TextChanged += textBox1_TextChanged;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(140, 139);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(301, 31);
            txtStudentName.TabIndex = 3;
            txtStudentName.TextChanged += textBox1_TextChanged_1;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = Color.White;
            btnAddStudent.ForeColor = Color.Red;
            btnAddStudent.Location = new Point(208, 176);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(139, 34);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += button1_Click;
            // 
            // lblHeading
            // 
            lblHeading.AutoSize = true;
            lblHeading.Font = new Font("Segoe UI", 14F);
            lblHeading.ForeColor = Color.Red;
            lblHeading.Location = new Point(92, 9);
            lblHeading.Name = "lblHeading";
            lblHeading.Size = new Size(529, 38);
            lblHeading.TabIndex = 5;
            lblHeading.Text = "Student Attendance Management System";
            lblHeading.Click += label1_Click_1;
            // 
            // dgvStudents
            // 
            dgvStudents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStudents.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Columns.AddRange(new DataGridViewColumn[] { StudentID, StudentName, Attendence });
            dgvStudents.Location = new Point(92, 226);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.RowHeadersWidth = 62;
            dgvStudents.Size = new Size(505, 76);
            dgvStudents.TabIndex = 6;
            // 
            // StudentID
            // 
            StudentID.HeaderText = "Student Id";
            StudentID.MinimumWidth = 8;
            StudentID.Name = "StudentID";
            // 
            // StudentName
            // 
            StudentName.HeaderText = "Student Name";
            StudentName.MinimumWidth = 8;
            StudentName.Name = "StudentName";
            // 
            // Attendence
            // 
            Attendence.HeaderText = "Attendence";
            Attendence.MinimumWidth = 8;
            Attendence.Name = "Attendence";
            // 
            // btnPresent
            // 
            btnPresent.Location = new Point(140, 345);
            btnPresent.Name = "btnPresent";
            btnPresent.Size = new Size(150, 41);
            btnPresent.TabIndex = 7;
            btnPresent.Text = "Mark Present";
            btnPresent.UseVisualStyleBackColor = true;
            btnPresent.Click += btnPresent_Click;
            // 
            // btnAbsent
            // 
            btnAbsent.Location = new Point(360, 349);
            btnAbsent.Name = "btnAbsent";
            btnAbsent.Size = new Size(143, 37);
            btnAbsent.TabIndex = 8;
            btnAbsent.Text = "Mark Absent";
            btnAbsent.UseVisualStyleBackColor = true;
            btnAbsent.Click += button1_Click_1;
            // 
            // btnDeleteStudent
            // 
            btnDeleteStudent.Location = new Point(267, 415);
            btnDeleteStudent.Name = "btnDeleteStudent";
            btnDeleteStudent.Size = new Size(145, 34);
            btnDeleteStudent.TabIndex = 9;
            btnDeleteStudent.Text = "Delete Student";
            btnDeleteStudent.UseVisualStyleBackColor = true;
            btnDeleteStudent.Click += btnDeleteStudent_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(706, 268);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(112, 34);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear Fields";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnStudentAttendnceSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 550);
            Controls.Add(btnClear);
            Controls.Add(btnDeleteStudent);
            Controls.Add(btnAbsent);
            Controls.Add(btnPresent);
            Controls.Add(dgvStudents);
            Controls.Add(lblHeading);
            Controls.Add(btnAddStudent);
            Controls.Add(txtStudentName);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentName);
            Controls.Add(lblStudentID);
            Name = "btnStudentAttendnceSystem";
            Text = "Student Attendencce Management System";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private Label lblStudentName;
        private TextBox txtStudentID;
        private TextBox txtStudentName;
        private Button btnAddStudent;
        private Label lblHeading;
        private DataGridView dgvStudents;
        private DataGridViewTextBoxColumn StudentID;
        private DataGridViewTextBoxColumn StudentName;
        private DataGridViewTextBoxColumn Attendence;
        private Button btnPresent;
        private Button btnAbsent;
        private Button btnDeleteStudent;
        private Button btnClear;
    }
}
