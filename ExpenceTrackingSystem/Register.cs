using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ExpenceTrackingSystem
{
    public partial class Register : Form
    {
        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        //// Initialize the connection with the constructed connection string
        //private readonly SqlConnection connect;

        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True");

        public Register()
        {
            InitializeComponent();

            //// Initialize the connection string with the default path
            //stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";

            //// Initialize the SqlConnection object with the constructed connection string
            //connect = new SqlConnection(stringConnection);
        }

        public bool checkConnection()
        {
            return (connect.State == ConnectionState.Closed) ? true : false;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signin_btn_Click(object sender, EventArgs e)
        {
            SignIn loginForm = new SignIn();
            loginForm.Show();

            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(user_name_text.Text == "" || Password_text.Text == "" || confirm_pasword_text.Text == "")
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (checkConnection())
                {
                    try
                    {
                        connect.Open();

                        string selectUsername = "SELECT * FROM users WHERE username = @usern";
                        using(SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@usern", user_name_text.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkUser);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if(table.Rows.Count != 0)
                            {
                                // TO PUT THE FIRST LETTER TO BIG LETTER
                                string tempUsern = user_name_text.Text.Substring(0, 1).ToUpper() + user_name_text.Text.Substring(1);
                                MessageBox.Show(tempUsern + " is exsisting already", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(Password_text.Text.Length < 8) 
                            {
                                MessageBox.Show("Invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (confirm_pasword_text.Text != Password_text.Text)
                            {
                                MessageBox.Show("Password does not match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO users (username, password, date_create) VALUES(@usern, @pass, @date)";

                                using (SqlCommand insertuser = new SqlCommand(insertData, connect))
                                {
                                    insertuser.Parameters.AddWithValue("@usern", user_name_text.Text.Trim());
                                    insertuser.Parameters.AddWithValue("@pass", Password_text.Text.Trim());

                                    DateTime today = DateTime.Today; //Date Now
                                    insertuser.Parameters.AddWithValue("@date", today);

                                    insertuser.ExecuteNonQuery();

                                    MessageBox.Show("Registerd succsessfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    SignIn loginForm = new SignIn();
                                    loginForm.Show();

                                    this.Hide();
                                }

                            }
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show("Faild Connection : " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void showPassword_btn_CheckedChanged(object sender, EventArgs e)
        {
            Password_text.PasswordChar = showPassword_btn.Checked ? '\0' : '*';
            confirm_pasword_text.PasswordChar = showPassword_btn.Checked ? '\0' : '*';
        }
    }
}
