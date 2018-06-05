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
    public partial class ChangePINFail : UserControl
    {

        private static ChangePINFail _instance;
        public static ChangePINFail Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChangePINFail();
                }
                return _instance;
            }
        }

        public ChangePINFail()
        {
            InitializeComponent();
        }
    }
}
