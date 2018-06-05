using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CardDTO
    {

        public string cardNo{get;set;}
        public string pin{get;set;}
        public string status{get;set;}
        public string startDate{get;set;}
        public string expiredDate {get;set;}
        public int attempt{get;set;}
        public string accountID {get;set;}

        public CardDTO() { }

        public CardDTO(string card, string pin, string sta, string start, string expired, int att, string accid) {
            this.cardNo = card;
            this.pin = pin; 
            this.status = sta;
            this.startDate = start;
            this.expiredDate = expired;
            this.attempt = att;
            this.accountID = accid;
        }
    }
}
