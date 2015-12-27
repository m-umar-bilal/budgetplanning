using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region History
/*
  
 */
#endregion 

namespace BudgetPlanner.Model
{
    public class GroceryModel
    {        
        public static int GetLastEnteredGroceryID()
        {           
            var query =
                (from groceryObject in DatabaseFunctions.DataContext.Groceries
                 orderby groceryObject.GroceryID ascending
                 select groceryObject).FirstOrDefault();

            if (query == null)
                return 1;

            return ++query.GroceryID;
        }

        public static void SaveGrocery(Controller.GroceryController groceryObject)
        {            
            Grocery obj = new Grocery();
            obj.GroceryID = GetLastEnteredGroceryID();
            obj.Cereals = groceryObject.Cereals;
            obj.Oil = groceryObject.Oil;
            obj.Shampoo = groceryObject.Shampoo;
            obj.Surf = groceryObject.Surf;
            obj.Soap = groceryObject.Soap;
            obj.EnergyDrinks = groceryObject.EnergyDrinks;
            obj.CleaningLiquids = groceryObject.CleaningLiquids;
            obj.Deoderants = groceryObject.Deoderants;
            obj.Lotion = groceryObject.Lotion;
            obj.Spices = groceryObject.Spices;
            obj.Tea = groceryObject.Tea;
            obj.ToothPaste = groceryObject.ToothPaste;

            DatabaseFunctions.DataContext.Groceries.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();            
        }

        public static void SaveGroceryQuery(Controller.GroceryController groceryObject)
        {
            string query = "INSERT INTO Grocery([GroceryID],[Cereals],[Soap],[Shampoo],[Lotion],[Oil],";
            query += "[Deoderants],[Surf],[ToothPaste],[CleaningLiquids],[Tea],[EnergyDrinks],[Spices])";
            query += " VALUES ('" + GetLastEnteredGroceryID() + "','" + groceryObject.Cereals + "','"
                                  + groceryObject.Soap + "','" + groceryObject.Shampoo + "','"
                                  + groceryObject.Lotion + "','" + groceryObject.Oil + "','"
                                  + groceryObject.Deoderants + "','" + groceryObject.Surf + "','"
                                  + groceryObject.ToothPaste + "','" + groceryObject.CleaningLiquids + "','"
                                  + groceryObject.Tea + "','" + groceryObject.EnergyDrinks + "','"
                                  + groceryObject.Spices + "')";

            DatabaseFunctions.ExecuteQuery(query);
        }

        public static Grocery GetGrocery(string userID)
        {
            Grocery obj = new Grocery();

            var query =
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 join groceryObject in DatabaseFunctions.DataContext.Groceries
                 on budgetObject.GroceryID equals groceryObject.GroceryID
                 where budgetObject.UserID.Equals(userID)
                 select new
                 {
                     groceryID = groceryObject.GroceryID,
                     cereals = groceryObject.Cereals,
                     soap = groceryObject.Soap,
                     shampoo = groceryObject.Shampoo,
                     surf = groceryObject.Surf,
                     lotion = groceryObject.Lotion,
                     oil = groceryObject.Oil,
                     toothPaste = groceryObject.ToothPaste,
                     liquids = groceryObject.CleaningLiquids,
                     energyDrinks = groceryObject.EnergyDrinks,
                     deoderants = groceryObject.Deoderants,
                     spices = groceryObject.Spices,
                     tea = groceryObject.Tea
                 }).FirstOrDefault();

            if (query != null)
            {
                obj.GroceryID = query.groceryID;
                obj.Cereals = query.cereals.Value;
                obj.Soap = query.soap.Value;
                obj.Shampoo = query.shampoo.Value;
                obj.Surf = query.surf.Value;
                obj.Lotion = query.lotion.Value;
                obj.Oil = query.oil.Value;
                obj.ToothPaste = query.toothPaste.Value;
                obj.CleaningLiquids = query.liquids.Value;
                obj.EnergyDrinks = query.energyDrinks.Value;
                obj.Deoderants = query.deoderants.Value;
                obj.Spices = query.spices.Value;
                obj.Tea = query.tea.Value;
            }

            return obj;
        }

        public static int GetGroceryByUserID(string userID)
        {
            return
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.UserID.Equals(userID)
                  select budgetObject.GroceryID).FirstOrDefault().Value;
        }

        public static void UpdateGrocery(string userID, Controller.GroceryController groceryObject)
        {
            var query =
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.GroceryID == groceryObject.GroceryID
                  && budgetObject.UserID.Equals(userID)
                  select budgetObject).FirstOrDefault();

            if (query != null)
            {
                query.Grocery.Cereals = groceryObject.Cereals;
                query.Grocery.Soap = groceryObject.Soap;
                query.Grocery.Shampoo = groceryObject.Shampoo;
                query.Grocery.Surf = groceryObject.Surf;
                query.Grocery.Oil = groceryObject.Oil;
                query.Grocery.Lotion = groceryObject.Lotion;
                query.Grocery.Tea = groceryObject.Tea;
                query.Grocery.ToothPaste = groceryObject.ToothPaste;
                query.Grocery.CleaningLiquids = groceryObject.CleaningLiquids;
                query.Grocery.Spices = groceryObject.Spices;
                query.Grocery.EnergyDrinks = groceryObject.EnergyDrinks;
                query.Grocery.Deoderants = groceryObject.Deoderants;

                DatabaseFunctions.DataContext.SubmitChanges();
            }            
        }
    }
}
