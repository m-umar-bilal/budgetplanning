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
    public partial class frmAddHomeBudget : Form
    {
        public frmAddHomeBudget()
        {
            InitializeComponent();
        }

        private bool _flag = false;
        private bool _updateFlag = false;
        private Controller.FoodController _foodObject = null;
        private Controller.AccessoriesController _accessObject = null;
        private Controller.BillsController _billsObject = null;
        private Controller.GroceryController _groceryObject = null;

        /// <summary>
        /// Animate form horizontally and vertically.
        /// </summary>
        /// <param name="value"></param>
        public void AnimateForm(bool value)
        {
            this._flag = true;

            if (value)
            {
                int width = 280;
                int height = 127;

                while (height <= 623)
                {
                    while (width <= 795)
                    {
                        this.Size = new Size(width, height);
                        Application.DoEvents();
                        this.DoubleBuffered = true;
                        System.Threading.Thread.Sleep(1);
                        width += 20;
                    }

                    this.Size = new Size(width, height);
                    Application.DoEvents();
                    this.DoubleBuffered = true;
                    height += 20;
                }

                btnSubmit.Icon = global::BudgetPlanner.Properties.Resources.back_icon;
            }
            else
            {
                int width = 795;
                int height = 623;

                while (height >= 127)
                {
                    while (width >= 283)
                    {
                        this.Size = new Size(width, height);
                        Application.DoEvents();
                        this.DoubleBuffered = true;
                        System.Threading.Thread.Sleep(1);
                        width -= 16;
                    }

                    this.Size = new Size(width, height);
                    Application.DoEvents();
                    this.DoubleBuffered = true;
                    height -= 16;
                }

                this._flag = false;
                btnSubmit.Icon = global::BudgetPlanner.Properties.Resources.Button_Next_icon__1_;
            }
        }

        /// <summary>
        /// Loading user budget if exist for the current date.
        /// </summary>
        public void LoadUserBudget()
        {
            Controller.BudgetController budgetObject = Controller.BudgetController.GetBudget(Controller.Constants.USER_LOGIN_ID);

            if (budgetObject == null)
                return;

            this._updateFlag = true;
            btnSaveAll.ControlText = "Update All";
            btnSaveAll.Icon = global::BudgetPlanner.Properties.Resources.addressbook_edit_icon;

            rdbDayWise.Checked = true;
            AnimateForm(true);
            btnSubmit.Enabled = false;
            OpenCloseCategoriesGroupBoxes(false);

            cmbMonthNames.SelectedValue = budgetObject.DateOfBudget.Month;

            Controller.AccessoriesController accessobject = Controller.AccessoriesController.GetAccessories(Controller.Constants.USER_LOGIN_ID);
            Controller.BillsController billsObject = Controller.BillsController.GetBills(Controller.Constants.USER_LOGIN_ID);
            Controller.FoodController foodObject = Controller.FoodController.GetFood(Controller.Constants.USER_LOGIN_ID);
            Controller.GroceryController groceryObject = Controller.GroceryController.GetGrocery(Controller.Constants.USER_LOGIN_ID);

            // Load in Accessories Text Fields
            txtAccessJewellary.Text = accessobject.Jewellary.ToString();
            txtAccessCosmetics.Text = accessobject.Cosmetics.ToString();
            txtAccessPerfumes.Text = accessobject.Perfumes.ToString();
            txtAccessClothes.Text = accessobject.Clothes.ToString();
            txtAccessShoes.Text = accessobject.Shoes.ToString();
            txtAccessInterior.Text = accessobject.InteriorDecor.ToString();
            // -------------------------------

            // Load in Bills Text Fields
            txtBillsElectricity.Text = billsObject.Electricity.ToString();
            txtBillsGas.Text = billsObject.Gas.ToString();
            txtBillsPhone.Text = billsObject.Phone.ToString();
            txtBillsWater.Text = billsObject.Water.ToString();
            txtBillsMedical.Text = billsObject.Medical.ToString();
            txtBillsEducation.Text = billsObject.Education.ToString();
            // -------------------------

            // Load in Food Text Fields
            txtFoodVegetables.Text = foodObject.Vegetables.ToString();
            txtFoodMeat.Text = foodObject.Meat.ToString();
            txtFoodFruits.Text = foodObject.Fruit.ToString();
            txtFoodMilk.Text = foodObject.Milk.ToString();
            // ------------------------

            // Load in Grocery Text Fields
            txtGroceryCereals.Text = groceryObject.Cereals.ToString();
            txtGroceryDeoderants.Text = groceryObject.Deoderants.ToString();
            txtGroceryEnergyDrinks.Text = groceryObject.EnergyDrinks.ToString();
            txtGroceryLiquids.Text = groceryObject.CleaningLiquids.ToString();
            txtGroceryLotion.Text = groceryObject.Lotion.ToString();
            txtGroceryOil.Text = groceryObject.Oil.ToString();
            txtGroceryShampoo.Text = groceryObject.Shampoo.ToString();
            txtGrocerySoap.Text = groceryObject.Soap.ToString();
            txtGrocerySpices.Text = groceryObject.Spices.ToString();
            txtGrocerySurf.Text = groceryObject.Surf.ToString();
            txtGroceryTea.Text = groceryObject.Tea.ToString();
            txtGroceryToothPaste.Text = groceryObject.ToothPaste.ToString();
            // --------------------------
        }

        public void OpenCloseCategoriesGroupBoxes(bool value)
        {
            if (value)
            {
                grpGrocery.IsOpen = false;
                grpFood.IsOpen = false;
                grpBills.IsOpen = false;
                grpAccessories.IsOpen = false;
            }
            else
            {
                grpGrocery.IsOpen = true;
                grpFood.IsOpen = true;
                grpBills.IsOpen = true;
                grpAccessories.IsOpen = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbMonthNames.SelectedIndex == 0)
            {
                Controller.Messager.ShowMessage("You must first select month name to add budget of it.", MessageBoxIcon.Information);
                return;
            }

            if (!this._flag)
            {
                if (!this._updateFlag)
                    OpenCloseCategoriesGroupBoxes(true);
                else
                    OpenCloseCategoriesGroupBoxes(false);

                AnimateForm(true);
            }
            else
            {
                AnimateForm(false);
            }
        }

        public void FillCmbMonthNames()
        {
            if (cmbMonthNames.DataSource == null)
                cmbMonthNames.Items.Clear();

            List<Controller.Month> lstOfMonths = Controller.Utilities.GetAllMonthNames();

            cmbMonthNames.DataSource = new BindingSource(lstOfMonths, null);

            cmbMonthNames.DisplayMember = "Name";
            cmbMonthNames.ValueMember = "Value";

            cmbMonthNames.Text = "<Select Month Name>";
        }

        private void frmAdd_Load(object sender, EventArgs e)
        {
            this.Size = new Size(280, 127);

            try
            {
                FillCmbMonthNames();
                grpFood.Enabled = false;

                LoadUserBudget();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void rdbWeekWise_CheckedChanged(object sender, EventArgs e)
        {
            if (!grpFood.Enabled)
                grpFood.Enabled = true;
        }

        private void rdbDayWise_CheckedChanged(object sender, EventArgs e)
        {
            if (!grpFood.Enabled)
                grpFood.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Controller.GroceryController GetGroceryFormFields()
        {
            this._groceryObject = new Controller.GroceryController();

            this._groceryObject.Cereals = Controller.Utilities.ValidateFields(txtGroceryCereals.Text);
            this._groceryObject.Soap = Controller.Utilities.ValidateFields(txtGrocerySoap.Text);
            this._groceryObject.Shampoo = Controller.Utilities.ValidateFields(txtGroceryShampoo.Text);
            this._groceryObject.Oil = Controller.Utilities.ValidateFields(txtGroceryOil.Text);
            this._groceryObject.ToothPaste = Controller.Utilities.ValidateFields(txtGroceryToothPaste.Text);
            this._groceryObject.Surf = Controller.Utilities.ValidateFields(txtGrocerySurf.Text);
            this._groceryObject.Tea = Controller.Utilities.ValidateFields(txtGroceryTea.Text);
            this._groceryObject.Spices = Controller.Utilities.ValidateFields(txtGrocerySpices.Text);
            this._groceryObject.Lotion = Controller.Utilities.ValidateFields(txtGroceryLotion.Text);
            this._groceryObject.Deoderants = Controller.Utilities.ValidateFields(txtGroceryDeoderants.Text);
            this._groceryObject.EnergyDrinks = Controller.Utilities.ValidateFields(txtGroceryEnergyDrinks.Text);
            this._groceryObject.CleaningLiquids = Controller.Utilities.ValidateFields(txtGroceryLiquids.Text);

            return this._groceryObject;
        }

        public Controller.BillsController GetBillsFormFields()
        {
            this._billsObject = new Controller.BillsController();

            this._billsObject.Electricity = Controller.Utilities.ValidateFields(txtBillsElectricity.Text);
            this._billsObject.Gas = Controller.Utilities.ValidateFields(txtBillsGas.Text);
            this._billsObject.Phone = Controller.Utilities.ValidateFields(txtBillsPhone.Text);
            this._billsObject.Water = Controller.Utilities.ValidateFields(txtBillsWater.Text);
            this._billsObject.Medical = Controller.Utilities.ValidateFields(txtBillsMedical.Text);
            this._billsObject.Education = Controller.Utilities.ValidateFields(txtBillsEducation.Text);

            return this._billsObject;
        }

        public Controller.AccessoriesController GetAccessoriesFormFields()
        {
            this._accessObject = new Controller.AccessoriesController();

            this._accessObject.Jewellary = Controller.Utilities.ValidateFields(txtAccessJewellary.Text);
            this._accessObject.Perfumes = Controller.Utilities.ValidateFields(txtAccessPerfumes.Text);
            this._accessObject.Cosmetics = Controller.Utilities.ValidateFields(txtAccessCosmetics.Text);
            this._accessObject.Clothes = Controller.Utilities.ValidateFields(txtAccessClothes.Text);
            this._accessObject.Shoes = Controller.Utilities.ValidateFields(txtAccessShoes.Text);
            this._accessObject.InteriorDecor = Controller.Utilities.ValidateFields(txtAccessInterior.Text);

            return this._accessObject;
        }

        public Controller.FoodController GetFoodFormFields()
        {
            this._foodObject = new Controller.FoodController();

            this._foodObject.Vegetables = Controller.Utilities.ValidateFields(txtFoodVegetables.Text);
            this._foodObject.Meat = Controller.Utilities.ValidateFields(txtFoodMeat.Text);
            this._foodObject.Fruit = Controller.Utilities.ValidateFields(txtFoodFruits.Text);
            this._foodObject.Milk = Controller.Utilities.ValidateFields(txtFoodMilk.Text);

            return this._foodObject;
        }

        public void SaveAll()
        {
            DateTime dateObject;

            int month = Controller.Utilities.ToInteger(cmbMonthNames.SelectedValue.ToString());
            int day = DateTime.Now.Day;
            int year = DateTime.Now.Year;

            dateObject = Controller.Utilities.ToDateTime(year, month, day);

            if (!this._updateFlag) // for adding new budget
            {
                Controller.BillsController.SaveBillsQuery(GetBillsFormFields());
                Controller.GroceryController.SaveGroceryQuery(GetGroceryFormFields());
                Controller.AccessoriesController.SaveAccessoriesQuery(GetAccessoriesFormFields());

                this._billsObject.BillsID = Controller.BillsController.GetLastEnteredBillsID();
                this._accessObject.AccessoriesID = Controller.AccessoriesController.GetLastEnteredAccessoriesID();
                this._groceryObject.GroceryID = Controller.GroceryController.GetLastEnteredGroceryID();

                if (rdbDayWise.Checked || rdbWeekWise.Checked)
                {
                    Controller.FoodController.SaveFoodQuery(GetFoodFormFields());
                    this._foodObject.FoodID = Controller.FoodController.GetLastEnteredFoodID();
                }

                Controller.BudgetController.AddBudget(Controller.Constants.USER_LOGIN_ID,
                                                --this._billsObject.BillsID,
                                                --this._accessObject.AccessoriesID,
                                                --this._groceryObject.GroceryID,
                                                --this._foodObject.FoodID,
                                                  dateObject);

                Controller.Messager.ShowMessage("Budget Added Successfully.", MessageBoxIcon.Information);
            }
            else // for updating loaded budget
            {
                // Updating Bills values
                Controller.BillsController billObject = GetBillsFormFields();
                billObject.BillsID = Controller.BillsController.GetBillsByUserID(Controller.Constants.USER_LOGIN_ID);
                Controller.BillsController.UpdateBills(Controller.Constants.USER_LOGIN_ID, billObject);
                // ---------------------

                // Updating Accessories values
                Controller.AccessoriesController accessObject = GetAccessoriesFormFields();
                accessObject.AccessoriesID = Controller.AccessoriesController.GetAccessoriesByUserID(Controller.Constants.USER_LOGIN_ID);
                Controller.AccessoriesController.UpdateAccessories(Controller.Constants.USER_LOGIN_ID, accessObject);
                // ---------------------------

                // Updating Food values
                Controller.FoodController foodObject = GetFoodFormFields();
                foodObject.FoodID = Controller.FoodController.GetFoodByUserID(Controller.Constants.USER_LOGIN_ID);
                Controller.FoodController.UpdateFood(Controller.Constants.USER_LOGIN_ID, foodObject);
                // --------------------

                // Updating Grocery values
                Controller.GroceryController groceryObject = GetGroceryFormFields();
                groceryObject.GroceryID = Controller.GroceryController.GetGroceryByUserID(Controller.Constants.USER_LOGIN_ID);
                Controller.GroceryController.UpdateGrocery(Controller.Constants.USER_LOGIN_ID, groceryObject);
                // -----------------------

                Controller.Messager.ShowMessage("Budget Updated Successfully.", MessageBoxIcon.Information);
            }

            CalculateBudget();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            try
            {
                SaveAll();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        // calculate all entered fields and minu from budget amount
        public void CalculateBudget()
        {
            int calculatedBudget = Controller.BudgetController.CalculateBudget(Controller.Constants.USER_LOGIN_ID);

            if (calculatedBudget != -1)
            {
                SubtractCalculatedBudget(calculatedBudget);
            }
        }

        // Minus calculated budget from actual HomeAmount of user
        public void SubtractCalculatedBudget(int homeAmount)
        {
            int tempAmount = 0;
            long oldSpentAmount = Controller.AmountController.GetSpentHomeAmount(Controller.Constants.USER_LOGIN_ID);

            int totalHomeAmount = (Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT) + (int)oldSpentAmount);

            if (totalHomeAmount != 0)
            {
                if (homeAmount >= 0 && homeAmount <= Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT))
                {
                    tempAmount = (totalHomeAmount - homeAmount);
                }
                else
                {
                    Controller.Messager.ShowMessage("Calculated Amount is more than actual balance, exiting without saving.", MessageBoxIcon.Information);
                    return;
                }
            }

            Controller.Messager.ShowMessage("Calculated Amount is : " + homeAmount, MessageBoxIcon.Information);
            Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, tempAmount);

            if (!this._updateFlag)
                Controller.AmountController.SaveSpentAmount(Controller.Constants.USER_LOGIN_ID, DateTime.Now, homeAmount);
            else
                Controller.AmountController.UpdateSpentAmount(Controller.Constants.USER_LOGIN_ID, DateTime.Now, homeAmount);
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Form frmCalc = new frmCalculator();
            frmCalc.Show();
        }
    }
}
