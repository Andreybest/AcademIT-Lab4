namespace ObjectOrientedCollege
{
    partial class StaffForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffForm));
            this.dataGridViewTeachers = new System.Windows.Forms.DataGridView();
            this.firstNameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyAmountTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studyTeacherButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.labelTeachers = new System.Windows.Forms.Label();
            this.buttonAddTeacher = new System.Windows.Forms.Button();
            this.buttonAddTechnician = new System.Windows.Forms.Button();
            this.labelTechnicians = new System.Windows.Forms.Label();
            this.dataGridViewTechnicians = new System.Windows.Forms.DataGridView();
            this.firstNameTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanTimesTechnician = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cleanTechnicianButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonRemoveTeacher = new System.Windows.Forms.Button();
            this.buttonRemoveTechnician = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTechnicians)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(405, 6);
            this.labelTitle.Size = new System.Drawing.Size(74, 33);
            this.labelTitle.Text = "Staff";
            // 
            // dataGridViewTeachers
            // 
            this.dataGridViewTeachers.AllowUserToAddRows = false;
            this.dataGridViewTeachers.AllowUserToDeleteRows = false;
            this.dataGridViewTeachers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTeachers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameTeacher,
            this.lastNameTeacher,
            this.ageTeacher,
            this.phoneNumberTeacher,
            this.salaryTeacher,
            this.moneyAmountTeacher,
            this.subjectTeacher,
            this.studyTeacherButton});
            this.dataGridViewTeachers.EnableHeadersVisualStyles = false;
            this.dataGridViewTeachers.Location = new System.Drawing.Point(69, 77);
            this.dataGridViewTeachers.MultiSelect = false;
            this.dataGridViewTeachers.Name = "dataGridViewTeachers";
            this.dataGridViewTeachers.ReadOnly = true;
            this.dataGridViewTeachers.RowHeadersVisible = false;
            this.dataGridViewTeachers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTeachers.Size = new System.Drawing.Size(743, 167);
            this.dataGridViewTeachers.TabIndex = 3;
            this.dataGridViewTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTeachers_CellContentClick);
            // 
            // firstNameTeacher
            // 
            this.firstNameTeacher.HeaderText = "First Name";
            this.firstNameTeacher.Name = "firstNameTeacher";
            this.firstNameTeacher.ReadOnly = true;
            // 
            // lastNameTeacher
            // 
            this.lastNameTeacher.HeaderText = "Last Name";
            this.lastNameTeacher.Name = "lastNameTeacher";
            this.lastNameTeacher.ReadOnly = true;
            // 
            // ageTeacher
            // 
            this.ageTeacher.HeaderText = "Age";
            this.ageTeacher.Name = "ageTeacher";
            this.ageTeacher.ReadOnly = true;
            this.ageTeacher.Width = 50;
            // 
            // phoneNumberTeacher
            // 
            this.phoneNumberTeacher.HeaderText = "Phone Number";
            this.phoneNumberTeacher.Name = "phoneNumberTeacher";
            this.phoneNumberTeacher.ReadOnly = true;
            this.phoneNumberTeacher.Width = 120;
            // 
            // salaryTeacher
            // 
            this.salaryTeacher.HeaderText = "Salary";
            this.salaryTeacher.Name = "salaryTeacher";
            this.salaryTeacher.ReadOnly = true;
            this.salaryTeacher.Width = 70;
            // 
            // moneyAmountTeacher
            // 
            this.moneyAmountTeacher.HeaderText = "Money";
            this.moneyAmountTeacher.Name = "moneyAmountTeacher";
            this.moneyAmountTeacher.ReadOnly = true;
            // 
            // subjectTeacher
            // 
            this.subjectTeacher.HeaderText = "Subject";
            this.subjectTeacher.Name = "subjectTeacher";
            this.subjectTeacher.ReadOnly = true;
            // 
            // studyTeacherButton
            // 
            this.studyTeacherButton.HeaderText = "Study Button";
            this.studyTeacherButton.Name = "studyTeacherButton";
            this.studyTeacherButton.ReadOnly = true;
            this.studyTeacherButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studyTeacherButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // labelTeachers
            // 
            this.labelTeachers.AutoSize = true;
            this.labelTeachers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeachers.Location = new System.Drawing.Point(66, 49);
            this.labelTeachers.Name = "labelTeachers";
            this.labelTeachers.Size = new System.Drawing.Size(108, 25);
            this.labelTeachers.TabIndex = 4;
            this.labelTeachers.Text = "Teachers:";
            // 
            // buttonAddTeacher
            // 
            this.buttonAddTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTeacher.Location = new System.Drawing.Point(721, 49);
            this.buttonAddTeacher.Name = "buttonAddTeacher";
            this.buttonAddTeacher.Size = new System.Drawing.Size(91, 23);
            this.buttonAddTeacher.TabIndex = 5;
            this.buttonAddTeacher.Text = "Add Teacher";
            this.buttonAddTeacher.UseVisualStyleBackColor = true;
            this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
            // 
            // buttonAddTechnician
            // 
            this.buttonAddTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddTechnician.Location = new System.Drawing.Point(721, 252);
            this.buttonAddTechnician.Name = "buttonAddTechnician";
            this.buttonAddTechnician.Size = new System.Drawing.Size(91, 23);
            this.buttonAddTechnician.TabIndex = 8;
            this.buttonAddTechnician.Text = "Add Technician";
            this.buttonAddTechnician.UseVisualStyleBackColor = true;
            this.buttonAddTechnician.Click += new System.EventHandler(this.buttonAddTechnician_Click);
            // 
            // labelTechnicians
            // 
            this.labelTechnicians.AutoSize = true;
            this.labelTechnicians.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTechnicians.Location = new System.Drawing.Point(66, 252);
            this.labelTechnicians.Name = "labelTechnicians";
            this.labelTechnicians.Size = new System.Drawing.Size(134, 25);
            this.labelTechnicians.TabIndex = 7;
            this.labelTechnicians.Text = "Technicians:";
            // 
            // dataGridViewTechnicians
            // 
            this.dataGridViewTechnicians.AllowUserToAddRows = false;
            this.dataGridViewTechnicians.AllowUserToDeleteRows = false;
            this.dataGridViewTechnicians.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewTechnicians.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTechnicians.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameTechnician,
            this.lastNameTechnician,
            this.ageTechnician,
            this.phoneNumberTechnician,
            this.salaryTechnician,
            this.moneyTechnician,
            this.cleanTimesTechnician,
            this.cleanTechnicianButton});
            this.dataGridViewTechnicians.EnableHeadersVisualStyles = false;
            this.dataGridViewTechnicians.Location = new System.Drawing.Point(69, 282);
            this.dataGridViewTechnicians.MultiSelect = false;
            this.dataGridViewTechnicians.Name = "dataGridViewTechnicians";
            this.dataGridViewTechnicians.ReadOnly = true;
            this.dataGridViewTechnicians.RowHeadersVisible = false;
            this.dataGridViewTechnicians.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTechnicians.Size = new System.Drawing.Size(743, 167);
            this.dataGridViewTechnicians.TabIndex = 6;
            this.dataGridViewTechnicians.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewTechnicians_CellContentClick);
            // 
            // firstNameTechnician
            // 
            this.firstNameTechnician.HeaderText = "First Name";
            this.firstNameTechnician.Name = "firstNameTechnician";
            this.firstNameTechnician.ReadOnly = true;
            // 
            // lastNameTechnician
            // 
            this.lastNameTechnician.HeaderText = "Last Name";
            this.lastNameTechnician.Name = "lastNameTechnician";
            this.lastNameTechnician.ReadOnly = true;
            // 
            // ageTechnician
            // 
            this.ageTechnician.HeaderText = "Age";
            this.ageTechnician.Name = "ageTechnician";
            this.ageTechnician.ReadOnly = true;
            this.ageTechnician.Width = 50;
            // 
            // phoneNumberTechnician
            // 
            this.phoneNumberTechnician.HeaderText = "Phone Number";
            this.phoneNumberTechnician.Name = "phoneNumberTechnician";
            this.phoneNumberTechnician.ReadOnly = true;
            this.phoneNumberTechnician.Width = 120;
            // 
            // salaryTechnician
            // 
            this.salaryTechnician.HeaderText = "Salary";
            this.salaryTechnician.Name = "salaryTechnician";
            this.salaryTechnician.ReadOnly = true;
            this.salaryTechnician.Width = 70;
            // 
            // moneyTechnician
            // 
            this.moneyTechnician.HeaderText = "Money";
            this.moneyTechnician.Name = "moneyTechnician";
            this.moneyTechnician.ReadOnly = true;
            // 
            // cleanTimesTechnician
            // 
            this.cleanTimesTechnician.HeaderText = "Clean Times";
            this.cleanTimesTechnician.Name = "cleanTimesTechnician";
            this.cleanTimesTechnician.ReadOnly = true;
            this.cleanTimesTechnician.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // cleanTechnicianButton
            // 
            this.cleanTechnicianButton.HeaderText = "Clean Button";
            this.cleanTechnicianButton.Name = "cleanTechnicianButton";
            this.cleanTechnicianButton.ReadOnly = true;
            this.cleanTechnicianButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cleanTechnicianButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonRemoveTeacher
            // 
            this.buttonRemoveTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveTeacher.Location = new System.Drawing.Point(613, 49);
            this.buttonRemoveTeacher.Name = "buttonRemoveTeacher";
            this.buttonRemoveTeacher.Size = new System.Drawing.Size(102, 23);
            this.buttonRemoveTeacher.TabIndex = 9;
            this.buttonRemoveTeacher.Text = "Remove Teacher";
            this.buttonRemoveTeacher.UseVisualStyleBackColor = true;
            this.buttonRemoveTeacher.Click += new System.EventHandler(this.buttonRemoveTeacher_Click);
            // 
            // buttonRemoveTechnician
            // 
            this.buttonRemoveTechnician.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveTechnician.Location = new System.Drawing.Point(604, 252);
            this.buttonRemoveTechnician.Name = "buttonRemoveTechnician";
            this.buttonRemoveTechnician.Size = new System.Drawing.Size(111, 23);
            this.buttonRemoveTechnician.TabIndex = 10;
            this.buttonRemoveTechnician.Text = "Remove Technician";
            this.buttonRemoveTechnician.UseVisualStyleBackColor = true;
            this.buttonRemoveTechnician.Click += new System.EventHandler(this.buttonRemoveTechnician_Click);
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonRemoveTechnician);
            this.Controls.Add(this.buttonRemoveTeacher);
            this.Controls.Add(this.buttonAddTechnician);
            this.Controls.Add(this.labelTechnicians);
            this.Controls.Add(this.dataGridViewTechnicians);
            this.Controls.Add(this.buttonAddTeacher);
            this.Controls.Add(this.labelTeachers);
            this.Controls.Add(this.dataGridViewTeachers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StaffForm";
            this.Text = "Staff Panel";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.dataGridViewTeachers, 0);
            this.Controls.SetChildIndex(this.labelTeachers, 0);
            this.Controls.SetChildIndex(this.buttonAddTeacher, 0);
            this.Controls.SetChildIndex(this.dataGridViewTechnicians, 0);
            this.Controls.SetChildIndex(this.labelTechnicians, 0);
            this.Controls.SetChildIndex(this.buttonAddTechnician, 0);
            this.Controls.SetChildIndex(this.buttonRemoveTeacher, 0);
            this.Controls.SetChildIndex(this.buttonRemoveTechnician, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTeachers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTechnicians)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTeachers;
        private System.Windows.Forms.Label labelTeachers;
        private System.Windows.Forms.Button buttonAddTeacher;
        private System.Windows.Forms.Button buttonAddTechnician;
        private System.Windows.Forms.Label labelTechnicians;
        private System.Windows.Forms.DataGridView dataGridViewTechnicians;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyAmountTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectTeacher;
        private System.Windows.Forms.DataGridViewButtonColumn studyTeacherButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyTechnician;
        private System.Windows.Forms.DataGridViewTextBoxColumn cleanTimesTechnician;
        private System.Windows.Forms.DataGridViewButtonColumn cleanTechnicianButton;
        private System.Windows.Forms.Button buttonRemoveTeacher;
        private System.Windows.Forms.Button buttonRemoveTechnician;
    }
}
