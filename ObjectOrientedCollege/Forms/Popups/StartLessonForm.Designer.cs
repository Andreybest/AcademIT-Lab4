namespace ObjectOrientedCollege
{
    partial class StartLessonForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartLessonForm));
            this.comboBoxTeachers = new System.Windows.Forms.ComboBox();
            this.labelTeacher = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonStartLesson = new System.Windows.Forms.Button();
            this.comboBoxAudiences = new System.Windows.Forms.ComboBox();
            this.labelAudience = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxTeachers
            // 
            this.comboBoxTeachers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeachers.FormattingEnabled = true;
            this.comboBoxTeachers.Location = new System.Drawing.Point(171, 77);
            this.comboBoxTeachers.Name = "comboBoxTeachers";
            this.comboBoxTeachers.Size = new System.Drawing.Size(100, 21);
            this.comboBoxTeachers.TabIndex = 38;
            // 
            // labelTeacher
            // 
            this.labelTeacher.AutoSize = true;
            this.labelTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTeacher.Location = new System.Drawing.Point(86, 78);
            this.labelTeacher.Name = "labelTeacher";
            this.labelTeacher.Size = new System.Drawing.Size(71, 20);
            this.labelTeacher.TabIndex = 37;
            this.labelTeacher.Text = "Teacher:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(96, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(167, 31);
            this.labelTitle.TabIndex = 36;
            this.labelTitle.Text = "Start Lesson";
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(171, 112);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGroups.TabIndex = 40;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(99, 112);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(58, 20);
            this.labelGroup.TabIndex = 39;
            this.labelGroup.Text = "Group:";
            // 
            // buttonStartLesson
            // 
            this.buttonStartLesson.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartLesson.Location = new System.Drawing.Point(128, 197);
            this.buttonStartLesson.Name = "buttonStartLesson";
            this.buttonStartLesson.Size = new System.Drawing.Size(75, 23);
            this.buttonStartLesson.TabIndex = 41;
            this.buttonStartLesson.Text = "Start Lesson";
            this.buttonStartLesson.UseVisualStyleBackColor = true;
            this.buttonStartLesson.Click += new System.EventHandler(this.buttonStartLesson_Click);
            // 
            // comboBoxAudiences
            // 
            this.comboBoxAudiences.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudiences.FormattingEnabled = true;
            this.comboBoxAudiences.Location = new System.Drawing.Point(171, 149);
            this.comboBoxAudiences.Name = "comboBoxAudiences";
            this.comboBoxAudiences.Size = new System.Drawing.Size(100, 21);
            this.comboBoxAudiences.TabIndex = 43;
            // 
            // labelAudience
            // 
            this.labelAudience.AutoSize = true;
            this.labelAudience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAudience.Location = new System.Drawing.Point(77, 149);
            this.labelAudience.Name = "labelAudience";
            this.labelAudience.Size = new System.Drawing.Size(80, 20);
            this.labelAudience.TabIndex = 42;
            this.labelAudience.Text = "Audience:";
            // 
            // StartLessonForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 232);
            this.Controls.Add(this.comboBoxAudiences);
            this.Controls.Add(this.labelAudience);
            this.Controls.Add(this.buttonStartLesson);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.comboBoxTeachers);
            this.Controls.Add(this.labelTeacher);
            this.Controls.Add(this.labelTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "StartLessonForm";
            this.Text = "Teach Group";
            this.Load += new System.EventHandler(this.StartLessonForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTeachers;
        private System.Windows.Forms.Label labelTeacher;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonStartLesson;
        private System.Windows.Forms.ComboBox comboBoxAudiences;
        private System.Windows.Forms.Label labelAudience;
    }
}