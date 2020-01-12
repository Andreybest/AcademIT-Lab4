using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class GroupsForm : ObjectOrientedCollege.TemplateForm
    {
        private const string NoGroupHeadmanText = "No Group Headman";
        private const string CreateRaportButtonText = "Create Raport";
        private const string AddHeadmanButtonText = "Add Headman";
        private const string GroupHasHeadmanMessage = "This group already has Headman.";
        private const string NoGroupHeadmanMessage = "This group dosen't have headman, please assign one in order to use this function.";
        private const string GroupHaveStudentsMessage = "This group has students, please remove all students from this group before removing this group.";

        private const int GroupNumberColumnIndex = 0;

        public GroupsForm(College college) : base(college)
        {
            InitializeComponent();
            RedrawGrid();
        }

        public void RedrawGrid()
        {
            List<StudentGroup> groups = college.StudentGroups;
            dataGridViewGroups.Rows.Clear();

            for (int rowIndex = 0; rowIndex < groups.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = groups[rowIndex].GroupNumber
                });
                if (groups[rowIndex].GroupHeadmanExists())
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = groups[rowIndex].GroupHeadman.FirstName + " " + groups[rowIndex].GroupHeadman.LastName
                    });
                }
                else
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = NoGroupHeadmanText
                    });
                }
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = groups[rowIndex].Students.Count
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = CreateRaportButtonText
                });
                if (groups[rowIndex].GroupHeadmanExists())
                {
                    row.Cells.Add(new DataGridViewButtonCell()
                    {
                        FlatStyle = FlatStyle.Flat
                    });
                }
                else
                {
                    row.Cells.Add(new DataGridViewButtonCell()
                    {
                        Value = AddHeadmanButtonText
                    });
                }

                dataGridViewGroups.Rows.Add(row);
            }
        }

        private void dataGridViewGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 3)
                {
                    if (college.StudentGroups[e.RowIndex].GroupHeadmanExists())
                    {
                        MessageBox.Show(college.StudentGroups[e.RowIndex].ToString());
                    }
                    else
                    {
                        MessageBox.Show(NoGroupHeadmanMessage);
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (!college.StudentGroups[e.RowIndex].GroupHeadmanExists())
                    {
                        AddHeadmanForm form = new AddHeadmanForm(college, college.StudentGroups[e.RowIndex].GroupNumber);
                        form.FormClosing += delegate { RedrawGrid(); };
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show(GroupHasHeadmanMessage);
                    }
                }
            }
        }

        private void buttonAddGroup_Click(object sender, EventArgs e)
        {
            AddGroupForm form = new AddGroupForm(college);
            form.FormClosing += delegate { RedrawGrid(); };
            form.Show();
        }

        private void buttonRemoveGroup_Click(object sender, EventArgs e)
        {
            if (dataGridViewGroups.SelectedRows.Count < 1)
            {
                MessageBox.Show(Config.NoChosenRowToRemoveMessage);
            }
            else
            {
                int groupNumber = int.Parse(dataGridViewGroups.SelectedRows[0].Cells[GroupNumberColumnIndex].Value.ToString());
                int groupIndex = college.FindGroupIndex(groupNumber);
                if (groupIndex != -1)
                {
                    if (college.StudentGroups[groupIndex].HasStudents())
                    {
                        MessageBox.Show(GroupHaveStudentsMessage);
                    }
                    else
                    {
                        college.RemoveGroup(college.StudentGroups[groupIndex]);
                        RedrawGrid();
                    }
                }
            }
        }
    }
}
