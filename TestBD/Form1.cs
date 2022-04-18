using ConnectAPI;
using Domain;

namespace TestBD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowStudent_Click(object sender, EventArgs e)
        {
                var result = StudentConnectAPI.GetStudent();

                if (result != null && result.Count > 0)
                {
                    ShowDataStudentGridView(result);
                }
                else
                {
                    MessageBox.Show("Data Not Found");
                }
        }
        //Show all
        private void ShowDataStudentGridView(List<Student> listStudent)
        {
            if (listStudent != null && listStudent.Count > 0)
            {
                int count = 0;
                dtgStudent.Rows.Clear();
                foreach (var item in listStudent)
                {
                    var row = new DataGridViewRow();
                    dtgStudent.Rows.Add(row);
                    dtgStudent.Rows[count].Cells[0].Value = item.StudentId;
                    dtgStudent.Rows[count].Cells[1].Value = item.FullName;
                    dtgStudent.Rows[count].Cells[2].Value = item.Address;
                    dtgStudent.Rows[count].Cells[3].Value = item.PhoneNumber;
                    dtgStudent.Rows[count].Cells[4].Value = item.Email;
                    dtgStudent.Rows[count].Cells[7].Value = "Edit";
                    dtgStudent.Rows[count].Cells[7].Style.ForeColor = Color.Red;
                    dtgStudent.Rows[count].Cells[8].Value = "Delete";
                    dtgStudent.Rows[count].Cells[8].Style.ForeColor = Color.Yellow;
                    count++;
                }

            }
        }

        private void ShowStudent_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (txtFullName.Text == "")
            {
                MessageBox.Show("You need enter a fullname");
                txtFullName.Focus();
            }
            else if (txtAddress.Text == "")
            {
                MessageBox.Show("You need enter a address");
                txtAddress.Focus();
            }
            else
            if (txtNumberPhone.Text == "")
            {
                MessageBox.Show("You need enter a number phone");
                txtNumberPhone.Focus();
            }

            else
          if (txtEmail.Text == "")
            {
                MessageBox.Show("You need enter a email address");
                txtEmail.Focus();
            }

            else
            {
                var student = new Student()
                {
                    FullName = txtFullName.Text,
                    Address = txtAddress.Text,
                    PhoneNumber = txtNumberPhone.Text,
                    Email = txtEmail.Text
                };

                bool isInsert = StudentConnectAPI.InsertStudent(student);
                if (isInsert)
                {
                    MessageBox.Show("Add succesfull Data");
                }
                else
                {
                    MessageBox.Show("Add failed Data");
                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.OKCancel);
            if (Result == DialogResult.OK)
            {
                bool isInsert = StudentConnectAPI.DeleteStudent(Int32.Parse(txtStudentId.Text));
                if (isInsert)
                {
                    MessageBox.Show("Delete success data");
                }
                else
                {
                    MessageBox.Show("Delete failed Data");
                }

            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            var student = new Student()
            {
                FullName = txtFullName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtNumberPhone.Text,
                Email = txtEmail.Text
            };

            bool isInsert = StudentConnectAPI.EditStudent(student);
            if (isInsert)
            {
                MessageBox.Show("Edit success data");
            }
            else
            {
                MessageBox.Show("Edit failed Data");
            }
        }
    }
}