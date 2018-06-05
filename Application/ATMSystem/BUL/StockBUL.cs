using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUL
{
    public class StockBUL
    {
        private StockDAL stock = new StockDAL();
        public bool updateQuantity(int money) {
            if (money > 5000000 || money % 50000 != 0) {
                return false;
            }
            string totalMoney = customSheet(money);
            if (totalMoney.Contains("&"))
            {
                string[] arr = totalMoney.Split('&');
                string[] typeOne = arr[0].Split('-');
                int count = Convert.ToInt32(typeOne[0]);
                int moneyValue = Convert.ToInt32(typeOne[1]);
                int total = count * moneyValue;
                string moneyID = "";
                if (moneyValue == 10000)
                    moneyID = "money01";
                else if (moneyValue == 20000)
                    moneyID = "money02";
                else if (moneyValue == 50000)
                    moneyID = "money03";
                else if (moneyValue == 100000)
                    moneyID = "money04";
                else if (moneyValue == 200000)
                    moneyID = "money05";
                else if (moneyValue == 500000)
                    moneyID = "money06";
                bool check = stock.updateQuantity("atm01", total, moneyID);

                string[] typeOne1 = arr[1].Split('-');
                int count1 = Convert.ToInt32(typeOne1[0]);
                int moneyValue1 = Convert.ToInt32(typeOne1[1]);
                int total1 = count1 * moneyValue1;
                string moneyID1 = "";
                if (moneyValue1 == 10000)
                    moneyID1 = "money01";
                else if (moneyValue1 == 20000)
                    moneyID1 = "money02";
                else if (moneyValue1 == 50000)
                    moneyID1 = "money03";
                else if (moneyValue1 == 100000)
                    moneyID1 = "money04";
                else if (moneyValue1 == 200000)
                    moneyID1 = "money05";
                else if (moneyValue1 == 500000)
                    moneyID1 = "money06";
                return stock.updateQuantity("atm01", total1, moneyID1);
            }
            else {
                string[] typeOne = totalMoney.Split('-');
                int count = Convert.ToInt32(typeOne[0]);
                int moneyValue = Convert.ToInt32(typeOne[1]);
                int total = count * moneyValue;
                string moneyID = "";
                if (moneyValue == 10000)
                    moneyID = "money01";
                else if (moneyValue == 20000)
                    moneyID = "money02";
                else if (moneyValue == 50000)
                    moneyID = "money03";
                else if (moneyValue == 100000)
                    moneyID = "money04";
                else if (moneyValue == 200000)
                    moneyID = "money05";
                else if (moneyValue == 500000)
                    moneyID = "money06";
                return  stock.updateQuantity("atm01", total, moneyID);
            }
        }

        private string customSheet(int mon) { 
                int[] money = new int[]{500000, 200000, 100000, 50000, 20000, 10000};
                List<string> ways = new List<string>();
                int total, countSheet;
                int mod;
                total = mon;
                for (int i = 0; i < money.Length; i++) {
                    countSheet = total / money[i];
                    if (countSheet != 0) {
                        String moneyEven = countSheet + "-" + money[i];
                        int tienChan = countSheet * money[i];
                        mod = total - countSheet * money[i];
                        if (mod == 0){
                            ways.Add(moneyEven);
                        }else {
                            while (mod != 0) {
                                for (int j = 0; j < money.Length; j++)
                                {
                                    countSheet = mod / money[j];
                                    if (countSheet != 0 && mod == countSheet * money[j]) {
                                        String pence = "&" + countSheet + "-" + money[j];
                                        mod = total - tienChan - countSheet * money[j];
                                        ways.Add(moneyEven + pence);
                                    }
                                }
                            }
                        }
                    }
                }

                return ways[0];
        }
    }
}
