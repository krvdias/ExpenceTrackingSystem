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
    public partial class DashboardForm : UserControl
    {
        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;


        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public DashboardForm()
        {
            InitializeComponent();

            //// Initialize the connection string with the default path
            //stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseToday();
            expenseYesterday();
            expenseThisMonth();
            expenseThisYear();
            totalExpense();
            balance();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }

            incomeTodayIncome();
            incomeYesterdayIncome();
            incomeThisMonth();
            incomeThisYear();
            totalIncome();

            expenseToday();
            expenseYesterday();
            expenseThisMonth();
            expenseThisYear();
            totalExpense();
            balance();
        }

        //Income

        public void incomeTodayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(income) FROM income WHERE date_income = @date_income AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_income", today);
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        income_today.Text = "Rs." + todayCost.ToString("0.");
                    }
                    else
                    {
                        income_today.Text = "Rs. 0.00";
                    }
                }
            }
        }

        public void incomeYesterdayIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(income) FROM income WHERE CONVERT(DATE, date_income) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1) AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        income_yesterday.Text = "Rs." + yesterdayCost.ToString("0.");
                    }
                    else
                    {
                        income_yesterday.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public void incomeThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startMonth AND date_income <= @endMonth AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal MonthCost = Convert.ToDecimal(result);

                        income_month.Text = "Rs." + MonthCost.ToString("0.");
                    }
                    else
                    {
                        income_month.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public void incomeThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(income) FROM income WHERE date_income >= @startYear AND date_income <= @endYear AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        income_year.Text = "Rs." + yearCost.ToString("0.");
                    }
                    else
                    {
                        income_year.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public void totalIncome()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(income) FROM income WHERE user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalIncom = totalCost;
                        total_income.Text = "Rs." + totalCost.ToString("0.00");
                    }
                    else
                    {
                        total_income.Text = "Rs. 0.00";
                    }
                }
            }
        }


        //Expenses

        public void expenseToday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense = @date_expense AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    DateTime today = DateTime.Today;
                    cmd.Parameters.AddWithValue("@date_expense", today);
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal todayCost = Convert.ToDecimal(result);

                        expense_today.Text = "Rs." + todayCost.ToString("0.");
                    }
                    else
                    {
                        expense_today.Text = "Rs. 0.00";
                    }
                }
            }
        }

        public void expenseYesterday()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(cost) FROM expenses WHERE CONVERT(DATE, date_expense) = DATEADD(day, DATEDIFF(day, 0, GETDATE()), -1) AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yesterdayCost = Convert.ToDecimal(result);

                        expense_yesterday.Text = "Rs." + yesterdayCost.ToString("0.");
                    }
                    else
                    {
                        expense_yesterday.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public void expenseThisMonth()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                DateTime today = DateTime.Now.Date;
                DateTime startMonth = new DateTime(today.Year, today.Month, 1);
                DateTime endMonth = startMonth.AddMonths(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startMonth AND date_expense <= @endMonth AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);
                    cmd.Parameters.AddWithValue("@startMonth", startMonth);
                    cmd.Parameters.AddWithValue("@endMonth", endMonth);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal MonthCost = Convert.ToDecimal(result);

                        expense_month.Text = "Rs." + MonthCost.ToString("0.");
                    }
                    else
                    {
                        expense_month.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public void expenseThisYear()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                DateTime today = DateTime.Now.Date;
                DateTime startYear = new DateTime(today.Year, 1, 1);
                DateTime endYear = startYear.AddYears(1).AddDays(-1);

                string query = "SELECT SUM(cost) FROM expenses WHERE date_expense >= @startYear AND date_expense <= @endYear AND user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@startYear", startYear);
                    cmd.Parameters.AddWithValue("@endYear", endYear);
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal yearCost = Convert.ToDecimal(result);

                        expense_year.Text = "Rs." + yearCost.ToString("0.");
                    }
                    else
                    {
                        expense_year.Text = "Rs. 0.00";
                    }
                }

            }
        }

        public static decimal totalExpence;
        public static decimal totalIncom;

        public void totalExpense()
        {
            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();
                int getUserId = SignIn.userid;

                string query = "SELECT SUM(cost) FROM expenses WHERE user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@user_id", getUserId);
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        decimal totalCost = Convert.ToDecimal(result);
                        totalExpence = totalCost;
                        total_expense.Text = "Rs." + totalCost.ToString("0.00");
                    }
                    else
                    {
                        total_expense.Text = "Rs. 0.00";
                    }
                }
            }
        }

        public void balance()
        {
            decimal balance = totalIncom - totalExpence;
            balance_txt.Text = "Rs." + balance.ToString("0.00");

            if (balance > 0)
            {
                balance_txt.ForeColor = Color.LightGreen;
            }
            else if (balance < 0)
            {
                balance_txt.ForeColor = Color.Red;
            }
            else
            {
                balance_txt.ForeColor = Color.White; // Neutral color for zero balance
            }
        }

        private void expense_today_Click(object sender, EventArgs e)
        {

        }
    }
}
