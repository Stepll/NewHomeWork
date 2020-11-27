namespace NewHomeWork
{
    partial class StorageProduct
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxNum = new System.Windows.Forms.TextBox();
            this.NumLabel = new System.Windows.Forms.Label();
            this.StorageLabel = new System.Windows.Forms.Label();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Brown;
            this.panel1.Controls.Add(this.EditButton);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.TextBoxNum);
            this.panel1.Controls.Add(this.NumLabel);
            this.panel1.Controls.Add(this.StorageLabel);
            this.panel1.Controls.Add(this.ProductList);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 139);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(213, 74);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(213, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TextBoxNum
            // 
            this.TextBoxNum.Location = new System.Drawing.Point(188, 48);
            this.TextBoxNum.Name = "TextBoxNum";
            this.TextBoxNum.Size = new System.Drawing.Size(100, 20);
            this.TextBoxNum.TabIndex = 3;
            // 
            // NumLabel
            // 
            this.NumLabel.AutoSize = true;
            this.NumLabel.ForeColor = System.Drawing.Color.Snow;
            this.NumLabel.Location = new System.Drawing.Point(147, 51);
            this.NumLabel.Name = "NumLabel";
            this.NumLabel.Size = new System.Drawing.Size(29, 13);
            this.NumLabel.TabIndex = 2;
            this.NumLabel.Text = "Num";
            // 
            // StorageLabel
            // 
            this.StorageLabel.AutoSize = true;
            this.StorageLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StorageLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.StorageLabel.Location = new System.Drawing.Point(12, 9);
            this.StorageLabel.Name = "StorageLabel";
            this.StorageLabel.Size = new System.Drawing.Size(103, 31);
            this.StorageLabel.TabIndex = 1;
            this.StorageLabel.Text = "Storage";
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(12, 47);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(121, 21);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // StorageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 139);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StorageProduct";
            this.Text = "StorageProduct";
            this.Load += new System.EventHandler(this.StorageProduct_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TextBoxNum;
        private System.Windows.Forms.Label NumLabel;
        private System.Windows.Forms.Label StorageLabel;
        private System.Windows.Forms.ComboBox ProductList;
    }
}