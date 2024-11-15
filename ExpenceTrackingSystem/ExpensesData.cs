﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ExpenceTrackingSystem
{
    internal class ExpensesData
    {
        //// Define the default path for your database
        //private readonly string defaultPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ExpenceTraker", "ExpenceTrackerDB.mdf");

        //// Construct the connection string
        //private readonly string stringConnection;

        //public ExpensesData()
        //{
        //    // Initialize the connection string with the default path
        //    stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""{defaultPath}"";Integrated Security=True";
        //}

        string stringConnection = $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""D:\c# projects\Expence Traker\new Code\ExpenceTrackingSystem\ExpenceTrackerDB.mdf"";Integrated Security=True";

        public int ID { get; set; }

        public string Category { get; set; }

        public string Item { get; set; }

        public string Cost { get; set; }

        public string Description { get; set; }

        public string DateExpense { get; set; }

        public List<ExpensesData> ExpensesListData()
        {
            List<ExpensesData> listData = new List<ExpensesData>();

            using (SqlConnection connect = new SqlConnection(stringConnection))
            {
                connect.Open();

                string selectData = "SELECT * FROM expenses WHERE user_id = @user_id";

                using (SqlCommand cmd = new SqlCommand(selectData, connect))
                {
                    int getUserId = SignIn.userid;
                    cmd.Parameters.AddWithValue("@user_id", getUserId);

                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        ExpensesData eData = new ExpensesData();
                        eData.ID = (int)reader["id"];
                        eData.Category = reader["category"].ToString();
                        eData.Item = reader["item"].ToString();
                        eData.Cost = reader["cost"].ToString();
                        eData.Description = reader["description"].ToString();
                        eData.DateExpense = ((DateTime)reader["date_expense"]).ToString("MM-dd-yyyy");

                        listData.Add(eData);
                    }
                }
            }

            return listData;
        }
    }
}
