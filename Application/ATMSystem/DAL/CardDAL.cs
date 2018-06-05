using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardDAL
    {
        public bool checkCardNo(string cardNo) {
            try
            {
                List<CardDTO> arrCard = new List<CardDTO>();
                string query = "select * from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo",cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    CardDTO card = new CardDTO(
                        dr["CardNo"].ToString(),
                        dr["PIN"].ToString(),
                        dr["Status"].ToString(),
                        dr["StartDate"].ToString(),
                        dr["ExpiredDate"].ToString(),
                        Convert.ToInt32(dr["Attempt"]),
                        dr["AccountID"].ToString());
                    arrCard.Add(card);
                }
                ConnectDatabase.close();
                if (arrCard.Count == 0)
                {
                    return false;
                }
                else {
                    return true;
                }

            }
            catch {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return false;
            }
        }

        public string checkPIN(string cardNo) {
            try
            {
                string PIN = "";
                string query = "select PIN from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read()) {
                    PIN = dr["PIN"].ToString();
                }
                ConnectDatabase.close();
                return PIN;
            }
            catch
            {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return "";
            }
        }

        public bool updateAttempt(string cardNo) {
            try
            {
                int count = 0;
                string query = "select Attempt from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count = Convert.ToInt32(dr["Attempt"]);
                }
                count++;
                ConnectDatabase.close();

                string query1 = "update Card set Attempt = @count where CardNo = @cardNo";
                ConnectDatabase.open();
                SqlCommand cmd1 = new SqlCommand(query1, ConnectDatabase.connect);
                cmd1.Parameters.AddWithValue("count", count);
                cmd1.Parameters.AddWithValue("cardNo", cardNo);
                cmd1.ExecuteNonQuery();

                ConnectDatabase.close();
                return true;
            }
            catch {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return false;
            }

        }

        public int getAttempt(string cardNo) {
            try
            {
                int count = 0;
                string query = "select Attempt from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    count = Convert.ToInt32(dr["Attempt"]);
                }
                ConnectDatabase.close();

                if (count == 3) {
                    string query1 = "update Card set Status = 'block' where CardNo = @cardNo";
                    ConnectDatabase.open();
                    SqlCommand cmd1 = new SqlCommand(query1, ConnectDatabase.connect);
                    cmd1.Parameters.AddWithValue("cardNo", cardNo);
                    cmd1.ExecuteNonQuery();
                    ConnectDatabase.close();
                }
                return count;
            }
            catch {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return -1;
            }
        }


        public string getStatus(string cardNo) {
            try
            {
                string status = "";
                string query = "select Status from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    status = dr["Status"].ToString();
                }
                ConnectDatabase.close();
                return status;
            }
            catch
            {
                if (ConnectDatabase.CHECK_OPEN)
                {
                    ConnectDatabase.close();
                }
                return "";
            }
        }

        public bool changePIN(string cardNo, string newPIN) {
            try
            {
                string query1 = "update Card set PIN = @newPIN where CardNo = @cardNo";
                ConnectDatabase.open();
                SqlCommand cmd1 = new SqlCommand(query1, ConnectDatabase.connect);
                cmd1.Parameters.AddWithValue("newPIN", newPIN);
                cmd1.Parameters.AddWithValue("cardNo", cardNo);
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

        public string getExpiredDate(string cardNo) {
            try
            {
                string exDate = "";
                string query = "select ExpiredDate from Card where CardNo=@cardNo";
                ConnectDatabase.open();
                SqlCommand cmd = new SqlCommand(query, ConnectDatabase.connect);
                cmd.Parameters.AddWithValue("cardNo", cardNo);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    exDate = dr["ExpiredDate"].ToString();
                }
                ConnectDatabase.close();
                return exDate;
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
