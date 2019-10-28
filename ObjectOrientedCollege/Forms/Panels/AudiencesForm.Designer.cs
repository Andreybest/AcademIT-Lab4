namespace ObjectOrientedCollege
{
    partial class AudiencesForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudiencesForm));
            this.dataGridViewAudiences = new System.Windows.Forms.DataGridView();
            this.roomNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clearness = new ObjectOrientedCollege.DataGridViewProgressColumn();
            this.cleanAudienceButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelTechnician = new System.Windows.Forms.Label();
            this.comboBoxTechnicians = new System.Windows.Forms.ComboBox();
            this.buttonAddAudience = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiences)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(379, 5);
            this.labelTitle.Size = new System.Drawing.Size(151, 33);
            this.labelTitle.Text = "Audiences";
            // 
            // dataGridViewAudiences
            // 
            this.dataGridViewAudiences.AllowUserToAddRows = false;
            this.dataGridViewAudiences.AllowUserToDeleteRows = false;
            this.dataGridViewAudiences.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewAudiences.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAudiences.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumber,
            this.clearness,
            this.cleanAudienceButton});
            this.dataGridViewAudiences.EnableHeadersVisualStyles = false;
            this.dataGridViewAudiences.Location = new System.Drawing.Point(258, 97);
            this.dataGridViewAudiences.Name = "dataGridViewAudiences";
            this.dataGridViewAudiences.ReadOnly = true;
            this.dataGridViewAudiences.RowHeadersVisible = false;
            this.dataGridViewAudiences.Size = new System.Drawing.Size(364, 349);
            this.dataGridViewAudiences.TabIndex = 4;
            this.dataGridViewAudiences.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAudiences_CellContentClick);
            // 
            // roomNumber
            // 
            this.roomNumber.HeaderText = "Audience Number";
            this.roomNumber.Name = "roomNumber";
            this.roomNumber.ReadOnly = true;
            this.roomNumber.Width = 60;
            // 
            // clearness
            // 
            this.clearness.HeaderText = "Clearness";
            this.clearness.Name = "clearness";
            this.clearness.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.clearness.ReadOnly = true;
            this.clearness.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.clearness.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.clearness.Width = 200;
            // 
            // cleanAudienceButton
            // 
            this.cleanAudienceButton.HeaderText = "Clean Audience";
            this.cleanAudienceButton.Name = "cleanAudienceButton";
            this.cleanAudienceButton.ReadOnly = true;
            this.cleanAudienceButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cleanAudienceButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelTechnician
            // 
            this.labelTechnician.AutoSize = true;
            this.labelTechnician.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechnician.Location = new System.Drawing.Point(327, 57);
            this.labelTechnician.Name = "labelTechnician";
            this.labelTechnician.Size = new System.Drawing.Size(109, 24);
            this.labelTechnician.TabIndex = 5;
            this.labelTechnician.Text = "Technician:";
            // 
            // comboBoxTechnicians
            // 
            this.comboBoxTechnicians.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTechnicians.FormattingEnabled = true;
            this.comboBoxTechnicians.Location = new System.Drawing.Point(439, 59);
            this.comboBoxTechnicians.Name = "comboBoxTechnicians";
            this.comboBoxTechnicians.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTechnicians.TabIndex = 6;
            // 
            // buttonAddAudience
            // 
            this.buttonAddAudience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAudience.Location = new System.Drawing.Point(785, 11);
            this.buttonAddAudience.Name = "buttonAddAudience";
            this.buttonAddAudience.Size = new System.Drawing.Size(83, 23);
            this.buttonAddAudience.TabIndex = 7;
            this.buttonAddAudience.Text = "Add Audience";
            this.buttonAddAudience.UseVisualStyleBackColor = true;
            this.buttonAddAudience.Click += new System.EventHandler(this.buttonAddAudience_Click);
            // 
            // AudiencesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonAddAudience);
            this.Controls.Add(this.comboBoxTechnicians);
            this.Controls.Add(this.labelTechnician);
            this.Controls.Add(this.dataGridViewAudiences);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AudiencesForm";
            this.Text = "Audiences Panel";
            this.Load += new System.EventHandler(this.AudiencesForm_Load);
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.dataGridViewAudiences, 0);
            this.Controls.SetChildIndex(this.labelTechnician, 0);
            this.Controls.SetChildIndex(this.comboBoxTechnicians, 0);
            this.Controls.SetChildIndex(this.buttonAddAudience, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAudiences)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAudiences;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumber;
        private DataGridViewProgressColumn clearness;
        private System.Windows.Forms.DataGridViewButtonColumn cleanAudienceButton;
        private System.Windows.Forms.Label labelTechnician;
        private System.Windows.Forms.ComboBox comboBoxTechnicians;
        private System.Windows.Forms.Button buttonAddAudience;
    }
}
