namespace ObjectOrientedCollege
{
    partial class AddAudienceForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAudienceForm));
            this.buttonAddAudience = new System.Windows.Forms.Button();
            this.labelNote = new System.Windows.Forms.Label();
            this.textBoxClearness = new System.Windows.Forms.TextBox();
            this.labelClearness = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxRoomNumber = new System.Windows.Forms.TextBox();
            this.labelRoomNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddAudience
            // 
            this.buttonAddAudience.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAudience.Location = new System.Drawing.Point(136, 148);
            this.buttonAddAudience.Name = "buttonAddAudience";
            this.buttonAddAudience.Size = new System.Drawing.Size(84, 23);
            this.buttonAddAudience.TabIndex = 50;
            this.buttonAddAudience.Text = "Add Audience";
            this.buttonAddAudience.UseVisualStyleBackColor = true;
            this.buttonAddAudience.Click += new System.EventHandler(this.buttonAddAudience_Click);
            // 
            // labelNote
            // 
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNote.Location = new System.Drawing.Point(112, 189);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(128, 16);
            this.labelNote.TabIndex = 49;
            this.labelNote.Text = "* - unnecesary fields";
            // 
            // textBoxClearness
            // 
            this.textBoxClearness.Location = new System.Drawing.Point(192, 110);
            this.textBoxClearness.Name = "textBoxClearness";
            this.textBoxClearness.Size = new System.Drawing.Size(100, 20);
            this.textBoxClearness.TabIndex = 40;
            this.textBoxClearness.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelClearness
            // 
            this.labelClearness.AutoSize = true;
            this.labelClearness.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelClearness.Location = new System.Drawing.Point(89, 110);
            this.labelClearness.Name = "labelClearness";
            this.labelClearness.Size = new System.Drawing.Size(90, 20);
            this.labelClearness.TabIndex = 39;
            this.labelClearness.Text = "Clearness*:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(90, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(182, 31);
            this.labelTitle.TabIndex = 38;
            this.labelTitle.Text = "Add Audience";
            // 
            // textBoxRoomNumber
            // 
            this.textBoxRoomNumber.Location = new System.Drawing.Point(192, 73);
            this.textBoxRoomNumber.Name = "textBoxRoomNumber";
            this.textBoxRoomNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxRoomNumber.TabIndex = 37;
            this.textBoxRoomNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelRoomNumber
            // 
            this.labelRoomNumber.AutoSize = true;
            this.labelRoomNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRoomNumber.Location = new System.Drawing.Point(39, 73);
            this.labelRoomNumber.Name = "labelRoomNumber";
            this.labelRoomNumber.Size = new System.Drawing.Size(140, 20);
            this.labelRoomNumber.TabIndex = 36;
            this.labelRoomNumber.Text = "Audience Number:";
            // 
            // AddAudienceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 215);
            this.Controls.Add(this.buttonAddAudience);
            this.Controls.Add(this.labelNote);
            this.Controls.Add(this.textBoxClearness);
            this.Controls.Add(this.labelClearness);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxRoomNumber);
            this.Controls.Add(this.labelRoomNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAudienceForm";
            this.Text = "Add Audience";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAudience;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.TextBox textBoxClearness;
        private System.Windows.Forms.Label labelClearness;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxRoomNumber;
        private System.Windows.Forms.Label labelRoomNumber;
    }
}