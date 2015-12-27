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
    public class AccessoriesModel
    {        
        public static int GetLastEnteredAccessoriesID()
        {
            var query =
                (from accessObject in DatabaseFunctions.DataContext.Accessories
                 orderby accessObject.AccessoriesID ascending
                 select accessObject).FirstOrDefault();

            if (query == null)
                return 1;

            return ++query.AccessoriesID;
        }

        public static void SaveAccessories(Controller.AccessoriesController accessObject)
        {          
            Accessory obj = new Accessory();
            obj.AccessoriesID = GetLastEnteredAccessoriesID();
            obj.Jewellary = accessObject.Jewellary;
            obj.Cosmetics = accessObject.Cosmetics;
            obj.Perfumes = accessObject.Perfumes;
            obj.Clothes = accessObject.Clothes;
            obj.Shoes = accessObject.Shoes;
            obj.InteriorDecor = accessObject.InteriorDecor;

            DatabaseFunctions.DataContext.Accessories.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();           
        }

        public static void SaveAccessoriesQuery(Controller.AccessoriesController accessObject)
        {
            string query = "INSERT INTO Accessory(AccessoriesID,Jewellary,Cosmetics,Perfumes,Clothes,Shoes,InteriorDecor)";
            query += " VALUES ('" + GetLastEnteredAccessoriesID() + "','" + accessObject.Jewellary + "','"
                                  + accessObject.Cosmetics +  "','" + accessObject.Perfumes + "','" 
                                  + accessObject.Clothes + "','" + accessObject.Shoes + "','" + accessObject.InteriorDecor + "')";
            
            DatabaseFunctions.ExecuteQuery(query);
        }

        public static Accessory GetAccessories(string userID)
        {
            Accessory obj = new Accessory();

            var query =
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 join accessObject in DatabaseFunctions.DataContext.Accessories
                 on budgetObject.AccessoriesID equals accessObject.AccessoriesID
                 where budgetObject.UserID.Equals(userID)
                 select new
                 {
                     accessID = accessObject.AccessoriesID,
                     jewellary = accessObject.Jewellary,
                     perfumes = accessObject.Perfumes,
                     cosmetics = accessObject.Cosmetics,
                     clothes = accessObject.Clothes,
                     shoes = accessObject.Shoes,
                     interiorDecor = accessObject.InteriorDecor
                 }).FirstOrDefault();

            if (query != null)
            {
                obj.AccessoriesID = query.accessID;
                obj.Jewellary = query.jewellary;
                obj.Perfumes = query.perfumes;
                obj.Cosmetics = query.cosmetics;
                obj.Clothes = query.clothes;
                obj.Shoes = query.shoes;
                obj.InteriorDecor = query.interiorDecor;
            }

            return obj;
        }

        public static int GetAccessoriesByUserID(string userID)
        {
            return
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.UserID.Equals(userID)
                  select budgetObject.AccessoriesID).FirstOrDefault().Value;
        }

        public static void UpdateAccessories(string userID, Controller.AccessoriesController accessObject)
        {
            var query =
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.AccessoriesID == accessObject.AccessoriesID
                  && budgetObject.UserID.Equals(userID)
                  select budgetObject).FirstOrDefault();

            if (query != null)
            {
                query.Accessory.Jewellary = accessObject.Jewellary;
                query.Accessory.Perfumes = accessObject.Perfumes;
                query.Accessory.Cosmetics = accessObject.Cosmetics;
                query.Accessory.Clothes = accessObject.Clothes;
                query.Accessory.Shoes = accessObject.Shoes;
                query.Accessory.InteriorDecor = accessObject.InteriorDecor;

                DatabaseFunctions.DataContext.SubmitChanges();
            }           
        }
    }
}
