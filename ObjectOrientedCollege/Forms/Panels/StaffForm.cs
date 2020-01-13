using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class StaffForm : ObjectOrientedCollege.TemplateForm
    {
        private const string TeachGroupButtonText = "Teach Group";
        private const string CleanAudienceButtonText = "Clean Audience";

        private const int FirstNameColumnIndex = 0;
        private const int LastNameColumnIndex = 1;

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
                StartLessonForm form = new StartLessonForm(college, college.Teachers[e.RowIndex].FirstName + " " + college.Teachers[e.RowIndex].LastName);
                form.FormClosing += delegate { RedrawTeachersGrid(); };
                form.Show();
            }
        }

        private void dataGridViewTechnicians_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                RedrawTechniciansGrid();
            }
        }

        private void RedrawTeachersGrid()
        {
            List<Teacher> teachers = college.Teachers;
            dataGridViewTeachers.Rows.Clear();

            for (int rowIndex = 0; rowIndex < teachers.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].FirstName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].LastName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].Age
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].PhoneNumber
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].Salary
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].MoneyAmount
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = teachers[rowIndex].Subject
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = TeachGroupButtonText
                });

                dataGridViewTeachers.Rows.Add(row);
            }
        }

        private void RedrawTechniciansGrid()
        {
            List<Technician> technicians = college.Technicians;
            dataGridViewTechnicians.Rows.Clear();

            for (int rowIndex = 0; rowIndex < technicians.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].FirstName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].LastName
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].Age
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].PhoneNumber
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].Salary
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].MoneyAmount
                });
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = technicians[rowIndex].CleanTimes
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = CleanAudienceButtonText
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

        private void buttonRemoveTeacher_Click(object sender, EventArgs e)
        {
            if (dataGridViewTeachers.SelectedRows.Count < 1)
            {
                MessageBox.Show(Config.NoChosenRowToRemoveMessage);
            }
            else
            {
                string selectedTeachersFirstName = dataGridViewTeachers.SelectedRows[0].Cells[FirstNameColumnIndex].Value.ToString();
                string selectedTeachersLastName = dataGridViewTeachers.SelectedRows[0].Cells[LastNameColumnIndex].Value.ToString();
                Teacher teacher = college.FindTeacher(selectedTeachersFirstName, selectedTeachersLastName);
                if (teacher != null)
                {
                    college.RemoveTeacher(teacher);
                    RedrawTeachersGrid();
                }
            }
        }

        private void buttonRemoveTechnician_Click(object sender, EventArgs e)
        {
            if (dataGridViewTechnicians.SelectedRows.Count < 1)
            {
                MessageBox.Show(Config.NoChosenRowToRemoveMessage);
            }
            else
            {
                string selectedTechnicianFirstName = dataGridViewTechnicians.SelectedRows[0].Cells[FirstNameColumnIndex].Value.ToString();
                string selectedTechnicianLastName = dataGridViewTechnicians.SelectedRows[0].Cells[LastNameColumnIndex].Value.ToString();
                Technician technician = college.FindTechnician(selectedTechnicianFirstName, selectedTechnicianLastName);
                if (technician != null)
                {
                    college.RemoveTechnician(technician);
                    RedrawTechniciansGrid();
                }
            }
        }
    }
}
