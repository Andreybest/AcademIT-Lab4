using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ObjectOrientedCollege
{
    public partial class AudiencesForm : ObjectOrientedCollege.TemplateForm
    {
        private const string CleanButtonText = "Clean";
        private const string NoChosenTechnician = "Please add technicians before cleaning audiences.";

        private const int AudienceNumberColumnIndex = 0;

        public AudiencesForm(College college) : base(college)
        {
            InitializeComponent();
            RedrawGrid();
        }
        
        public void RedrawGrid()
        {
            List<Audience> audiences = college.audiences;
            dataGridViewAudiences.Rows.Clear();

            for (int rowIndex = 0; rowIndex < audiences.Count; rowIndex++)
            {
                var row = new DataGridViewRow();
                row.Cells.Add(new DataGridViewTextBoxCell()
                {
                    Value = audiences[rowIndex].roomNumber
                });
                row.Cells.Add(new DataGridViewProgressCell()
                {
                    Value = audiences[rowIndex].Clearness
                });
                row.Cells.Add(new DataGridViewButtonCell()
                {
                    Value = CleanButtonText
                });

                dataGridViewAudiences.Rows.Add(row);
            }
        }

        private void AudiencesForm_Load(object sender, EventArgs e)
        {
            List<ComboboxTechicianItem> items = new List<ComboboxTechicianItem>();
            for (int i = 0; i < college.technicians.Count; i++)
            {
                ComboboxTechicianItem item = new ComboboxTechicianItem(college.technicians[i].firstName + " " + college.technicians[i].lastName, college.technicians[i]);
                items.Add(item);
            }
            for (int i = 0; i < items.Count; i++)
            {
                comboBoxTechnicians.Items.Add(items[i]);
            }

            if (items.Count > 0)
            {
                comboBoxTechnicians.SelectedIndex = 0;
            }
        }

        private void dataGridViewAudiences_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBoxTechnicians.Text != "")
            {
                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    (comboBoxTechnicians.SelectedItem as ComboboxTechicianItem).Value.CleanAudince(college.audiences[e.RowIndex]);
                    RedrawGrid();
                }
            }
            else
            {
                MessageBox.Show(NoChosenTechnician);
            }
        }

        private void buttonAddAudience_Click(object sender, EventArgs e)
        {
            AddAudienceForm form = new AddAudienceForm(college);
            form.FormClosing += delegate { RedrawGrid(); };
            form.Show();
        }

        private void buttonRemoveAudience_Click(object sender, EventArgs e)
        {
            if (dataGridViewAudiences.SelectedRows.Count < 1)
            {
                MessageBox.Show(Config.NoChosenRowToRemoveMessage);
            }
            else
            {
                int audienceNumber = int.Parse(dataGridViewAudiences.SelectedRows[0].Cells[AudienceNumberColumnIndex].Value.ToString());
                int audienceIndex = college.FindAudience(audienceNumber);
                if (audienceIndex != -1)
                {
                    college.RemoveAudience(college.audiences[audienceIndex]);
                    RedrawGrid();
                }
            }
        }
    }
}
