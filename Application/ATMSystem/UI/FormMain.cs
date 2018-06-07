using BUL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class formMain : Form
    {
        public static string state;
        private CardBUL carcBUL = new CardBUL();
        private CustomerBUL custBUL = new CustomerBUL();
        private LogBUL logBUL = new LogBUL();
        private ConfigBUL configBUL = new ConfigBUL();
        private AccountBUL accountBUL = new AccountBUL();
        private StockBUL stockBUL = new StockBUL();
        private int pageNumber;
        private int numberRecord;
        
        public formMain()
        {
            InitializeComponent();
            pageNumber = 1;
            numberRecord = configBUL.getNumPerPage();

            state = "validateCard";
            if (!panelMain.Controls.Contains(ValidateCard.Instance))
            {
                panelMain.Controls.Add(ValidateCard.Instance);
                ValidateCard.Instance.Dock = DockStyle.Fill;
                ValidateCard.Instance.BringToFront();
            }
            else
            {
                ValidateCard.Instance.BringToFront();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            
            // state validate card
            if (state.Equals("validateCard"))
            {
                checkCardNo();
            }
            // state validate PIN
            else if (state.Equals("validatePin"))
            {
                checkPIN();
            }
            // state change PIN
            else if (state.Equals("changePIN")) {
                changePIN();
            }
            // state cash transfer card
            else if (state.Equals("cashTransferCard"))
            {
                pressEnterCashTransferCard();
            }
            // state cash transfer money
            else if (state.Equals("cashTransferMoney"))
            {
                pressEnterCashTransferMoney();
            }
            else if (state.Equals("customWidthdraw")) {
                pressEnterCustomWidthdraw();
            }
                
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // state validate card
            if (state.Equals("validateCard"))
            {
                ValidateCard.Instance.clearTextBoxCardNo();
            }
            // state validate PIN
            else if (state.Equals("validatePin"))
            {
                ValidatePin.Instance.clearTextBoxPIN();
            }
            // state change PIN
            else if (state.Equals("changePIN"))
            {
                ChangePIN.Instance.clearTextBoxNewPIN();
            }
            // state cash transfer card
            else if (state.Equals("cashTransferCard")) {
                CashTransfer.Instance.clearTextBoxCardNoTo();
            }
            // state cash transfer money
            else if (state.Equals("cashTransferMoney"))
            {
                CashTransfer.Instance.clearTextBoxMoneyTransfer();
            }
            // state custom widthdraw
            else if (state.Equals("customWidthdraw")) {
                CustomWidthdraw.Instance.clearTextBoxCustom();
            }                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // back to List service 
            if (state.Equals("changePIN") || state.Equals("changePINFail") || state.Equals("changePINSuccess"))
            {
                exitChangePIN();
            }
            // back to Validate Card
            else if (state.Equals("listService"))
            {
                exitListService();
            }
            // back to List service 
            else if (state.Equals("viewHistory"))
            {
                exitViewHistory();
            }
            // state cash transfer card
            else if (state.Equals("cashTransferCard"))
            {
                exitCashTransferCard();
            }
            // state cash transfer money
            else if (state.Equals("cashTransferMoney"))
            {
                exitCashTransferMoney();
            }
            // state cash transfer money
            else if (state.Equals("success"))
            {
                exitSuccessCashTransfer();
            }
            // state cash transfer money
            else if (state.Equals("fail"))
            {
                exitFailCashTransfer();
            }

            // state widthdraw
            else if (state.Equals("widthdraw"))
            {
                exitWidthdraw();
            }            
        }



        private void btn1_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("1");
            else if (state.Equals("validatePin"))
                enterTextBox("1");
            else if (state.Equals("changePIN"))
                enterTextBox("1");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("1");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("1");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("2");
            else if (state.Equals("validatePin"))
                enterTextBox("2");
            else if (state.Equals("changePIN"))
                enterTextBox("2");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("2");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("2");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("3");
            else if (state.Equals("validatePin"))
                enterTextBox("3");
            else if (state.Equals("changePIN"))
                enterTextBox("3");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("3");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("3");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("4");
            else if (state.Equals("validatePin"))
                enterTextBox("4");
            else if (state.Equals("changePIN"))
                enterTextBox("4");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("4");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("4");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("5");
            else if (state.Equals("validatePin"))
                enterTextBox("5");
            else if (state.Equals("changePIN"))
                enterTextBox("5");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("5");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("5");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("6");
            else if (state.Equals("validatePin"))
                enterTextBox("6");
            else if (state.Equals("changePIN"))
                enterTextBox("6");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("6");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("6");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("7");
            else if (state.Equals("validatePin"))
                enterTextBox("7");
            else if (state.Equals("changePIN"))
                enterTextBox("7");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("7");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("7");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("8");
            else if (state.Equals("validatePin"))
                enterTextBox("8");
            else if (state.Equals("changePIN"))
                enterTextBox("8");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("8");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("8");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("9");
            else if (state.Equals("validatePin"))
                enterTextBox("9");
            else if (state.Equals("changePIN"))
                enterTextBox("9");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("9");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("9");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("9");
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (state.Equals("validateCard"))
                enterTextBox("0");
            else if (state.Equals("validatePin"))
                enterTextBox("0");
            else if (state.Equals("changePIN"))
                enterTextBox("0");
            else if (state.Equals("cashTransferCard"))
                enterTextBox("0");
            else if (state.Equals("cashTransferMoney"))
                enterTextBox("0");
            else if (state.Equals("customWidthdraw"))
                enterTextBox("0");
        }



        private void enterTextBox(string str)
        {
            // state validate card
            if (state.Equals("validateCard"))
            {
                ValidateCard.Instance.setTextBoxCardNo(str);
            }
            // state validate PIN
            else if (state.Equals("validatePin")) 
            {
                ValidatePin.Instance.setTextBoxPIN(str);
            }
                //state change PIN
            else if (state.Equals("changePIN"))
            {
                ChangePIN.Instance.setTextBoxNewPIN(str);
            }
                //state cash transfer
            else if (state.Equals("cashTransferCard"))
            {
                CashTransfer.Instance.setTextBoxCardNoTo(str);
            }
            else if (state.Equals("cashTransferMoney"))
            {
                CashTransfer.Instance.setTextBoxMoneyTransfer(str);
            }
            else if (state.Equals("customWidthdraw")) {
                CustomWidthdraw.Instance.setTextBoxCustom(str);
            }
        }


        private void btnLeft1_Click(object sender, EventArgs e)
        {
            // state widthdraw
            if (state.Equals("widthdraw")) {
                widthdrawSelectOne();
            }
        }

        private void btnLeft2_Click(object sender, EventArgs e)
        {
            // withDraw
            if (state.Equals("listService")) {
                openStateWidthdraw();
            }
            // state widthdraw
            else if (state.Equals("widthdraw"))
            {
                widthdrawSelectTwo();
            }
        }

        private void btnLeft3_Click(object sender, EventArgs e)
        {
            // check balance
            if (state.Equals("listService"))
            {
                openStateCheckBalance();
            }
            // state widthdraw
            else if (state.Equals("widthdraw"))
            {
                widthdrawSelectThree();
            }

        }

        private void btnLeft4_Click(object sender, EventArgs e)
        {
            // change PIN
            if (state.Equals("listService"))
            {
                openStateChangePIN();
            }

            else if (state.Equals("viewHistory"))
            {
                backPageViewHistory();
            }
            // state widthdraw
            else if (state.Equals("widthdraw"))
            {
                widthdrawSelectFour();
            }
        }

        private void btnRight1_Click(object sender, EventArgs e)
        {
            // state widthdraw
            if (state.Equals("widthdraw"))
            {
                widthdrawSelectFive();
            }
        }

        private void btnRight2_Click(object sender, EventArgs e)
        {
            // state widthdraw
            if (state.Equals("widthdraw"))
            {
                widthdrawSelectSix();
            }
        }

        private void btnRight3_Click(object sender, EventArgs e)
        {
            // state validate card
            if (state.Equals("validateCard"))
            {
                checkCardNo();
            }
            // state validate PIN
            else if (state.Equals("validatePin"))
            {
                checkPIN();
            }
            // state check Balance
            else if (state.Equals("checkBalance"))
            {
                exitCheckBalance();
            }
                // state cash transfer
            else if (state.Equals("listService")) {
                openStateCashTransfer();
            }
            // state cash transfer card
            else if (state.Equals("cashTransferCard"))
            {
                checkCardStateCashTransfer();
            }
            // state cash transfer money
            else if (state.Equals("cashTransferMoney"))
            {
                processCashTransfer();
            }

            // state widthdraw
            if (state.Equals("widthdraw"))
            {
                widthdrawSelectSeven();
            }



        }

        private void btnRight4_Click(object sender, EventArgs e)
        {
            // state validate card
            if (state.Equals("validateCard"))
            {
                ValidateCard.Instance.clearTextBoxCardNo();
            }
            // state validate PIN
            else if (state.Equals("validatePin"))
            {
                exitValidatePIN();
            }
                // view history
            else if (state.Equals("listService"))
            {
                openStateViewHistory();
            }
            else if (state.Equals("viewHistory"))
            {
                nextPageViewHistory();
            }
             // state check Balance
            else if (state.Equals("checkBalance"))
            {
                endUser();
            }
            // state cash transfer card
            else if (state.Equals("cashTransferCard"))
            {
                exitCashTransferCard();
            }
            // state cash transfer money
            else if (state.Equals("cashTransferMoney"))
            {
                exitCashTransferMoney();
            }
            // state custom widthdraw
            else if (state.Equals("widthdraw"))
            {
                openStateCustomWidthdraw();
            }
        }


        ////////////////////////////////// Lê Quang Trung

        // function to check CardNo
        private void checkCardNo()
        {
            bool checkSuccess = carcBUL.checkCardNo(ValidateCard.Instance.getTextBoxCardNo());
            if (checkSuccess)
            {
                lbCardNo.Text = ValidateCard.Instance.getTextBoxCardNo();
                if (!panelMain.Controls.Contains(ValidatePin.Instance))
                {
                    panelMain.Controls.Add(ValidatePin.Instance);
                    ValidatePin.Instance.Dock = DockStyle.Fill;
                    ValidatePin.Instance.BringToFront();
                }
                else
                {
                    ValidatePin.Instance.BringToFront();
                }
                ValidateCard.Instance.clearTextBoxCardNo();
                state = "validatePin";
            }
            else
            {
                ValidateCard.Instance.getlbCheckMa().Visible = true;
                ValidateCard.Instance.clearTextBoxCardNo();
            }
        }

        // function to check PIN
        private void checkPIN()
        {
            bool checkAttempt = carcBUL.checkAttempt(lbCardNo.Text);
            bool checkStatus = carcBUL.checkStatus(lbCardNo.Text);
            bool checkExpiredDate = carcBUL.checkExpiredDate(lbCardNo.Text);
            if (carcBUL.checkPIN(lbCardNo.Text).Equals(ValidatePin.Instance.getTextBoxPin()) && checkAttempt && checkStatus && checkExpiredDate)
            {
                if (!panelMain.Controls.Contains(ListService.Instance))
                {
                    panelMain.Controls.Add(ListService.Instance);
                    ListService.Instance.Dock = DockStyle.Fill;
                    ListService.Instance.BringToFront();
                }
                else
                {
                    ListService.Instance.BringToFront();
                }
                state = "listService";
                ValidatePin.Instance.clearTextBoxPIN();
                ListService.Instance.setNameHello(custBUL.getNameCustomer(lbCardNo.Text));
            }
            else if (carcBUL.checkPIN(lbCardNo.Text).Equals(ValidatePin.Instance.getTextBoxPin()) || !checkAttempt || !checkStatus || !checkExpiredDate)
            {
                ValidatePin.Instance.getLbLockCard().Visible = true;
            }
            else
            {
                ValidatePin.Instance.getLbCheckPIN().Visible = true;
                ValidatePin.Instance.clearTextBoxPIN();
                bool checkUpdateAttempt = carcBUL.updateAttempt(lbCardNo.Text);
            }
        }

        // function to change PIN
        private void changePIN()
        {
            if (ChangePIN.Instance.getTextBoxNewPIN().Length == 0)
            {
                state = "changePINFail";
                if (!panelMain.Controls.Contains(ChangePINFail.Instance))
                {
                    panelMain.Controls.Add(ChangePINFail.Instance);
                    ChangePINFail.Instance.Dock = DockStyle.Fill;
                    ChangePINFail.Instance.BringToFront();
                }
                else
                {
                    ChangePINFail.Instance.BringToFront();
                }
                return;
            }
            bool checkChangePIN = carcBUL.changePIN(lbCardNo.Text, ChangePIN.Instance.getTextBoxNewPIN());
            if (checkChangePIN)
            {
                state = "changePINSuccess";
                createLog("logtype04", 0, "", lbCardNo.Text, "atm01", "New PIN:" + ChangePIN.Instance.getTextBoxNewPIN());
                if (!panelMain.Controls.Contains(ChangePINSuccess.Instance))
                {
                    panelMain.Controls.Add(ChangePINSuccess.Instance);
                    ChangePINSuccess.Instance.Dock = DockStyle.Fill;
                    ChangePINSuccess.Instance.BringToFront();
                }
                else
                {
                    ChangePINSuccess.Instance.BringToFront();
                }
            }
            else
            {
                state = "changePINFail";
                if (!panelMain.Controls.Contains(ChangePINFail.Instance))
                {
                    panelMain.Controls.Add(ChangePINFail.Instance);
                    ChangePINFail.Instance.Dock = DockStyle.Fill;
                    ChangePINFail.Instance.BringToFront();
                }
                else
                {
                    ChangePINFail.Instance.BringToFront();
                }
            }
        }

        // switch from control list service to control view history
        private void openStateViewHistory() {
            if (!panelMain.Controls.Contains(ViewHistory.Instance))
            {
                panelMain.Controls.Add(ViewHistory.Instance);
                ViewHistory.Instance.Dock = DockStyle.Fill;
                ViewHistory.Instance.BringToFront();
            }
            else
            {
                ViewHistory.Instance.BringToFront();
            }
            state = "viewHistory";
            pageNumber = 1;

            setDataGridViewHistory(pageNumber, numberRecord);
        }

        // switch from control list service to control change pin
        private void openStateChangePIN() {
            if (!panelMain.Controls.Contains(ChangePIN.Instance))
            {
                panelMain.Controls.Add(ChangePIN.Instance);
                ChangePIN.Instance.Dock = DockStyle.Fill;
                ChangePIN.Instance.BringToFront();
            }
            else
            {
                ChangePIN.Instance.BringToFront();
            }
            state = "changePIN";
        }

        // set data for DataGridViewHistory
        private void setDataGridViewHistory(int page, int record)
        {
            ViewHistory.Instance.getDataGridView().DataSource = logBUL.getAllLog(lbCardNo.Text).Skip((page - 1) * record).Take(record).ToList();
            ViewHistory.Instance.settingDataGridView();
        }

        // back to state validate card from state validate pin
        private void exitValidatePIN() {
            ValidatePin.Instance.clearTextBoxPIN();
            ValidatePin.Instance.getLbLockCard().Visible = false;
            ValidatePin.Instance.getLbCheckPIN().Visible = false;
            if (!panelMain.Controls.Contains(ValidateCard.Instance))
            {
                panelMain.Controls.Add(ValidatePin.Instance);
                ValidateCard.Instance.Dock = DockStyle.Fill;
                ValidateCard.Instance.BringToFront();
            }
            else
            {
                ValidateCard.Instance.BringToFront();
            }
            lbCardNo.Text = "";
            ValidateCard.Instance.clearTextBoxCardNo();
            state = "validateCard";
        }

        // back to state list service from state change PIN
        private void exitChangePIN() {
            ChangePIN.Instance.clearTextBoxNewPIN();
            ChangePIN.Instance.reset();
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
            ListService.Instance.setNameHello(custBUL.getNameCustomer(lbCardNo.Text));
        }

        // back to state validate card from state list service
        private void exitListService() {
            if (!panelMain.Controls.Contains(ValidateCard.Instance))
            {
                panelMain.Controls.Add(ValidateCard.Instance);
                ValidateCard.Instance.Dock = DockStyle.Fill;
                ValidateCard.Instance.BringToFront();
            }
            else
            {
                ValidateCard.Instance.BringToFront();
            }
            state = "validateCard";
        }

        // back to state list service from state view history
        private void exitViewHistory() {
            ViewHistory.Instance.getDataGridView().Refresh();
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
            ListService.Instance.setNameHello(custBUL.getNameCustomer(lbCardNo.Text));
        }

        // return to previous page in state view history
        private void backPageViewHistory() {
            if (pageNumber - 1 > 0)
            {
                pageNumber--;
                setDataGridViewHistory(pageNumber, numberRecord);
            }
        }

        // next page in state view history
        private void nextPageViewHistory() {
            if (pageNumber - 1 < logBUL.getAllLog(lbCardNo.Text).Count / numberRecord)
            {
                pageNumber++;
                setDataGridViewHistory(pageNumber, numberRecord);
            }
        }


        ////////////////////////////////// Nguyễn Phùng Hải Chung

        // switch from control list service to control check balance
        private void openStateCheckBalance() {
            if (!panelMain.Controls.Contains(CheckBalance.Instance))
            {
                panelMain.Controls.Add(CheckBalance.Instance);
                CheckBalance.Instance.Dock = DockStyle.Fill;
                CheckBalance.Instance.BringToFront();
            }
            else
            {
                CheckBalance.Instance.BringToFront();
            }
            state = "checkBalance";
            CheckBalance.Instance.setLbBalance(accountBUL.getBalance(lbCardNo.Text));
            createLog("logtype03", accountBUL.getBalanceInt(lbCardNo.Text), "", lbCardNo.Text, "atm01", "Check Balance");
        }

        // back to state list service from state check balance
        private void exitCheckBalance() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
            ListService.Instance.setNameHello(custBUL.getNameCustomer(lbCardNo.Text));
        }

        // user press "Không" switch to state validate card
        private void endUser() {
            if (!panelMain.Controls.Contains(ValidateCard.Instance))
            {
                panelMain.Controls.Add(ValidateCard.Instance);
                ValidateCard.Instance.Dock = DockStyle.Fill;
                ValidateCard.Instance.BringToFront();
            }
            else
            {
                ValidateCard.Instance.BringToFront();
            }
            state = "validateCard";
        }

        // function to create log
        private void createLog(string logType, int amount, string cardTo, string cardNo, string atmId, string details)
        {
            string dateTime = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:sszzz");
            string logID = "log" + dateTime;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            bool checkCreateLog = logBUL.createLog(logID, date, amount, details, cardTo, logType, atmId, cardNo);
        }


        ////////////////////////////////// Nguyễn Duy Linh

        // back to state list service from state cash transfer
        private void exitCashTransferCard() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
        }

        // back to state list service from state cash transfer
        private void exitCashTransferMoney() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
        }

        // back to state list service from state cash transfer success
        private void exitSuccessCashTransfer() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
        }

        // back to state list service from state cash transfer fail
        private void exitFailCashTransfer() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
        }

        // back to state list service from state widthdraw
        private void exitWidthdraw() {
            if (!panelMain.Controls.Contains(ListService.Instance))
            {
                panelMain.Controls.Add(ListService.Instance);
                ListService.Instance.Dock = DockStyle.Fill;
                ListService.Instance.BringToFront();
            }
            else
            {
                ListService.Instance.BringToFront();
            }
            state = "listService";
        }

        // press ENTER in state cash transfer card
        private void pressEnterCashTransferCard() {
            bool checkCardTo = carcBUL.checkCardNo(CashTransfer.Instance.getTextBoxCardNoTo());
            if (!checkCardTo)
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                Fail.Instance.showErrorCard();
                state = "fail";
            }
            else
            {
                CashTransfer.Instance.hideCardShowMoney();
                state = "cashTransferMoney";
            }
        }

        // press ENTER in state cash transfer money
        private void pressEnterCashTransferMoney() {
            if (CashTransfer.Instance.getTextBoxMoneyTransfer().Equals(""))
            {
                return;
            }
            bool checkMoney = accountBUL.compareBalance(Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer()), lbCardNo.Text);

            if (!checkMoney)
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                Fail.Instance.showErrorMoney();
                state = "fail";
            }
            else
            {
                bool checkSuccess = accountBUL.updateBalance(Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer())
                    , lbCardNo.Text, CashTransfer.Instance.getTextBoxCardNoTo());
                if (!checkSuccess)
                {
                    if (!panelMain.Controls.Contains(Fail.Instance))
                    {
                        panelMain.Controls.Add(Fail.Instance);
                        Fail.Instance.Dock = DockStyle.Fill;
                        Fail.Instance.BringToFront();
                    }
                    else
                    {
                        Fail.Instance.BringToFront();
                    }
                    state = "fail";
                }
                else
                {
                    if (!panelMain.Controls.Contains(Success.Instance))
                    {
                        panelMain.Controls.Add(Success.Instance);
                        Success.Instance.Dock = DockStyle.Fill;
                        Success.Instance.BringToFront();
                    }
                    else
                    {
                        Success.Instance.BringToFront();
                    }
                    state = "success";
                    createLog("logtype02", Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer())
                        , CashTransfer.Instance.getTextBoxCardNoTo(), lbCardNo.Text, "atm01", "Thành công");
                }
            }
        }

        // press ENTER in state custom widthdraw
        private void pressEnterCustomWidthdraw() {
            bool check = stockBUL.updateQuantity(Convert.ToInt32(CustomWidthdraw.Instance.getTextBoxCustom()));
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", Convert.ToInt32(CustomWidthdraw.Instance.getTextBoxCustom()), "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(Convert.ToInt32(CustomWidthdraw.Instance.getTextBoxCustom()), lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 50.000
        private void widthdrawSelectOne() {
            bool check = stockBUL.updateQuantity(50000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 50000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(50000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // switch from control list service to control widthdraw
        private void openStateWidthdraw() {
            if (!panelMain.Controls.Contains(Widthdraw.Instance))
            {
                panelMain.Controls.Add(Widthdraw.Instance);
                Widthdraw.Instance.Dock = DockStyle.Fill;
                Widthdraw.Instance.BringToFront();
            }
            else
            {
                Widthdraw.Instance.BringToFront();
            }
            state = "widthdraw";
        }

        // select widthdraw 100.000
        private void widthdrawSelectTwo() {
            bool check = stockBUL.updateQuantity(100000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 100000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(100000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 200.000
        private void widthdrawSelectThree() {
            bool check = stockBUL.updateQuantity(200000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 200000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(200000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 500.000
        private void widthdrawSelectFour() {
            bool check = stockBUL.updateQuantity(500000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 500000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(500000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 1.000.000
        private void widthdrawSelectFive() {
            bool check = stockBUL.updateQuantity(1000000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 1000000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(1000000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 1.500.000
        private void widthdrawSelectSix() {
            bool check = stockBUL.updateQuantity(1500000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 1500000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(1500000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // select widthdraw 2.000.000
        private void widthdrawSelectSeven() {
            bool check = stockBUL.updateQuantity(2000000);
            if (check)
            {
                if (!panelMain.Controls.Contains(Success.Instance))
                {
                    panelMain.Controls.Add(Success.Instance);
                    Success.Instance.Dock = DockStyle.Fill;
                    Success.Instance.BringToFront();
                }
                else
                {
                    Success.Instance.BringToFront();
                }
                state = "success";
                createLog("logtype01", 2000000, "", lbCardNo.Text, "atm01", "Thành công");
                accountBUL.updateBalance(2000000, lbCardNo.Text);
            }
            else
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                state = "fail";
            }
        }

        // switch from control list service to control cash transfer
        private void openStateCashTransfer() {
            if (!panelMain.Controls.Contains(CashTransfer.Instance))
            {
                panelMain.Controls.Add(CashTransfer.Instance);
                CashTransfer.Instance.Dock = DockStyle.Fill;
                CashTransfer.Instance.BringToFront();
            }
            else
            {
                CashTransfer.Instance.BringToFront();
            }
            CashTransfer.Instance.refesh();
            state = "cashTransferCard";
        }

        // check card to cash transfer
        private void checkCardStateCashTransfer()
        {
            bool checkCardTo = carcBUL.checkCardNo(CashTransfer.Instance.getTextBoxCardNoTo());
            if (!checkCardTo)
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                Fail.Instance.showErrorCard();
                state = "fail";
            }
            else
            {
                CashTransfer.Instance.hideCardShowMoney();
                state = "cashTransferMoney";
            }
        }

        // excute cash transfer
        private void processCashTransfer() {
            if (CashTransfer.Instance.getTextBoxMoneyTransfer().Equals(""))
            {
                return;
            }
            bool checkMoney = accountBUL.compareBalance(Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer()), lbCardNo.Text);

            if (!checkMoney)
            {
                if (!panelMain.Controls.Contains(Fail.Instance))
                {
                    panelMain.Controls.Add(Fail.Instance);
                    Fail.Instance.Dock = DockStyle.Fill;
                    Fail.Instance.BringToFront();
                }
                else
                {
                    Fail.Instance.BringToFront();
                }
                Fail.Instance.showErrorMoney();
                state = "fail";
            }
            else
            {
                bool checkSuccess = accountBUL.updateBalance(Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer())
                    , lbCardNo.Text, CashTransfer.Instance.getTextBoxCardNoTo());
                if (!checkSuccess)
                {
                    if (!panelMain.Controls.Contains(Fail.Instance))
                    {
                        panelMain.Controls.Add(Fail.Instance);
                        Fail.Instance.Dock = DockStyle.Fill;
                        Fail.Instance.BringToFront();
                    }
                    else
                    {
                        Fail.Instance.BringToFront();
                    }
                    state = "fail";
                }
                else
                {
                    if (!panelMain.Controls.Contains(Success.Instance))
                    {
                        panelMain.Controls.Add(Success.Instance);
                        Success.Instance.Dock = DockStyle.Fill;
                        Success.Instance.BringToFront();
                    }
                    else
                    {
                        Success.Instance.BringToFront();
                    }
                    state = "success";
                    createLog("logtype02", Convert.ToInt32(CashTransfer.Instance.getTextBoxMoneyTransfer()), CashTransfer.Instance.getTextBoxCardNoTo(), lbCardNo.Text, "atm01", "Thành công");
                }
            }
        }

        // switch from control widthdraw to control custom widthdraw
        private void openStateCustomWidthdraw() {
            if (!panelMain.Controls.Contains(CustomWidthdraw.Instance))
            {
                panelMain.Controls.Add(CustomWidthdraw.Instance);
                CustomWidthdraw.Instance.Dock = DockStyle.Fill;
                CustomWidthdraw.Instance.BringToFront();
            }
            else
            {
                CustomWidthdraw.Instance.BringToFront();
            }
            state = "customWidthdraw";
            CustomWidthdraw.Instance.clearTextBoxCustom();
        }

    }
}