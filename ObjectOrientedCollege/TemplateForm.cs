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
    public partial class TemplateForm : Form
    {
        protected MainMenuForm FormData;

        public TemplateForm(MainMenuForm FormData)
        {
            InitializeComponent();
            this.FormData = FormData;
        }
        
        private void TemplateForm_Load(object sender, EventArgs e)
        {
            labelLine.Width = TemplateForm.ActiveForm.Size.Width;
        }

        private void labelMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
