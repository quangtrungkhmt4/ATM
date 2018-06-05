using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class LogBUL
    {
        LogDAL logDAL = new LogDAL();

        public bool createLog(string logId, string logDate, int amount, string details, string cardNoTo, string logType, string atmID, string cardNo) {
            return logDAL.createLog(logId, logDate, amount, details, cardNoTo, logType, atmID, cardNo);
        }

        public List<LogDTO> getAllLog(string cardNo) {
            List<LogDTO> arrLog = logDAL.getAllLog(cardNo);
            List<LogDTO> arrLogNew = new List<LogDTO>();

            for (int i = 0; i < arrLog.Count; i++) {
                LogDTO log = arrLog[i];
                if (log.logTypeID.Equals("logtype01")) {
                    log.logTypeID = "Rút tiền";
                }
                else if (log.logTypeID.Equals("logtype02")) {
                    log.logTypeID = "Chuyển tiền";
                }
                else if (log.logTypeID.Equals("logtype03"))
                {
                    log.logTypeID = "Kiểm tra tài khoản";
                }
                else if (log.logTypeID.Equals("logtype04"))
                {
                    log.logTypeID = "Đổi mã PIN";
                }
                arrLogNew.Add(log);
            }

            return arrLogNew;
        }
    }
}
