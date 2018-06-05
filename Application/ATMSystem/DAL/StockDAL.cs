using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StockDAL
    {
        public bool updateQuantity(string atmId, int money, string moneyID) {
            try
            {

                int total = -1;
                string query = "select Quantity from Stock  where ATMID = @atmId and MoneyID = @moneyID";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("atmId", atmId);
                cmd.Parameters.AddWithValue("moneyID", moneyID);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    total = Convert.ToInt32(dr["Quantity"]);
                }
                ConnectDatabase.close();
                int newTotal = total - money;

                string queryUpdate = "update Stock set Quantity = @newTotal where ATMID = @atmId and MoneyID = @moneyID";
                ConnectDatabase.open();
                SqlCommand cmd1 = new SqlCommand(queryUpdate, ConnectDatabase.connect);
                cmd1.Parameters.AddWithValue("newTotal", newTotal);
                cmd1.Parameters.AddWithValue("atmId", atmId);
                cmd1.Parameters.AddWithValue("moneyID", moneyID);
                cmd1.ExecuteNonQuery();

                ConnectDatabase.close();
                return true;
            }
            catch
            {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return false;
            }
        }

        
    }
}
