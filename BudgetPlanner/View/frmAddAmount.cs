using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region History
/*
 * 21-Dec-2015 --- Created By Muhammad Abdullah
 */
#endregion

namespace BudgetPlanner.View
{
    public partial class frmAddAmount : Form
    {
        private bool _isAmountExist = false;
        private bool _fromPersonalBudget = false;
        private Controller.AmountController _amountObject = null;

        public frmAddAmount()
        {
            InitializeComponent();
        }

        public frmAddAmount(bool value)
            : this()
        {
            this._fromPersonalBudget = value;
            LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID, true);
        }

        public void LoadUserTotalAmount(string userID, bool value = false)
        {
            if (value)
                this._amountObject = Controller.AmountController.LoadUserTotalAmount(userID, true);
            else
                this._amountObject = Controller.AmountController.LoadUserTotalAmount(userID);

            if (this._amountObject == null)
            {
                // means no amount exists for the person he would have to add new amount
                txtAmount.Text = string.Empty;
                txtAmount.Enabled = true;
                return;
            }

            txtAmount.Enabled = false;
            this._isAmountExist = true;

            if (value)
                txtAmount.Text = this._amountObject.PersonalAmount.ToString();
            else
                txtAmount.Text = this._amountObject.HomeAmount.ToString();
        }

        public void ReloadForm()
        {
            LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID);
        }

        public void SettingToolTips()
        {
            Controller.Utilities.SetToolTipText(btnAddAmount, "Save Amount");
            Controller.Utilities.SetToolTipText(btnEditAmount, "Edit Amount");
            Controller.Utilities.SetToolTipText(btnAmountClose, "Close");
            Controller.Utilities.SetToolTipText(btnUpdate, "Update");

            // putting amount panel at center of form whenever form loads.
            //pnlAmount.Location = new Point(this.ClientSize.Width / 2 - pnlAmount.Size.Width / 2,
            //this.ClientSize.Height / 2 - pnlAmount.Size.Height / 2);

            //pnlAmount.Anchor = AnchorStyles.None;
        }

        private void frmAddAmount_Load(object sender, EventArgs e)
        {
            try
            {
                SettingToolTips();

                if (this._fromPersonalBudget)
                    LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID, true);
                else
                    LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID);

                txtAmountEdit.Visible = false;
                btnUpdate.Visible = false;
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void EditAmount()
        {
            if (this._isAmountExist)
            {
                if (!String.IsNullOrEmpty(txtAmount.Text))
                {
                    btnEditAmount.Enabled = false;
                    txtAmount.Enabled = false;
                    txtAmountEdit.Text = txtAmount.Text;
                    txtAmountEdit.Visible = true;
                    btnUpdate.Visible = true;
                }
            }
        }

        private void btnEditAmount_Click(object sender, EventArgs e)
        {
            try
            {
                EditAmount();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void UpdateAmount()
        {
            // update amount

            if (this._isAmountExist)
            {
                if (this._fromPersonalBudget)
                {
                    long amount = Controller.AmountController.GetSpentHomeAmount(Controller.Constants.USER_LOGIN_ID);

                    if (amount != 0)
                    {
                        Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID,
                                                   Controller.Utilities.ToInteger(amount.ToString()),
                                                   Controller.Utilities.ToInteger(txtAmountEdit.Text));

                        btnEditAmount.Enabled = true;
                        txtAmount.Enabled = true;
                        txtAmount.Text = txtAmountEdit.Text;
                        txtAmountEdit.Visible = false;
                        btnUpdate.Visible = false;

                        return;
                    }
                }

                if (!String.IsNullOrEmpty(txtAmountEdit.Text))
                {
                    Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, Controller.Utilities.ToInteger(txtAmountEdit.Text));
                }
                else
                {
                    Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, Controller.Utilities.ToInteger(txtAmount.Text));
                }
            }

            btnEditAmount.Enabled = true;
            txtAmount.Enabled = true;
            txtAmount.Text = txtAmountEdit.Text;
            txtAmountEdit.Visible = false;
            btnUpdate.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateAmount();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnAmountClose_Click(object sender, EventArgs e)
        {
            Controller.Constants.FLAG = true;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        public void AddAmount()
        {
            if (!this._isAmountExist)
            {
                if (!String.IsNullOrEmpty(txtAmount.Text))
                {
                    if (this._fromPersonalBudget)
                    {
                        long amount = Controller.AmountController.GetSpentHomeAmount(Controller.Constants.USER_LOGIN_ID);

                        if (amount != 0)
                        {
                            Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID,
                                                       Controller.Utilities.ToInteger(amount.ToString()),
                                                       Controller.Utilities.ToInteger(txtAmount.Text));
                            return;
                        }
                    }

                    Controller.AmountController.AddAmount(Controller.Constants.USER_LOGIN_ID, Controller.Utilities.ToInteger(txtAmount.Text));
                }
            }

            Controller.Constants.FLAG = true;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnAddAmount_Click(object sender, EventArgs e)
        {
            try
            {
                AddAmount();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void frmAddAmount_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Constants.FLAG = true;
        }
    }
}
