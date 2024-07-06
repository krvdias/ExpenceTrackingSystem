namespace ExpenceTrackingSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            exit_btn = new Label();
            panel2 = new Panel();
            logout_btn = new Button();
            expense_btn = new Button();
            income_btn = new Button();
            addCategory_btn = new Button();
            dashboard_btn = new Button();
            getuser = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            dashboardForm1 = new DashboardForm();
            expensesForm1 = new ExpensesForm();
            incomeForm1 = new IncomeForm();
            categoryForm1 = new CategoryForm();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(exit_btn);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1315, 73);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Budget1;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Cursor = Cursors.Hand;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.MidnightBlue;
            label1.Location = new Point(85, 25);
            label1.Name = "label1";
            label1.Size = new Size(208, 26);
            label1.TabIndex = 12;
            label1.Text = "Expence Tracker";
            // 
            // exit_btn
            // 
            exit_btn.AutoSize = true;
            exit_btn.Cursor = Cursors.Hand;
            exit_btn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit_btn.Location = new Point(1289, 6);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(20, 20);
            exit_btn.TabIndex = 11;
            exit_btn.Text = "X";
            exit_btn.Click += exit_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(logout_btn);
            panel2.Controls.Add(expense_btn);
            panel2.Controls.Add(income_btn);
            panel2.Controls.Add(addCategory_btn);
            panel2.Controls.Add(dashboard_btn);
            panel2.Controls.Add(getuser);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(302, 698);
            panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            logout_btn.BackColor = Color.Transparent;
            logout_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            logout_btn.ForeColor = Color.MidnightBlue;
            logout_btn.Image = (Image)resources.GetObject("logout_btn.Image");
            logout_btn.ImageAlign = ContentAlignment.MiddleLeft;
            logout_btn.Location = new Point(30, 635);
            logout_btn.Name = "logout_btn";
            logout_btn.Size = new Size(242, 40);
            logout_btn.TabIndex = 6;
            logout_btn.Text = "Log Out";
            logout_btn.UseVisualStyleBackColor = false;
            logout_btn.Click += logout_btn_Click;
            // 
            // expense_btn
            // 
            expense_btn.BackColor = Color.Transparent;
            expense_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expense_btn.ForeColor = Color.MidnightBlue;
            expense_btn.Image = Properties.Resources.Dashboard_Layout;
            expense_btn.ImageAlign = ContentAlignment.MiddleLeft;
            expense_btn.Location = new Point(30, 445);
            expense_btn.Name = "expense_btn";
            expense_btn.Size = new Size(242, 40);
            expense_btn.TabIndex = 5;
            expense_btn.Text = "Expense";
            expense_btn.UseVisualStyleBackColor = false;
            expense_btn.Click += expense_btn_Click;
            // 
            // income_btn
            // 
            income_btn.BackColor = Color.Transparent;
            income_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            income_btn.ForeColor = Color.MidnightBlue;
            income_btn.Image = Properties.Resources.Dashboard_Layout;
            income_btn.ImageAlign = ContentAlignment.MiddleLeft;
            income_btn.Location = new Point(30, 375);
            income_btn.Name = "income_btn";
            income_btn.Size = new Size(242, 40);
            income_btn.TabIndex = 4;
            income_btn.Text = "Income";
            income_btn.UseVisualStyleBackColor = false;
            income_btn.Click += income_btn_Click;
            // 
            // addCategory_btn
            // 
            addCategory_btn.BackColor = Color.Transparent;
            addCategory_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            addCategory_btn.ForeColor = Color.MidnightBlue;
            addCategory_btn.Image = Properties.Resources.Dashboard_Layout;
            addCategory_btn.ImageAlign = ContentAlignment.MiddleLeft;
            addCategory_btn.Location = new Point(30, 300);
            addCategory_btn.Name = "addCategory_btn";
            addCategory_btn.Size = new Size(242, 40);
            addCategory_btn.TabIndex = 3;
            addCategory_btn.Text = "Add Category";
            addCategory_btn.UseVisualStyleBackColor = false;
            addCategory_btn.Click += addCategory_btn_Click;
            // 
            // dashboard_btn
            // 
            dashboard_btn.BackColor = Color.Transparent;
            dashboard_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dashboard_btn.ForeColor = Color.MidnightBlue;
            dashboard_btn.Image = Properties.Resources.Dashboard_Layout;
            dashboard_btn.ImageAlign = ContentAlignment.MiddleLeft;
            dashboard_btn.Location = new Point(30, 230);
            dashboard_btn.Name = "dashboard_btn";
            dashboard_btn.Size = new Size(242, 40);
            dashboard_btn.TabIndex = 2;
            dashboard_btn.Text = "Dashboard";
            dashboard_btn.UseVisualStyleBackColor = false;
            dashboard_btn.Click += dashboard_btn_Click;
            // 
            // getuser
            // 
            getuser.AutoSize = true;
            getuser.Font = new Font("Swis721 Hv BT", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            getuser.ForeColor = Color.White;
            getuser.Location = new Point(44, 141);
            getuser.Name = "getuser";
            getuser.Size = new Size(134, 27);
            getuser.TabIndex = 1;
            getuser.Text = "WELCOME";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Name;
            pictureBox2.Location = new Point(101, 22);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(dashboardForm1);
            panel3.Controls.Add(expensesForm1);
            panel3.Controls.Add(incomeForm1);
            panel3.Controls.Add(categoryForm1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(302, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(1013, 698);
            panel3.TabIndex = 2;
            // 
            // dashboardForm1
            // 
            dashboardForm1.Location = new Point(0, 0);
            dashboardForm1.Name = "dashboardForm1";
            dashboardForm1.Size = new Size(1013, 872);
            dashboardForm1.TabIndex = 14;
            // 
            // expensesForm1
            // 
            expensesForm1.Location = new Point(0, 0);
            expensesForm1.Name = "expensesForm1";
            expensesForm1.Size = new Size(1013, 872);
            expensesForm1.TabIndex = 14;
            // 
            // incomeForm1
            // 
            incomeForm1.Location = new Point(0, 0);
            incomeForm1.Name = "incomeForm1";
            incomeForm1.Size = new Size(1013, 872);
            incomeForm1.TabIndex = 1;
            // 
            // categoryForm1
            // 
            categoryForm1.Location = new Point(0, 0);
            categoryForm1.Name = "categoryForm1";
            categoryForm1.Size = new Size(1013, 698);
            categoryForm1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1315, 771);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label exit_btn;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Label getuser;
        private Button dashboard_btn;
        private Button expense_btn;
        private Button income_btn;
        private Button addCategory_btn;
        private Button logout_btn;
        private Panel panel3;
        private CategoryForm categoryForm1;
        private DashboardForm dashboardForm1;
        private ExpensesForm expensesForm1;
        private IncomeForm incomeForm1;
    }
}