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
    public partial class CustomWidthdraw : UserControl
    {

        private static CustomWidthdraw _instance;
        public static CustomWidthdraw Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new CustomWidthdraw();
                }
                return _instance;
            }
        }

        public CustomWidthdraw()
        {
            InitializeComponent();
        }

        public string getTextBoxCustom() {
            return tbCustomWidthdraw.Text;
        }

        public void setTextBoxCustom(string str) {
            tbCustomWidthdraw.Text = tbCustomWidthdraw.Text + str;
        }

        public void clearTextBoxCustom() {
            tbCustomWidthdraw.Text = "";
        }
    }
}
