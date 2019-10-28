using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class GroupsForm : ObjectOrientedCollege.TemplateForm
    {
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
                        Value = "No Group Headman"
                    });
                }
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = groups[rowIndex].Students.Count
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = "Create Raport"
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
                        Value = "Add Headman"
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
                    MessageBox.Show(college.studentGroups[e.RowIndex].ToString());
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
                        MessageBox.Show("This group already has Headman.");
                    }
                }
            }
        }
    }
}
