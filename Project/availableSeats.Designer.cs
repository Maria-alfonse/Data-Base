namespace Project
{
    partial class availableSeats
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            classname = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            label7 = new Label();
            date = new ComboBox();
            destination = new ComboBox();
            source = new ComboBox();
            button2 = new Button();
            seatGrid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)seatGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(366, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(209, 37);
            label1.TabIndex = 0;
            label1.Text = "available seats";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(755, 81);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 1;
            label2.Text = "Date";
            // 
            // classname
            // 
            classname.FormattingEnabled = true;
            classname.Items.AddRange(new object[] { "Bussiness", "Economy" });
            classname.Location = new Point(9, 129);
            classname.Margin = new Padding(2, 3, 2, 3);
            classname.Name = "classname";
            classname.Size = new Size(147, 28);
            classname.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 81);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Destination";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 81);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(86, 20);
            label4.TabIndex = 4;
            label4.Text = "Class Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(282, 81);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 7;
            label7.Text = "Source";
            // 
            // date
            // 
            date.FormattingEnabled = true;
            date.Items.AddRange(new object[] { "1/07/2024", "5/07/2024", "9/07/2024", "15/07/2024" });
            date.Location = new Point(712, 129);
            date.Margin = new Padding(2, 3, 2, 3);
            date.Name = "date";
            date.Size = new Size(147, 28);
            date.TabIndex = 8;
            // 
            // destination
            // 
            destination.FormattingEnabled = true;
            destination.Items.AddRange(new object[] { "Cairo", "Alex", "Hurghada", "Sharm El-Sheikh" });
            destination.Location = new Point(473, 129);
            destination.Margin = new Padding(2, 3, 2, 3);
            destination.Name = "destination";
            destination.Size = new Size(147, 28);
            destination.TabIndex = 10;
            // 
            // source
            // 
            source.FormattingEnabled = true;
            source.Items.AddRange(new object[] { "Cairo", "Alex", "Hurghada", "Sharm El-sheikh" });
            source.Location = new Point(230, 129);
            source.Margin = new Padding(2, 3, 2, 3);
            source.Name = "source";
            source.Size = new Size(147, 28);
            source.TabIndex = 11;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(415, 175);
            button2.Margin = new Padding(2, 3, 2, 3);
            button2.Name = "button2";
            button2.Size = new Size(89, 45);
            button2.TabIndex = 12;
            button2.Text = "show";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // seatGrid
            // 
            seatGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            seatGrid.Location = new Point(22, 237);
            seatGrid.Margin = new Padding(2, 3, 2, 3);
            seatGrid.Name = "seatGrid";
            seatGrid.RowHeadersWidth = 62;
            seatGrid.Size = new Size(898, 321);
            seatGrid.TabIndex = 13;
            // 
            // availableSeats
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(955, 567);
            Controls.Add(seatGrid);
            Controls.Add(button2);
            Controls.Add(source);
            Controls.Add(destination);
            Controls.Add(date);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(classname);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 3, 2, 3);
            Name = "availableSeats";
            Text = "availableSeats";
            Load += availableSeats_Load;
            ((System.ComponentModel.ISupportInitialize)seatGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox classname;
        private Label label3;
        private Label label4;
        private Label label7;
        private ComboBox date;
        private ComboBox destination;
        private ComboBox source;
        private Button button2;
        private DataGridView seatGrid;
    }
}