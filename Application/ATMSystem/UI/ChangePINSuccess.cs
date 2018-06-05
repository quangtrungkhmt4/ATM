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
    public partial class ChangePINSuccess : UserControl
    {

        private static ChangePINSuccess _instance;
        public static ChangePINSuccess Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ChangePINSuccess();
                }
                return _instance;
            }
        }

        public ChangePINSuccess()
        {
            InitializeComponent();
        }
    }
}
