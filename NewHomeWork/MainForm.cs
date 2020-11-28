using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace NewHomeWork
{
    public partial class MainForm : Form
    {

        Point lastPoint;

        private SQLiteConnection Connection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.Red;
        }

        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            CloseLabel.ForeColor = Color.White;
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
            
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StorageNameClass.Conn = new SQLiteConnection("Data Source=BD.db; Version=3");
            StorageNameClass.Conn.Open();


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StorageNameClass.Conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            AnswerBox.Clear();
            SQLiteCommand Find = Connection.CreateCommand();
            Find.CommandText = $"SELECT S.name  FROM (Product P JOIN Inter_Product_Storage PS ON P.id = PS.id_product) JOIN Storage S ON PS.id_storage = S.id WHERE P.name='{TextBoxFind.Text}';";
            //Find.ExecuteNonQuery(); for insert
            SQLiteDataReader reader = Find.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    AnswerBox.Text += "strage: " + reader["name"] + "\r\n";
                }
            }
            else
                AnswerBox.Text = "entry not found";
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
            StorageForm frm2 = new StorageForm(); 
            frm2.Show();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            ProductForm frm2 = new ProductForm();
            frm2.Show();
        }
    }
}
