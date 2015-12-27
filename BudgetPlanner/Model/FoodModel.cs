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
    public class FoodModel
    {       
        public static int GetLastEnteredFoodID()
        {            
            var query =
                (from foodObject in DatabaseFunctions.DataContext.Foods
                 orderby foodObject.FoodID ascending
                 select foodObject).FirstOrDefault();

            if (query == null)
                return 1;

            return ++query.FoodID;
        }

        public static void SaveFood(Controller.FoodController foodObject)
        {            
            Food obj = new Food();
            obj.FoodID = GetLastEnteredFoodID();
            obj.Vegetables = foodObject.Vegetables;
            obj.Meat = foodObject.Meat;
            obj.Fruits = foodObject.Fruit;
            obj.Milk = foodObject.Milk;
       
            DatabaseFunctions.DataContext.Foods.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();
         
        }

        public static void SaveFoodQuery(Controller.FoodController foodObject)
        {
            string query = "INSERT INTO Food(FoodID,Vegetables,Meat,Fruits,Milk) VALUES ('" + GetLastEnteredFoodID() + "','" + foodObject.Vegetables + "','" +
                                                                                            + foodObject.Meat + "','" + foodObject.Fruit + "','" + foodObject.Milk + "')";

            DatabaseFunctions.ExecuteQuery(query);
        }

        public static Food GetFood(string userID)
        {
            Food obj = new Food();

            var query =
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 join foodObject in DatabaseFunctions.DataContext.Foods
                 on budgetObject.FoodID equals foodObject.FoodID
                 where budgetObject.UserID.Equals(userID)
                 select new
                 {
                     foodID = foodObject.FoodID,
                     vegetables = foodObject.Vegetables,
                     meat = foodObject.Meat,
                     fruits = foodObject.Fruits,
                     milk = foodObject.Milk,                     
                 }).FirstOrDefault();

            if (query != null)
            {
                obj.FoodID = query.foodID;
                obj.Vegetables = query.vegetables.Value;
                obj.Meat = query.meat.Value;
                obj.Fruits = query.fruits.Value;
                obj.Milk = query.milk.Value;                
            }

            return obj;
        }

        public static int GetFoodByUserID(string userID)
        {
            return
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.UserID.Equals(userID)
                  select budgetObject.FoodID).FirstOrDefault().Value;
        }

        public static void UpdateFood(string userID, Controller.FoodController foodObject)
        {
            var query =
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.FoodID == foodObject.FoodID
                  && budgetObject.UserID.Equals(userID)
                  select budgetObject).FirstOrDefault();

            if (query != null)
            {
                query.Food.Vegetables = foodObject.Vegetables;
                query.Food.Meat = foodObject.Meat;
                query.Food.Fruits = foodObject.Fruit;
                query.Food.Milk = foodObject.Milk;

                DatabaseFunctions.DataContext.SubmitChanges();
            }           
        }
    }
}
