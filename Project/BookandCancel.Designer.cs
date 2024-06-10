namespace Project
{
    partial class BookandCancel
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
            paymethod = new TextBox();
            seatno = new TextBox();
            bookingdate = new TextBox();
            tripid = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // paymethod
            // 
            paymethod.BackColor = SystemColors.InactiveCaption;
            paymethod.Location = new Point(221, 209);
            paymethod.Margin = new Padding(2, 2, 2, 2);
            paymethod.Name = "paymethod";
            paymethod.Size = new Size(250, 27);
            paymethod.TabIndex = 4;
            // 
            // seatno
            // 
            seatno.BackColor = SystemColors.InactiveCaption;
            seatno.Location = new Point(221, 260);
            seatno.Margin = new Padding(2, 2, 2, 2);
            seatno.Name = "seatno";
            seatno.Size = new Size(250, 27);
            seatno.TabIndex = 5;
            // 
            // bookingdate
            // 
            bookingdate.BackColor = SystemColors.InactiveCaption;
            bookingdate.Location = new Point(221, 138);
            bookingdate.Margin = new Padding(2, 2, 2, 2);
            bookingdate.Name = "bookingdate";
            bookingdate.Size = new Size(250, 27);
            bookingdate.TabIndex = 6;
            // 
            // tripid
            // 
            tripid.BackColor = SystemColors.InactiveCaption;
            tripid.Location = new Point(221, 77);
            tripid.Margin = new Padding(2, 2, 2, 2);
            tripid.Name = "tripid";
            tripid.Size = new Size(250, 27);
            tripid.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(62, 262);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(53, 20);
            label5.TabIndex = 16;
            label5.Text = "seatno";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 211);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 17;
            label1.Text = "paymentMethod";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 138);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 18;
            label2.Text = "bookingDate";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 77);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(45, 20);
            label3.TabIndex = 19;
            label3.Text = "tripid";
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(364, 312);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 28;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(183, 312);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 29;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BookandCancel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(tripid);
            Controls.Add(bookingdate);
            Controls.Add(seatno);
            Controls.Add(paymethod);
            Margin = new Padding(2, 2, 2, 2);
            Name = "BookandCancel";
            Text = "BookandCancel";
            Load += BookandCancel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paymethod;
        private TextBox seatno;
        private TextBox bookingdate;
        private TextBox tripid;
        private Label label5;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button1;
    }
}