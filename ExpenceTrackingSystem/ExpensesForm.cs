﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace ExpenceTrackingSystem
{
    public partial class ExpensesForm : UserControl
    {
        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public ExpensesForm()
        {
            InitializeComponent();

            //// Initialize the connection string with the default path
            //stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";

            displayCategoryList();

            displayExpensesData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoryList();

            displayExpensesData();
        }

        public void displayExpensesData()
        {
            ExpensesData eData = new ExpensesData();
            List<ExpensesData> listData = eData.ExpensesListData();

            dataGridView1.DataSource = listData;
        }

        public void displayCategoryList()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string selectData = "SELECT category FROM categories WHERE type = @type AND status = @status AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@type", "Expence");
                    cmd.Parameters.AddWithValue("@status", "Active");
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    category_drp.Items.Clear();
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        category_drp.Items.Add(reader["category"].ToString());
                    }
                }

                connect.Close();
            }
        }

        private void expence_addbtn_Click(object sender, EventArgs e)
        {
            if (category_drp.SelectedIndex == -1 || item_txt.Text == "" || cost_txt.Text == "" || description_txt.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Validate item_txt.Text to contain only letters
                if (!System.Text.RegularExpressions.Regex.IsMatch(item_txt.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("You can only add words in the item field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate cost_txt.Text to contain only numbers
                if (!System.Text.RegularExpressions.Regex.IsMatch(cost_txt.Text, @"^\d+(\.\d{1,2})?$"))
                {
                    MessageBox.Show("You can only add numbers in the cost field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO expenses (category, item, cost, description, date_expense, date_insert, user_id) " + " VALUES(@category, @item, @cost, @description, @date_expense, @date, @user_id)";
                    int getUserId = SignIn.userid;

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", category_drp.SelectedItem);
                        cmd.Parameters.AddWithValue("@item", item_txt.Text);
                        cmd.Parameters.AddWithValue("@cost", cost_txt.Text);
                        cmd.Parameters.AddWithValue("@description", description_txt.Text);
                        cmd.Parameters.AddWithValue("@date_expense", expense_date.Value);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.Parameters.AddWithValue("@user_id", getUserId);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                    connect.Close();
                }
            }

            displayExpensesData();
        }

        public void clearFields()
        {
            item_txt.Text = "";
            category_drp.SelectedIndex = -1;
            cost_txt.Text = "";
            description_txt.Text = "";
        }

        private void expence_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private int getID = 0;

        private void expence_updatebtn_Click(object sender, EventArgs e)
        {
            if (category_drp.SelectedIndex == -1 || item_txt.Text == "" || cost_txt.Text == "" || description_txt.Text == "")
            {
                MessageBox.Show("Please select the item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // Validate item_txt.Text to contain only letters
                if (!System.Text.RegularExpressions.Regex.IsMatch(item_txt.Text, @"^[a-zA-Z\s]+$"))
                {
                    MessageBox.Show("You can only add words in the item field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate cost_txt.Text to contain only numbers
                if (!System.Text.RegularExpressions.Regex.IsMatch(cost_txt.Text, @"^\d+(\.\d{1,2})?$"))
                {
                    MessageBox.Show("You can only add numbers in the cost field.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show("Are you sure you want to Update ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE income SET category = @category, item = @item, cost = cost, description = @description, date_expense = @date_expense WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@category", category_drp.SelectedItem);
                            cmd.Parameters.AddWithValue("@item", item_txt.Text);
                            cmd.Parameters.AddWithValue("@income", cost_txt.Text);
                            cmd.Parameters.AddWithValue("@description", description_txt.Text);
                            cmd.Parameters.AddWithValue("@date_income", expense_date.Value);
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayExpensesData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                getID = (int)row.Cells[0].Value;
                category_drp.SelectedItem = row.Cells[1].Value.ToString();
                item_txt.Text = row.Cells[2].Value.ToString();
                cost_txt.Text = row.Cells[3].Value.ToString();
                description_txt.Text = row.Cells[4].Value.ToString();
                expense_date.Value = Convert.ToDateTime(row.Cells[5].Value.ToString());
            }
        }

        private void expence_deletebtn_Click(object sender, EventArgs e)
        {
            if (category_drp.SelectedIndex == -1 || item_txt.Text == "" || cost_txt.Text == "" || description_txt.Text == "")
            {
                MessageBox.Show("Please select the item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Delete ID:" + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM expenses WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                        connect.Close();
                    }
                }

            }

            displayExpensesData();
        }
    }
}
