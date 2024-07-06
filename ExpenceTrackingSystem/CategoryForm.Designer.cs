namespace ExpenceTrackingSystem
{
    partial class CategoryForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            panel2 = new Panel();
            category_deletebtn = new Button();
            category_clearbtn = new Button();
            category_updatebtn = new Button();
            category_addbtn = new Button();
            category_status = new ComboBox();
            category_type = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            category_category = new TextBox();
            label1 = new Label();
            panel3 = new Panel();
            label4 = new Label();
            category_list = new DataGridView();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)category_list).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(18, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 677);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(category_deletebtn);
            panel2.Controls.Add(category_clearbtn);
            panel2.Controls.Add(category_updatebtn);
            panel2.Controls.Add(category_addbtn);
            panel2.Controls.Add(category_status);
            panel2.Controls.Add(category_type);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(category_category);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(18, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 678);
            panel2.TabIndex = 1;
            // 
            // category_deletebtn
            // 
            category_deletebtn.BackColor = Color.MidnightBlue;
            category_deletebtn.FlatStyle = FlatStyle.Flat;
            category_deletebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            category_deletebtn.ForeColor = SystemColors.ButtonHighlight;
            category_deletebtn.Image = Properties.Resources.Delete;
            category_deletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            category_deletebtn.Location = new Point(18, 594);
            category_deletebtn.Name = "category_deletebtn";
            category_deletebtn.Size = new Size(201, 55);
            category_deletebtn.TabIndex = 11;
            category_deletebtn.Text = "Delete";
            category_deletebtn.UseVisualStyleBackColor = false;
            category_deletebtn.Click += category_deletebtn_Click;
            // 
            // category_clearbtn
            // 
            category_clearbtn.BackColor = Color.MidnightBlue;
            category_clearbtn.FlatStyle = FlatStyle.Flat;
            category_clearbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            category_clearbtn.ForeColor = SystemColors.ButtonHighlight;
            category_clearbtn.Image = Properties.Resources.Broom;
            category_clearbtn.ImageAlign = ContentAlignment.MiddleLeft;
            category_clearbtn.Location = new Point(18, 508);
            category_clearbtn.Name = "category_clearbtn";
            category_clearbtn.Size = new Size(201, 55);
            category_clearbtn.TabIndex = 10;
            category_clearbtn.Text = "Clear";
            category_clearbtn.UseVisualStyleBackColor = false;
            category_clearbtn.Click += category_clearbtn_Click;
            // 
            // category_updatebtn
            // 
            category_updatebtn.BackColor = Color.MidnightBlue;
            category_updatebtn.FlatStyle = FlatStyle.Flat;
            category_updatebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            category_updatebtn.ForeColor = SystemColors.ButtonHighlight;
            category_updatebtn.Image = Properties.Resources.Installing_Updates;
            category_updatebtn.ImageAlign = ContentAlignment.MiddleLeft;
            category_updatebtn.Location = new Point(18, 418);
            category_updatebtn.Name = "category_updatebtn";
            category_updatebtn.Size = new Size(201, 55);
            category_updatebtn.TabIndex = 9;
            category_updatebtn.Text = "Update";
            category_updatebtn.UseVisualStyleBackColor = false;
            category_updatebtn.Click += category_updatebtn_Click;
            // 
            // category_addbtn
            // 
            category_addbtn.BackColor = Color.MidnightBlue;
            category_addbtn.BackgroundImageLayout = ImageLayout.None;
            category_addbtn.FlatStyle = FlatStyle.Flat;
            category_addbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            category_addbtn.ForeColor = SystemColors.ButtonHighlight;
            category_addbtn.Image = Properties.Resources.Add1;
            category_addbtn.ImageAlign = ContentAlignment.MiddleLeft;
            category_addbtn.Location = new Point(18, 330);
            category_addbtn.Name = "category_addbtn";
            category_addbtn.Size = new Size(201, 55);
            category_addbtn.TabIndex = 8;
            category_addbtn.Text = "Add";
            category_addbtn.UseVisualStyleBackColor = false;
            category_addbtn.Click += category_addbtn_Click;
            // 
            // category_status
            // 
            category_status.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_status.FormattingEnabled = true;
            category_status.Items.AddRange(new object[] { "Active", "Inactive" });
            category_status.Location = new Point(18, 242);
            category_status.Name = "category_status";
            category_status.Size = new Size(201, 33);
            category_status.TabIndex = 7;
            // 
            // category_type
            // 
            category_type.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_type.FormattingEnabled = true;
            category_type.Items.AddRange(new object[] { "Income", "Expence" });
            category_type.Location = new Point(18, 149);
            category_type.Name = "category_type";
            category_type.Size = new Size(201, 33);
            category_type.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 202);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 4;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(18, 110);
            label2.Name = "label2";
            label2.Size = new Size(50, 25);
            label2.TabIndex = 2;
            label2.Text = "Type";
            // 
            // category_category
            // 
            category_category.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            category_category.Location = new Point(18, 59);
            category_category.Name = "category_category";
            category_category.Size = new Size(201, 31);
            category_category.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 25);
            label1.Name = "label1";
            label1.Size = new Size(84, 25);
            label1.TabIndex = 0;
            label1.Text = "Category";
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ButtonHighlight;
            panel3.Controls.Add(label4);
            panel3.Controls.Add(category_list);
            panel3.Location = new Point(291, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(702, 677);
            panel3.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(16, 8);
            label4.Name = "label4";
            label4.Size = new Size(117, 25);
            label4.TabIndex = 12;
            label4.Text = "Category List";
            // 
            // category_list
            // 
            category_list.AllowUserToAddRows = false;
            category_list.AllowUserToDeleteRows = false;
            category_list.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            category_list.BackgroundColor = Color.GhostWhite;
            category_list.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.SelectionForeColor = Color.MidnightBlue;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            category_list.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            category_list.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            category_list.EnableHeadersVisualStyles = false;
            category_list.Location = new Point(16, 47);
            category_list.Name = "category_list";
            category_list.ReadOnly = true;
            category_list.RowHeadersVisible = false;
            category_list.RowHeadersWidth = 51;
            category_list.Size = new Size(672, 613);
            category_list.TabIndex = 0;
            category_list.CellClick += category_list_CellClick;
            category_list.CellContentClick += category_list_CellContentClick;
            // 
            // CategoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CategoryForm";
            Size = new Size(1013, 698);
            Load += CategoryForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)category_list).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private ComboBox category_type;
        private Label label3;
        private Label label2;
        private TextBox category_category;
        private Label label1;
        private Button category_addbtn;
        private ComboBox category_status;
        private Button category_deletebtn;
        private Button category_clearbtn;
        private Button category_updatebtn;
        private Label label4;
        private DataGridView category_list;
    }
}
