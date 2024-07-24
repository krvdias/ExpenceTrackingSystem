using System;
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
    public partial class CategoryForm : UserControl
    {

        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public CategoryForm()
        {
            InitializeComponent();

            //// Initialize the connection string with the default path
            //stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";

            displayCategoryList();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            displayCategoryList();

        }

        public void displayCategoryList()
        {
            CategoryData cData = new CategoryData();
            List<CategoryData> listData = cData.categoryListData();

            category_list.DataSource = listData;

            category_list.Columns["Date"].DefaultCellStyle.Format = "MM-dd-yyyy";
        }

        private void category_addbtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all the blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(stringConnection))
                {
                    connect.Open();

                    string insertData = "INSERT INTO categories (category, type, status, date_insert, user_id) " + "VALUES(@category, @type, @status, @date, @user_id)";
                    int getUserId = SignIn.userid;

                    using (SqlCommand cmd = new SqlCommand(insertData, connect))
                    {
                        cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                        cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
                        cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                        DateTime today = DateTime.Today;
                        cmd.Parameters.AddWithValue("@date", today);

                        cmd.Parameters.AddWithValue("@user_id", getUserId);

                        cmd.ExecuteNonQuery();
                        clearFields();

                        MessageBox.Show("Added successfully!", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    connect.Close();
                }
            }
            displayCategoryList();
        }

        private int getID = 0;
        private void category_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = category_list.Rows[e.RowIndex];

                getID = Convert.ToInt32(row.Cells[0].Value);
                category_category.Text = row.Cells[1].Value.ToString();
                category_type.SelectedItem = row.Cells[2].Value.ToString();
                category_status.SelectedItem = row.Cells[3].Value.ToString();
            }
        }

        private void category_updatebtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to update ID : " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string updateData = "UPDATE categories SET category = @category, type = @type, status = @status WHERE id = @id ";

                        using (SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);
                            cmd.Parameters.AddWithValue("@category", category_category.Text.Trim());
                            cmd.Parameters.AddWithValue("@type", category_type.SelectedItem);
                            cmd.Parameters.AddWithValue("@status", category_status.SelectedItem);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Updated successfully!", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayCategoryList();

        }

        public void clearFields()
        {
            category_category.Text = "";
            category_type.SelectedIndex = -1;
            category_status.SelectedIndex = -1;
        }

        private void category_clearbtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void category_deletebtn_Click(object sender, EventArgs e)
        {
            if (category_category.Text == "" || category_type.SelectedIndex == -1 || category_status.SelectedIndex == -1)
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete ID : " + getID + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using (SqlConnection connect = new SqlConnection(stringConnection))
                    {
                        connect.Open();

                        string deleteData = "DELETE FROM categories WHERE id = @id";

                        using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                        {
                            cmd.Parameters.AddWithValue("@id", getID);

                            cmd.ExecuteNonQuery();
                            clearFields();

                            MessageBox.Show("Deleted successfully!", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                        connect.Close();
                    }
                }
            }
            displayCategoryList();
        }

        private void category_list_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
