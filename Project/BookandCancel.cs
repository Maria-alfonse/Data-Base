using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class BookandCancel : Form
    {
        // Define the connection string for your database
        SqlConnection con = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database""; Integrated Security=true");
        public BookandCancel()
        {
            InitializeComponent();
        }

        // Event handler for Book Ticket button
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tripid.Text) || string.IsNullOrEmpty(bookingdate.Text) || string.IsNullOrEmpty(paymethod.Text) || string.IsNullOrEmpty(seatno.Text))
            {
                MessageBox.Show("Please fill all fields.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "INSERT INTO Ticket (id, booking_date, patment_method, Seat_no) VALUES (@tripid, @bookingdate, @paymentmethod, @seatno)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Using parameters to prevent SQL injection
                    cmd.Parameters.AddWithValue("@TripId", int.Parse(tripid.Text)); // Assuming TripId is int in the database
                    cmd.Parameters.AddWithValue("@BookingDate", DateTime.Parse(bookingdate.Text)); // Assuming BookingDate is DateTime in the database
                    cmd.Parameters.AddWithValue("@PaymentMethod", paymethod.Text);
                    cmd.Parameters.AddWithValue("@SeatNo", int.Parse(seatno.Text)); // Assuming SeatNo is int in the database

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Ticket booked successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        // Event handler for Cancel Ticket button
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tripid.Text))
            {
                MessageBox.Show("Please enter Trip ID to cancel the booking.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                con.Open();
                string query = "DELETE FROM Ticket WHERE id = @tripid";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@tripid", int.Parse(tripid.Text)); // Assuming TripId is int in the database

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show($"Ticket with Trip ID: {tripid.Text} has been cancelled.", "Cancellation Confirmed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No ticket found with the specified Trip ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void BookandCancel_Load(object sender, EventArgs e)
        {

        }
    }
}
