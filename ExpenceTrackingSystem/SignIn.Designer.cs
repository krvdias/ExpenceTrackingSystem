namespace ExpenceTrackingSystem
{
    partial class SignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignIn));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            panel1 = new Panel();
            signup_btn = new Button();
            label6 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            user_name_text = new TextBox();
            Password_text = new TextBox();
            label5 = new Label();
            login_btn = new Button();
            showPassword_btn = new CheckBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(signup_btn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(271, 378);
            panel1.TabIndex = 0;
            // 
            // signup_btn
            // 
            signup_btn.BackColor = Color.White;
            signup_btn.Cursor = Cursors.Hand;
            signup_btn.FlatStyle = FlatStyle.Flat;
            signup_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signup_btn.ForeColor = Color.MidnightBlue;
            signup_btn.Location = new Point(24, 302);
            signup_btn.Name = "signup_btn";
            signup_btn.Size = new Size(208, 41);
            signup_btn.TabIndex = 9;
            signup_btn.Text = "SIGN UP";
            signup_btn.UseVisualStyleBackColor = false;
            signup_btn.Click += signup_btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("ErgoeBlackCond", 10.1999989F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(68, 274);
            label6.Name = "label6";
            label6.Size = new Size(119, 19);
            label6.TabIndex = 9;
            label6.Text = "REGISTER HERE";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.Popup;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(29, 159);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(562, 3);
            label1.Name = "label1";
            label1.Size = new Size(20, 20);
            label1.TabIndex = 1;
            label1.Text = "X";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("ErgoeBlackCond", 13.7999992F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(301, 48);
            label3.Name = "label3";
            label3.Size = new Size(91, 26);
            label3.TabIndex = 2;
            label3.Text = "SIGN IN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(301, 112);
            label4.Name = "label4";
            label4.Size = new Size(98, 23);
            label4.TabIndex = 3;
            label4.Text = "User Name";
            // 
            // user_name_text
            // 
            user_name_text.Cursor = Cursors.IBeam;
            user_name_text.Location = new Point(301, 147);
            user_name_text.Name = "user_name_text";
            user_name_text.Size = new Size(238, 27);
            user_name_text.TabIndex = 4;
            // 
            // Password_text
            // 
            Password_text.Cursor = Cursors.IBeam;
            Password_text.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password_text.Location = new Point(301, 229);
            Password_text.Name = "Password_text";
            Password_text.PasswordChar = '*';
            Password_text.Size = new Size(238, 27);
            Password_text.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(301, 194);
            label5.Name = "label5";
            label5.Size = new Size(86, 23);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.MidnightBlue;
            login_btn.Cursor = Cursors.Hand;
            login_btn.FlatStyle = FlatStyle.Flat;
            login_btn.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            login_btn.ForeColor = Color.White;
            login_btn.Location = new Point(301, 301);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(102, 41);
            login_btn.TabIndex = 7;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // showPassword_btn
            // 
            showPassword_btn.AutoSize = true;
            showPassword_btn.Cursor = Cursors.Hand;
            showPassword_btn.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            showPassword_btn.Location = new Point(409, 262);
            showPassword_btn.Name = "showPassword_btn";
            showPassword_btn.Size = new Size(130, 24);
            showPassword_btn.TabIndex = 8;
            showPassword_btn.Text = "Show Password";
            showPassword_btn.UseVisualStyleBackColor = true;
            showPassword_btn.CheckedChanged += showPassword_btn_CheckedChanged;
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(585, 378);
            Controls.Add(showPassword_btn);
            Controls.Add(login_btn);
            Controls.Add(Password_text);
            Controls.Add(label5);
            Controls.Add(user_name_text);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SignIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox user_name_text;
        private TextBox Password_text;
        private Label label5;
        private Button login_btn;
        private CheckBox showPassword_btn;
        private Button signup_btn;
        private Label label6;
    }
}
