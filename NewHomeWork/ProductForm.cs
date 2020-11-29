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
using ZXing;

namespace NewHomeWork
{
    public partial class ProductForm : Form
    {
        Point lastPoint;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void NameFormLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void NameFormLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void panel3_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        void UpdateBox()
        {
            ProductList.Items.Clear();
            CategoryList.Items.Clear();
            CurrencyList.Items.Clear();
            NameBox.Clear();
            PriceBox.Clear();
            SQLiteCommand product = StorageNameClass.Conn.CreateCommand();
            product.CommandText = "SELECT name FROM Product;";
            SQLiteDataReader reader = product.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductList.Items.Add(reader["name"]);
                }
            }

            SQLiteCommand category = StorageNameClass.Conn.CreateCommand();
            category.CommandText = "SELECT name FROM Category;";
            SQLiteDataReader reader2 = category.ExecuteReader();
            if (reader2.HasRows)
            {
                while (reader2.Read())
                {
                    CategoryList.Items.Add(reader2["name"]);
                }
            }

            SQLiteCommand currency = StorageNameClass.Conn.CreateCommand();
            currency.CommandText = "SELECT name FROM Currency;";
            SQLiteDataReader reader3 = currency.ExecuteReader();
            if (reader3.HasRows)
            {
                while (reader3.Read())
                {
                    CurrencyList.Items.Add(reader3["name"]);
                }
            }
            ProductList.SelectedIndex = 0;
            CategoryList.SelectedIndex = 0;
            CurrencyList.SelectedIndex = 0;
        }

        void DefaultStat()
        {
            ActionLabel.Text = "Nothing";
            NameBox.Enabled = false;
            CategoryList.Enabled = false;
            PriceBox.Enabled = false;
            CurrencyList.Enabled = false;
            AddEditButton.Enabled = false;
            ProductList.Enabled = true;
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            UpdateBox();
            DefaultStat();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ActionLabel.Text != "Add")
            {
                ActionLabel.Text = "Add";
                NameBox.Enabled = true;
                CategoryList.Enabled = true;
                PriceBox.Enabled = true;
                CurrencyList.Enabled = true;
                AddEditButton.Enabled = true;
                ProductList.Enabled = false;
                NameBox.Clear();
                PriceBox.Clear();
            }
            else 
            {
                UpdateBox();
                DefaultStat();
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ActionLabel.Text != "Edit")
            {
                ActionLabel.Text = "Edit";
                NameBox.Enabled = true;
                CategoryList.Enabled = true;
                PriceBox.Enabled = true;
                CurrencyList.Enabled = true;
                AddEditButton.Enabled = true;
                ProductList.Enabled = false;

                SQLiteCommand product = StorageNameClass.Conn.CreateCommand();
                product.CommandText = $"SELECT P.name a, P.price_main b, Ct.Name c, C.name d FROM (Product P JOIN Category Ct ON P.id_category=Ct.id) JOIN Currency C ON P.id_currency=C.id WHERE P.name='{ProductList.SelectedItem}';";
                SQLiteDataReader reader = product.ExecuteReader();
                reader.Read();
                NameBox.Text = reader["a"].ToString();
                PriceBox.Text = reader["b"].ToString();
                CategoryList.Text = reader["c"].ToString();
                CurrencyList.Text = reader["d"].ToString();
            }
            else 
            {
                UpdateBox();
                DefaultStat();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            ActionLabel.Text = "Delete";


            DialogResult res = MessageBox.Show("Delete?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                int id = 0;
                SQLiteCommand getid = StorageNameClass.Conn.CreateCommand();
                getid.CommandText = $"SELECT id FROM Product WHERE name='{ProductList.SelectedItem}';";
                SQLiteDataReader reader = getid.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = Convert.ToInt32(reader["id"]);
                }

                SQLiteCommand Delete0 = StorageNameClass.Conn.CreateCommand();
                Delete0.CommandText = $"DELETE FROM Inter_Product_Storage WHERE id_product={id};";
                Delete0.ExecuteNonQuery();

                SQLiteCommand Delete = StorageNameClass.Conn.CreateCommand();
                Delete.CommandText = $"DELETE FROM Product WHERE name='{ProductList.SelectedItem}';";
                Delete.ExecuteNonQuery();
                DefaultStat();

                UpdateBox();
                ProductList.SelectedIndex = 0;
                MessageBox.Show("Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                DefaultStat();
            }
        }

        string CreateCode()
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < 8; i++)
            {
                str += (random.Next() % 10).ToString();
            }
            return str;
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            int id_category;
            int id_currency;

            SQLiteCommand category = StorageNameClass.Conn.CreateCommand();
            category.CommandText = $"SELECT id FROM Category WHERE name ='{CategoryList.SelectedItem}';";
            SQLiteDataReader reader1 = category.ExecuteReader();
            reader1.Read();
            id_category = Convert.ToInt32(reader1["id"]);

            SQLiteCommand currency = StorageNameClass.Conn.CreateCommand();
            currency.CommandText = $"SELECT id FROM Currency WHERE name ='{CurrencyList.SelectedItem}';";
            SQLiteDataReader reader2 = currency.ExecuteReader();
            reader2.Read();
            id_currency = Convert.ToInt32(reader2["id"]);

            string code = "";
            bool nounic = true;

            while (nounic)
            {
                nounic = false;
                code = CreateCode();

                SQLiteCommand productcode = StorageNameClass.Conn.CreateCommand();
                productcode.CommandText = "SELECT code FROM Product;";
                SQLiteDataReader reader = productcode.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        if (code == reader["code"].ToString())
                        {
                            nounic = true;
                        }
                    }
                }
            }

            // price_main/rate

            SQLiteCommand rate = StorageNameClass.Conn.CreateCommand();
            rate.CommandText = $"SELECT rate FROM Currency WHERE name='{CurrencyList.SelectedItem}';";
            SQLiteDataReader readerrate = rate.ExecuteReader();
            readerrate.Read();
            double currentrate = Convert.ToDouble(readerrate["rate"]);
            double real_price = Convert.ToDouble(PriceBox.Text) * currentrate;


            if (NameBox.Text != "" && PriceBox.Text != "" && ActionLabel.Text == "Add")
            {
                SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
                Add.CommandText = "INSERT INTO Product ('name', 'price_main', 'price_real', 'id_category', 'id_currency', 'code') " +
                    $"VALUES ('{NameBox.Text}', '{PriceBox.Text}', '{real_price}', {id_category}, {id_currency}, '{code}');";
                Add.ExecuteNonQuery();
                MessageBox.Show("Added", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                
            }
            else if (NameBox.Text != "" && PriceBox.Text != "" && ActionLabel.Text == "Edit")
            {
                SQLiteCommand id = StorageNameClass.Conn.CreateCommand();
                id.CommandText = $"SELECT id FROM Product WHERE name='{ProductList.SelectedItem}';";
                SQLiteDataReader readerid = id.ExecuteReader();
                readerid.Read();
                int intid = Convert.ToInt32(readerid["id"]);



                SQLiteCommand UpdateCommand = StorageNameClass.Conn.CreateCommand();
                UpdateCommand.CommandText = $"UPDATE Product SET name = '{NameBox.Text}', price_main= '{PriceBox.Text}', price_real='{real_price}', id_category={id_category}, id_currency={id_currency}, code='{code}' WHERE id={intid};";
                UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Edited", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("NOT NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DefaultStat();
            UpdateBox();
        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            BarcodeWriter writer = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            SQLiteCommand code = StorageNameClass.Conn.CreateCommand();
            code.CommandText = $"SELECT code FROM Product WHERE name='{ProductList.SelectedItem}';";
            SQLiteDataReader readerid = code.ExecuteReader();
            readerid.Read();
            string strcode = readerid["code"].ToString();
            Pic.Image = writer.Write(strcode);
        }
    }
}
