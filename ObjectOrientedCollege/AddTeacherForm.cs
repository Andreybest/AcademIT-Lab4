using System;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AddTeacherForm : Form
    {
        protected College college;

        public AddTeacherForm(College college)
        {
            InitializeComponent();
            this.college = college;
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && textBoxSalary.Text != "" && textBoxSubject.Text != "")
            {
                college.AddTeacher(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(textBoxSalary.Text.ToString()), textBoxSubject.Text.ToString());
                Close();
            }
            else
            {
                MessageBox.Show("All required fields should be filled!");
            }
        }

        private void textBox_KeyPress_NumberCheck(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
