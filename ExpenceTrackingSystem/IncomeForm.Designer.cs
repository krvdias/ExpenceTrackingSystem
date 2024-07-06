namespace ExpenceTrackingSystem
{
    partial class IncomeForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            income_deletebtn = new Button();
            income_clearbtn = new Button();
            income_updatebtn = new Button();
            income_addbtn = new Button();
            income_date = new DateTimePicker();
            label6 = new Label();
            description_txt = new TextBox();
            label5 = new Label();
            income_txt = new TextBox();
            label4 = new Label();
            item_txt = new TextBox();
            label3 = new Label();
            category_drp = new ComboBox();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(17, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 345);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 25);
            label1.TabIndex = 1;
            label1.Text = "Income List";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.WhiteSmoke;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 55);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(951, 279);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(income_deletebtn);
            panel2.Controls.Add(income_clearbtn);
            panel2.Controls.Add(income_updatebtn);
            panel2.Controls.Add(income_addbtn);
            panel2.Controls.Add(income_date);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(description_txt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(income_txt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(item_txt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(category_drp);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 323);
            panel2.TabIndex = 2;
            // 
            // income_deletebtn
            // 
            income_deletebtn.BackColor = Color.MidnightBlue;
            income_deletebtn.FlatStyle = FlatStyle.Flat;
            income_deletebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            income_deletebtn.ForeColor = SystemColors.ButtonHighlight;
            income_deletebtn.Image = Properties.Resources.Delete;
            income_deletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            income_deletebtn.Location = new Point(506, 248);
            income_deletebtn.Name = "income_deletebtn";
            income_deletebtn.Size = new Size(201, 55);
            income_deletebtn.TabIndex = 15;
            income_deletebtn.Text = "Delete";
            income_deletebtn.UseVisualStyleBackColor = false;
            income_deletebtn.Click += income_deletebtn_Click;
            // 
            // income_clearbtn
            // 
            income_clearbtn.BackColor = Color.MidnightBlue;
            income_clearbtn.FlatStyle = FlatStyle.Flat;
            income_clearbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            income_clearbtn.ForeColor = SystemColors.ButtonHighlight;
            income_clearbtn.Image = Properties.Resources.Broom;
            income_clearbtn.ImageAlign = ContentAlignment.MiddleLeft;
            income_clearbtn.Location = new Point(745, 248);
            income_clearbtn.Name = "income_clearbtn";
            income_clearbtn.Size = new Size(201, 55);
            income_clearbtn.TabIndex = 14;
            income_clearbtn.Text = "Clear";
            income_clearbtn.UseVisualStyleBackColor = false;
            income_clearbtn.Click += income_clearbtn_Click;
            // 
            // income_updatebtn
            // 
            income_updatebtn.BackColor = Color.MidnightBlue;
            income_updatebtn.FlatStyle = FlatStyle.Flat;
            income_updatebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            income_updatebtn.ForeColor = SystemColors.ButtonHighlight;
            income_updatebtn.Image = Properties.Resources.Installing_Updates;
            income_updatebtn.ImageAlign = ContentAlignment.MiddleLeft;
            income_updatebtn.Location = new Point(267, 248);
            income_updatebtn.Name = "income_updatebtn";
            income_updatebtn.Size = new Size(201, 55);
            income_updatebtn.TabIndex = 13;
            income_updatebtn.Text = "Update";
            income_updatebtn.UseVisualStyleBackColor = false;
            income_updatebtn.Click += income_updatebtn_Click;
            // 
            // income_addbtn
            // 
            income_addbtn.BackColor = Color.MidnightBlue;
            income_addbtn.BackgroundImageLayout = ImageLayout.None;
            income_addbtn.FlatStyle = FlatStyle.Flat;
            income_addbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            income_addbtn.ForeColor = SystemColors.ButtonHighlight;
            income_addbtn.Image = Properties.Resources.Add1;
            income_addbtn.ImageAlign = ContentAlignment.MiddleLeft;
            income_addbtn.Location = new Point(29, 248);
            income_addbtn.Name = "income_addbtn";
            income_addbtn.Size = new Size(201, 55);
            income_addbtn.TabIndex = 12;
            income_addbtn.Text = "Add";
            income_addbtn.UseVisualStyleBackColor = false;
            income_addbtn.Click += income_addbtn_Click;
            // 
            // income_date
            // 
            income_date.CustomFormat = "MM-dd-yyyy";
            income_date.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_date.Format = DateTimePickerFormat.Custom;
            income_date.Location = new Point(569, 175);
            income_date.Name = "income_date";
            income_date.Size = new Size(250, 31);
            income_date.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(446, 178);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 9;
            label6.Text = "Date : ";
            // 
            // description_txt
            // 
            description_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            description_txt.Location = new Point(569, 23);
            description_txt.Multiline = true;
            description_txt.Name = "description_txt";
            description_txt.Size = new Size(377, 126);
            description_txt.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(446, 26);
            label5.Name = "label5";
            label5.Size = new Size(117, 25);
            label5.TabIndex = 7;
            label5.Text = "Description : ";
            // 
            // income_txt
            // 
            income_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            income_txt.Location = new Point(135, 169);
            income_txt.Name = "income_txt";
            income_txt.Size = new Size(262, 31);
            income_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 172);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 5;
            label4.Text = "Income : ";
            // 
            // item_txt
            // 
            item_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            item_txt.Location = new Point(135, 95);
            item_txt.Name = "item_txt";
            item_txt.Size = new Size(262, 31);
            item_txt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(31, 96);
            label3.Name = "label3";
            label3.Size = new Size(62, 25);
            label3.TabIndex = 3;
            label3.Text = "Item : ";
            // 
            // category_drp
            // 
            category_drp.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            category_drp.FormattingEnabled = true;
            category_drp.Location = new Point(135, 24);
            category_drp.Name = "category_drp";
            category_drp.Size = new Size(262, 33);
            category_drp.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(29, 23);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 1;
            label2.Text = "Category : ";
            // 
            // IncomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IncomeForm";
            Size = new Size(1013, 698);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private ComboBox category_drp;
        private DateTimePicker income_date;
        private Label label6;
        private TextBox description_txt;
        private Label label5;
        private TextBox income_txt;
        private Label label4;
        private TextBox item_txt;
        private Button income_deletebtn;
        private Button income_clearbtn;
        private Button income_updatebtn;
        private Button income_addbtn;
    }
}
