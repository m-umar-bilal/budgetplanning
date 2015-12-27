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
 * 01-Dec-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.View
{
    public partial class frmForgotUserDetail : Form
    {
        public frmForgotUserDetail()
        {
            InitializeComponent();
        }

        private Controller.UserAccountController _userAccntObject = null;

        public void LoadUserDetailByUserID(string userID)
        {
            Controller.UserAccountController obj = Controller.UserAccountController.GetUserDetailByID(userID);

            if (obj == null)
            {
                Controller.Messager.ShowMessage("No information is available against the ID.", MessageBoxIcon.Information);
                dgvUserDetail.Rows.Clear();
                txtUserID.Clear();
                return;
            }

            dgvUserDetail.Rows.Clear();

            int dgRow = dgvUserDetail.Rows.Add();
            dgvUserDetail.Rows[dgRow].Cells["colUserName"].Value = obj.UserName;
            dgvUserDetail.Rows[dgRow].Cells["colPassword"].Value = obj.Password;
            this._userAccntObject = obj;
        }

        private void txtUserID_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    if (!String.IsNullOrEmpty(txtUserID.Text))
                    {
                        LoadUserDetailByUserID(txtUserID.Text);
                        btnEdit.Visible = true;
                        btnContinue.Enabled = true;
                    }
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void SettingToolTips()
        {
            Controller.Utilities.SetToolTipText(btnGoBack, "Go Back");
            Controller.Utilities.SetToolTipText(btnContinue, "Continue");
            Controller.Utilities.SetToolTipText(btnEdit, "Edit");
            Controller.Utilities.SetToolTipText(btnSave, "Update");
        }

        private void frmForgotUserDetail_Load(object sender, EventArgs e)
        {
            SettingToolTips();
            btnEdit.Visible = false;
            btnContinue.Enabled = false;

            this.Size = new Size(310, 180);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.Size = new Size(310, 180);
            Controller.UserAccountController.UpdateLoginPassword(txtUserID.Text, txtUserName.Text, txtPassword.Text);
            Controller.Messager.ShowMessage("Account Updated Successfully.", MessageBoxIcon.Information);
            LoadUserDetailByUserID(txtUserID.Text);
            btnEdit.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUserID.Text))
            {
                Controller.Messager.ShowMessage("You must enter user id to continue to main form.", MessageBoxIcon.Information);
                return;
            }

            // Continue from here to main form

            LoadUserDetailByUserID(txtUserID.Text);

            this.Hide();

            Form frMain = new frmMain(this._userAccntObject);
            frMain.ShowDialog();
        }

        public void Edit()
        {
            if (!String.IsNullOrEmpty(txtUserID.Text))
            {
                txtUserName.Text = dgvUserDetail.SelectedRows[0].Cells["colUserName"].Value.ToString();
                txtPassword.Text = dgvUserDetail.SelectedRows[0].Cells["colPassword"].Value.ToString();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Size = new Size(310, 309);
            btnEdit.Enabled = false;

            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
