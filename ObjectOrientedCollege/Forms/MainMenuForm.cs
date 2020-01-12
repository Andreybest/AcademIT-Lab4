using System;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class MainMenuForm : Form
    {
        private const string PayDayMessage = "Everyone got a money check!";

        public College college = new College("PPK", "Despacito land");

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelCollegeName.Text = college.Name;
            labelAddress.Text = college.Address;
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            StudentsForm form = new StudentsForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            GroupsForm form = new GroupsForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void buttonAudiences_Click(object sender, EventArgs e)
        {
            AudiencesForm form = new AudiencesForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            StaffForm form = new StaffForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            form.FormClosing += delegate { this.Show(); };
            form.Show();
            this.Hide();
        }

        private void buttonPayday_Click(object sender, EventArgs e)
        {
            college.GiveMoneyToEveryHuman();
            MessageBox.Show(PayDayMessage);
        }
    }
}
