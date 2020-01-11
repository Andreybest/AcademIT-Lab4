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
            labelCollegeName.Text = college.name;
            labelAddress.Text = college.address;
        }

        private void buttonStudents_Click(object sender, EventArgs e)
        {
            StudentsForm frm = new StudentsForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonGroups_Click(object sender, EventArgs e)
        {
            GroupsForm frm = new GroupsForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonAudiences_Click(object sender, EventArgs e)
        {
            AudiencesForm frm = new AudiencesForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonStaff_Click(object sender, EventArgs e)
        {
            StaffForm frm = new StaffForm(college)
            {
                Location = this.Location,
                StartPosition = FormStartPosition.Manual
            };
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }

        private void buttonPayday_Click(object sender, EventArgs e)
        {
            college.Payday();
            MessageBox.Show(PayDayMessage);
        }
    }
}
