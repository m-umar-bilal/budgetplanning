using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BudgetPlanner.Controller
{
    public class AccessoriesController
    {
        #region Private Properties

        private int _accessoriesID;       
        private int _jewellary;
        private int _perfumes;
        private int _interiorDecor;
        private int _cosmetics;
        private int _clothes;
        private int _shoes;

        #endregion

        #region Public Properties

        public int AccessoriesID
        {
            get { return _accessoriesID; }
            set { _accessoriesID = value; }
        }
        public int Jewellary
        {
            get { return _jewellary; }
            set { _jewellary = value; }
        }

        public int Perfumes
        {
            get { return _perfumes; }
            set { _perfumes = value; }
        }

        public int InteriorDecor
        {
            get { return _interiorDecor; }
            set { _interiorDecor = value; }
        }

        public int Cosmetics
        {
            get { return _cosmetics; }
            set { _cosmetics = value; }
        }

        public int Clothes
        {
            get { return _clothes; }
            set { _clothes = value; }
        }

        public int Shoes
        {
            get { return _shoes; }
            set { _shoes = value; }
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

        public static void SaveAccessories(AccessoriesController accessObject)
        {
            Model.AccessoriesModel.SaveAccessories(accessObject);
        }

        public static void SaveAccessoriesQuery(Controller.AccessoriesController accessObject)
        {
            Model.AccessoriesModel.SaveAccessoriesQuery(accessObject);
        }

        public static Controller.AccessoriesController GetAccessories(string userID)
        {
            Model.Accessory obj = Model.AccessoriesModel.GetAccessories(userID);
            AccessoriesController accessObject = new AccessoriesController();

            accessObject.AccessoriesID = obj.AccessoriesID;
            accessObject.Jewellary = obj.Jewellary.Value;
            accessObject.Cosmetics = obj.Cosmetics.Value;
            accessObject.Perfumes = obj.Perfumes.Value;
            accessObject.Clothes = obj.Clothes.Value;
            accessObject.Shoes = obj.Shoes.Value;
            accessObject.InteriorDecor = obj.InteriorDecor.Value;

            return accessObject;
        }

        public static int GetLastEnteredAccessoriesID()
        {
            return Model.AccessoriesModel.GetLastEnteredAccessoriesID();
        }       

        public static int GetAccessoriesByUserID(string userID)
        {
            return Model.AccessoriesModel.GetAccessoriesByUserID(userID);
        }      

        public static void UpdateAccessories(string userID, Controller.AccessoriesController accessObject)
        {
            Model.AccessoriesModel.UpdateAccessories(userID, accessObject);
        }

        #endregion
    }
}
