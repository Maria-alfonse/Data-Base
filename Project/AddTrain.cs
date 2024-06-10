using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Project
{
    public partial class AddTrain : Form
    {
        private readonly SqlConnection Con = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database"";Integrated Security=True");

        public AddTrain()
        {
            InitializeComponent();
            populate();
        }

        private void button1_Click(object sender, EventArgs e)

        {
            if (string.IsNullOrWhiteSpace(TrName.Text) || string.IsNullOrWhiteSpace(Trtype.Text) || string.IsNullOrWhiteSpace(Trcap.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                Con.Open();
                string Query = "INSERT INTO Train (train_name, type, capacity, train_id) VALUES (@train_name, @type, @capacity, @train_id)";
                SqlCommand cmd = new SqlCommand(Query, Con);
                cmd.Parameters.AddWithValue("@train_name", TrName.Text);
                cmd.Parameters.AddWithValue("@type", Trtype.Text);
                cmd.Parameters.AddWithValue("@capacity", Trcap.Text);
                cmd.Parameters.AddWithValue("@train_id", Trid.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Train Added");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
                reset();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                TrName.Text = dataGridView1.SelectedRows[0].Cells["train_name"].Value?.ToString();
                Trtype.Text = dataGridView1.SelectedRows[0].Cells["type"].Value?.ToString();
                Trcap.Text = dataGridView1.SelectedRows[0].Cells["capacity"].Value?.ToString();
                Trid.Text = dataGridView1.SelectedRows[0].Cells["train_id"].Value?.ToString();
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);

                        Con.Open();
                        string query = "DELETE FROM Train WHERE train_id = @train_id";
                        SqlCommand cmd = new SqlCommand(query, Con);
                        cmd.Parameters.AddWithValue("@train_id", selectedId);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Record deleted successfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                    finally
                    {
                        Con.Close();
                        populate(); // Refresh the DataGridView after deleting
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void populate()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM Train";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                var ds = new DataSet();
                sda.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void reset()
        {
            TrName.Text = "";
            Trcap.Text = "";
            Trtype.Text = "";
            Trid.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the ID of the selected row
                int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["train_id"].Value);

                try
                {
                    // Open the connection
                    Con.Open();

                    // Query to update the record
                    string query = "UPDATE Train SET train_name = @train_name, type = @type, capacity = @capacity WHERE train_id = @train_id";

                    // Create and execute the command
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@train_name", TrName.Text);
                    cmd.Parameters.AddWithValue("@type", Trtype.Text);
                    cmd.Parameters.AddWithValue("@capacity", Trcap.Text);
                    cmd.Parameters.AddWithValue("@train_id", selectedId);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    // Close the connection
                    Con.Close();
                    populate(); // Refresh the DataGridView after updating
                }
            }
            else
            {
                MessageBox.Show("Please select a row to edit.");
            }
        }

        private void AddTrain_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
