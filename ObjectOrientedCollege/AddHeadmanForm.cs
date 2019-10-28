using System;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AddHeadmanForm : Form
    {
        protected College college;
        private int group;

        public AddHeadmanForm(College college, int group)
        {
            InitializeComponent();
            this.college = college;
            this.group = group;
        }

        private void AddHeadmanForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < college.studentGroups.Count; i++)
            {
                comboBoxGroups.Items.Add(college.studentGroups[i].groupNumber);
            }
            comboBoxGroups.SelectedIndex = comboBoxGroups.FindStringExact(group.ToString());
        }

        private void buttonAddHeadman_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxGroups.Text != "" && textBoxScholarship.Text != "" && textBoxKnowlageLevel.Text != "")
            {
                if (CheckKnowlageLevel(Int32.Parse(textBoxKnowlageLevel.Text.ToString())))
                {
                    college.AddHeadman(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(comboBoxGroups.Text.ToString()), Int32.Parse(textBoxScholarship.Text.ToString()), Int32.Parse(textBoxKnowlageLevel.Text.ToString()));
                    Close();
                }
                else
                {
                    MessageBoxKnowlageLevelWarning();
                }
            }
            else if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxGroups.Text != "" && textBoxScholarship.Text != "")
            {
                college.AddHeadman(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(comboBoxGroups.Text.ToString()), Int32.Parse(textBoxScholarship.Text.ToString()));
                Close();
            }
            else if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxGroups.Text != "" && textBoxKnowlageLevel.Text != "")
            {
                if (CheckKnowlageLevel(Int32.Parse(textBoxKnowlageLevel.Text.ToString())))
                {
                    college.AddHeadman(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(comboBoxGroups.Text.ToString()), knowlageLevel: Int32.Parse(textBoxKnowlageLevel.Text.ToString()));
                    Close();
                }
                else
                {
                    MessageBoxKnowlageLevelWarning();
                }
            }
            else if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxAge.Text != "" && textBoxPhoneNumber.Text != "" && comboBoxGroups.Text != "")
            {
                college.AddHeadman(textBoxFirstName.Text.ToString(), textBoxLastName.Text.ToString(), Int32.Parse(textBoxAge.Text.ToString()), textBoxPhoneNumber.Text.ToString(), Int32.Parse(comboBoxGroups.Text.ToString()));
                Close();
            }
            else
            {
                MessageBox.Show("All required fields should be filled!");
            }
        }

        private bool CheckKnowlageLevel(int knowlageLevel)
        {
            if (Enum.IsDefined(typeof(EKnowlageLevel), knowlageLevel))
            {
                return true;
            }
            return false;
        }

        private static void MessageBoxKnowlageLevelWarning()
        {
            MessageBox.Show("This knowlage level is unacceptable, only 2 - 5 avaliable.");
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
