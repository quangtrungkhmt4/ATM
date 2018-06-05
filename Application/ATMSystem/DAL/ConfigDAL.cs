using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ConfigDAL
    {
        public int getNumPerPage() {
            try
            {
                int number = -1;
                string query = "select NumPerPage from Config";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    number = Convert.ToInt32(dr["NumPerPage"]);
                }
                ConnectDatabase.close();
                return number;
            }
            catch {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return -1;
            }
        }
    }
}
