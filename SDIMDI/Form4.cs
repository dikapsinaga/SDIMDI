using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SDIMDI
{
    public partial class Form4 : Form
    {
        static string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=mandala94;database=test;SslMode=none";

        MySqlConnection databaseConnection = new MySqlConnection(connectionString);
        MySqlCommand commandDatabase;
        MySqlDataReader reader;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void show_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            try
            {
                String query = "SELECT * FROM user";
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        String[] row = { reader.GetString(0), reader.GetString(1), reader.GetString(2), reader.GetString(3) };
                        var listViewItem = new ListViewItem(row);
                        listView1.Items.Add(listViewItem);
                    }
                }
                else
                {
                    MessageBox.Show("TIDAK ADA DATA");
                }

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void hapus_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                String id = item.SubItems[0].Text;
                String query = "DELETE FROM user WHERE id = "+ id;
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                // Ops, maybe the id doesn't exists ?
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
                return;

            ListViewItem item = listView1.SelectedItems[0];
            //fill the text boxes
            firstName_textBox.Text = item.SubItems[1].Text;
            lastName_textBox.Text = item.SubItems[2].Text;
            address_textBox.Text = item.SubItems[3].Text;
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = listView1.SelectedItems[0];
                String id = item.SubItems[0].Text;
                String firstName = firstName_textBox.Text;
                String lastName = lastName_textBox.Text;
                String address = address_textBox.Text;

                String query = "UPDATE user SET firstName='"+firstName+ "',lastName='" + lastName + "',address='" + address + "' WHERE id = " + id;
                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                // Succesfully updated
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void save_Click(object sender, EventArgs e)
        {
            try
            {
                String query = "INSERT INTO user(firstName, lastName, address) VALUES ('" + firstName_textBox.Text + "', '" + lastName_textBox.Text + "', '" + address_textBox.Text + "')";

                commandDatabase = new MySqlCommand(query, databaseConnection);
                commandDatabase.CommandTimeout = 60;

                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                MessageBox.Show("User succesfully registered");

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}