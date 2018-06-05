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
    public partial class ValidatePin : UserControl
    {
        private static ValidatePin _instance;
        public static ValidatePin Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ValidatePin();
                }
                return _instance;
            }
        }

        public ValidatePin()
        {
            InitializeComponent();
            formMain.state = "validatePin";
        }

        public Label getLbCheckPIN() {
            return lbCheckMaPIN;
        }

        public string getTextBoxPin() {
            return tbPIN.Text;
        }

        public void setTextBoxPIN(string str) {
            if(tbPIN.Text.Length < 5)
                tbPIN.Text = tbPIN.Text + str;
        }

        public void clearTextBoxPIN() {
            tbPIN.Text = "";
        }

        public Label getLbLockCard() {
            return lbLockCard;
        }
    }
}
