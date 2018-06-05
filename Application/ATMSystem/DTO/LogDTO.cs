using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LogDTO
    {
        public string logID{get;set;}
        public string logDate{get;set;}
        public int amount{get;set;}
        public string details{get;set;}
        public string cardNoTo{get;set;}
        public string logTypeID{get;set;}
        public string atmID{get;set;}
        public string cardNo{get;set;}

        public LogDTO() { }

        public LogDTO(string logid, string logdate, int amou, string detai, string cardTo, string logtype, string atmid, string cardNo) {
            this.logID = logid;
            this.logDate = logdate;
            this.amount = amou;
            this.details = detai;
            this.cardNoTo = cardTo;
            this.logTypeID = logtype;
            this.atmID = atmid;
            this.cardNo = cardNo;
        }
    }
}
