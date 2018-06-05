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
    public partial class Success : UserControl
    {

        private static Success _instance;
        public static Success Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Success();
                }
                return _instance;
            }
        }

        public Success()
        {
            InitializeComponent();
        }
    }
}
