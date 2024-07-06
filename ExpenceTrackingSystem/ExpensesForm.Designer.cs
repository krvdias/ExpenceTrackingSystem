namespace ExpenceTrackingSystem
{
    partial class ExpensesForm
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
            panel2 = new Panel();
            expence_deletebtn = new Button();
            expence_clearbtn = new Button();
            expence_updatebtn = new Button();
            expence_addbtn = new Button();
            expense_date = new DateTimePicker();
            label6 = new Label();
            description_txt = new TextBox();
            label5 = new Label();
            cost_txt = new TextBox();
            label4 = new Label();
            item_txt = new TextBox();
            label3 = new Label();
            category_drp = new ComboBox();
            label2 = new Label();
            panel1 = new Panel();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(expence_deletebtn);
            panel2.Controls.Add(expence_clearbtn);
            panel2.Controls.Add(expence_updatebtn);
            panel2.Controls.Add(expence_addbtn);
            panel2.Controls.Add(expense_date);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(description_txt);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cost_txt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(item_txt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(category_drp);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(17, 355);
            panel2.Name = "panel2";
            panel2.Size = new Size(978, 323);
            panel2.TabIndex = 4;
            // 
            // expence_deletebtn
            // 
            expence_deletebtn.BackColor = Color.MidnightBlue;
            expence_deletebtn.FlatStyle = FlatStyle.Flat;
            expence_deletebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expence_deletebtn.ForeColor = SystemColors.ButtonHighlight;
            expence_deletebtn.Image = Properties.Resources.Delete;
            expence_deletebtn.ImageAlign = ContentAlignment.MiddleLeft;
            expence_deletebtn.Location = new Point(506, 248);
            expence_deletebtn.Name = "expence_deletebtn";
            expence_deletebtn.Size = new Size(201, 55);
            expence_deletebtn.TabIndex = 15;
            expence_deletebtn.Text = "Delete";
            expence_deletebtn.UseVisualStyleBackColor = false;
            expence_deletebtn.Click += expence_deletebtn_Click;
            // 
            // expence_clearbtn
            // 
            expence_clearbtn.BackColor = Color.MidnightBlue;
            expence_clearbtn.FlatStyle = FlatStyle.Flat;
            expence_clearbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expence_clearbtn.ForeColor = SystemColors.ButtonHighlight;
            expence_clearbtn.Image = Properties.Resources.Broom;
            expence_clearbtn.ImageAlign = ContentAlignment.MiddleLeft;
            expence_clearbtn.Location = new Point(745, 248);
            expence_clearbtn.Name = "expence_clearbtn";
            expence_clearbtn.Size = new Size(201, 55);
            expence_clearbtn.TabIndex = 14;
            expence_clearbtn.Text = "Clear";
            expence_clearbtn.UseVisualStyleBackColor = false;
            expence_clearbtn.Click += expence_clearbtn_Click;
            // 
            // expence_updatebtn
            // 
            expence_updatebtn.BackColor = Color.MidnightBlue;
            expence_updatebtn.FlatStyle = FlatStyle.Flat;
            expence_updatebtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expence_updatebtn.ForeColor = SystemColors.ButtonHighlight;
            expence_updatebtn.Image = Properties.Resources.Installing_Updates;
            expence_updatebtn.ImageAlign = ContentAlignment.MiddleLeft;
            expence_updatebtn.Location = new Point(267, 248);
            expence_updatebtn.Name = "expence_updatebtn";
            expence_updatebtn.Size = new Size(201, 55);
            expence_updatebtn.TabIndex = 13;
            expence_updatebtn.Text = "Update";
            expence_updatebtn.UseVisualStyleBackColor = false;
            expence_updatebtn.Click += expence_updatebtn_Click;
            // 
            // expence_addbtn
            // 
            expence_addbtn.BackColor = Color.MidnightBlue;
            expence_addbtn.BackgroundImageLayout = ImageLayout.None;
            expence_addbtn.FlatStyle = FlatStyle.Flat;
            expence_addbtn.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            expence_addbtn.ForeColor = SystemColors.ButtonHighlight;
            expence_addbtn.Image = Properties.Resources.Add1;
            expence_addbtn.ImageAlign = ContentAlignment.MiddleLeft;
            expence_addbtn.Location = new Point(29, 248);
            expence_addbtn.Name = "expence_addbtn";
            expence_addbtn.Size = new Size(201, 55);
            expence_addbtn.TabIndex = 12;
            expence_addbtn.Text = "Add";
            expence_addbtn.UseVisualStyleBackColor = false;
            expence_addbtn.Click += expence_addbtn_Click;
            // 
            // expense_date
            // 
            expense_date.CustomFormat = "MM-dd-yyyy";
            expense_date.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            expense_date.Format = DateTimePickerFormat.Custom;
            expense_date.Location = new Point(569, 175);
            expense_date.Name = "expense_date";
            expense_date.Size = new Size(250, 31);
            expense_date.TabIndex = 10;
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
            // cost_txt
            // 
            cost_txt.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cost_txt.Location = new Point(135, 169);
            cost_txt.Name = "cost_txt";
            cost_txt.Size = new Size(262, 31);
            cost_txt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(31, 172);
            label4.Name = "label4";
            label4.Size = new Size(61, 25);
            label4.TabIndex = 5;
            label4.Text = "Cost : ";
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(17, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(978, 345);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 1;
            label1.Text = "Expenses List";
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
            // ExpensesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ExpensesForm";
            Size = new Size(1013, 698);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button expence_deletebtn;
        private Button expence_clearbtn;
        private Button expence_updatebtn;
        private Button expence_addbtn;
        private DateTimePicker expense_date;
        private Label label6;
        private TextBox description_txt;
        private Label label5;
        private TextBox cost_txt;
        private Label label4;
        private TextBox item_txt;
        private Label label3;
        private ComboBox category_drp;
        private Label label2;
        private Panel panel1;
        private Label label1;
        private DataGridView dataGridView1;
    }
}
