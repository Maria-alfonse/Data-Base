namespace Project
{
    partial class account
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
            userid = new TextBox();
            useremail = new TextBox();
            userpass = new TextBox();
            usertype = new TextBox();
            userFN = new TextBox();
            label5 = new Label();
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            label6 = new Label();
            label7 = new Label();
            userLN = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // userid
            // 
            userid.BackColor = SystemColors.InactiveCaption;
            userid.Location = new Point(157, 40);
            userid.Margin = new Padding(2, 2, 2, 2);
            userid.Name = "userid";
            userid.Size = new Size(250, 27);
            userid.TabIndex = 3;
            // 
            // useremail
            // 
            useremail.BackColor = SystemColors.InactiveCaption;
            useremail.Location = new Point(157, 98);
            useremail.Margin = new Padding(2, 2, 2, 2);
            useremail.Name = "useremail";
            useremail.Size = new Size(250, 27);
            useremail.TabIndex = 4;
            // 
            // userpass
            // 
            userpass.BackColor = SystemColors.InactiveCaption;
            userpass.Location = new Point(157, 154);
            userpass.Margin = new Padding(2, 2, 2, 2);
            userpass.Name = "userpass";
            userpass.Size = new Size(250, 27);
            userpass.TabIndex = 5;
            // 
            // usertype
            // 
            usertype.BackColor = SystemColors.InactiveCaption;
            usertype.Location = new Point(157, 207);
            usertype.Margin = new Padding(2, 2, 2, 2);
            usertype.Name = "usertype";
            usertype.Size = new Size(250, 27);
            usertype.TabIndex = 6;
            // 
            // userFN
            // 
            userFN.BackColor = SystemColors.InactiveCaption;
            userFN.Location = new Point(157, 276);
            userFN.Margin = new Padding(2, 2, 2, 2);
            userFN.Name = "userFN";
            userFN.Size = new Size(250, 27);
            userFN.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(52, 40);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 15;
            label5.Text = "id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 98);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 20;
            label1.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 157);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 21;
            label3.Text = "password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 207);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 22;
            label2.Text = "account-type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 281);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 23;
            label6.Text = "first name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 346);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 24;
            label7.Text = "last name'";
            // 
            // userLN
            // 
            userLN.BackColor = SystemColors.InactiveCaption;
            userLN.Location = new Point(157, 342);
            userLN.Margin = new Padding(2, 2, 2, 2);
            userLN.Name = "userLN";
            userLN.Size = new Size(250, 27);
            userLN.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(354, 416);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 26;
            button1.Text = "reset";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.ForeColor = SystemColors.ActiveCaptionText;
            button2.Location = new Point(226, 416);
            button2.Margin = new Padding(2, 2, 2, 2);
            button2.Name = "button2";
            button2.Size = new Size(90, 27);
            button2.TabIndex = 27;
            button2.Text = "save";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // account
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 467);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(userLN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(userFN);
            Controls.Add(usertype);
            Controls.Add(userpass);
            Controls.Add(useremail);
            Controls.Add(userid);
            Margin = new Padding(2, 2, 2, 2);
            Name = "account";
            Text = "account";
            Load += account_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox userid;
        private TextBox useremail;
        private TextBox userpass;
        private TextBox usertype;
        private TextBox userFN;
        private Label label5;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label6;
        private Label label7;
        private TextBox userLN;
        private Button button1;
        private Button button2;
    }
}