using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class StartLessonForm : Form
    {
        protected College college;
        private string teacherName;

        public StartLessonForm(College college, string teacherName)
        {
            InitializeComponent();
            this.college = college;
            this.teacherName = teacherName;
        }

        private void StartLessonForm_Load(object sender, EventArgs e)
        {
            List<ComboboxTeacherItem> itemsTeachers = new List<ComboboxTeacherItem>();
            for (int i = 0; i < college.Teachers.Count; i++)
            {
                ComboboxTeacherItem item = new ComboboxTeacherItem(college.Teachers[i].FirstName + " " + college.Teachers[i].LastName, college.Teachers[i]);
                itemsTeachers.Add(item);
            }
            for (int i = 0; i < itemsTeachers.Count; i++)
            {
                comboBoxTeachers.Items.Add(itemsTeachers[i]);
            }

            if (itemsTeachers.Count > 0)
            {
                comboBoxTeachers.SelectedIndex = comboBoxTeachers.FindStringExact(teacherName.ToString());
            }

            List<ComboboxGroupItem> itemsGroups = new List<ComboboxGroupItem>();
            for (int i = 0; i < college.StudentGroups.Count; i++)
            {
                ComboboxGroupItem item = new ComboboxGroupItem(college.StudentGroups[i].GroupNumber.ToString(), college.StudentGroups[i]);
                itemsGroups.Add(item);
            }
            for (int i = 0; i < itemsGroups.Count; i++)
            {
                comboBoxGroups.Items.Add(itemsGroups[i]);
            }

            if (itemsGroups.Count > 0)
            {
                comboBoxGroups.SelectedIndex = 0;
            }

            List<ComboboxAudienceItem> itemsAudiences = new List<ComboboxAudienceItem>();
            for (int i = 0; i < college.Audiences.Count; i++)
            {
                ComboboxAudienceItem item = new ComboboxAudienceItem(college.Audiences[i].RoomNumber.ToString(), college.Audiences[i]);
                itemsAudiences.Add(item);
            }
            for (int i = 0; i < itemsAudiences.Count; i++)
            {
                comboBoxAudiences.Items.Add(itemsAudiences[i]);
            }

            if (itemsAudiences.Count > 0)
            {
                comboBoxAudiences.SelectedIndex = 0;
            }
        }

        private void buttonStartLesson_Click(object sender, EventArgs e)
        {
            if (comboBoxTeachers.Text != "" && comboBoxGroups.Text != "" && comboBoxAudiences.Text != "")
            {
                (comboBoxTeachers.SelectedItem as ComboboxTeacherItem).Value.TeachGroup((comboBoxGroups.SelectedItem as ComboboxGroupItem).Value, (comboBoxAudiences.SelectedItem as ComboboxAudienceItem).Value);
                Close();
            }
            else
            {
                MessageBox.Show(Config.UnfulfilledRequiredFieldsMessage);
            }
        }
    }
}
