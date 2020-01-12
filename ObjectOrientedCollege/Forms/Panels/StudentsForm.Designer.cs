namespace ObjectOrientedCollege
{
    partial class StudentsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentsForm));
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scholarship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneyAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowlageLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.knowlageProgress = new ObjectOrientedCollege.DataGridViewProgressColumn();
            this.studyButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonRemoveStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(395, 6);
            this.labelTitle.Size = new System.Drawing.Size(129, 33);
            this.labelTitle.Text = "Students";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstName,
            this.lastName,
            this.age,
            this.phoneNumber,
            this.group,
            this.scholarship,
            this.moneyAmount,
            this.knowlageLevel,
            this.knowlageProgress,
            this.studyButton});
            this.dataGridViewStudents.EnableHeadersVisualStyles = false;
            this.dataGridViewStudents.Location = new System.Drawing.Point(15, 80);
            this.dataGridViewStudents.MultiSelect = false;
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowHeadersVisible = false;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(853, 349);
            this.dataGridViewStudents.TabIndex = 2;
            this.dataGridViewStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStudents_CellContentClick);
            // 
            // firstName
            // 
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.ReadOnly = true;
            // 
            // lastName
            // 
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            this.lastName.ReadOnly = true;
            // 
            // age
            // 
            this.age.HeaderText = "Age";
            this.age.Name = "age";
            this.age.ReadOnly = true;
            this.age.Width = 50;
            // 
            // phoneNumber
            // 
            this.phoneNumber.HeaderText = "Phone Number";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.ReadOnly = true;
            this.phoneNumber.Width = 120;
            // 
            // group
            // 
            this.group.HeaderText = "Group";
            this.group.Name = "group";
            this.group.ReadOnly = true;
            this.group.Width = 50;
            // 
            // scholarship
            // 
            this.scholarship.HeaderText = "Scholarship";
            this.scholarship.Name = "scholarship";
            this.scholarship.ReadOnly = true;
            this.scholarship.Width = 70;
            // 
            // moneyAmount
            // 
            this.moneyAmount.HeaderText = "Money";
            this.moneyAmount.Name = "moneyAmount";
            this.moneyAmount.ReadOnly = true;
            // 
            // knowlageLevel
            // 
            this.knowlageLevel.HeaderText = "Knowlage Level";
            this.knowlageLevel.Name = "knowlageLevel";
            this.knowlageLevel.ReadOnly = true;
            this.knowlageLevel.Width = 60;
            // 
            // knowlageProgress
            // 
            this.knowlageProgress.HeaderText = "Knowlage Progress";
            this.knowlageProgress.Name = "knowlageProgress";
            this.knowlageProgress.ProgressBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.knowlageProgress.ReadOnly = true;
            this.knowlageProgress.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.knowlageProgress.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // studyButton
            // 
            this.studyButton.HeaderText = "Study Button";
            this.studyButton.Name = "studyButton";
            this.studyButton.ReadOnly = true;
            this.studyButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.studyButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddStudent.Location = new System.Drawing.Point(769, 9);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(84, 27);
            this.buttonAddStudent.TabIndex = 3;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonRemoveStudent
            // 
            this.buttonRemoveStudent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveStudent.Location = new System.Drawing.Point(663, 9);
            this.buttonRemoveStudent.Name = "buttonRemoveStudent";
            this.buttonRemoveStudent.Size = new System.Drawing.Size(100, 27);
            this.buttonRemoveStudent.TabIndex = 4;
            this.buttonRemoveStudent.Text = "Remove Student";
            this.buttonRemoveStudent.UseVisualStyleBackColor = true;
            this.buttonRemoveStudent.Click += new System.EventHandler(this.buttonRemoveStudent_Click);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonRemoveStudent);
            this.Controls.Add(this.buttonAddStudent);
            this.Controls.Add(this.dataGridViewStudents);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentsForm";
            this.Text = "Students Panel";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.dataGridViewStudents, 0);
            this.Controls.SetChildIndex(this.buttonAddStudent, 0);
            this.Controls.SetChildIndex(this.buttonRemoveStudent, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button buttonAddStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn group;
        private System.Windows.Forms.DataGridViewTextBoxColumn scholarship;
        private System.Windows.Forms.DataGridViewTextBoxColumn moneyAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn knowlageLevel;
        private DataGridViewProgressColumn knowlageProgress;
        private System.Windows.Forms.DataGridViewButtonColumn studyButton;
        private System.Windows.Forms.Button buttonRemoveStudent;
    }
}
