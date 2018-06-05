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
    public partial class ListService : UserControl
    {

        private static ListService _instance;
        public static ListService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ListService();
                }
                return _instance;
            }
        }

        public ListService()
        {
            InitializeComponent();
            formMain.state = "listService";
        }

        public void setNameHello(string name){
            lbHello.Text = "Xin chào, " + name;
        }
    }
}
