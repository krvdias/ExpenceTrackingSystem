using System.Data;
using System.Data.SqlClient;

namespace ExpenceTrackingSystem
{
    public partial class SignIn : Form
    {

        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public SignIn()
        {
            InitializeComponent();

            //// Initialize the connection string with the default path
            //stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Register regForm = new Register();
            regForm.Show();

            this.Hide();
        }

        public static string username;
        public static int userid;

        private void login_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM users WHERE username = @usern AND password = @pass";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    cmd.Parameters.AddWithValue("@usern", user_name_text.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", Password_text.Text.Trim());

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    
                    if(table.Rows.Count > 0)
                    {
                        username = user_name_text.Text;
                        userid = Convert.ToInt32(table.Rows[0]["id"]);

                        MessageBox.Show("Login Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        MainForm mForm = new MainForm();
                        mForm.Show();

                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Incorrect Usename / Password", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void showPassword_btn_CheckedChanged(object sender, EventArgs e)
        {
            Password_text.PasswordChar = (showPassword_btn.Checked) ? '\0' : '*';
        }
    }
}
