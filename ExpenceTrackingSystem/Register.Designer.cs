namespace ExpenceTrackingSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            signin_btn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            showPassword_btn = new CheckBox();
            login_btn = new Button();
            Password_text = new TextBox();
            label5 = new Label();
            user_name_text = new TextBox();
            label4 = new Label();
            label3 = new Label();
            exit_btn = new Label();
            panel1 = new Panel();
            confirm_pasword_text = new TextBox();
            label7 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // signin_btn
            // 
            signin_btn.BackColor = Color.White;
            signin_btn.Cursor = Cursors.Hand;
            signin_btn.FlatStyle = FlatStyle.Flat;
            signin_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signin_btn.ForeColor = Color.MidnightBlue;
            signin_btn.Location = new Point(32, 382);
            signin_btn.Name = "signin_btn";
            signin_btn.Size = new Size(200, 41);
            signin_btn.TabIndex = 9;
            signin_btn.Text = "SIGN IN";
            signin_btn.UseVisualStyleBackColor = false;
            signin_btn.Click += signin_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("ErgoeBlackCond", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(82, 353);
            label6.Name = "label6";
            label6.Size = new Size(106, 19);
            label6.TabIndex = 9;
            label6.Text = "SIGN IN HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(32, 159);
            label2.Name = "label2";
            label2.Size = new Size(208, 26);
            label2.TabIndex = 1;
            label2.Text = "Expence Tracker";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(89, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // showPassword_btn
            // 
            showPassword_btn.AutoSize = true;
            showPassword_btn.Cursor = Cursors.Hand;
            showPassword_btn.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            showPassword_btn.Location = new Point(412, 331);
            showPassword_btn.Name = "showPassword_btn";
            showPassword_btn.Size = new Size(130, 24);
            showPassword_btn.TabIndex = 17;
            showPassword_btn.Text = "Show Password";
            showPassword_btn.UseVisualStyleBackColor = true;
            showPassword_btn.CheckedChanged += showPassword_btn_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.MidnightBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(307, 382);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(102, 41);
            login_btn.TabIndex = 16;
            login_btn.Text = "SIGN UP";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // Password_text
            // 
            Password_text.Cursor = Cursors.IBeam;
            Password_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_text.Location = new Point(307, 224);
            Password_text.Name = "Password_text";
            Password_text.PasswordChar = '*';
            Password_text.Size = new Size(238, 27);
            Password_text.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 189);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 14;
            label5.Text = "Password";
            // 
            // user_name_text
            // 
            user_name_text.Cursor = Cursors.IBeam;
            user_name_text.Location = new Point(307, 148);
            user_name_text.Name = "user_name_text";
            user_name_text.Size = new Size(238, 27);
            user_name_text.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(307, 116);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 12;
            label4.Text = "User Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ErgoeBlackCond", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(307, 48);
            label3.Name = "label3";
            label3.Size = new Size(112, 26);
            label3.TabIndex = 11;
            label3.Text = "REGISTER";
            // 
            // exit_btn
            // 
            exit_btn.AutoSize = true;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.Location = new Point(571, 3);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(20, 20);
            exit_btn.TabIndex = 10;
            exit_btn.Text = "X";
            exit_btn.Click += exit_btn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(signin_btn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(270, 457);
            panel1.TabIndex = 9;
            // 
            // confirm_pasword_text
            // 
            confirm_pasword_text.Cursor = Cursors.IBeam;
            confirm_pasword_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            confirm_pasword_text.Location = new Point(304, 300);
            confirm_pasword_text.Name = "confirm_pasword_text";
            confirm_pasword_text.PasswordChar = '*';
            confirm_pasword_text.Size = new Size(238, 27);
            confirm_pasword_text.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.Location = new Point(304, 265);
            label7.Name = "label7";
            label7.Size = new Size(155, 23);
            label7.TabIndex = 18;
            label7.Text = "Confirm Password";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(594, 457);
            Controls.Add(confirm_pasword_text);
            Controls.Add(label7);
            Controls.Add(showPassword_btn);
            Controls.Add(login_btn);
            Controls.Add(Password_text);
            Controls.Add(label5);
            Controls.Add(user_name_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(exit_btn);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button signin_btn;
        private Label label6;
        private Label label2;
        private PictureBox pictureBox1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private CheckBox showPassword_btn;
        private Button login_btn;
        private TextBox Password_text;
        private Label label5;
        private TextBox user_name_text;
        private Label label4;
        private Label label3;
        private Label exit_btn;
        private Panel panel1;
        private TextBox confirm_pasword_text;
        private Label label7;
    }
}