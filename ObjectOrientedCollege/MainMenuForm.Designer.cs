namespace ObjectOrientedCollege
{
    partial class MainMenuForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.label5 = new System.Windows.Forms.Label();
            this.labelCollegeName = new System.Windows.Forms.Label();
            this.labelAddress = new System.Windows.Forms.Label();
            this.buttonStudents = new System.Windows.Forms.Button();
            this.buttonGroups = new System.Windows.Forms.Button();
            this.buttonAudiences = new System.Windows.Forms.Button();
            this.buttonStaff = new System.Windows.Forms.Button();
            this.buttonPayday = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(213, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 55);
            this.label5.TabIndex = 4;
            this.label5.Text = "Welcome to college!";
            // 
            // labelCollegeName
            // 
            this.labelCollegeName.AutoSize = true;
            this.labelCollegeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCollegeName.Location = new System.Drawing.Point(385, 95);
            this.labelCollegeName.Name = "labelCollegeName";
            this.labelCollegeName.Size = new System.Drawing.Size(118, 42);
            this.labelCollegeName.TabIndex = 5;
            this.labelCollegeName.Text = "label6";
            this.labelCollegeName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAddress.Location = new System.Drawing.Point(373, 150);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(120, 24);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "labelAddress";
            this.labelAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonStudents
            // 
            this.buttonStudents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStudents.Location = new System.Drawing.Point(344, 187);
            this.buttonStudents.Name = "buttonStudents";
            this.buttonStudents.Size = new System.Drawing.Size(191, 59);
            this.buttonStudents.TabIndex = 7;
            this.buttonStudents.Text = "Students Panel";
            this.buttonStudents.UseVisualStyleBackColor = true;
            this.buttonStudents.Click += new System.EventHandler(this.buttonStudents_Click);
            // 
            // buttonGroups
            // 
            this.buttonGroups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGroups.Location = new System.Drawing.Point(344, 252);
            this.buttonGroups.Name = "buttonGroups";
            this.buttonGroups.Size = new System.Drawing.Size(191, 59);
            this.buttonGroups.TabIndex = 8;
            this.buttonGroups.Text = "Groups Panel";
            this.buttonGroups.UseVisualStyleBackColor = true;
            this.buttonGroups.Click += new System.EventHandler(this.buttonGroups_Click);
            // 
            // buttonAudiences
            // 
            this.buttonAudiences.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAudiences.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAudiences.Location = new System.Drawing.Point(344, 317);
            this.buttonAudiences.Name = "buttonAudiences";
            this.buttonAudiences.Size = new System.Drawing.Size(191, 59);
            this.buttonAudiences.TabIndex = 9;
            this.buttonAudiences.Text = "Audiences Panel";
            this.buttonAudiences.UseVisualStyleBackColor = true;
            this.buttonAudiences.Click += new System.EventHandler(this.buttonAudiences_Click);
            // 
            // buttonStaff
            // 
            this.buttonStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStaff.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStaff.Location = new System.Drawing.Point(344, 382);
            this.buttonStaff.Name = "buttonStaff";
            this.buttonStaff.Size = new System.Drawing.Size(191, 59);
            this.buttonStaff.TabIndex = 10;
            this.buttonStaff.Text = "Staff Panel";
            this.buttonStaff.UseVisualStyleBackColor = true;
            this.buttonStaff.Click += new System.EventHandler(this.buttonStaff_Click);
            // 
            // buttonPayday
            // 
            this.buttonPayday.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPayday.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPayday.Location = new System.Drawing.Point(618, 252);
            this.buttonPayday.Name = "buttonPayday";
            this.buttonPayday.Size = new System.Drawing.Size(187, 65);
            this.buttonPayday.TabIndex = 11;
            this.buttonPayday.Text = "PayDay!";
            this.buttonPayday.UseVisualStyleBackColor = true;
            this.buttonPayday.Click += new System.EventHandler(this.buttonPayday_Click);
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonPayday);
            this.Controls.Add(this.buttonStaff);
            this.Controls.Add(this.buttonAudiences);
            this.Controls.Add(this.buttonGroups);
            this.Controls.Add(this.buttonStudents);
            this.Controls.Add(this.labelAddress);
            this.Controls.Add(this.labelCollegeName);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "Lab 4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelCollegeName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Button buttonStudents;
        private System.Windows.Forms.Button buttonGroups;
        private System.Windows.Forms.Button buttonAudiences;
        private System.Windows.Forms.Button buttonStaff;
        private System.Windows.Forms.Button buttonPayday;
    }
}

