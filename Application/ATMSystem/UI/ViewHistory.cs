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
    public partial class ViewHistory : UserControl
    {

        private static ViewHistory _instance;
        public static ViewHistory Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ViewHistory();
                }
                return _instance;
            }
        }

        public ViewHistory()
        {
            InitializeComponent();
        }

        public DataGridView getDataGridView() {
            return dataGridViewHistory;
        }

        public void settingDataGridView() {

            dataGridViewHistory.Columns["logDate"].HeaderText = "Ngày giao dịch";
            dataGridViewHistory.Columns["amount"].HeaderText = "Số tiền giao dịch";
            dataGridViewHistory.Columns["details"].HeaderText = "Chi tiết giao dịch";
            dataGridViewHistory.Columns["cardNoTo"].HeaderText = "Số thẻ nhận tiền";
            dataGridViewHistory.Columns["logTypeID"].HeaderText = "Loại giao dịch";
            dataGridViewHistory.Columns["cardNo"].HeaderText = "Số thẻ thực hiện";
            dataGridViewHistory.Columns["logID"].Visible = false;
            dataGridViewHistory.Columns["atmID"].Visible = false;

            foreach (DataGridViewRow row in dataGridViewHistory.Rows)
            {
                row.Height = (dataGridViewHistory.ClientRectangle.Height - dataGridViewHistory.ColumnHeadersHeight) / dataGridViewHistory.Rows.Count;
            }
        }
    }
}
