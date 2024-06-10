namespace Project
{
    partial class AddTrain
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
            TrName = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            button1 = new Button();
            Trcap = new TextBox();
            Trtype = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            button5 = new Button();
            label3 = new Label();
            Trid = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(295, 11);
            label1.Name = "label1";
            label1.Size = new Size(117, 38);
            label1.TabIndex = 0;
            label1.Text = "Trains ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // TrName
            // 
            TrName.BackColor = Color.SkyBlue;
            TrName.Font = new Font("Segoe UI", 12F);
            TrName.Location = new Point(213, 157);
            TrName.Margin = new Padding(3, 4, 3, 4);
            TrName.Multiline = true;
            TrName.Name = "TrName";
            TrName.Size = new Size(266, 35);
            TrName.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(24, 284);
            label4.Name = "label4";
            label4.Size = new Size(111, 29);
            label4.TabIndex = 4;
            label4.Text = "Capacity:";
            label4.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(24, 219);
            label5.Name = "label5";
            label5.Size = new Size(74, 29);
            label5.TabIndex = 5;
            label5.Text = "Type:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(24, 163);
            label6.Name = "label6";
            label6.Size = new Size(146, 29);
            label6.TabIndex = 6;
            label6.Text = "Train Name:";
            // 
            // button1
            // 
            button1.BackColor = Color.LightSkyBlue;
            button1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(29, 364);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(135, 61);
            button1.TabIndex = 9;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Trcap
            // 
            Trcap.BackColor = Color.SkyBlue;
            Trcap.Font = new Font("Segoe UI", 12F);
            Trcap.Location = new Point(213, 284);
            Trcap.Margin = new Padding(3, 4, 3, 4);
            Trcap.Multiline = true;
            Trcap.Name = "Trcap";
            Trcap.Size = new Size(266, 35);
            Trcap.TabIndex = 10;
            // 
            // Trtype
            // 
            Trtype.BackColor = Color.SkyBlue;
            Trtype.Font = new Font("Segoe UI", 12F);
            Trtype.Location = new Point(213, 213);
            Trtype.Margin = new Padding(3, 4, 3, 4);
            Trtype.Multiline = true;
            Trtype.Name = "Trtype";
            Trtype.Size = new Size(266, 35);
            Trtype.TabIndex = 11;
            // 
            // button2
            // 
            button2.BackColor = Color.LightSkyBlue;
            button2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(694, 364);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(135, 61);
            button2.TabIndex = 12;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.LightSkyBlue;
            button3.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(258, 364);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(135, 61);
            button3.TabIndex = 13;
            button3.Text = "Edit";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Brown;
            button4.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(475, 364);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(135, 61);
            button4.TabIndex = 14;
            button4.Text = "Delete";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(324, 444);
            label2.Name = "label2";
            label2.Size = new Size(0, 29);
            label2.TabIndex = 15;
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(38, 510);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(775, 438);
            dataGridView1.TabIndex = 17;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkCyan;
            button5.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(241, 441);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(164, 61);
            button5.TabIndex = 18;
            button5.Text = "Save After Edit";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 93);
            label3.Name = "label3";
            label3.Size = new Size(104, 29);
            label3.TabIndex = 20;
            label3.Text = "Train ID:";
            label3.Click += label3_Click;
            // 
            // Trid
            // 
            Trid.BackColor = Color.SkyBlue;
            Trid.Font = new Font("Segoe UI", 12F);
            Trid.Location = new Point(213, 93);
            Trid.Margin = new Padding(3, 4, 3, 4);
            Trid.Multiline = true;
            Trid.Name = "Trid";
            Trid.Size = new Size(266, 35);
            Trid.TabIndex = 19;
            Trid.TextChanged += textBox1_TextChanged;
            // 
            // AddTrain
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(863, 982);
            Controls.Add(label3);
            Controls.Add(Trid);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Trtype);
            Controls.Add(Trcap);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TrName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 1, true);
            HelpButton = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddTrain";
            Text = "AddTrain";
            Load += AddTrain_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TrName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Trcap;
        private System.Windows.Forms.TextBox Trtype;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private Label label3;
        private TextBox Trid;
    }
}