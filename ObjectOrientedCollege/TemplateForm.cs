using System;
using System.Drawing;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class TemplateForm : Form
    {
        protected College college;

        public TemplateForm()
        {
            InitializeComponent();
        }
        public TemplateForm(College college)
        {
            InitializeComponent();
            this.college = college;
        }
        
        private void TemplateForm_Load(object sender, EventArgs e)
        {
            labelLine.Width = Size.Width;
        }

        private void labelMenuButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
