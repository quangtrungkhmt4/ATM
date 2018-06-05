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
    public partial class ValidateCard : UserControl
    {

        private static ValidateCard _instance;
        public static ValidateCard Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ValidateCard();
                }
                return _instance;
            }
        }

        public ValidateCard()
        {
            InitializeComponent();
        }

        public string getTextBoxCardNo() {
            return tbCardNo.Text;
        }
        public void clearTextBoxCardNo() {
            tbCardNo.Text = "";
        }
        public void setTextBoxCardNo(string str)
        {
            tbCardNo.Text = tbCardNo.Text + str;
        }
        public Label getlbCheckMa() {
            return lbCheckMaThe;
        }
    }
}
