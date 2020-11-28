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

    public partial class StorageForm : Form
    {
        Point lastPoint;

        

        int id;

        public StorageForm()
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

        private void ButtonEnd_Click(object sender, EventArgs e)
        {
            
            Close();
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void UpdateBox()
        {
            
            ListStorage.Items.Clear();
            SQLiteCommand storages = StorageNameClass.Conn.CreateCommand();
            storages.CommandText = "SELECT name FROM Storage;";
            SQLiteDataReader reader = storages.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    ListStorage.Items.Add(reader["name"]);
                }
            }
            TextBoxName.Clear();
            TextBoxAddress.Clear();
            
        }

        private void StorageForm_Load(object sender, EventArgs e)
        {
            
            
            UpdateBox();
            ListStorage.SelectedIndex = 1;
            StorageNameClass.StorageName = ListStorage.SelectedItem.ToString();
        }

        private void DefaultStat()
        {
            ActionLabel.Text = "Nothing";
            ProductButton.Enabled = false;
            TextBoxName.Enabled = false;
            TextBoxAddress.Enabled = false;
            AddButton2.Enabled = false;
            TextBoxName.Clear();
            TextBoxAddress.Clear();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ActionLabel.Text = "Add";
            ProductButton.Enabled = false;
            TextBoxName.Enabled = true;
            TextBoxAddress.Enabled = true;
            AddButton2.Enabled = true;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            
            ActionLabel.Text = "Edit";
            ProductButton.Enabled = true;
            TextBoxName.Enabled = true;
            TextBoxAddress.Enabled = true;
            AddButton2.Enabled = true;

            StorageNameClass.StorageName = ListStorage.SelectedItem.ToString();
            SQLiteCommand Load = StorageNameClass.Conn.CreateCommand();
            Load.CommandText = $"SELECT * FROM Storage WHERE name = '{ListStorage.SelectedItem.ToString()}'; ";
            
            SQLiteDataReader reader = Load.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Read();
                TextBoxName.Text = reader["name"].ToString();
                TextBoxAddress.Text = reader["address"].ToString();
                id = Convert.ToInt32(reader["id"]);
            }
            
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            DefaultStat();
            ActionLabel.Text = "Delete";

            
            DialogResult res = MessageBox.Show("Delete?", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                
                SQLiteCommand Delete = StorageNameClass.Conn.CreateCommand();
                Delete.CommandText = $"DELETE FROM Storage WHERE name='{ListStorage.SelectedItem}';";
                Delete.ExecuteNonQuery();
                DefaultStat();
                
                UpdateBox();
                ListStorage.SelectedIndex = 0;
                MessageBox.Show("Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void StorageLabel_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void StorageLabel_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        private void AddButton2_Click(object sender, EventArgs e)
        {
            
            if (TextBoxAddress.Text != "" && TextBoxName.Text != "" && ActionLabel.Text == "Add")
            {
                SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
                Add.CommandText = $"INSERT INTO Storage ('name', 'address') VALUES ('{TextBoxName.Text}', '{TextBoxAddress.Text}');";
                Add.ExecuteNonQuery();
                DefaultStat();
                UpdateBox();
                MessageBox.Show("Added", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else if (TextBoxAddress.Text != "" && TextBoxName.Text != "" && ActionLabel.Text == "Edit")
            {
                SQLiteCommand UpdateCommand = StorageNameClass.Conn.CreateCommand();
                UpdateCommand.CommandText = $"UPDATE Storage SET name = '{TextBoxName.Text}', address= '{TextBoxAddress.Text}' WHERE id = {id};";
                UpdateCommand.ExecuteNonQuery();
                DefaultStat();
                UpdateBox();
                MessageBox.Show("Edited", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("NOT NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            
            StorageProduct frm2 = new StorageProduct();
            frm2.Show();
        }

        private void ListStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            EditButton.Enabled = true;
            DefaultStat();
        }

        private void TaskButton_Click(object sender, EventArgs e)
        {
            Task frm2 = new Task();
            frm2.Show();
        }
    }
}
