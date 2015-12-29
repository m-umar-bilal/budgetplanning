using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace BudgetPlanner.View
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Controller.UserAccountController _userAccntObject = null;
        private Controller.AmountController _amountObject = null;

        public frmMain(Controller.UserAccountController userAccntObject)
            : this()
        {
            this._userAccntObject = userAccntObject;
            Controller.Constants.USER_LOGIN_ID = this._userAccntObject.ID;
        }

        public void LoadUserTotalAmount(string userID)
        {
            this._amountObject = Controller.AmountController.LoadUserTotalAmount(userID);
            btnEditAmount.Visible = true;

            if (this._amountObject == null)
            {
                lblAmount.Text = "000";
                return;
            }

            Controller.Constants.FLAG = true;
            lblAmount.Text = this._amountObject.HomeAmount.ToString();
            Controller.Constants.TOTAL_AMOUNT = this._amountObject.HomeAmount.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void SettingToolTips()
        {
            Controller.Utilities.SetToolTipText(btnHome, "Home Budget");
            Controller.Utilities.SetToolTipText(btnPersonal, "Personal Budget");
            Controller.Utilities.SetToolTipText(btnExport, "Export Data");
            Controller.Utilities.SetToolTipText(btnEditAmount, "Edit Amount");
        }

  


        private void frmMain_Load(object sender, EventArgs e)
        {
            try
            {
                grpCategory.Visible = false;
                grpData.IsOpen = false;
                SettingToolTips();

                if (Controller.Constants.IS_ADMIN)
                {
                    pnlAmount.Visible = false;
                    lblUserName.Text = Controller.Constants.WELCOME_NAME;
                    btnEditDetails.Enabled = false;
                }

                if (this._userAccntObject != null)
                {
                    lblUserName.Text = this._userAccntObject.Name;
                    LoadUserTotalAmount(this._userAccntObject.ID);

                    if (this._userAccntObject.Gender)
                        picBoxGender.BackgroundImage = global::BudgetPlanner.Properties.Resources.Male_Face_D2_icon;
                    else
                        picBoxGender.BackgroundImage = global::BudgetPlanner.Properties.Resources.Female_Face_FC_5_icon;
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void EditInfo()
        {
            if (this._userAccntObject != null)
            {
                Form frmCrtUser = new frmCreateUser(true, this._userAccntObject);
                frmCrtUser.ShowDialog();

                Controller.UserAccountController obj = Controller.UserAccountController.GetUserDetailByID(this._userAccntObject.ID);
                lblUserName.Text = obj.Name;
                this._userAccntObject = obj;
            }
        }

        private void btnEditDetails_Click(object sender, EventArgs e)
        {
            try
            {
                EditInfo();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (!grpCategory.Visible)
            {
                grpCategory.Visible = true;
                grpCategory.IsOpen = false;
            }
            else
            {
                grpCategory.Visible = false;
                grpCategory.IsOpen = false;
            }
        }

        public void Home()
        {
            Controller.Constants.USER_LOGIN_ID = this._userAccntObject.ID;

            if (Controller.Constants.FLAG)
            {
                Form frmAddHomeBud = new frmAddHomeBudget();
                DialogResult dr = frmAddHomeBud.ShowDialog();

                if (dr == DialogResult.OK)
                    LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Constants.IS_ADMIN)
                    return;

                Home();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void Personal()
        {
            Controller.Constants.USER_LOGIN_ID = this._userAccntObject.ID;

            if (Controller.Constants.FLAG)
            {
                Form frmAddPersonalBud = new frmAddPersonalBudget(ref lblAmount);
                DialogResult dr = frmAddPersonalBud.ShowDialog();

                if (dr == DialogResult.OK)
                    LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID);
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Constants.IS_ADMIN)
                    return;

                Personal();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (!Controller.Constants.IS_ADMIN)
            {
                Controller.Messager.ShowMessage("You are not authorized to do this.", MessageBoxIcon.Warning);
                return;
            }

            Form frmCrtUser = new frmCreateUser();
            frmCrtUser.ShowDialog();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form frmAd = new frmAddHomeBudget();
            frmAd.ShowDialog();
        }

        private void btnEditAmount_Click(object sender, EventArgs e)
        {
            Form frmAddAmnt = new frmAddAmount();
            DialogResult dr = frmAddAmnt.ShowDialog();

            if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            {
                LoadUserTotalAmount(Controller.Constants.USER_LOGIN_ID);
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Form frmCalc = new frmCalculator();
            frmCalc.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            btnLogout.Visible = false;

            Form frmLgn = new Form1();
            frmLgn.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmAbt = new frmAbout();
            frmAbt.ShowDialog();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Constants.IS_ADMIN)
                    return;

                Home();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (Controller.Constants.IS_ADMIN)
                    return;

                Personal();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void ViewBudget()
        {
            Form frmView = new frmViewDetails();
            frmView.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            try
            {
                ViewBudget();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void viewBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ViewBudget();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void ExportData()
        {
            Form frmExp = new frmExportData();
            frmExp.ShowDialog();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                ExportData();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                ExportData();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }
    }
}
