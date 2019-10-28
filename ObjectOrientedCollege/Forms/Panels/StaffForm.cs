using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class StaffForm : ObjectOrientedCollege.TemplateForm
    {
        public StaffForm(College college) : base(college)
        {
            InitializeComponent();
            RedrawTeachersGrid();
            RedrawTechniciansGrid();
        }

        private void dataGridViewTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                StartLessonForm form = new StartLessonForm(college, college.teachers[e.RowIndex].firstName + " " + college.teachers[e.RowIndex].lastName);
                form.FormClosing += delegate { RedrawTeachersGrid(); };
                form.Show();
            }
        }

        private void dataGridViewTechnicians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                // TODO
                RedrawTechniciansGrid();
            }
        }

        private void RedrawTeachersGrid()
        {
            List<Teacher> teachers = college.teachers;
            dataGridViewTeachers.Rows.Clear();

            for (int rowIndex = 0; rowIndex < teachers.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].firstName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].lastName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].age
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].phoneNumber
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].salary
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].moneyAmount
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].subject
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = "Teach Group"
                });

                dataGridViewTeachers.Rows.Add(row);
            }
        }

        private void RedrawTechniciansGrid()
        {
            List<Technician> technicians = college.technicians;
            dataGridViewTechnicians.Rows.Clear();

            for (int rowIndex = 0; rowIndex < technicians.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].firstName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].lastName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].age
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].phoneNumber
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].salary
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].moneyAmount
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].CleanTimes
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = "Clean Audience"
                });

                dataGridViewTechnicians.Rows.Add(row);
            }
        }

        private void buttonAddTeacher_Click(object sender, EventArgs e)
        {
            AddTeacherForm form = new AddTeacherForm(college);
            form.FormClosing += delegate { RedrawTeachersGrid(); };
            form.Show();
        }

        private void buttonAddTechnician_Click(object sender, EventArgs e)
        {
            AddTechnicianForm form = new AddTechnicianForm(college);
            form.FormClosing += delegate { RedrawTechniciansGrid(); };
            form.Show();
        }
    }
}
