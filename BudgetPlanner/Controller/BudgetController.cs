using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


namespace BudgetPlanner.Controller
{
    public class BudgetController
    {
        #region Private Properties

        private UserAccountController _userObject;
        private int _foodID;
        private int _billsID;
        private int _accessoriesID;
        private int _groceryID;
        private DateTime _dateOfBudget;        

        #endregion

        #region Public Properties

        public UserAccountController UserObject
        {
            get { return _userObject; }
            set { _userObject = value; }
        }
        public int FoodID
        {
            get { return _foodID; }
            set { _foodID = value; }
        }
        public int BillsID
        {
            get { return _billsID; }
            set { _billsID = value; }
        }
        public int AccessoriesID
        {
            get { return _accessoriesID; }
            set { _accessoriesID = value; }
        }
        public int GroceryID
        {
            get { return _groceryID; }
            set { _groceryID = value; }
        }

        public DateTime DateOfBudget
        {
            get { return _dateOfBudget; }
            set { _dateOfBudget = value; }
        }

        public Model.Amount Amount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Model.Bill Bill
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Model.UserAccount UserAccount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Model.Accessory Accessory
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Model.AmountSpent AmountSpent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Model.PersonalBudget PersonalBudget
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        #endregion

        #region Public Methods

        public static void AddBudget(string userID, int billsID, int accessoriesID, int groceryID, int foodID, DateTime date)
        {
            Model.BudgetModel.AddBudget(userID, billsID, accessoriesID, groceryID, foodID, date);
        }

        public static int CalculateBudget(string userID)
        {
            return Model.BudgetModel.CalculateBudget(userID);
        }

        public static BudgetController GetBudget(string userID)
        {
            Model.Budget obj = Model.BudgetModel.GetBudget(userID);

            if (obj == null)
                return null;

            BudgetController budgetObject = new BudgetController();

            budgetObject.AccessoriesID = obj.AccessoriesID.Value;
            budgetObject.BillsID = obj.BillsID.Value;
            budgetObject.FoodID = obj.FoodID.Value;
            budgetObject.GroceryID = obj.GroceryID.Value;
            budgetObject.DateOfBudget = obj.DateOfBudget;

            return budgetObject;
        }

        public static void AddPersonalBudget(Controller.PersonalBudget personalObject)
        {
            Model.BudgetModel.AddPersonalBudget(personalObject);
        }

        public static void UpdatePersonalBudget(Controller.PersonalBudget personalObject)
        {
            Model.BudgetModel.UpdatePersonalBudget(personalObject);
        }

        public static PersonalBudget LoadPersonalBudget(string userID, DateTime todaysDate)
        {
            Model.PersonalBudget obj = Model.BudgetModel.LoadPersonalBudget(userID, todaysDate);

            if (obj == null)
                return null;

            PersonalBudget personalObject = new PersonalBudget();

            personalObject.UserID = obj.UserID;
            personalObject.BusFair = obj.BusFair.Value;
            personalObject.WithFriends = obj.WithFriends.Value;
            personalObject.OnMySelf = obj.OnMySelf.Value;
            personalObject.Clothes = obj.Clothes.Value;
            personalObject.Gifts = obj.Gifts.Value;
            personalObject.Extra = obj.Extra.Value;
            personalObject.Phone = obj.Phone.Value;
            personalObject.Date = obj.Date;

            return personalObject;
        }

        public static int CalculatePersonalBudget(string userID, DateTime todaysDate)
        {
            return Model.BudgetModel.CalculatePersonalBudget(userID, todaysDate);
        }

        public static DataTable GetPersonalBudget(string userID, DateTime? date = null)
        {
            return Model.BudgetModel.GetPersonalBudget(userID, date);
        }

        public static DataTable GetHomeBudget(string userID, DateTime? date = null)
        {
            return Model.BudgetModel.GetHomeBudget(userID, date);
        }

        public static DataTable LoadFood(int foodID)
        {
            return Model.BudgetModel.LoadFood(foodID);
        }

        public static DataTable LoadBills(int billsID)
        {
            return Model.BudgetModel.LoadBills(billsID);
        }

        public static DataTable LoadGrocery(int groceryID)
        {
            return Model.BudgetModel.LoadGrocery(groceryID);
        }

        public static DataTable LoadAccessories(int accessID)
        {
            return Model.BudgetModel.LoadAccessories(accessID);
        }

        #endregion
    }
}
