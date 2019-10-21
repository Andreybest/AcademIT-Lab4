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
    public partial class Form1 : Form
    {

        Student human = new Student("Valerka", "Zhmishak", 23, "+3805454343", 2);
        Headman headman = new Headman("Valerkovna", "Zhmishak", 23, "+3548945854", 2, 19);
        int clickAmounts = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Student.CountStudents.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            clickAmounts++;
            if (clickAmounts == 10)
            {
                label1.Text = "DESPACITO SANS";
            }
        }
    }
}
