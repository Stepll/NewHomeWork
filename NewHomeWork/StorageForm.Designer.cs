namespace NewHomeWork
{
    partial class StorageForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AddButton2 = new System.Windows.Forms.Button();
            this.TaskButton = new System.Windows.Forms.Button();
            this.ProductButton = new System.Windows.Forms.Button();
            this.TextBoxAddress = new System.Windows.Forms.TextBox();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ListStorage = new System.Windows.Forms.ComboBox();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.ButtonEnd = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Gray;
            this.MainPanel.Controls.Add(this.AddButton2);
            this.MainPanel.Controls.Add(this.TaskButton);
            this.MainPanel.Controls.Add(this.ProductButton);
            this.MainPanel.Controls.Add(this.TextBoxAddress);
            this.MainPanel.Controls.Add(this.TextBoxName);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.ActionLabel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.ButtonEnd);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(407, 215);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // AddButton2
            // 
            this.AddButton2.Enabled = false;
            this.AddButton2.Location = new System.Drawing.Point(318, 151);
            this.AddButton2.Name = "AddButton2";
            this.AddButton2.Size = new System.Drawing.Size(75, 23);
            this.AddButton2.TabIndex = 10;
            this.AddButton2.Text = "Add/Edit";
            this.AddButton2.UseVisualStyleBackColor = true;
            this.AddButton2.Click += new System.EventHandler(this.AddButton2_Click);
            // 
            // TaskButton
            // 
            this.TaskButton.Location = new System.Drawing.Point(152, 181);
            this.TaskButton.Name = "TaskButton";
            this.TaskButton.Size = new System.Drawing.Size(75, 23);
            this.TaskButton.TabIndex = 9;
            this.TaskButton.Text = "Task";
            this.TaskButton.UseVisualStyleBackColor = true;
            this.TaskButton.Click += new System.EventHandler(this.TaskButton_Click);
            // 
            // ProductButton
            // 
            this.ProductButton.Enabled = false;
            this.ProductButton.Location = new System.Drawing.Point(152, 152);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(75, 23);
            this.ProductButton.TabIndex = 8;
            this.ProductButton.Text = "Product";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // TextBoxAddress
            // 
            this.TextBoxAddress.Enabled = false;
            this.TextBoxAddress.Location = new System.Drawing.Point(222, 126);
            this.TextBoxAddress.Name = "TextBoxAddress";
            this.TextBoxAddress.Size = new System.Drawing.Size(171, 20);
            this.TextBoxAddress.TabIndex = 7;
            // 
            // TextBoxName
            // 
            this.TextBoxName.Enabled = false;
            this.TextBoxName.Location = new System.Drawing.Point(222, 94);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(171, 20);
            this.TextBoxName.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(152, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(152, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ActionLabel.Location = new System.Drawing.Point(152, 60);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(62, 19);
            this.ActionLabel.TabIndex = 3;
            this.ActionLabel.Text = "Nothing";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.DeleteButton);
            this.panel1.Controls.Add(this.ListStorage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(146, 163);
            this.panel1.TabIndex = 2;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 71);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 100);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 129);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ListStorage
            // 
            this.ListStorage.FormattingEnabled = true;
            this.ListStorage.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.ListStorage.Location = new System.Drawing.Point(12, 6);
            this.ListStorage.Name = "ListStorage";
            this.ListStorage.Size = new System.Drawing.Size(121, 21);
            this.ListStorage.TabIndex = 0;
            this.ListStorage.SelectedIndexChanged += new System.EventHandler(this.ListStorage_SelectedIndexChanged);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TopPanel.Controls.Add(this.StorageLabel);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(407, 52);
            this.TopPanel.TabIndex = 1;
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // StorageLabel
            // 
            this.StorageLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.StorageLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StorageLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StorageLabel.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StorageLabel.Location = new System.Drawing.Point(0, 0);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(407, 52);
            this.StorageLabel.TabIndex = 0;
            this.StorageLabel.Text = "Storage";
            this.StorageLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.StorageLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.StorageLabel_MouseDown);
            this.StorageLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.StorageLabel_MouseMove);
            // 
            // ButtonEnd
            // 
            this.ButtonEnd.Location = new System.Drawing.Point(318, 180);
            this.ButtonEnd.Name = "ButtonEnd";
            this.ButtonEnd.Size = new System.Drawing.Size(75, 23);
            this.ButtonEnd.TabIndex = 0;
            this.ButtonEnd.Text = "OK";
            this.ButtonEnd.UseVisualStyleBackColor = true;
            this.ButtonEnd.Click += new System.EventHandler(this.ButtonEnd_Click);
            // 
            // StorageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 215);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageForm";
            this.Text = "StorageForm";
            this.Load += new System.EventHandler(this.StorageForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button ButtonEnd;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label StorageLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox ListStorage;
        private System.Windows.Forms.Button AddButton2;
        private System.Windows.Forms.Button TaskButton;
        private System.Windows.Forms.Button ProductButton;
        private System.Windows.Forms.TextBox TextBoxAddress;
        private System.Windows.Forms.TextBox TextBoxName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}