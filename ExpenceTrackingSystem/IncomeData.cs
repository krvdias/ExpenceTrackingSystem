using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenceTrackingSystem
{
    internal class IncomeData
    {
        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        //public IncomeData()
        //{
        //    // Initialize the connection string with the default path
        //    stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";
        //}

        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public int ID { get; set; }

        public string Category { get; set; }

        public string Item { get; set; }

        public string Income { get; set; }

        public string Description { get; set; }

        public string DateIncome { get; set; }

        public List<IncomeData> IncomeListData()
        {
            List<IncomeData> listData = new List<IncomeData>();

            using(SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM income WHERE user_id = @user_id";

                using(SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    int getUserId = SignIn.userid;
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        IncomeData iData = new IncomeData();
                        iData.ID = (int)reader["id"];
                        iData.Category = reader["category"].ToString();
                        iData.Item = reader["item"].ToString();
                        iData.Income = reader["income"].ToString();
                        iData.Description = reader["description"].ToString();
                        iData.DateIncome = ((DateTime)reader["date_income"]).ToString("MM-dd-yyyy");

                        listData.Add(iData);
                    }
                }
            }

            return listData;
        }
    }
}
