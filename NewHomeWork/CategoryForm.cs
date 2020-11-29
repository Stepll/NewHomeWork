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
    public partial class CategoryForm : Form
    {
        Point lastPoint;

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void EndButton_Click(object sender, EventArgs e)
        {
            Close();
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

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            MoveClass.MoveCommand(e, ref lastPoint, this);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            MoveClass.DownCommand(e, ref lastPoint);
        }

        void UpdateBox()
        {
            CategoryList.Items.Clear();
            NameBox.Clear();
            SQLiteCommand category = StorageNameClass.Conn.CreateCommand();
            category.CommandText = "SELECT name FROM Category;";
            SQLiteDataReader reader = category.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    CategoryList.Items.Add(reader["name"]);
                }
            }
            CategoryList.SelectedIndex = 0;
        }

        void DefaultStat()
        {
            ActionLabel.Text = "Nothing";
            CategoryList.Enabled = true;
            NameBox.Enabled = false;
            AddEditButton.Enabled = false;
        }

        private void CategoryForm_Load(object sender, EventArgs e)
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
                AddEditButton.Enabled = true;
                CategoryList.Enabled = false;
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
                CategoryList.Enabled = false;
                AddEditButton.Enabled = true;
                NameBox.Text = CategoryList.SelectedItem.ToString();
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
                getid.CommandText = $"SELECT id FROM Category WHERE name='{CategoryList.SelectedItem}';";
                SQLiteDataReader reader = getid.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    id = Convert.ToInt32(reader["id"]);
                }

                int newid = 0;
                SQLiteCommand getnewid = StorageNameClass.Conn.CreateCommand();
                getnewid.CommandText = $"SELECT id FROM Category;";
                SQLiteDataReader reader2 = getnewid.ExecuteReader();
                if (reader2.HasRows)
                {
                    reader2.Read();
                    newid = Convert.ToInt32(reader2["id"]);
                }



                SQLiteCommand nullcategory = StorageNameClass.Conn.CreateCommand();
                nullcategory.CommandText = $"UPDATE Product SET id_category={newid} WHERE id_category={id};";
                nullcategory.ExecuteNonQuery();


                SQLiteCommand Delete = StorageNameClass.Conn.CreateCommand();
                Delete.CommandText = $"DELETE FROM Category WHERE name='{CategoryList.SelectedItem}';";
                Delete.ExecuteNonQuery();
                DefaultStat();
                UpdateBox();
                CategoryList.SelectedIndex = 0;
                MessageBox.Show("Deleted", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DefaultStat();
            }
        }

        private void AddEditButton_Click(object sender, EventArgs e)
        {
            if (NameBox.Text != "" && ActionLabel.Text == "Add")
            {
                SQLiteCommand Add = StorageNameClass.Conn.CreateCommand();
                Add.CommandText = $"INSERT INTO Category ('name') VALUES ('{NameBox.Text}');";
                Add.ExecuteNonQuery();
                MessageBox.Show("Added", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (NameBox.Text != "" && ActionLabel.Text == "Edit")
            {
                SQLiteCommand id = StorageNameClass.Conn.CreateCommand();
                id.CommandText = $"SELECT id FROM Category WHERE name='{CategoryList.SelectedItem}';";
                SQLiteDataReader readerid = id.ExecuteReader();
                readerid.Read();
                int intid = Convert.ToInt32(readerid["id"]);

                SQLiteCommand UpdateCommand = StorageNameClass.Conn.CreateCommand();
                UpdateCommand.CommandText = $"UPDATE Category SET name = '{NameBox.Text}' WHERE id={intid};";
                UpdateCommand.ExecuteNonQuery();

                MessageBox.Show("Edited", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("NOT NULL", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            DefaultStat();
            UpdateBox();
        }
    }
}
