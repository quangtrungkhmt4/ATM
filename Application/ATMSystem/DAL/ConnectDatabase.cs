using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class ConnectDatabase
    {
        public static SqlConnection conn =
            new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnString"].ToString());
        public static bool CHECK_OPEN = false;

        public static SqlConnection connect
        {
            get { return ConnectDatabase.conn; }
        }

        public static void open()
        {
            conn.Open();
            CHECK_OPEN = true;
        }

        public static void close()
        {
            conn.Close();
            CHECK_OPEN = false;
        }
    }
}
