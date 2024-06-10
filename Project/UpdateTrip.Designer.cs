namespace Project
{
    partial class UpdateTrip
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTripId;
        private System.Windows.Forms.Label lblStationId;
        private System.Windows.Forms.Label lblTrainId;
        private System.Windows.Forms.Label lblStaStationId;
        private System.Windows.Forms.Label lblDepartureTime;
        private System.Windows.Forms.Label lblArrivalTime;
        private System.Windows.Forms.TextBox txtTripId;
        private System.Windows.Forms.TextBox txtStationId;
        private System.Windows.Forms.TextBox txtTrainId;
        private System.Windows.Forms.TextBox txtStaStationId;
        private System.Windows.Forms.DateTimePicker dtpDepartureTime;
        private System.Windows.Forms.DateTimePicker dtpArrivalTime;
        private System.Windows.Forms.Button btnLoadTrip;
        private System.Windows.Forms.Button btnUpdateTrip;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTripId = new Label();
            lblStationId = new Label();
            lblTrainId = new Label();
            lblStaStationId = new Label();
            lblDepartureTime = new Label();
            lblArrivalTime = new Label();
            txtTripId = new TextBox();
            txtStationId = new TextBox();
            txtTrainId = new TextBox();
            txtStaStationId = new TextBox();
            dtpDepartureTime = new DateTimePicker();
            dtpArrivalTime = new DateTimePicker();
            btnLoadTrip = new Button();
            btnUpdateTrip = new Button();
            SuspendLayout();
            // 
            // lblTripId
            // 
            lblTripId.AutoSize = true;
            lblTripId.Location = new Point(27, 31);
            lblTripId.Margin = new Padding(4, 0, 4, 0);
            lblTripId.Name = "lblTripId";
            lblTripId.Size = new Size(56, 20);
            lblTripId.TabIndex = 0;
            lblTripId.Text = "Trip ID:";
            // 
            // lblStationId
            // 
            lblStationId.AutoSize = true;
            lblStationId.Location = new Point(27, 92);
            lblStationId.Margin = new Padding(4, 0, 4, 0);
            lblStationId.Name = "lblStationId";
            lblStationId.Size = new Size(78, 20);
            lblStationId.TabIndex = 1;
            lblStationId.Text = "Station ID:";
            // 
            // lblTrainId
            // 
            lblTrainId.AutoSize = true;
            lblTrainId.Location = new Point(27, 154);
            lblTrainId.Margin = new Padding(4, 0, 4, 0);
            lblTrainId.Name = "lblTrainId";
            lblTrainId.Size = new Size(63, 20);
            lblTrainId.TabIndex = 2;
            lblTrainId.Text = "Train ID:";
            // 
            // lblStaStationId
            // 
            lblStaStationId.AutoSize = true;
            lblStaStationId.Location = new Point(27, 215);
            lblStaStationId.Margin = new Padding(4, 0, 4, 0);
            lblStaStationId.Name = "lblStaStationId";
            lblStaStationId.Size = new Size(107, 20);
            lblStaStationId.TabIndex = 3;
            lblStaStationId.Text = "STA Station ID:";
            // 
            // lblDepartureTime
            // 
            lblDepartureTime.AutoSize = true;
            lblDepartureTime.Location = new Point(27, 277);
            lblDepartureTime.Margin = new Padding(4, 0, 4, 0);
            lblDepartureTime.Name = "lblDepartureTime";
            lblDepartureTime.Size = new Size(116, 20);
            lblDepartureTime.TabIndex = 4;
            lblDepartureTime.Text = "Departure Time:";
            // 
            // lblArrivalTime
            // 
            lblArrivalTime.AutoSize = true;
            lblArrivalTime.Location = new Point(27, 338);
            lblArrivalTime.Margin = new Padding(4, 0, 4, 0);
            lblArrivalTime.Name = "lblArrivalTime";
            lblArrivalTime.Size = new Size(92, 20);
            lblArrivalTime.TabIndex = 5;
            lblArrivalTime.Text = "Arrival Time:";
            // 
            // txtTripId
            // 
            txtTripId.Location = new Point(160, 31);
            txtTripId.Margin = new Padding(4, 5, 4, 5);
            txtTripId.Name = "txtTripId";
            txtTripId.Size = new Size(265, 27);
            txtTripId.TabIndex = 6;
            // 
            // txtStationId
            // 
            txtStationId.Location = new Point(160, 92);
            txtStationId.Margin = new Padding(4, 5, 4, 5);
            txtStationId.Name = "txtStationId";
            txtStationId.Size = new Size(265, 27);
            txtStationId.TabIndex = 7;
            // 
            // txtTrainId
            // 
            txtTrainId.Location = new Point(160, 154);
            txtTrainId.Margin = new Padding(4, 5, 4, 5);
            txtTrainId.Name = "txtTrainId";
            txtTrainId.Size = new Size(265, 27);
            txtTrainId.TabIndex = 8;
            // 
            // txtStaStationId
            // 
            txtStaStationId.Location = new Point(160, 215);
            txtStaStationId.Margin = new Padding(4, 5, 4, 5);
            txtStaStationId.Name = "txtStaStationId";
            txtStaStationId.Size = new Size(265, 27);
            txtStaStationId.TabIndex = 9;
            // 
            // dtpDepartureTime
            // 
            dtpDepartureTime.Format = DateTimePickerFormat.Short;
            dtpDepartureTime.Location = new Point(160, 277);
            dtpDepartureTime.Margin = new Padding(4, 5, 4, 5);
            dtpDepartureTime.Name = "dtpDepartureTime";
            dtpDepartureTime.Size = new Size(265, 27);
            dtpDepartureTime.TabIndex = 10;
            // 
            // dtpArrivalTime
            // 
            dtpArrivalTime.Format = DateTimePickerFormat.Short;
            dtpArrivalTime.Location = new Point(160, 338);
            dtpArrivalTime.Margin = new Padding(4, 5, 4, 5);
            dtpArrivalTime.Name = "dtpArrivalTime";
            dtpArrivalTime.Size = new Size(265, 27);
            dtpArrivalTime.TabIndex = 11;
            // 
            // btnLoadTrip
            // 
            btnLoadTrip.Location = new Point(160, 400);
            btnLoadTrip.Margin = new Padding(4, 5, 4, 5);
            btnLoadTrip.Name = "btnLoadTrip";
            btnLoadTrip.Size = new Size(100, 35);
            btnLoadTrip.TabIndex = 12;
            btnLoadTrip.Text = "Load Trip";
            btnLoadTrip.UseVisualStyleBackColor = true;
            btnLoadTrip.Click += BtnLoadTrip_Click;
            // 
            // btnUpdateTrip
            // 
            btnUpdateTrip.Location = new Point(327, 400);
            btnUpdateTrip.Margin = new Padding(4, 5, 4, 5);
            btnUpdateTrip.Name = "btnUpdateTrip";
            btnUpdateTrip.Size = new Size(100, 35);
            btnUpdateTrip.TabIndex = 13;
            btnUpdateTrip.Text = "Update Trip";
            btnUpdateTrip.UseVisualStyleBackColor = true;
            btnUpdateTrip.Click += BtnUpdateTrip_Click;
            // 
            // UpdateTrip
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 462);
            Controls.Add(btnUpdateTrip);
            Controls.Add(btnLoadTrip);
            Controls.Add(dtpArrivalTime);
            Controls.Add(dtpDepartureTime);
            Controls.Add(txtStaStationId);
            Controls.Add(txtTrainId);
            Controls.Add(txtStationId);
            Controls.Add(txtTripId);
            Controls.Add(lblArrivalTime);
            Controls.Add(lblDepartureTime);
            Controls.Add(lblStaStationId);
            Controls.Add(lblTrainId);
            Controls.Add(lblStationId);
            Controls.Add(lblTripId);
            Margin = new Padding(4, 5, 4, 5);
            Name = "UpdateTrip";
            Text = "Update Trip";
            Load += UpdateTrip_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}