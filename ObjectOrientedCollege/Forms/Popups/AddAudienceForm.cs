using System;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AddAudienceForm : Form
    {
        protected College college;

        public AddAudienceForm(College college)
        {
            InitializeComponent();
            this.college = college;
        }

        private void buttonAddAudience_Click(object sender, EventArgs e)
        {
            if (textBoxRoomNumber.Text != "" && textBoxClearness.Text != "")
            {
                if ( Int32.Parse(textBoxClearness.Text.ToString()) >= 0 && Int32.Parse(textBoxClearness.Text.ToString()) <= 100 )
                {
                    college.AddAudience(Int32.Parse(textBoxRoomNumber.Text.ToString()), Int32.Parse(textBoxClearness.Text.ToString()));
                    Close();
                }
                else
                {
                    MessageBoxClearnessWarning();
                }
            }
            else if (textBoxRoomNumber.Text != "")
            {
                college.AddAudience(Int32.Parse(textBoxRoomNumber.Text.ToString()));
                Close();
            }
            else
            {
                MessageBox.Show(Config.UnfulfilledRequiredFieldsMessage);
            }
        }

        private static void MessageBoxClearnessWarning()
        {
            MessageBox.Show("This clearness level is unacceptable, only 0 - 100 % avaliable.");
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
