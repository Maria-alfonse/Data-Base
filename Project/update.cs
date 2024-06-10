using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class Update : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database""; Integrated Security=true");

        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (userid.Text == "" || useremail.Text == "" || userFN.Text == "" || userLN.Text == "" || usertype.Text == "" || userpass.Text == "")
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                con.Open();
                // Update statement for account_user table
                string updateQuery = "UPDATE user_account SET email = @UserEmail, account_type = @UserType, password = @UserPassword, first_name = @UserFirstName, last_name = @UserLastName WHERE account_id = @Id";
                SqlCommand cmd = new SqlCommand(updateQuery, con);
                cmd.Parameters.AddWithValue("@Id", userid.Text);
                cmd.Parameters.AddWithValue("@UserEmail", useremail.Text);
                cmd.Parameters.AddWithValue("@UserType", usertype.Text);
                cmd.Parameters.AddWithValue("@UserPassword", userpass.Text);
                cmd.Parameters.AddWithValue("@UserFirstName", userFN.Text);
                cmd.Parameters.AddWithValue("@UserLastName", userLN.Text);

                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("User's Data has been updated successfully");
                }
                else
                {
                    MessageBox.Show("No matching user found for update.");
                }
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void userid_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
