using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
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
            DateTime date = DateTime.Today;
            DateLabel.Text = date.ToShortDateString();
            StorageNameClass.Conn = new SQLiteConnection("Data Source=BD.db; Version=3");
            StorageNameClass.Conn.Open();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange?json");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);
            string Data = reader.ReadToEnd();
            response.Close();

            dynamic d = JsonConvert.DeserializeObject(Data);
            double UAN = 1, USD = 1, EUR = 1, cUAN = 0, cEUR = 0;
            DateTime dateDB = new DateTime();
            for (int i = 1; i < 50; i++)
            {
                if (d[i].cc == "USD")
                {
                    USD = Convert.ToDouble(d[i].rate);
                }
                if (d[i].cc == "EUR")
                {
                    EUR = Convert.ToDouble(d[i].rate);
                }
            }
            UAN /= USD;
            EUR /= USD;

            //InfoLabel.Text = $"UAN: {Convert.ToString(Math.Round(UAN, 5))}    EUR: {Convert.ToString(Math.Round(EUR, 5))}";
            
            SQLiteCommand ratenow = StorageNameClass.Conn.CreateCommand();
            ratenow.CommandText = $"SELECT code, rate, uptodate FROM Currency";
            SQLiteDataReader reader2 = ratenow.ExecuteReader();
            if (reader2.HasRows)
            {
               
                while (reader2.Read())
                {
                    dateDB = Convert.ToDateTime(reader2["uptodate"]);
                    if (reader2["code"].ToString() == "UAN")
                        cUAN = Convert.ToDouble(reader2["rate"]);
                    if (reader2["code"].ToString() == "EUR")
                        cEUR = Convert.ToDouble(reader2["rate"]);
                }
            }

            if (date != dateDB)
            {
                DialogResult res = MessageBox.Show("Update rate?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (res == DialogResult.Yes)
                {
                    SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
                    Add.CommandText = $"UPDATE Currency SET uptodate = '{date}';";
                    Add.ExecuteNonQuery();

                    // UAN 
                    SQLiteCommand Add2 = StorageNameClass.Conn.CreateCommand();
                    Add2.CommandText = $"UPDATE Currency SET rate = '{UAN}' WHERE code='UAN';";
                    Add2.ExecuteNonQuery();
                    cUAN = UAN;

                    // EUR
                    SQLiteCommand Add3 = StorageNameClass.Conn.CreateCommand();
                    Add3.CommandText = $"UPDATE Currency SET rate = '{EUR}' WHERE code='EUR';";
                    Add3.ExecuteNonQuery();
                    cEUR = EUR;
                }
            }
            InfoLabel.Text = $"UAN: {Math.Round(cUAN, 5).ToString()}    EUR: {Math.Round(cEUR, 5).ToString()}    update: {dateDB.ToShortDateString()}";


        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StorageNameClass.Conn.Close();
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

        private void CategoryButton_Click(object sender, EventArgs e)
        {
            CategoryForm frm2 = new CategoryForm();
            frm2.Show();
        }
    }
}
