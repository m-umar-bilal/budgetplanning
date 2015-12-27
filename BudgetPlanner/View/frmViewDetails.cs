using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;


namespace BudgetPlanner.View
{
    public partial class frmViewDetails : Form
    {
        public frmViewDetails()
        {
            InitializeComponent();
        }

        private DateTime _pickedDate;
        private DataTable _dtHome = null;
        private bool _categoryChoosen = false;

        public void SettingToolTips()
        {
            Controller.Utilities.SetToolTipText(btnDone, "Done");
            Controller.Utilities.SetToolTipText(btnSearch, "Search");
            Controller.Utilities.SetToolTipText(btnAccess, "Accessories");
            Controller.Utilities.SetToolTipText(btnFood, "Food");
            Controller.Utilities.SetToolTipText(btnBill, "Bills");
            Controller.Utilities.SetToolTipText(btnGrocery, "Grocery");
        }

        private void frmViewDetails_Load(object sender, EventArgs e)
        {
            try
            {
                grpCategory.IsOpen = false;
                grpHomeCategory.IsOpen = false;

                grpHomeCategory.Visible = false;
                btnSearch.Visible = false;

                dtPicker.Size = new Size(275, 23);

                SettingToolTips();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void Home()
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            this._pickedDate = dtPicker.Value;

            if (this._pickedDate != null)
            {
                DateTime myDateTime = Controller.Utilities.ToDateTime(this._pickedDate.Year,
                                                               this._pickedDate.Month,
                                                               this._pickedDate.Day);

                if (!chkAll.Checked)
                    this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID, myDateTime);
                else
                    this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);

                if (this._dtHome.Rows.Count == 0)
                {
                    if (!chkAll.Checked)
                    {
                        Controller.Messager.ShowMessage("No Home Budget Details Exist For Picked Date.", MessageBoxIcon.Information);
                    }
                    else
                    {
                        Controller.Messager.ShowMessage("No Home Budget Details Exist For The User.", MessageBoxIcon.Information);
                    }

                    return;
                }

                chkAll.Visible = false;
                grpHomeCategory.Visible = true;
                this._categoryChoosen = false;
                dtPicker.Size = new Size(235, 23);
                btnSearch.Visible = true;

                Controller.Messager.ShowMessage("Now Choose One Of The Home Category To Display Its Budget Details.", MessageBoxIcon.Information);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            try
            {
                Home();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void Personal()
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtPersonal = null;
            this._pickedDate = dtPicker.Value;

            if (this._pickedDate != null)
            {
                DateTime myDateTime = Controller.Utilities.ToDateTime(this._pickedDate.Year,
                                                               this._pickedDate.Month,
                                                               this._pickedDate.Day);

                if (!chkAll.Checked)
                    dtPersonal = Controller.BudgetController.GetPersonalBudget(Controller.Constants.USER_LOGIN_ID, myDateTime);

                if (dtPersonal.Rows.Count == 0)
                {
                    if (!chkAll.Checked)
                    {
                        Controller.Messager.ShowMessage("No Personal Budget Details Exist For Picked Date.", MessageBoxIcon.Information);
                    }
                    else
                    {
                        Controller.Messager.ShowMessage("No Personal Budget Details Exist For The User.", MessageBoxIcon.Information);
                    }

                    return;
                }

                this._categoryChoosen = true;
                dtPicker.Size = new Size(235, 23);
                btnSearch.Visible = true;

                dgvInfo.DataSource = dtPersonal;

                if (chkAll.Checked)
                {
                    dgvInfo.Columns["UserID"].Visible = false;
                    dgvInfo.Columns["UserAccount"].Visible = false;
                }
            }
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            try
            {
                Personal();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAll.Checked)
                dtPicker.Enabled = false;
            else
                dtPicker.Enabled = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this._categoryChoosen) // true for personal
            {
                Personal();
            }
            else // for home
            {
                Home();
            }
        }

        public void LoadFood(int foodID)
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtFood = Controller.BudgetController.LoadFood(foodID);

            if (dtFood.Rows.Count == 0)
                return;

            dgvInfo.DataSource = dtFood;
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._dtHome != null)
                {
                    int foodID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["FoodID"].ToString());
                    LoadFood(foodID);
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void LoadBills(int billID)
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtBills = Controller.BudgetController.LoadBills(billID);

            if (dtBills.Rows.Count == 0)
                return;

            dgvInfo.DataSource = dtBills;
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._dtHome != null)
                {
                    int billsID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["BillsID"].ToString());
                    LoadBills(billsID);
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void LoadAccessories(int accessID)
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtAccessories = Controller.BudgetController.LoadAccessories(accessID);

            if (dtAccessories.Rows.Count == 0)
                return;

            dgvInfo.DataSource = dtAccessories;
        }

        private void btnAccess_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._dtHome != null)
                {
                    int accessID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["AccessoriesID"].ToString());
                    LoadAccessories(accessID);
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        public void LoadGrocery(int groceryID)
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtGrocery = Controller.BudgetController.LoadGrocery(groceryID);

            if (dtGrocery.Rows.Count == 0)
                return;

            dgvInfo.DataSource = dtGrocery;
        }

        private void btnGrocery_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._dtHome != null)
                {
                    int groceryID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["GroceryID"].ToString());
                    LoadGrocery(groceryID);
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }
    }
}
