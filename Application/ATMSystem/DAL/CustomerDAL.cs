using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CustomerDAL
    {
        public string getNameCustomer(string cardNo) {
            try
            {
                string name = "";
                string query = "select Customer.Name from Account inner join Customer on Account.CustID = Customer.CustID inner join Card on Account.AccountID = Card.AccountID where CardNo = @cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = dr["Name"].ToString();
                }
                ConnectDatabase.close();
                return name;
            }
            catch {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return "";
            }
        }
    }
}
