using StudentAttendanceSystem;

namespace StudentAttendenceSystem
{
    public partial class btnStudentAttendnceSystem : Form
    {
        public btnStudentAttendnceSystem()
        {
            InitializeComponent();
            dgvStudents.RowTemplate.Height = 45;
            dgvStudents.RowHeadersWidth = 25;
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvStudents.ColumnHeadersHeight = 45;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = txtStudentID.Text.Trim();
            string name = txtStudentName.Text.Trim();

            if (id == "" || name == "")
            {
                MessageBox.Show("Please enter both Student ID and Student Name.");
                return;
            }

            Student student = new Student
            {
                StudentID = id,
                StudentName = name
            };

            dgvStudents.Rows.Add(student.StudentID, student.StudentName, "Not Marked");

            txtStudentID.Clear();
            txtStudentName.Clear();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
    dgvStudents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            dgvStudents.CurrentRow.Cells[2].Value = "Present";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
                dgvStudents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            dgvStudents.CurrentRow.Cells[2].Value = "Absent";
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            if (dgvStudents.CurrentRow == null ||
    dgvStudents.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Please select a student first.");
                return;
            }

            dgvStudents.Rows.Remove(dgvStudents.CurrentRow);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();
            txtStudentName.Clear();
            txtStudentID.Focus();
        }
    }
}
