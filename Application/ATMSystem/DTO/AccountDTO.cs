using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class AccountDTO
    {

        public string accountID{get;set;}
        public int balance{get;set;}
        public string accountNo{get;set;}
        public string custID{get;set;}
        public string odID{get;set;}
        public string wdID{get;set;}

        public AccountDTO() { }

        public AccountDTO(string id, int balan, string accNo, string cust, string od, string wd) {
            this.accountID = id;
            this.balance = balan;
            this.accountNo = accNo;
            this.custID = cust;
            this.odID = od;
            this.wdID = wd;
        }
    }
}
