using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Project
{
    public partial class AddTrip : Form
    {
        private SqlConnection conn;
        private string connectionString = @"Data Source=MARIA;Initial Catalog=""Train database"";Integrated Security=True";

        public AddTrip()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
        }

        private void InitializeDatabaseConnection()
        {
            conn = new SqlConnection(connectionString);
        }

        private void BtnAddTrip_Click(object sender, EventArgs e)
        {
            // Event handler for Add Trip button
            string tripId = txtTripId.Text;
            string stationId = txtStationId.Text;
            string trainId = txtTrainId.Text;
            string staStationId = txtStaStationId.Text;
            DateTime departureTime = dtpDepartureTime.Value;
            DateTime arrivalTime = dtpArrivalTime.Value;

            // Save the trip information to the database
            SaveTrip(tripId, stationId, trainId, staStationId, departureTime, arrivalTime);

            // Show confirmation message
            MessageBox.Show($"Trip {tripId} to {stationId} added!");
        }

        private void SaveTrip(string tripId, string stationId, string trainId, string staStationId, DateTime departureTime, DateTime arrivalTime)
        {
            // SQL query to insert trip into database
            string query = "INSERT INTO Trip (trip_id, station_id, train_id, sta_station_id, departure_time, arrival_time) " +
                           "VALUES (@tripId, @stationId, @trainId, @staStationId, @departureTime, @arrivalTime)";

            // Create SqlCommand and assign parameters
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@tripId", tripId);
                cmd.Parameters.AddWithValue("@stationId", stationId);
                cmd.Parameters.AddWithValue("@trainId", trainId);
                cmd.Parameters.AddWithValue("@staStationId", staStationId);
                cmd.Parameters.AddWithValue("@departureTime", departureTime);
                cmd.Parameters.AddWithValue("@arrivalTime", arrivalTime);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void AddTrip_Load(object sender, EventArgs e)
        {

        }
    }
}