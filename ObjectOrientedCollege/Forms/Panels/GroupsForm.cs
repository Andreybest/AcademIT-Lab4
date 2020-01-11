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


        public GroupsForm(College college) : base(college)
        {
            InitializeComponent();
            RedrawGrid();
        }

        public void RedrawGrid()
        {
            List<StudentGroup> groups = college.studentGroups;
            dataGridViewGroups.Rows.Clear();

            for (int rowIndex = 0; rowIndex < groups.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = groups[rowIndex].groupNumber
                });
                if (groups[rowIndex].GroupHeadmanExists())
                {
                    row.Cells.Add(new DataGridViewTextBoxCell()
                    {
                        Value = groups[rowIndex].GroupHeadman.firstName + " " + groups[rowIndex].GroupHeadman.lastName
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
                    if (college.studentGroups[e.RowIndex].GroupHeadmanExists())
                    {
                        MessageBox.Show(college.studentGroups[e.RowIndex].ToString());
                    }
                    else
                    {
                        MessageBox.Show(NoGroupHeadmanMessage);
                    }
                }
                else if (e.ColumnIndex == 4)
                {
                    if (!college.studentGroups[e.RowIndex].GroupHeadmanExists())
                    {
                        AddHeadmanForm form = new AddHeadmanForm(college, college.studentGroups[e.RowIndex].groupNumber);
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
    }
}
