namespace ObjectOrientedCollege
{
    partial class TemplateForm
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
            this.labelMenuButton = new System.Windows.Forms.Label();
            this.labelLine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelMenuButton
            // 
            this.labelMenuButton.AutoSize = true;
            this.labelMenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenuButton.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMenuButton.Location = new System.Drawing.Point(6, 6);
            this.labelMenuButton.Name = "labelMenuButton";
            this.labelMenuButton.Size = new System.Drawing.Size(213, 31);
            this.labelMenuButton.TabIndex = 0;
            this.labelMenuButton.Text = "← Back to menu";
            this.labelMenuButton.Click += new System.EventHandler(this.labelMenuButton_Click);
            // 
            // labelLine
            // 
            this.labelLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLine.Location = new System.Drawing.Point(0, 42);
            this.labelLine.Name = "labelLine";
            this.labelLine.Size = new System.Drawing.Size(220, 2);
            this.labelLine.TabIndex = 1;
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.labelLine);
            this.Controls.Add(this.labelMenuButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TemplateForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TemplateForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuButton;
        private System.Windows.Forms.Label labelLine;
    }
}