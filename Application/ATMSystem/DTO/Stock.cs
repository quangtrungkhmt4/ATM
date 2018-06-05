using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Stock
    {
        public string stockID { get; set; }
        public int quantity { get; set; }
        public string moneyID { get; set; }
        public string atmID { get; set; }

        public Stock() { }

        public Stock(string id, int quantity, string moneyid, string atmid) {
            this.stockID = id;
            this.quantity = quantity;
            this.moneyID = moneyid;
            this.atmID = atmid;
        }
    }
}
