using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class CardBUL
    {
        CardDAL cardDal = new CardDAL();

        // Validate Card
        public bool checkCardNo(string cardNo) {
            return cardDal.checkCardNo(cardNo);
        }

        // Validate PIN
        public string checkPIN(string cardNo) {
            return cardDal.checkPIN(cardNo);
        }

        // update attempt
        public bool updateAttempt(string cardNo) {
            return cardDal.updateAttempt(cardNo);
        }

        //get attempt
        public bool checkAttempt(string cardNo) {
            if (cardDal.getAttempt(cardNo) >= 0 && cardDal.getAttempt(cardNo) < 3)
            {
                return true;
            }
            else if (cardDal.getAttempt(cardNo) == -1 || cardDal.getAttempt(cardNo) == 3)
            {
                return false;
            }
            return true;
        }

        //check status
        public bool checkStatus(string cardNo)
        {
            if (cardDal.getStatus(cardNo).Equals("normal"))
            {
                return true;
            }
            else if (cardDal.getStatus(cardNo).Equals("block"))
            {
                return false;
            }
            return true;
        }

        // change PIN
        public bool changePIN(string cardNo, string newPIN) {
            return cardDal.changePIN(cardNo, newPIN);
        }

        // check expiredDate
        public bool checkExpiredDate(string cardNo) {
            string currentDate = DateTime.Now.ToString("yyyy-MM-dd");
            int currentYear = Convert.ToInt32(currentDate.Split('-')[0]);
            int currentMonth = Convert.ToInt32(currentDate.Split('-')[1]);
            int currentDay = Convert.ToInt32(currentDate.Split('-')[2]);

            int exYear = Convert.ToInt32(cardDal.getExpiredDate(cardNo).Split('/')[2]);
            int extMonth = Convert.ToInt32(cardDal.getExpiredDate(cardNo).Split('/')[1]);
            int exDay = Convert.ToInt32(cardDal.getExpiredDate(cardNo).Split('/')[0]);

            if (currentYear > exYear) {
                return false;
            }
            else if (currentYear == exYear)
            {
                if (currentMonth > extMonth)
                {
                    return false;
                }
                else if (currentMonth < extMonth)
                {
                    return true;
                }
                else if (currentMonth == extMonth)
                {
                    if (currentDay > exDay)
                    {
                        return false;
                    }
                    else if (currentDay < exDay)
                    {
                        return true;
                    }
                    else
                    {
                        return true;
                    }
                }
            }
            else {
                return true;
            }
            return false;
        }




    }
}
