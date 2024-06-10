using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Project
{
    public partial class UpdateTrip : Form

    {
        public UpdateTrip()
        {
            InitializeComponent();
        }
       
        SqlConnection conn = new SqlConnection(@"Data Source=MARIA;Initial Catalog=""Train database""; Integrated Security=true");

        private void LoadTripDetails(int tripId)
        {
            string query = "SELECT station_id, train_id, sta_station_id, departure_time, arrival_time FROM Trip WHERE trip_id = @TripId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@TripId", tripId);

                try
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        txtStationId.Text = reader["station_id"].ToString();
                        txtTrainId.Text = reader["train_id"].ToString();
                        txtStaStationId.Text = reader["sta_station_id"].ToString();
                        dtpDepartureTime.Value = Convert.ToDateTime(reader["departure_time"]);
                        dtpArrivalTime.Value = Convert.ToDateTime(reader["arrival_time"]);
                    }
                    else
                    {
                        MessageBox.Show("Trip ID not found.");
                    }
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

        private void BtnLoadTrip_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTripId.Text, out int tripId))
            {
                LoadTripDetails(tripId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Trip ID.");
            }
        }

        private void BtnUpdateTrip_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTripId.Text, out int tripId))
            {
                string stationId = txtStationId.Text;
                string trainId = txtTrainId.Text;
                string staStationId = txtStaStationId.Text;
                DateTime departureTime = dtpDepartureTime.Value;
                DateTime arrivalTime = dtpArrivalTime.Value;

                UpdateTripDetails(tripId, stationId, trainId, staStationId, departureTime, arrivalTime);

                MessageBox.Show($"Trip {tripId} updated successfully!");
            }
            else
            {
                MessageBox.Show("Please enter a valid Trip ID.");
            }
        }

        private void UpdateTripDetails(int tripId, string stationId, string trainId, string staStationId, DateTime departureTime, DateTime arrivalTime)
        {
            string query = "UPDATE Trip SET station_id = @StationId, train_id = @TrainId, sta_station_id = @StaStationId, departure_time = @DepartureTime, arrival_time = @ArrivalTime WHERE trip_id = @TripId";

            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@StationId", stationId);
                cmd.Parameters.AddWithValue("@TrainId", trainId);
                cmd.Parameters.AddWithValue("@StaStationId", staStationId);
                cmd.Parameters.AddWithValue("@DepartureTime", departureTime);
                cmd.Parameters.AddWithValue("@ArrivalTime", arrivalTime);
                cmd.Parameters.AddWithValue("@TripId", tripId);

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

        private void UpdateTrip_Load(object sender, EventArgs e)
        {

        }
    }
}