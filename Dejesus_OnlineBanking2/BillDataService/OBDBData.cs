using Microsoft.Data.SqlClient;
using ObModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BillDataService
{
    public class OBDBData:IOB
    {
        private string connectionString
       = "Data Source =localhost\\SQLEXPRESS; Initial Catalog = OnlineBankingDB; Integrated Security = True; TrustServerCertificate=True;";

        private SqlConnection sqlConnection;
        public OBDBData()
        {
            sqlConnection = new SqlConnection(connectionString);

            AddSeeds();
        }

        private void AddSeeds()
        {
            var existing = GetBills();

            if (existing.Count == 0)
            {
                Bills prod = new Bills { BillType = "Product", BillAmount = 3700, PaymentMethod= "Gcash", AccountName = "Tom" , AccountNumber = 1234343};
                Bills el = new Bills { BillType = "Electric", BillAmount = 1500, PaymentMethod = "Gcash", AccountName = "Tom", AccountNumber = 1234343 };
                Bills wat = new Bills { BillType = "Water", BillAmount = 2000, PaymentMethod = "Gcash", AccountName = "Tom", AccountNumber = 1234343 };

                Add(prod);
                Add(el);
                Add(wat);
            }
        }
        public void Add(Bills bils)
        {
            var insertStatement = "INSERT INTO OnlineBankingTbl VALUES (@BillType, @BillAmount, @PaymentMethod, @AccountName,@AccountNumber)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, sqlConnection);

            insertCommand.Parameters.AddWithValue("@BillType", bils.BillType);
            insertCommand.Parameters.AddWithValue("@BillAmount", bils.BillAmount);
            insertCommand.Parameters.AddWithValue("@PaymentMethod", bils.PaymentMethod);
            insertCommand.Parameters.AddWithValue("@AccountName", bils.AccountName);
            insertCommand.Parameters.AddWithValue("@AccountNumber", bils.AccountNumber);
            sqlConnection.Open();

            insertCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public List<Bills> GetBills()
        {
            string selectStatement = "SELECT BillType, BillAmount, PaymentMethod, AccountName,AccountNumber FROM OnlineBankingTbl";

            SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);

            sqlConnection.Open();

            SqlDataReader reader = selectCommand.ExecuteReader();

            var bilss = new List<Bills>();

            while (reader.Read())
            {
                //deserialize

                Bills bl = new Bills();
                bl.BillType = reader["BillType"].ToString();
                bl.BillAmount = Convert.ToDouble( reader["BillAmount"].ToString());
                bl.PaymentMethod = reader["PaymentMethod"].ToString();
                bl.AccountName = reader["AccountName"].ToString();
                bl.AccountNumber = Convert.ToInt32(reader["AccountNumber"].ToString());

                bilss.Add(bl);
            }

            sqlConnection.Close();
            return bilss;
        }

        //public Account? GetById(Guid id)
        //{
        //    var selectStatement = "SELECT AccountId, Username, Password FROM Accounts WHERE AccountId = @AccountId";
        //    SqlCommand selectCommand = new SqlCommand(selectStatement, sqlConnection);
        //    selectCommand.Parameters.AddWithValue("@AccountId", id.ToString());
        //    sqlConnection.Open();
        //    SqlDataReader reader = selectCommand.ExecuteReader();

        //    var account = new Account();

        //    while (reader.Read())
        //    {
        //        account.AccountId = Guid.Parse(reader["AccountId"].ToString());
        //        account.Username = reader["Username"].ToString();
        //        account.Password = reader["Password"].ToString();
        //    }

        //    sqlConnection.Close();
        //    return account;
        //}
    }
}
