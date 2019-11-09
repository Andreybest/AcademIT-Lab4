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
    public partial class MainMenuForm : Form
    {

        //Student human = new Student("Valerka", "Zhmishak", 23, "+3805454343", 2, 1500);
        //Headman headman = new Headman("Valerkovna", "Zhmishak", 23, "+3548945854", 2, 2000);
        public College college = new College("College Tem wants to attend :3", "Depressito land");
        int clickAmounts = 0;

        public MainMenuForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //label1.Text = Student.CountStudents.ToString();
            college.AddGroup(25);
            college.AddGroup(35);
            college.AddStudent("Valerka", "Zhmishak", 18, "+3805454343", 35, 1500);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //clickAmounts++;
            //if (clickAmounts == 10)
            //{
            //    label1.Text = "DESPACITO SANS";
            //}
            var frm = new TemplateForm();
            frm.Location = this.Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}
