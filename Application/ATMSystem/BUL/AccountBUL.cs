using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class AccountBUL
    {
        private AccountDAL accountDAL = new AccountDAL();
        public string getBalance(string cardNo) {
            int balance = accountDAL.getBalance(cardNo);
            string str = balance + "";
            List<char> arrChar = new List<char>();
            char[] arr = str.ToCharArray();
            if (arr.Length <= 3)
            {
                return str;
            }
            else {
                for (int i = 0; i < arr.Length; i++)
                {
                    arrChar.Add(arr[i]);
                }

                int count = 1;
                for (int i = arr.Length - 1; i >= 0; i--)
                {
                    if (count < 3)
                    {
                        count++;
                    }
                    else if (count == 3)
                    {
                        if (i != 0)
                        {
                            arrChar.Insert(arrChar.Count - (arrChar.Count - i), ',');
                            count = 1;
                        }
                    }
                }
                return String.Join("", arrChar);
            }
        }

        public int getBalanceInt(string cardNo) {
            return accountDAL.getBalance(cardNo);
        }

        public bool updateBalance(int money, string cardNo, string cardNoTo) {
            return accountDAL.updateBalance(money, cardNo,cardNoTo);
        }

        public bool compareBalance(int money, string cardNo) {
            return accountDAL.compareBalance(money, cardNo);
        }

        // widthdraw
        public bool updateBalance(int money, string cardNo) {
            return accountDAL.updateBalance(money, cardNo);
        }
    }
}
