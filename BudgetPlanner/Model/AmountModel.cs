
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BudgetPlanner.Model
{
    public class AmountModel
    {        
        public static Amount LoadUserTotalAmount(string userID)
        {            
            return
                (from amountObject in DatabaseFunctions.DataContext.Amounts
                 where amountObject.UserID.Equals(userID)
                 select amountObject).FirstOrDefault();
        }

        public static void AddAmount(string userID, int homeAmount, int personalAmount = 0)
        {
            Amount amountObject = new Amount();
            amountObject.UserID = userID;
            amountObject.HomeAmount = homeAmount;

            if (personalAmount != 0)
                amountObject.PersonalAmount = personalAmount;

            DatabaseFunctions.DataContext.Amounts.InsertOnSubmit(amountObject);
            DatabaseFunctions.DataContext.SubmitChanges();
        }

        public static void UpdateAmount(string userID, int homeAmount, int personalAmount = 0)
        {            
            var query =
                (from amountObject in DatabaseFunctions.DataContext.Amounts
                 where amountObject.UserID.Equals(userID)
                 select amountObject).FirstOrDefault();

            if (query != null)
            {
                query.HomeAmount = homeAmount;

                if (personalAmount != 0)
                    query.PersonalAmount = personalAmount;
            }

            DatabaseFunctions.DataContext.SubmitChanges();            
        }

        public static void SaveSpentAmount(string userID, DateTime date, int homeAmount, int personalAmount = 0)
        {
            AmountSpent obj = new AmountSpent();
            obj.UserID = userID;
            obj.DateOfSpentAmount = date;
            obj.SpentHomeAmount = homeAmount;

            if (personalAmount != 0)
                obj.SpentPersonalAmount = personalAmount;

            DatabaseFunctions.DataContext.AmountSpents.InsertOnSubmit(obj);
            DatabaseFunctions.DataContext.SubmitChanges();
        }

        public static void UpdateSpentAmount(string userID, DateTime date, int homeAmount, int personalAmount = 0)
        {
            var query =
                (from spentAmntObject in DatabaseFunctions.DataContext.AmountSpents
                 where spentAmntObject.UserID.Equals(userID)
                 select spentAmntObject).FirstOrDefault();

            if (query != null)
            {
                query.DateOfSpentAmount = date;
                query.SpentHomeAmount = homeAmount;

                if (personalAmount != 0)                
                    query.SpentPersonalAmount = personalAmount;                
            }

            DatabaseFunctions.DataContext.SubmitChanges();
        }

        public static long GetSpentHomeAmount(string userID)
        {
            return
                (from spentObject in DatabaseFunctions.DataContext.AmountSpents
                 where spentObject.UserID.Equals(userID)
                 select spentObject.SpentHomeAmount).FirstOrDefault().Value;
        }

        public static long GetSpentPersonalAmount(string userID)
        {
            return
                (from spentObject in DatabaseFunctions.DataContext.AmountSpents
                 where spentObject.UserID.Equals(userID)
                 select spentObject.SpentPersonalAmount).FirstOrDefault().Value;
        }
    }
}
