using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region History
/*
 * 03-Dec-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.Controller
{
    public class FoodController
    {
        #region Private Properties

        private int _foodID;      
        private int _vegetables;        
        private int _meat;
        private int _fruit;
        private int _milk;
       
        #endregion

        #region Public Properties

        public int FoodID
        {
            get { return _foodID; }
            set { _foodID = value; }
        }
        public int Vegetables
        {
            get { return _vegetables; }
            set { _vegetables = value; }
        }

        public int Meat
        {
            get { return _meat; }
            set { _meat = value; }
        }

        public int Fruit
        {
            get { return _fruit; }
            set { _fruit = value; }
        }

        public int Milk
        {
            get { return _milk; }
            set { _milk = value; }
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

        #endregion

        #region Public Methods

        public static void SaveFood(FoodController foodObject)
        {
            Model.FoodModel.SaveFood(foodObject);
        }

        public static void SaveFoodQuery(Controller.FoodController foodObject)
        {
            Model.FoodModel.SaveFoodQuery(foodObject);
        }

        public static int GetLastEnteredFoodID()
        {
            return Model.FoodModel.GetLastEnteredFoodID();
        }

        public static FoodController GetFood(string userID)
        {
            Model.Food obj = Model.FoodModel.GetFood(userID);
            FoodController foodObject = new FoodController();

            foodObject.FoodID = obj.FoodID;
            foodObject.Vegetables = obj.Vegetables.Value;
            foodObject.Fruit = obj.Fruits.Value;
            foodObject.Meat = obj.Meat.Value;
            foodObject.Milk = obj.Milk.Value;

            return foodObject;
        }

        public static int GetFoodByUserID(string userID)
        {
            return Model.FoodModel.GetFoodByUserID(userID);
        }      

        public static void UpdateFood(string userID, Controller.FoodController foodObject)
        {
            Model.FoodModel.UpdateFood(userID, foodObject);
        }

        #endregion
    }
}
