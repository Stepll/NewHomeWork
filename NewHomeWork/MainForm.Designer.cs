namespace NewHomeWork
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.TextBoxFind = new System.Windows.Forms.TextBox();
            this.ButtonFind = new System.Windows.Forms.Button();
            this.AnswerBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DimGray;
            this.MainPanel.Controls.Add(this.ProductButton);
            this.MainPanel.Controls.Add(this.button1);
            this.MainPanel.Controls.Add(this.TextBoxFind);
            this.MainPanel.Controls.Add(this.ButtonFind);
            this.MainPanel.Controls.Add(this.AnswerBox);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(545, 417);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Storage";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TextBoxFind
            // 
            this.TextBoxFind.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxFind.Location = new System.Drawing.Point(12, 71);
            this.TextBoxFind.Name = "TextBoxFind";
            this.TextBoxFind.Size = new System.Drawing.Size(100, 20);
            this.TextBoxFind.TabIndex = 3;
            // 
            // ButtonFind
            // 
            this.ButtonFind.BackColor = System.Drawing.Color.DarkGray;
            this.ButtonFind.FlatAppearance.BorderSize = 0;
            this.ButtonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonFind.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ButtonFind.Location = new System.Drawing.Point(12, 97);
            this.ButtonFind.Name = "ButtonFind";
            this.ButtonFind.Size = new System.Drawing.Size(75, 23);
            this.ButtonFind.TabIndex = 2;
            this.ButtonFind.Text = "Find";
            this.ButtonFind.UseVisualStyleBackColor = false;
            this.ButtonFind.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnswerBox
            // 
            this.AnswerBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AnswerBox.Enabled = false;
            this.AnswerBox.Location = new System.Drawing.Point(12, 126);
            this.AnswerBox.Multiline = true;
            this.AnswerBox.Name = "AnswerBox";
            this.AnswerBox.Size = new System.Drawing.Size(196, 110);
            this.AnswerBox.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.CloseLabel);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 64);
            this.panel2.TabIndex = 0;
            // 
            // CloseLabel
            // 
            this.CloseLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(528, 0);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(17, 19);
            this.CloseLabel.TabIndex = 1;
            this.CloseLabel.Text = "X";
            this.CloseLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            this.CloseLabel.MouseEnter += new System.EventHandler(this.CloseLabel_MouseEnter);
            this.CloseLabel.MouseLeave += new System.EventHandler(this.CloseLabel_MouseLeave);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            // 
            // ProductButton
            // 
            this.ProductButton.Location = new System.Drawing.Point(458, 96);
            this.ProductButton.Name = "ProductButton";
            this.ProductButton.Size = new System.Drawing.Size(75, 23);
            this.ProductButton.TabIndex = 5;
            this.ProductButton.Text = "Product";
            this.ProductButton.UseVisualStyleBackColor = true;
            this.ProductButton.Click += new System.EventHandler(this.ProductButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 417);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxFind;
        private System.Windows.Forms.Button ButtonFind;
        private System.Windows.Forms.TextBox AnswerBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ProductButton;
    }
}