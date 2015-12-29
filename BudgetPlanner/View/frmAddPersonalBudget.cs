using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace BudgetPlanner.View
{
    public partial class frmAddPersonalBudget : Form
    {
        Label label;
        public frmAddPersonalBudget()
        {
            InitializeComponent();
        }
        
           public frmAddPersonalBudget(ref Label label):this()
        {
            this.label = label;
        }
        private Controller.PersonalBudget _personalObject = null;
        private Controller.AmountController _amountObject = null;
        private bool _updateFlag = false;

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Form frmCalc = new frmCalculator();
            frmCalc.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEditAmount_Click(object sender, EventArgs e)
        {
            Form frmAddAmnt = new frmAddAmount(true);
            DialogResult dr = frmAddAmnt.ShowDialog();

            if (dr == DialogResult.OK || dr == DialogResult.Cancel)
                LoadUserPersonalAmount(Controller.Constants.USER_LOGIN_ID);
        }

        public Controller.PersonalBudget GetDataFromFields()
        {
            /*        this._personalObject = new Controller.PersonalBudget();

                    this._personalObject.UserID = Controller.Constants.USER_LOGIN_ID;
                    this._personalObject.BusFair = Controller.Utilities.ValidateFields(txtFair.Text);
                    this._personalObject.WithFriends = Controller.Utilities.ValidateFields(txtFriends.Text);
                    this._personalObject.Gifts = Controller.Utilities.ValidateFields(txtGifts.Text);
                    this._personalObject.OnMySelf = Controller.Utilities.ValidateFields(txtMyself.Text);
                    this._personalObject.Extra = Controller.Utilities.ValidateFields(txtExtra.Text);
                    this._personalObject.Clothes = Controller.Utilities.ValidateFields(txtClothes.Text);
                    this._personalObject.Phone = Controller.Utilities.ValidateFields(txtPhone.Text);
                    this._personalObject.Date = Convert.ToDateTime(dtPicker.Text);

                    return this._personalObject;*/
            return null;//temporarily
        }

        public void LoadUserPersonalAmount(string userID)
        {
            this._amountObject = Controller.AmountController.LoadUserTotalAmount(userID, true); // true to load personal amount.

            if (this._amountObject == null)
            {
                // means no amount exists for the person he would have to add new amount
               // lblAmount.Text = "000";
                return;
            }

          //  lblAmount.Text = this._amountObject.PersonalAmount.ToString();
            Controller.Constants.TOTAL_AMOUNT = this._amountObject.PersonalAmount.ToString();
        }

        public void LoadPersonalBudget(string userID, DateTime todaysDate)
        {
            DateTime myDateTime = Controller.Utilities.ToDateTime(todaysDate.Year, todaysDate.Month, todaysDate.Day);
         /*   Controller.PersonalBudget personalObject = Controller.BudgetController.LoadPersonalBudget(userID, myDateTime);

            if (personalObject == null)
            {
                Controller.Messager.ShowMessage("No Personal Budget Available Against Today's Date.", MessageBoxIcon.Information);
                return;
            }

            this._updateFlag = true;

            dtPicker.Value = personalObject.Date;
            txtFair.Text = personalObject.BusFair.ToString();
            txtFriends.Text = personalObject.WithFriends.ToString();
            txtMyself.Text = personalObject.OnMySelf.ToString();
            txtGifts.Text = personalObject.Gifts.ToString();
            txtClothes.Text = personalObject.Clothes.ToString();
            txtExtra.Text = personalObject.Extra.ToString();
            txtPhone.Text = personalObject.Phone.ToString();

            btnSave.ControlText = "Update";
            btnSave.Icon = global::BudgetPlanner.Properties.Resources.addressbook_edit_icon;
            */
        }

        public void Save()
        {
            if (!this._updateFlag)
            {
                Controller.BudgetController.AddPersonalBudget(GetDataFromFields());
                Controller.Messager.ShowMessage("Personal Budget Added Successfully.", MessageBoxIcon.Information);
            }
            else
            {
                Controller.BudgetController.UpdatePersonalBudget(GetDataFromFields());
                Controller.Messager.ShowMessage("Personal Budget Updated Successfully.", MessageBoxIcon.Information);
                this._updateFlag = true;
             //   btnSave.ControlText = "Save";
               // btnSave.Icon = global::BudgetPlanner.Properties.Resources.Actions_document_save_all_icon;
            }

            CalculatePersonalBudget();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void CalculatePersonalBudget()
        {
            int amount = Controller.BudgetController.CalculatePersonalBudget(Controller.Constants.USER_LOGIN_ID, DateTime.Now);

            if (amount != 0)
            {
                SubtractCalculatedBudget(amount);
            }
        }

        // Minus calculated budget from actual HomeAmount of user
        public void SubtractCalculatedBudget(int personalAmount)
        {
            int tempAmount = 0;
            int totalAmount = 0;
            long oldPersonalAmount = Controller.AmountController.GetSpentPersonalAmount(Controller.Constants.USER_LOGIN_ID);

            if (oldPersonalAmount != 0)
                totalAmount = (Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT) + (int)oldPersonalAmount);

            if (totalAmount != 0)
            {
                if (personalAmount >= 0 && personalAmount <= Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT))
                {
                    tempAmount = (totalAmount - personalAmount);
                }
                else
                {
                    personalAmount = Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT);
                    Controller.Messager.ShowMessage("Calculated Amount is more than actual balance, exiting without saving.", MessageBoxIcon.Information);
                    return;
                }
            }

            Controller.Messager.ShowMessage("Calculated Amount is : " + personalAmount, MessageBoxIcon.Information);

            int homeAmount = Controller.Utilities.ToInteger(Controller.AmountController.GetSpentHomeAmount(Controller.Constants.USER_LOGIN_ID).ToString());
            Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, homeAmount, tempAmount);

            if (!this._updateFlag)
            {
                Controller.AmountController.SaveSpentAmount(Controller.Constants.USER_LOGIN_ID,
                                              DateTime.Now,
                                              homeAmount,
                                              personalAmount);
            }
            else
            {
                Controller.AmountController.UpdateSpentAmount(Controller.Constants.USER_LOGIN_ID,
                                                DateTime.Now,
                                                homeAmount,
                                                personalAmount);
            }

            Controller.Constants.TOTAL_AMOUNT = string.Empty;
            LoadUserPersonalAmount(Controller.Constants.USER_LOGIN_ID);
        }

        private void frmAddPersonalBudget_Load(object sender, EventArgs e)
        {
            CategoryToolTip.SetToolTip(btnAddCategory,"Add Category");
            try
            {
                if (Controller.Constants.IS_ADMIN)
                    return;

                LoadPersonalBudget(Controller.Constants.USER_LOGIN_ID, DateTime.Now);
                LoadUserPersonalAmount(Controller.Constants.USER_LOGIN_ID);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            Form frmMn = new frmCategory();
            DialogResult dr = frmMn.ShowDialog();
        }

        private void btnAddExpenses_Click(object sender, EventArgs e)
        {
            Form frmMn = new frmAddExpenses(ref label);
            DialogResult dr = frmMn.ShowDialog();
        }

        private void frmAddPersonalBudget_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cloudDesktopButton1_Click(object sender, EventArgs e)
        {
            Form frmMn = new frmAddEarnings(ref label);
            DialogResult dr = frmMn.ShowDialog();
        }
    }
}
