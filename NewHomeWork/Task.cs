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
    public partial class Task : Form
    {

        Point lastPoint;

        public Task()
        {
            InitializeComponent();
        }

        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Task_Load(object sender, EventArgs e)
        {

            SQLiteCommand load = StorageNameClass.Conn.CreateCommand();
            load.CommandText = "SELECT name FROM Currency;";
            SQLiteDataReader reader = load.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CurrencyBox.Items.Add(reader["name"]);
                }
            }

            SQLiteCommand load2 = StorageNameClass.Conn.CreateCommand();
            load2.CommandText = "SELECT name FROM Storage;";
            SQLiteDataReader reader2 = load2.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    StorageBox.Items.Add(reader2["name"]);
                }
            }
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            double sum = 0;
            SQLiteCommand load = StorageNameClass.Conn.CreateCommand();
            load.CommandText = $"SELECT P.price_real, PS.number FROM (Product P JOIN Inter_Product_Storage PS ON P.id = PS.id_product) JOIN Storage S ON PS.id_storage = S.id WHERE S.name='{StorageBox.SelectedItem}';";
            SQLiteDataReader reader = load.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    sum += Convert.ToDouble(reader["price_real"]) * Convert.ToDouble(reader["number"]);
                }
            }

            SQLiteCommand load2 = StorageNameClass.Conn.CreateCommand();
            load2.CommandText = $"SELECT rate FROM Currency WHERE name='{CurrencyBox.Text}'";
            SQLiteDataReader reader2 = load2.ExecuteReader();
            reader2.Read();
            sum /= Convert.ToDouble(reader2["rate"]);


            MessageBox.Show(sum.ToString(), "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
