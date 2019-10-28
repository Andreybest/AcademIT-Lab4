namespace ObjectOrientedCollege
{
    partial class AddHeadmanForm
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
            this.comboBoxGroups = new System.Windows.Forms.ComboBox();
            this.labelGroup = new System.Windows.Forms.Label();
            this.buttonAddHeadman = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxKnowlageLevel = new System.Windows.Forms.TextBox();
            this.labelKnowlageLevel = new System.Windows.Forms.Label();
            this.textBoxScholarship = new System.Windows.Forms.TextBox();
            this.labelScholarship = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxGroups
            // 
            this.comboBoxGroups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGroups.FormattingEnabled = true;
            this.comboBoxGroups.Location = new System.Drawing.Point(180, 213);
            this.comboBoxGroups.Name = "comboBoxGroups";
            this.comboBoxGroups.Size = new System.Drawing.Size(100, 21);
            this.comboBoxGroups.TabIndex = 35;
            // 
            // labelGroup
            // 
            this.labelGroup.AutoSize = true;
            this.labelGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroup.Location = new System.Drawing.Point(95, 214);
            this.labelGroup.Name = "labelGroup";
            this.labelGroup.Size = new System.Drawing.Size(58, 20);
            this.labelGroup.TabIndex = 34;
            this.labelGroup.Text = "Group:";
            // 
            // buttonAddHeadman
            // 
            this.buttonAddHeadman.Location = new System.Drawing.Point(129, 318);
            this.buttonAddHeadman.Name = "buttonAddHeadman";
            this.buttonAddHeadman.Size = new System.Drawing.Size(84, 23);
            this.buttonAddHeadman.TabIndex = 33;
            this.buttonAddHeadman.Text = "Add Headman";
            this.buttonAddHeadman.UseVisualStyleBackColor = true;
            this.buttonAddHeadman.Click += new System.EventHandler(this.buttonAddHeadman_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNote.Location = new System.Drawing.Point(108, 359);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(128, 16);
            this.labelNote.TabIndex = 32;
            this.labelNote.Text = "* - unnecesary fields";
            // 
            // textBoxKnowlageLevel
            // 
            this.textBoxKnowlageLevel.Location = new System.Drawing.Point(180, 277);
            this.textBoxKnowlageLevel.Name = "textBoxKnowlageLevel";
            this.textBoxKnowlageLevel.Size = new System.Drawing.Size(100, 20);
            this.textBoxKnowlageLevel.TabIndex = 31;
            this.textBoxKnowlageLevel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelKnowlageLevel
            // 
            this.labelKnowlageLevel.AutoSize = true;
            this.labelKnowlageLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKnowlageLevel.Location = new System.Drawing.Point(38, 277);
            this.labelKnowlageLevel.Name = "labelKnowlageLevel";
            this.labelKnowlageLevel.Size = new System.Drawing.Size(129, 20);
            this.labelKnowlageLevel.TabIndex = 30;
            this.labelKnowlageLevel.Text = "Knowlage Level*:";
            // 
            // textBoxScholarship
            // 
            this.textBoxScholarship.Location = new System.Drawing.Point(180, 244);
            this.textBoxScholarship.Name = "textBoxScholarship";
            this.textBoxScholarship.Size = new System.Drawing.Size(100, 20);
            this.textBoxScholarship.TabIndex = 29;
            this.textBoxScholarship.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelScholarship
            // 
            this.labelScholarship.AutoSize = true;
            this.labelScholarship.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelScholarship.Location = new System.Drawing.Point(65, 244);
            this.labelScholarship.Name = "labelScholarship";
            this.labelScholarship.Size = new System.Drawing.Size(102, 20);
            this.labelScholarship.TabIndex = 28;
            this.labelScholarship.Text = "Scholarship*:";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(180, 181);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxPhoneNumber.TabIndex = 27;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhoneNumber.Location = new System.Drawing.Point(48, 179);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(119, 20);
            this.labelPhoneNumber.TabIndex = 26;
            this.labelPhoneNumber.Text = "Phone Number:";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(180, 146);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(100, 20);
            this.textBoxAge.TabIndex = 25;
            this.textBoxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAge.Location = new System.Drawing.Point(125, 146);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(42, 20);
            this.labelAge.TabIndex = 24;
            this.labelAge.Text = "Age:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(180, 110);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastName.TabIndex = 23;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLastName.Location = new System.Drawing.Point(77, 110);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(90, 20);
            this.labelLastName.TabIndex = 22;
            this.labelLastName.Text = "Last Name:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(86, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(186, 31);
            this.labelTitle.TabIndex = 21;
            this.labelTitle.Text = "Add Headman";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(180, 73);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFirstName.TabIndex = 20;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstName.Location = new System.Drawing.Point(77, 73);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(90, 20);
            this.labelFirstName.TabIndex = 19;
            this.labelFirstName.Text = "First Name:";
            // 
            // AddHeadmanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 384);
            this.Controls.Add(this.comboBoxGroups);
            this.Controls.Add(this.labelGroup);
            this.Controls.Add(this.buttonAddHeadman);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxKnowlageLevel);
            this.Controls.Add(this.labelKnowlageLevel);
            this.Controls.Add(this.textBoxScholarship);
            this.Controls.Add(this.labelScholarship);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.labelPhoneNumber);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.labelLastName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelFirstName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddHeadmanForm";
            this.Text = "AddHeadmanForm";
            this.Load += new System.EventHandler(this.AddHeadmanForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxGroups;
        private System.Windows.Forms.Label labelGroup;
        private System.Windows.Forms.Button buttonAddHeadman;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxKnowlageLevel;
        private System.Windows.Forms.Label labelKnowlageLevel;
        private System.Windows.Forms.TextBox textBoxScholarship;
        private System.Windows.Forms.Label labelScholarship;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
    }
}