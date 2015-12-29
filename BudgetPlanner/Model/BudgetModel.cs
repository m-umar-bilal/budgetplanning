using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using BudgetPlanner.Controller;

namespace BudgetPlanner.Model
{
    public class BudgetModel
    {
        public static void AddBudget(string userID, int billsID, int accessoriesID, int groceryID, int foodID, DateTime date)
        {
            //Budget obj = new Budget();
            //obj.UserID = userID;
            //obj.BillsID = billsID;
            //obj.AccessoriesID = accessoriesID;
            //obj.GroceryID = groceryID;
            //obj.FoodID = foodID;
            //obj.DateOfBudget = date;

            //DatabaseFunctions.DataContext.Budgets.InsertOnSubmit(obj);
            //DatabaseFunctions.DataContext.SubmitChanges();

            string query = "INSERT INTO Budget(UserID,BillsID,AccessoriesID,GroceryID,FoodID,DateOfBudget)";
            query += " VALUES ('" + userID + "','" + billsID + "','" + accessoriesID + "','" + groceryID + "','" + foodID + "','"
                                  + date + "')";

            DatabaseFunctions.ExecuteQuery(query);
        }

        public static int CalculateBills(int billsID) 
        {            
            int totalBills = 0;

            var query =
                from billsObject in DatabaseFunctions.DataContext.Bills
                where billsObject.BillsID == billsID
                select billsObject;

            DataTable dtBills = DatabaseFunctions.LINQToDataTable(query);

            if (dtBills.Rows.Count == 0)
                return 0;

            foreach (DataRow dtRow in dtBills.Rows)
            {
                totalBills = Controller.Utilities.ToInteger(dtRow["Electricity"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Gas"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Water"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Phone"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Medical"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Education"].ToString());
            }            

            return totalBills;
        }
        
        public static int CalculateGrocery(int groceryID) 
        {            
            int totalGrocery = 0;

            var query =
                from groceryObject in DatabaseFunctions.DataContext.Groceries
                where groceryObject.GroceryID == groceryID
                select groceryObject;

            DataTable dtGrocery = DatabaseFunctions.LINQToDataTable(query);

            if (dtGrocery.Rows.Count == 0)
                return 0;

            foreach (DataRow dtRow in dtGrocery.Rows)
            {
                totalGrocery = Controller.Utilities.ToInteger(dtRow["Cereals"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Shampoo"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Soap"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Surf"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Tea"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Deoderants"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Spices"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["CleaningLiquids"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["EnergyDrinks"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Oil"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["ToothPaste"].ToString())
                               + Controller.Utilities.ToInteger(dtRow["Lotion"].ToString());
            }            

            return totalGrocery;
        }

        public static DataTable LoadFood(int foodID)
        {
            var query =
               from foodObject in DatabaseFunctions.DataContext.Foods
               where foodObject.FoodID == foodID
               select foodObject;

            if (query != null)
                return DatabaseFunctions.LINQToDataTable(query);

            return null;
        }

        public static int CalculateFood(int foodID) 
        {            
            int totalFood = 0;

            var query =
                from foodObject in DatabaseFunctions.DataContext.Foods
                where foodObject.FoodID == foodID
                select foodObject;

            DataTable dtFood = DatabaseFunctions.LINQToDataTable(query);

            if (dtFood.Rows.Count == 0)
                return 0;

            foreach (DataRow dtRow in dtFood.Rows)
            {
                totalFood = Controller.Utilities.ToInteger(dtRow["Vegetables"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Fruits"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Milk"].ToString())
                           + Controller.Utilities.ToInteger(dtRow["Meat"].ToString());                          
            }            

            return totalFood;
        }
        
        public static int CalculateAccessories(int accessID) 
        {            
            int totalAccessories = 0;

            var query =
                from accessObject in DatabaseFunctions.DataContext.Accessories
                where accessObject.AccessoriesID == accessID
                select accessObject;

            DataTable dtAccessories = DatabaseFunctions.LINQToDataTable(query);

            if (dtAccessories.Rows.Count == 0)
                return 0;

            foreach (DataRow dtRow in dtAccessories.Rows)
            {
                totalAccessories = Controller.Utilities.ToInteger(dtRow["Jewellary"].ToString())
                                   + Controller.Utilities.ToInteger(dtRow["Perfumes"].ToString())
                                   + Controller.Utilities.ToInteger(dtRow["InteriorDecor"].ToString())
                                   + Controller.Utilities.ToInteger(dtRow["Cosmetics"].ToString())
                                   + Controller.Utilities.ToInteger(dtRow["Clothes"].ToString())
                                   + Controller.Utilities.ToInteger(dtRow["Shoes"].ToString());
            }            

            return totalAccessories;
        }

        public static int CalculateBudget(string userID)
        {                        
            int totalBudget = 0;
            int totalFood = 0, totalBills = 0, totalGrocey = 0, totalAccessories = 0;

            var query =
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 where budgetObject.UserID.Equals(userID)
                 select budgetObject).FirstOrDefault();

            if (query == null)
                return -1;

            if (query != null)
            {
                totalFood = CalculateFood(query.FoodID.Value);
                totalBills = CalculateBills(query.BillsID.Value);
                totalAccessories = CalculateAccessories(query.AccessoriesID.Value);
                totalGrocey = CalculateGrocery(query.GroceryID.Value);
            }

            totalBudget = (totalFood + totalBills + totalGrocey + totalAccessories);            

            return totalBudget;
        }

        public static Budget GetBudget(string userID)
        {
            return
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 where budgetObject.UserID.Equals(userID)
                 select budgetObject).FirstOrDefault();
        }

        public static void AddPersonalBudget(Controller.PersonalBudget personalObject)
        {
            PersonalBudget obj = new PersonalBudget();

            obj.UserID = personalObject.UserID;
            obj.BusFair = personalObject.BusFair;
            obj.WithFriends = personalObject.WithFriends;
            obj.OnMySelf = personalObject.OnMySelf;
            obj.Gifts = personalObject.Gifts;
            obj.Clothes = personalObject.Clothes;
            obj.Extra = personalObject.Extra;
            obj.Phone = personalObject.Phone;
            obj.Date = personalObject.Date;

            DatabaseFunctions.DataContext.PersonalBudgets.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();
        }

        public static PersonalBudget LoadPersonalBudget(string userID, DateTime todaysDate)
        {
            return
                (from personalObject in DatabaseFunctions.DataContext.PersonalBudgets
                 where personalObject.UserID.Equals(userID) && personalObject.Date.Equals(todaysDate)
                 select personalObject).FirstOrDefault();
        }

        public static void UpdatePersonalBudget(Controller.PersonalBudget personalObject)
        {
            var query = 
                (from obj in DatabaseFunctions.DataContext.PersonalBudgets
                 where obj.UserID.Equals(obj.UserID) && obj.Date.Equals(obj.Date)
                 select obj).FirstOrDefault();
            
            if (query != null)
            {                
                query.BusFair = personalObject.BusFair;
                query.WithFriends = personalObject.WithFriends;
                query.OnMySelf = personalObject.OnMySelf;
                query.Gifts = personalObject.Gifts;
                query.Clothes = personalObject.Clothes;
                query.Extra = personalObject.Extra;
                query.Phone = personalObject.Phone;

                DatabaseFunctions.DataContext.SubmitChanges();
            }
        }

        public static int CalculatePersonalBudget(string userID, DateTime todaysDate)
        {
            int total = 0;

            var query =
               (from obj in DatabaseFunctions.DataContext.PersonalBudgets
                where obj.UserID.Equals(obj.UserID) && obj.Date.Equals(obj.Date)
                select obj).FirstOrDefault();

            if (query != null)
            {
                total = (query.BusFair.Value
                        + query.WithFriends.Value
                        + query.OnMySelf.Value
                        + query.Gifts.Value
                        + query.Clothes.Value
                        + query.Extra.Value
                        + query.Phone.Value);
            }     

            return total;                        
        }

        public static DataTable GetPersonalBudget(string userID, DateTime? date = null)
        {
            Amount amntObject = AmountModel.LoadUserTotalAmount(userID);
            
            if (date != null)
            {
                var query =
                    (from personalObject in DatabaseFunctions.DataContext.PersonalBudgets
                     join amntSpentObject in DatabaseFunctions.DataContext.AmountSpents
                     on personalObject.UserAccount.ID equals amntSpentObject.UserID
                     where personalObject.UserID.ToUpper().Equals(userID.ToUpper()) &&
                           personalObject.Date.Equals(date)
                     select new
                     {
                        BusFair = personalObject.BusFair,
                        WithFriends = personalObject.WithFriends,
                        OnMySelf = personalObject.OnMySelf,
                        Gifts = personalObject.Gifts,
                        Clothes = personalObject.Clothes,
                        Extra = personalObject.Extra,
                        Phone = personalObject.Phone,                        
                        Savings = (amntObject.PersonalAmount.Value - amntSpentObject.SpentPersonalAmount)
                     });

                if (query != null)
                    return DatabaseFunctions.LINQToDataTable(query);
            }
            else
            {
                var query =
                   (from personalBudget in DatabaseFunctions.DataContext.PersonalBudgets
                    where personalBudget.UserID.ToUpper().Equals(userID.ToUpper())                          
                    select personalBudget);

                if (query != null)
                    return DatabaseFunctions.LINQToDataTable(query);
            }

            return null;
        }

        public static DataTable GetHomeBudget(string userID, DateTime? date = null)
        {
            if (date != null)
            {
                string txt = date+"";
                string[] array = txt.Split(new char[] { ' ' }, 2);
                var query =
                    (from budgetObject in DatabaseFunctions.DataContext.Budgets
                     where budgetObject.UserID.ToUpper().Equals(userID.ToUpper()) &&
                           budgetObject.DateOfBudget.Date.Equals(txt)
                     select budgetObject);
                
                if (query != null)
                    return DatabaseFunctions.LINQToDataTable(query);
            }
            else
            {
                var query =
                    (from budgetObject in DatabaseFunctions.DataContext.Budgets
                     where budgetObject.UserID.ToUpper().Equals(userID.ToUpper())                           
                     select budgetObject);

                if (query != null)
                    return DatabaseFunctions.LINQToDataTable(query);
            }

            return null;
        }

        public static DataTable LoadBills(int billsID)
        {
            var query =
               from billsObject in DatabaseFunctions.DataContext.Bills
               where billsObject.BillsID == billsID
               select billsObject;

            if (query != null)
                return DatabaseFunctions.LINQToDataTable(query);

            return null;
        }

        public static DataTable LoadAccessories(int accessID)
        {
            var query =
               from accessObject in DatabaseFunctions.DataContext.Accessories
               where accessObject.AccessoriesID == accessID
               select accessObject;

            if (query != null)
                return DatabaseFunctions.LINQToDataTable(query);

            return null;
        }

        public static DataTable LoadGrocery(int groceryID)
        {
            var query =
               from groceryObject in DatabaseFunctions.DataContext.Groceries
               where groceryObject.GroceryID == groceryID
               select groceryObject;

            if (query != null)
                return DatabaseFunctions.LINQToDataTable(query);

            return null;
        }
    }
}
