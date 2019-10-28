namespace ObjectOrientedCollege
{
    partial class AddGroupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddGroupForm));
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textBoxGroupNumber = new System.Windows.Forms.TextBox();
            this.labelGroupNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGroup.Location = new System.Drawing.Point(149, 112);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(67, 23);
            this.buttonAddGroup.TabIndex = 56;
            this.buttonAddGroup.Text = "Add Group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(113, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(144, 31);
            this.labelTitle.TabIndex = 53;
            this.labelTitle.Text = "Add Group";
            // 
            // textBoxGroupNumber
            // 
            this.textBoxGroupNumber.Location = new System.Drawing.Point(193, 73);
            this.textBoxGroupNumber.Name = "textBoxGroupNumber";
            this.textBoxGroupNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxGroupNumber.TabIndex = 52;
            this.textBoxGroupNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_KeyPress_NumberCheck);
            // 
            // labelGroupNumber
            // 
            this.labelGroupNumber.AutoSize = true;
            this.labelGroupNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGroupNumber.Location = new System.Drawing.Point(62, 71);
            this.labelGroupNumber.Name = "labelGroupNumber";
            this.labelGroupNumber.Size = new System.Drawing.Size(118, 20);
            this.labelGroupNumber.TabIndex = 51;
            this.labelGroupNumber.Text = "Group Number:";
            // 
            // AddGroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 147);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textBoxGroupNumber);
            this.Controls.Add(this.labelGroupNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddGroupForm";
            this.Text = "Add Group";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textBoxGroupNumber;
        private System.Windows.Forms.Label labelGroupNumber;
    }
}