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
    public partial class StorageProduct : Form
    {

        Point lastPoint;

        int id_product, id_storage;

        
        public StorageProduct()
        {
            InitializeComponent();
            
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void GridDB()
        {
            int id = 0;
            SQLiteCommand getid = StorageNameClass.Conn.CreateCommand();
            getid.CommandText = $"SELECT id FROM Storage WHERE name='{StorageNameClass.StorageName}';";
            SQLiteDataReader reader = getid.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id = Convert.ToInt32(reader["id"]);
            }

            SQLiteCommand Delete = StorageNameClass.Conn.CreateCommand();
            Delete.CommandText = $"DELETE FROM Inter_Product_Storage WHERE id_storage={id} AND number=0;";
            Delete.ExecuteNonQuery();


            DataGrid.Columns.Clear();
            SQLiteCommand comm = new SQLiteCommand($"SELECT P.name, P.code, I.number FROM (Product P JOIN Inter_Product_Storage I ON P.id=I.id_product ) JOIN Storage S ON I.id_storage=S.id WHERE S.name='{StorageNameClass.StorageName}';", StorageNameClass.Conn);
            DataGrid.Columns.Add("column-2", "name");
            DataGrid.Columns.Add("column-3", "code");
            DataGrid.Columns.Add("column-4", "number");
            using (SQLiteDataReader read = comm.ExecuteReader())
            {
                while (read.Read())
                {
                    DataGrid.Rows.Add(new object[] {
                    read.GetValue(0),
                    read.GetValue(1),
                    read.GetValue(2)
                    });
                }
            }
        }

        private void StorageProduct_Load(object sender, EventArgs e)
        {
            StorageLabel.Text = StorageNameClass.StorageName;

            

            SQLiteCommand load = StorageNameClass.Conn.CreateCommand();
            load.CommandText = "SELECT name FROM Product;";
            SQLiteDataReader reader = load.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ProductList.Items.Add(reader["name"]);
                }
            }

            SQLiteCommand loadid = StorageNameClass.Conn.CreateCommand();
            loadid.CommandText = $"SELECT id FROM Storage WHERE name='{StorageLabel.Text}';";
            SQLiteDataReader readerid = loadid.ExecuteReader();
            if (readerid.HasRows)
            {
                readerid.Read();
                id_storage = Convert.ToInt32(readerid["id"]);
            }
            GridDB();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
            Add.CommandText = $"UPDATE Inter_Product_Storage SET number={Convert.ToInt32(TextBoxNum.Text)} WHERE id_product={id_product} AND id_storage={id_storage};";
            Add.ExecuteNonQuery();
            MessageBox.Show("Edited", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GridDB();


        }

        private void ProductList_SelectedIndexChanged(object sender, EventArgs e)
        {
            SQLiteCommand load = StorageNameClass.Conn.CreateCommand();
            load.CommandText = $"SELECT id FROM Product WHERE name='{ProductList.SelectedItem.ToString()}';";
            SQLiteDataReader reader = load.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                id_product = Convert.ToInt32(reader["id"]);
            }

            SQLiteCommand check = StorageNameClass.Conn.CreateCommand();
            check.CommandText = $"SELECT * FROM Inter_Product_Storage WHERE id_product='{id_product}' AND id_storage='{id_storage}';";
            SQLiteDataReader readercheck = check.ExecuteReader();
            if (readercheck.HasRows)
            {
                readercheck.Read();
                TextBoxNum.Text = readercheck["number"].ToString();
            }
            else 
            {
                SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
                Add.CommandText = $"INSERT INTO Inter_Product_Storage ('id_product', 'id_storage', 'number') VALUES ({id_product}, {id_storage}, 0);";
                Add.ExecuteNonQuery();
                TextBoxNum.Text = "0";
            }


            


        }
    }
}
