using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class CustomerBUL
    {
        CustomerDAL custDAL = new CustomerDAL();

        public string getNameCustomer(string cardNo) {
            return custDAL.getNameCustomer(cardNo);
        }
    }
}
