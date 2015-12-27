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
    public class GroceryController
    {
        #region Private Properties

        private int _groceryID;      
        private int _cereals;
        private int _soap;
        private int _shampoo;
        private int _lotion;
        private int _oil;
        private int _deoderants;
        private int _surf;
        private int _toothPaste;
        private int _cleaningLiquids;
        private int _tea;
        private int _energyDrinks;
        private int _spices;

        #endregion

        #region Public Properties

        public int GroceryID
        {
            get { return _groceryID; }
            set { _groceryID = value; }
        }
        public int Cereals
        {
            get { return _cereals; }
            set { _cereals = value; }
        }
        public int Soap
        {
            get { return _soap; }
            set { _soap = value; }
        }
        public int Shampoo
        {
            get { return _shampoo; }
            set { _shampoo = value; }
        }
        public int Lotion
        {
            get { return _lotion; }
            set { _lotion = value; }
        }
        public int Oil
        {
            get { return _oil; }
            set { _oil = value; }
        }
        public int Deoderants
        {
            get { return _deoderants; }
            set { _deoderants = value; }
        }
        public int Surf
        {
            get { return _surf; }
            set { _surf = value; }
        }
        public int ToothPaste
        {
            get { return _toothPaste; }
            set { _toothPaste = value; }
        }
        public int CleaningLiquids
        {
            get { return _cleaningLiquids; }
            set { _cleaningLiquids = value; }
        }
        public int Tea
        {
            get { return _tea; }
            set { _tea = value; }
        }
        public int EnergyDrinks
        {
            get { return _energyDrinks; }
            set { _energyDrinks = value; }
        }
        public int Spices
        {
            get { return _spices; }
            set { _spices = value; }
        }

        public BudgetController BudgetController
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

        public static void SaveGrocery(GroceryController groceryObject)
        {
            Model.GroceryModel.SaveGrocery(groceryObject);
        }

        public static void SaveGroceryQuery(Controller.GroceryController groceryObject)
        {
            Model.GroceryModel.SaveGroceryQuery(groceryObject);
        }

        public static int GetLastEnteredGroceryID()
        {
            return Model.GroceryModel.GetLastEnteredGroceryID();
        }

        public static GroceryController GetGrocery(string userID)
        {
            Model.Grocery obj = Model.GroceryModel.GetGrocery(userID);
            GroceryController groceryObject = new GroceryController();

            groceryObject.GroceryID = obj.GroceryID;
            groceryObject.Cereals = obj.Cereals.Value;
            groceryObject.Soap = obj.Soap.Value;
            groceryObject.Shampoo = obj.Shampoo.Value;
            groceryObject.Surf = obj.Surf.Value;
            groceryObject.Lotion = obj.Lotion.Value;
            groceryObject.Oil = obj.Oil.Value;
            groceryObject.ToothPaste = obj.ToothPaste.Value;
            groceryObject.CleaningLiquids = obj.CleaningLiquids.Value;
            groceryObject.EnergyDrinks = obj.EnergyDrinks.Value;
            groceryObject.Deoderants = obj.Deoderants.Value;
            groceryObject.Spices = obj.Spices.Value;
            groceryObject.Tea = obj.Tea.Value;

            return groceryObject;
        }

        public static int GetGroceryByUserID(string userID)
        {
            return Model.GroceryModel.GetGroceryByUserID(userID);
        }     

        public static void UpdateGrocery(string userID, Controller.GroceryController groceryObject)
        {
            Model.GroceryModel.UpdateGrocery(userID, groceryObject);
        }

        #endregion
    }
}
