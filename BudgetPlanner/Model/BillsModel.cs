using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

 


namespace BudgetPlanner.Model
{
    public class BillsModel
    {        
        public static int GetLastEnteredBillsID()
        {            
            var query =
                (from billsObject in DatabaseFunctions.DataContext.Bills
                 orderby billsObject.BillsID ascending
                 select billsObject).FirstOrDefault();

            if (query == null)
                return 1;

            return ++query.BillsID;
        }

        public static void SaveBills(Controller.BillsController billsObject)
        {            
            Bill obj = new Bill();
            obj.BillsID = GetLastEnteredBillsID();
            obj.Electricity = billsObject.Electricity;
            obj.Gas = billsObject.Gas;
            obj.Water = billsObject.Water;
            obj.Phone = billsObject.Phone;
            obj.Medical = billsObject.Medical;
            obj.Education = billsObject.Education;

            DatabaseFunctions.DataContext.Bills.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();            
        }

        public static void SaveBillsQuery(Controller.BillsController billsObject)
        {
            string query = "INSERT INTO Bill(BillsID,Electricity,Gas,Water,Phone,Medical,Education)";
            query += " VALUES ('" + GetLastEnteredBillsID() + "','" + billsObject.Electricity + "','"
                                  + billsObject.Gas + "','" + billsObject.Water + "','"
                                  + billsObject.Phone + "','" + billsObject.Medical + "','"
                                  + billsObject.Education + "')";

            DatabaseFunctions.ExecuteQuery(query);
        }

        public static Bill GetBills(string userID)
        {
            Bill obj = new Bill();

            var query =
                (from budgetObject in DatabaseFunctions.DataContext.Budgets
                 join billsObject in DatabaseFunctions.DataContext.Bills
                 on budgetObject.BillsID equals billsObject.BillsID
                 where budgetObject.UserID.Equals(userID)
                 select new
                 {
                     billsID = billsObject.BillsID,
                     electricity = billsObject.Electricity,
                     gas = billsObject.Gas,
                     water = billsObject.Water,
                     phone = billsObject.Phone,
                     education = billsObject.Education,
                     medical = billsObject.Medical
                 }).FirstOrDefault();

            if (query != null)
            {
                obj.BillsID = query.billsID;
                obj.Electricity = query.electricity;
                obj.Gas = query.gas;
                obj.Water = query.water;
                obj.Phone = query.phone;
                obj.Education = query.education;
                obj.Medical = query.medical;
            }

            return obj;
        }

        public static void UpdateBills(string userID, Controller.BillsController billsObject)
        {
            var query =
                  (from budgetObject in DatabaseFunctions.DataContext.Budgets
                   where budgetObject.BillsID == billsObject.BillsID
                   && budgetObject.UserID.Equals(userID)
                   select budgetObject).FirstOrDefault();

            if (query != null)
            {
                query.Bill.Electricity = billsObject.Electricity;
                query.Bill.Gas = billsObject.Gas;
                query.Bill.Phone = billsObject.Phone;
                query.Bill.Water = billsObject.Water;
                query.Bill.Education = billsObject.Education;
                query.Bill.Medical = billsObject.Medical;

                DatabaseFunctions.DataContext.SubmitChanges();
            }           
        }
        
        public static int GetBillsByUserID(string userID)
        {
            return
                 (from budgetObject in DatabaseFunctions.DataContext.Budgets
                  where budgetObject.UserID.Equals(userID)
                  select budgetObject.BillsID).FirstOrDefault().Value;
        }
    }
}
