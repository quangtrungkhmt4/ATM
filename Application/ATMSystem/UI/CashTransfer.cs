using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class CashTransfer : UserControl
    {

        private static CashTransfer _instance;
        public static CashTransfer Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CashTransfer();
                }
                return _instance;
            }
        }

        public void refesh() {
            panelCardNoTo.Visible = true;
            panelMonetTranfer.Visible = false;
            tbCardNoTo.Text = "";
            tbMoneyTransfer.Text = "";
        }

        public CashTransfer()
        {
            InitializeComponent();
        }

        public string getTextBoxCardNoTo() {
            return tbCardNoTo.Text;
        }

        public string getTextBoxMoneyTransfer()
        {
            return tbMoneyTransfer.Text;
        }

        public void setTextBoxMoneyTransfer(string str)
        {
            tbMoneyTransfer.Text = tbMoneyTransfer.Text + str;
        }

        public void setTextBoxCardNoTo(string str) {
            tbCardNoTo.Text = tbCardNoTo.Text + str;
        }

        public void clearTextBoxCardNoTo() {
            tbCardNoTo.Text = "";
        }

        public void clearTextBoxMoneyTransfer()
        {
            tbMoneyTransfer.Text = "";
        }

        public void hideCardShowMoney() {
            panelCardNoTo.Visible = false;
            panelMonetTranfer.Visible = true;
        }
    }
}
