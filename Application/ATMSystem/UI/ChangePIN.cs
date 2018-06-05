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
    public partial class ChangePIN : UserControl
    {

        private static ChangePIN _instance;
        public static ChangePIN Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChangePIN();
                }
                return _instance;
            }
        }

        public ChangePIN()
        {
            InitializeComponent();
        }

        private void ChangePIN_Load(object sender, EventArgs e)
        {

        }

        public void clearTextBoxNewPIN() {
            tbNewPIN.Text = "";
        }

        public string getTextBoxNewPIN() {
            return tbNewPIN.Text;
        }

        public void setTextBoxNewPIN(string str) {
            if (tbNewPIN.Text.Length < 5)
                tbNewPIN.Text = tbNewPIN.Text + str;
        }

        public void showLbSuccess() {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tbNewPIN.Visible = false;
        }

        public void showLbFail()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            tbNewPIN.Visible = false;
        }

        public void reset()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            tbNewPIN.Visible = true;
        }




    }
}
