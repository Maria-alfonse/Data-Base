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
    public partial class availableSeats : Form
    {
        public availableSeats()
        {
            InitializeComponent();
            //populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database""; Integrated Security=true");
        private object class_name;

        private void populate()
        {
            con.Open();
            string query = "select * from seat";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            var ds = new DataSet();
            sda.Fill(ds);
            seatGrid.DataSource = ds.Tables[0];
            con.Close();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (date.SelectedIndex == -1 || source.SelectedIndex == -1 ||
                destination.SelectedIndex == -1 || classname.SelectedIndex == -1)
            {
                MessageBox.Show("Please select values for all dropdowns.");
                return;
            }

            try
            {
                con.Open();
                string query = "SELECT * FROM seat WHERE [Date] = @date AND [Source] = @source " +
                               "AND [Destination] = @destination AND [classname] = @classname";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@date", date.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@source", source.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@destination", destination.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@classname", classname.SelectedItem.ToString());



                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Display the data from the query result
                        string seatNo = reader["seatno"].ToString(); // Modify column name as per your database schema
                        // Similarly, retrieve other columns and display them
                        MessageBox.Show($"Available number of seats: {seatNo}");
                    }
                }
                else
                {
                    MessageBox.Show("No available seats found for the selected criteria.");
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void availableSeats_Load(object sender, EventArgs e)
        {

        }
    }
}
