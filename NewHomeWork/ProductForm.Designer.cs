namespace NewHomeWork
{
    partial class ProductForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddEditButton = new System.Windows.Forms.Button();
            this.CurrencyList = new System.Windows.Forms.ComboBox();
            this.CategoryList = new System.Windows.Forms.ComboBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ActionLabel = new System.Windows.Forms.Label();
            this.EndButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ProductList = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameFormLabel = new System.Windows.Forms.Label();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.Pic);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.AddEditButton);
            this.panel1.Controls.Add(this.CurrencyList);
            this.panel1.Controls.Add(this.CategoryList);
            this.panel1.Controls.Add(this.PriceBox);
            this.panel1.Controls.Add(this.NameBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ActionLabel);
            this.panel1.Controls.Add(this.EndButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(438, 246);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(140, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "Currency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(141, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(140, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 19);
            this.label1.TabIndex = 13;
            this.label1.Text = "Category";
            // 
            // AddEditButton
            // 
            this.AddEditButton.Location = new System.Drawing.Point(242, 210);
            this.AddEditButton.Name = "AddEditButton";
            this.AddEditButton.Size = new System.Drawing.Size(75, 23);
            this.AddEditButton.TabIndex = 12;
            this.AddEditButton.Text = "Add/Edit";
            this.AddEditButton.UseVisualStyleBackColor = true;
            this.AddEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // CurrencyList
            // 
            this.CurrencyList.FormattingEnabled = true;
            this.CurrencyList.Location = new System.Drawing.Point(217, 181);
            this.CurrencyList.Name = "CurrencyList";
            this.CurrencyList.Size = new System.Drawing.Size(100, 21);
            this.CurrencyList.TabIndex = 11;
            // 
            // CategoryList
            // 
            this.CategoryList.FormattingEnabled = true;
            this.CategoryList.Location = new System.Drawing.Point(217, 126);
            this.CategoryList.Name = "CategoryList";
            this.CategoryList.Size = new System.Drawing.Size(100, 21);
            this.CategoryList.TabIndex = 10;
            // 
            // PriceBox
            // 
            this.PriceBox.Location = new System.Drawing.Point(217, 154);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(100, 20);
            this.PriceBox.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(217, 97);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(100, 20);
            this.NameBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(141, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // ActionLabel
            // 
            this.ActionLabel.AutoSize = true;
            this.ActionLabel.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ActionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ActionLabel.Location = new System.Drawing.Point(141, 64);
            this.ActionLabel.Name = "ActionLabel";
            this.ActionLabel.Size = new System.Drawing.Size(75, 22);
            this.ActionLabel.TabIndex = 3;
            this.ActionLabel.Text = "Nothing";
            // 
            // EndButton
            // 
            this.EndButton.Location = new System.Drawing.Point(348, 211);
            this.EndButton.Name = "EndButton";
            this.EndButton.Size = new System.Drawing.Size(75, 23);
            this.EndButton.TabIndex = 2;
            this.EndButton.Text = "OK";
            this.EndButton.UseVisualStyleBackColor = true;
            this.EndButton.Click += new System.EventHandler(this.EndButton_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel3.Controls.Add(this.AddButton);
            this.panel3.Controls.Add(this.EditButton);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.ProductList);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 57);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(134, 189);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(12, 95);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 3;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(12, 124);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 2;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(12, 153);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ProductList
            // 
            this.ProductList.FormattingEnabled = true;
            this.ProductList.Location = new System.Drawing.Point(13, 7);
            this.ProductList.Name = "ProductList";
            this.ProductList.Size = new System.Drawing.Size(104, 21);
            this.ProductList.TabIndex = 0;
            this.ProductList.SelectedIndexChanged += new System.EventHandler(this.ProductList_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.NameFormLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(438, 57);
            this.panel2.TabIndex = 0;
            // 
            // NameFormLabel
            // 
            this.NameFormLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.NameFormLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameFormLabel.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameFormLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NameFormLabel.Location = new System.Drawing.Point(0, 0);
            this.NameFormLabel.Name = "NameFormLabel";
            this.NameFormLabel.Size = new System.Drawing.Size(438, 57);
            this.NameFormLabel.TabIndex = 0;
            this.NameFormLabel.Text = "Product";
            this.NameFormLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameFormLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NameFormLabel_MouseDown);
            this.NameFormLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.NameFormLabel_MouseMove);
            // 
            // Pic
            // 
            this.Pic.BackColor = System.Drawing.Color.White;
            this.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Pic.Location = new System.Drawing.Point(323, 96);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(100, 108);
            this.Pic.TabIndex = 16;
            this.Pic.TabStop = false;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 246);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button EndButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label NameFormLabel;
        private System.Windows.Forms.Button AddEditButton;
        private System.Windows.Forms.ComboBox CurrencyList;
        private System.Windows.Forms.ComboBox CategoryList;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ActionLabel;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.ComboBox ProductList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.PictureBox Pic;
    }
}