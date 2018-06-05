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
    public partial class CheckBalance : UserControl
    {

        private static CheckBalance _instance;
        public static CheckBalance Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CheckBalance();
                }
                return _instance;
            }
        }

        public CheckBalance()
        {
            InitializeComponent();
        }

        public Label getLbBalance() {
            return lbBalance;
        }

        public void setLbBalance(string balance) {
            lbBalance.Text = balance + " VND";
        }
    }
}
