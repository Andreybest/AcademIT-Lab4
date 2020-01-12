namespace ObjectOrientedCollege
{
    partial class GroupsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupsForm));
            this.dataGridViewGroups = new System.Windows.Forms.DataGridView();
            this.groupNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.headman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createRaportButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addHeadmanButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonAddGroup = new System.Windows.Forms.Button();
            this.buttonRemoveGroup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Location = new System.Drawing.Point(398, 6);
            this.labelTitle.Size = new System.Drawing.Size(111, 33);
            this.labelTitle.Text = "Groups";
            // 
            // dataGridViewGroups
            // 
            this.dataGridViewGroups.AllowUserToAddRows = false;
            this.dataGridViewGroups.AllowUserToDeleteRows = false;
            this.dataGridViewGroups.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGroups.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.groupNumber,
            this.headman,
            this.studentAmount,
            this.createRaportButton,
            this.addHeadmanButton});
            this.dataGridViewGroups.EnableHeadersVisualStyles = false;
            this.dataGridViewGroups.Location = new System.Drawing.Point(188, 76);
            this.dataGridViewGroups.MultiSelect = false;
            this.dataGridViewGroups.Name = "dataGridViewGroups";
            this.dataGridViewGroups.ReadOnly = true;
            this.dataGridViewGroups.RowHeadersVisible = false;
            this.dataGridViewGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGroups.Size = new System.Drawing.Size(513, 349);
            this.dataGridViewGroups.TabIndex = 3;
            this.dataGridViewGroups.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewGroups_CellContentClick);
            // 
            // groupNumber
            // 
            this.groupNumber.HeaderText = "Group Number";
            this.groupNumber.Name = "groupNumber";
            this.groupNumber.ReadOnly = true;
            this.groupNumber.Width = 50;
            // 
            // headman
            // 
            this.headman.HeaderText = "Headman";
            this.headman.Name = "headman";
            this.headman.ReadOnly = true;
            this.headman.Width = 200;
            // 
            // studentAmount
            // 
            this.studentAmount.HeaderText = "Student Amount";
            this.studentAmount.Name = "studentAmount";
            this.studentAmount.ReadOnly = true;
            this.studentAmount.Width = 60;
            // 
            // createRaportButton
            // 
            this.createRaportButton.HeaderText = "Create Raport";
            this.createRaportButton.Name = "createRaportButton";
            this.createRaportButton.ReadOnly = true;
            this.createRaportButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.createRaportButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // addHeadmanButton
            // 
            this.addHeadmanButton.HeaderText = "Add Headman";
            this.addHeadmanButton.Name = "addHeadmanButton";
            this.addHeadmanButton.ReadOnly = true;
            this.addHeadmanButton.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.addHeadmanButton.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // buttonAddGroup
            // 
            this.buttonAddGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddGroup.Location = new System.Drawing.Point(797, 11);
            this.buttonAddGroup.Name = "buttonAddGroup";
            this.buttonAddGroup.Size = new System.Drawing.Size(75, 23);
            this.buttonAddGroup.TabIndex = 4;
            this.buttonAddGroup.Text = "Add Group";
            this.buttonAddGroup.UseVisualStyleBackColor = true;
            this.buttonAddGroup.Click += new System.EventHandler(this.buttonAddGroup_Click);
            // 
            // buttonRemoveGroup
            // 
            this.buttonRemoveGroup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoveGroup.Location = new System.Drawing.Point(700, 11);
            this.buttonRemoveGroup.Name = "buttonRemoveGroup";
            this.buttonRemoveGroup.Size = new System.Drawing.Size(91, 23);
            this.buttonRemoveGroup.TabIndex = 5;
            this.buttonRemoveGroup.Text = "Remove Group";
            this.buttonRemoveGroup.UseVisualStyleBackColor = true;
            this.buttonRemoveGroup.Click += new System.EventHandler(this.buttonRemoveGroup_Click);
            // 
            // GroupsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonRemoveGroup);
            this.Controls.Add(this.buttonAddGroup);
            this.Controls.Add(this.dataGridViewGroups);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GroupsForm";
            this.Text = "Groups Panel";
            this.Controls.SetChildIndex(this.labelTitle, 0);
            this.Controls.SetChildIndex(this.dataGridViewGroups, 0);
            this.Controls.SetChildIndex(this.buttonAddGroup, 0);
            this.Controls.SetChildIndex(this.buttonRemoveGroup, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGroups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGroups;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn headman;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentAmount;
        private System.Windows.Forms.DataGridViewButtonColumn createRaportButton;
        private System.Windows.Forms.DataGridViewButtonColumn addHeadmanButton;
        private System.Windows.Forms.Button buttonAddGroup;
        private System.Windows.Forms.Button buttonRemoveGroup;
    }
}
