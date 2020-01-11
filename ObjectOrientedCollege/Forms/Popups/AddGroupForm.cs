using System;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AddGroupForm : Form
    {
        protected College college;

        public AddGroupForm(College college)
        {
            InitializeComponent();
            this.college = college;
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            if (textBoxGroupNumber.Text != "")
            {
                college.AddGroup(Int32.Parse(textBoxGroupNumber.Text.ToString()));
                Close();
            }
            else
            {
                MessageBox.Show(Config.UnfulfilledRequiredFieldsMessage);
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
