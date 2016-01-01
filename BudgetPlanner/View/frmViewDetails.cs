using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using BudgetPlanner.Model;

namespace BudgetPlanner.View
{
    public partial class frmViewDetails : Form
    {
        public frmViewDetails()
        {
            InitializeComponent();
            set(false);
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
                grpHome.IsOpen = false;

                grpHome.Visible = false;
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
                { this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID, myDateTime);
                    Controller.Messager.ShowMessage("Now Choose One Of The Home Category To Display Its Budget Details.", MessageBoxIcon.Information);
                }
                else
                {
                    this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);
                    LoadAll();
                    Controller.Messager.ShowMessage("Now Select Row first and Choose One Of The Home Category To Display Its Budget Details..", MessageBoxIcon.Information);
                }

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

                // chkAll.Visible = false;
                grpHome.Visible = true;
                this._categoryChoosen = false;
                dtPicker.Size = new Size(235, 23);
                btnSearch.Visible = true;


            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            set(false);
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
                set(true);
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

            chkMonth.Checked = false;
            chkDay.Checked = false;
            chkYear.Checked = false;

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
        public void LoadAll()
        {
            if (dgvInfo.DataSource == null)
                dgvInfo.Rows.Clear();

            DataTable dtFood = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);

            if (dtFood.Rows.Count == 0)
                return;

            dgvInfo.DataSource = dtFood;
        }
        private void btnFood_Click(object sender, EventArgs e)
        {
            try
            {
                if (chkAll.Checked)
                {

                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);
                        LoadAll();
                        Controller.Messager.ShowMessage("Now Select Row first and Choose One Of The Home Category To Display Its Budget Details..", MessageBoxIcon.Information);

                        Controller.Messager.ShowMessage("You must select row from data grid to load its fields for editing.", MessageBoxIcon.Information);
                        return;
                    }
                    if (this._dtHome != null)
                    {
                        int foodID = Controller.Utilities.ToInteger(dgvInfo.SelectedRows[0].Cells["FoodID"].Value.ToString());
                        LoadFood(foodID);
                    }
                    dgvInfo.ClearSelection();
                }
                else {
                    if (this._dtHome != null)
                    {
                        int foodID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["FoodID"].ToString());
                        LoadFood(foodID);
                    }
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
                if (chkAll.Checked)
                {
                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);
                        LoadAll();
                        Controller.Messager.ShowMessage("Now Select Row first and Choose One Of The Home Category To Display Its Budget Details..", MessageBoxIcon.Information);

                        Controller.Messager.ShowMessage("You must select row from data grid to load its fields", MessageBoxIcon.Information);
                        return;
                    }
                    if (this._dtHome != null)
                    {
                        int foodID = Controller.Utilities.ToInteger(dgvInfo.SelectedRows[0].Cells["BillsID"].Value.ToString());
                        LoadBills(foodID);
                    }
                    dgvInfo.ClearSelection();
                }
                else {
                    if (this._dtHome != null)
                    {
                        int billsID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["BillsID"].ToString());
                        LoadBills(billsID);
                    } }
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
                if (chkAll.Checked)
                {
                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);
                        LoadAll();
                        Controller.Messager.ShowMessage("Now Select Row first and Choose One Of The Home Category To Display Its Budget Details..", MessageBoxIcon.Information);

                        Controller.Messager.ShowMessage("You must select row from data grid to load its fields", MessageBoxIcon.Information);
                        return;
                    }
                    if (this._dtHome != null)
                    {
                        int foodID = Controller.Utilities.ToInteger(dgvInfo.SelectedRows[0].Cells["AccessoriesID"].Value.ToString());
                        LoadAccessories(foodID);
                    }
                    dgvInfo.ClearSelection();
                }
                else {
                    if (this._dtHome != null)
                    {
                        int accessID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["AccessoriesID"].ToString());
                        LoadAccessories(accessID);
                    }
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
                if (chkAll.Checked)
                {
                    if (dgvInfo.SelectedRows.Count == 0)
                    {
                        this._dtHome = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);
                        LoadAll();
                        Controller.Messager.ShowMessage("Now Select Row first and Choose One Of The Home Category To Display Its Budget Details..", MessageBoxIcon.Information);

                        Controller.Messager.ShowMessage("You must select row from data grid to load its fields", MessageBoxIcon.Information);
                        return;
                    }
                    if (this._dtHome != null)
                    {
                        int groceryID = Controller.Utilities.ToInteger(dgvInfo.SelectedRows[0].Cells["GroceryID"].Value.ToString());
                        LoadGrocery(groceryID);
                    }
                    dgvInfo.ClearSelection();
                }
                else {
                    if (this._dtHome != null)
                    {
                        int groceryID = Controller.Utilities.ToInteger(this._dtHome.Rows[0]["GroceryID"].ToString());
                        LoadGrocery(groceryID);
                    }
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void chkMonth_CheckedChanged(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            chkDay.Checked = false;
            chkYear.Checked = false;

          
        }

        private void chkYear_CheckedChanged(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            chkDay.Checked = false;
            chkMonth.Checked = false;
        }

        private void chkDay_CheckedChanged(object sender, EventArgs e)
        {
            chkAll.Checked = false;
            chkMonth.Checked = false;
            chkYear.Checked = false;
        }

        public void set(bool val)
         {

            chkMonth.Visible = val;
            chkDay.Visible = val;
            chkYear.Visible = val;
            grpPersonal.Visible = val;
            grpHome.Visible = !val;

        }

        private void cloudDesktopButton4_Click(object sender, EventArgs e)
        {

            dgvInfo.DataSource = null;

            DataTable t = null;
            if (chkAll.Checked)
            {
                t = EarningDb.getALLEarning("%", Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkYear.Checked)
            {

                t = EarningDb.getEarningOfYear(dtPicker.Value.ToString("yyyy"), Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkMonth.Checked)
            {

                t = EarningDb.getEarningOfMonth(dtPicker.Value.ToString("MM"), Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkDay.Checked)
            {

                t = EarningDb.getEarning(dtPicker.Value.ToString("yyyy-MM-dd"), Controller.Constants.USER_LOGIN_ID);

            }
            else
            {
                t = EarningDb.getEarning(dtPicker.Value.ToString("yyyy-MM-dd"), Controller.Constants.USER_LOGIN_ID);

            }
            if (t == null)
            {
                MessageBox.Show("No Record Found");
            }
            else
                dgvInfo.DataSource = t;
            }

        private void cloudDesktopButton3_Click(object sender, EventArgs e)
        {
            dgvInfo.DataSource = null;

            DataTable t = null;
            if (chkAll.Checked)
            {
                t = ExpenseDb.getALLExpense("%", Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkYear.Checked)
            {

                t = ExpenseDb.getExpenseOfYear(dtPicker.Value.ToString("yyyy"), Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkMonth.Checked)
            {

                t = ExpenseDb.getExpenseOfMonth(dtPicker.Value.ToString("MM"), Controller.Constants.USER_LOGIN_ID);
            }
            else if (chkDay.Checked)
            {

                t = ExpenseDb.getExpense(dtPicker.Value.ToString("yyyy-MM-dd"), Controller.Constants.USER_LOGIN_ID);

            }
            else
            {
                t = ExpenseDb.getExpense(dtPicker.Value.ToString("yyyy-MM-dd"), Controller.Constants.USER_LOGIN_ID);

            }
            if (t == null)
            {
                MessageBox.Show("No Record Found");
            }
            else
                dgvInfo.DataSource = t;
        }
    }
    }
    

