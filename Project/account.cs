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
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database"";Integrated Security=True");

        private void button2_Click(object sender, EventArgs e)
        {
            // Check if any of the input fields are empty
            if (string.IsNullOrWhiteSpace(userid.Text) || string.IsNullOrWhiteSpace(useremail.Text) ||
                string.IsNullOrWhiteSpace(userFN.Text) || string.IsNullOrWhiteSpace(userLN.Text) ||
                string.IsNullOrWhiteSpace(usertype.Text) || string.IsNullOrWhiteSpace(userpass.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                con.Open();
                // Adjusted SQL query to match the table structure and attribute names
                string Query = "INSERT INTO user_account (account_id, email, password, first_name, last_name, account_type) " +
                               "VALUES (@AccountId, @Email, @Password, @FirstName, @LastName, @AccountType)";

                // Use parameterized queries to prevent SQL injection
                using (SqlCommand cmd = new SqlCommand(Query, con))
                {
                    cmd.Parameters.AddWithValue("@AccountId", userid.Text);
                    cmd.Parameters.AddWithValue("@Email", useremail.Text);
                    cmd.Parameters.AddWithValue("@Password", userpass.Text);
                    cmd.Parameters.AddWithValue("@FirstName", userFN.Text);
                    cmd.Parameters.AddWithValue("@LastName", userLN.Text);
                    cmd.Parameters.AddWithValue("@AccountType", usertype.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User's Data has been added successfully");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void Reset()
        {
            userid.Text = "";
            useremail.Text = "";
            userFN.Text = "";
            userLN.Text = "";
            userpass.Text = "";
            usertype.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void account_Load(object sender, EventArgs e)
        {

        }
    }
}
