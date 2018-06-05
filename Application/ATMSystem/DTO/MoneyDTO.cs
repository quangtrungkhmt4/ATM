using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MoneyDTO
    {
        public string moneyID { get; set; }
        public int moneyValue { get;set;}

        public MoneyDTO() { }

        public MoneyDTO(string id, int value) {
            this.moneyID = id;
            this.moneyValue = value;
        }
    }
}
