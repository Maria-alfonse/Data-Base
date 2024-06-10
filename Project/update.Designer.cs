
namespace Project
{
    partial class Update
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            fontDialog1 = new FontDialog();
            label1 = new Label();
            userid = new TextBox();
            userpass = new TextBox();
            useremail = new TextBox();
            userFN = new TextBox();
            usertype = new TextBox();
            userLN = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            label5 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // fontDialog1
            // 
            fontDialog1.Apply += fontDialog1_Apply;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Segoe UI Black", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(224, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 25);
            label1.TabIndex = 1;
            label1.Text = "update-user-account";
            // 
            // userid
            // 
            userid.BackColor = SystemColors.InactiveCaption;
            userid.Location = new Point(138, 77);
            userid.Margin = new Padding(2);
            userid.Name = "userid";
            userid.Size = new Size(250, 27);
            userid.TabIndex = 2;
            userid.TextChanged += userid_TextChanged;
            // 
            // userpass
            // 
            userpass.BackColor = SystemColors.InactiveCaption;
            userpass.Location = new Point(138, 151);
            userpass.Margin = new Padding(2);
            userpass.Name = "userpass";
            userpass.Size = new Size(250, 27);
            userpass.TabIndex = 3;
            // 
            // useremail
            // 
            useremail.BackColor = SystemColors.InactiveCaption;
            useremail.Location = new Point(138, 111);
            useremail.Margin = new Padding(2);
            useremail.Name = "useremail";
            useremail.Size = new Size(250, 27);
            useremail.TabIndex = 4;
            // 
            // userFN
            // 
            userFN.BackColor = SystemColors.InactiveCaption;
            userFN.Location = new Point(138, 240);
            userFN.Margin = new Padding(2);
            userFN.Name = "userFN";
            userFN.Size = new Size(250, 27);
            userFN.TabIndex = 5;
            // 
            // usertype
            // 
            usertype.BackColor = SystemColors.InactiveCaption;
            usertype.Location = new Point(138, 194);
            usertype.Margin = new Padding(2);
            usertype.Name = "usertype";
            usertype.Size = new Size(250, 27);
            usertype.TabIndex = 6;
            // 
            // userLN
            // 
            userLN.BackColor = SystemColors.InactiveCaption;
            userLN.Location = new Point(138, 283);
            userLN.Margin = new Padding(2);
            userLN.Name = "userLN";
            userLN.Size = new Size(250, 27);
            userLN.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 111);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 156);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 9;
            label3.Text = "password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 199);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 10;
            label4.Text = "account-type";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(24, 245);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(75, 20);
            label6.TabIndex = 12;
            label6.Text = "first name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 288);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(76, 20);
            label7.TabIndex = 13;
            label7.Text = "last name'";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 77);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 14;
            label5.Text = "id";
            label5.Click += label5_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(251, 333);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(90, 27);
            button1.TabIndex = 15;
            button1.Text = "save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // update
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(640, 370);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(userLN);
            Controls.Add(usertype);
            Controls.Add(userFN);
            Controls.Add(useremail);
            Controls.Add(userpass);
            Controls.Add(userid);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "update";
            Text = "Form1";
            Load += update_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void update_Load(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private FontDialog fontDialog1;
        private Label label1;
        private TextBox userid;
        private TextBox userpass;
        private TextBox useremail;
        private TextBox userFN;
        private TextBox usertype;
        private TextBox userLN;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Label label5;
        private Button button1;
    }
}
