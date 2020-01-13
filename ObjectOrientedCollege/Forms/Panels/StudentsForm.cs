using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class StudentsForm : TemplateForm
    {
        private const string SelfStudyButtonText = "Self Study";
        private const string NoGroupsMessage = "You need to add a group in order to add a student.";

        private const int StudentFirstNameColumnIndex = 0;
        private const int StudentLastNameColumnIndex = 1;

        public StudentsForm(College college) : base(college)
        {
            InitializeComponent();
            RedrawGrid();
        }

        public void RedrawGrid()
        {
            List<Student> students = college.Students;
            dataGridViewStudents.Rows.Clear();

            for (int rowIndex = 0; rowIndex < students.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].FirstName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].LastName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].Age
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].PhoneNumber
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].Group
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].Scholarship
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].MoneyAmount
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = students[rowIndex].KnowlageLevel
                });
                row.Cells.Add(new DataGridViewProgressCell()
                {
                    Value = (int)students[rowIndex].KnowlageProgress
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = SelfStudyButtonText
                });

                dataGridViewStudents.Rows.Add(row);
            }
        }

        private void dataGridViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                college.Students[e.RowIndex].SelfStudy();
                RedrawGrid();
            }
        }

        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            if (college.StudentGroups.Count < 1)
            {
                MessageBox.Show(NoGroupsMessage);
            }
            else
            {
                AddStudentForm form = new AddStudentForm(college);
                form.FormClosing += delegate { RedrawGrid(); };
                form.Show();
            }
        }

        private void buttonRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count < 1)
            {
                MessageBox.Show(Config.NoChosenRowToRemoveMessage);
            }
            else
            {
                string selectedStudentFirstName = dataGridViewStudents.SelectedRows[0].Cells[StudentFirstNameColumnIndex].Value.ToString();
                string selectedStudentLastName = dataGridViewStudents.SelectedRows[0].Cells[StudentLastNameColumnIndex].Value.ToString();
                Student student = college.FindStudent(selectedStudentFirstName, selectedStudentLastName);
                StudentGroup group = college.FindGroup(student.Group);
                if (student != null && group != null)
                {
                    group.RemoveStudent(student);
                    college.RemoveStudent(student);
                    RedrawGrid();
                }
            }
        }
    }
}
