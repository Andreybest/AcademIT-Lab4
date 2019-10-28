using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AddStudentForm : Form
    {
        protected College college;

        public AddStudentForm(College college)
        {
            InitializeComponent();
            this.college = college;
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < college.studentGroups.Count; i++)
            {
                comboBoxGroups.Items.Add(college.studentGroups[i].groupNumber);
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxGroups.Text != "")
            {
                college.AddStudent(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(comboBoxGroups.Text.ToString()), Int32.Parse(textBoxScholarship.Text.ToString()), Int32.Parse(textBoxKnowlageLevel.Text.ToString()));
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
