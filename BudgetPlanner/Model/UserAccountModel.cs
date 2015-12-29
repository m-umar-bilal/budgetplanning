using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BudgetPlanner.Controller;


namespace BudgetPlanner.Model
{
    public class UserAccountModel
    {       
        public static void SaveAccount(UserAccountController userAccntObject)
        {            
            UserAccount userObject = new UserAccount();
            userObject.ID = userAccntObject.ID;
            userObject.Name = userAccntObject.Name;
            userObject.PhoneNumber = userAccntObject.PhoneNumber;
            userObject.Age = userAccntObject.Age;
            userObject.Gender = userAccntObject.Gender;
            userObject.UserName = userAccntObject.UserName;
            userObject.Password = userAccntObject.Password;

            DatabaseFunctions.DataContext.UserAccounts.InsertOnSubmit(userObject);
            DatabaseFunctions.DataContext.SubmitChanges();            
        }

        public static void UpdateAccount(UserAccountController userAccntObject)
        {         
            var query =
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                 where userObject.ID.ToUpper().Equals(userAccntObject.ID.ToUpper())
                 select userObject).FirstOrDefault();

            if (query != null)
            {
                query.Name = userAccntObject.Name;
                query.PhoneNumber = userAccntObject.PhoneNumber;
                query.Age = userAccntObject.Age;
                query.Gender = userAccntObject.Gender;
                query.UserName = userAccntObject.UserName;
                query.Password = userAccntObject.Password;

                DatabaseFunctions.DataContext.SubmitChanges();                
            }
        }

        public static void DeleteAccount(string userID)
        {           
            var query =
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                 where userObject.ID.ToUpper().Equals(userID.ToUpper())
                 select userObject).FirstOrDefault();

            if (query != null)
            {
                DatabaseFunctions.DataContext.UserAccounts.DeleteOnSubmit(query);
                DatabaseFunctions.DataContext.SubmitChanges();       
            }
        }

        public static UserAccount GetUserDetailByID(string userID)
        {           
            return
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                where userObject.ID.ToUpper().Equals(userID.ToUpper())
                select userObject).FirstOrDefault();                        
        }

        public static UserAccount LoginUser(string userName, string password)
        {            
            return
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                 where userObject.UserName.ToUpper().Equals(userName.ToUpper()) 
                 && userObject.Password.ToUpper().Equals(password.ToUpper())
                 select userObject).FirstOrDefault();            
        }

        public static List<UserAccount> GetAllUsers()
        {           
            List<UserAccount> lstUsers = new List<UserAccount>();

            var query =
                from userObject in DatabaseFunctions.DataContext.UserAccounts
                orderby userObject.ID ascending
                select userObject;

            if (query != null && query.Count() > 0)
            {
                foreach (var obj in query)
                    lstUsers.Add(obj);
            }

            return lstUsers;                
        }

        public static void UpdateLoginPassword(string userID, string userName, string password)
        {          
            var query =
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                 where userObject.ID.ToUpper().Equals(userID.ToUpper())
                 select userObject).FirstOrDefault();

            if (query != null)
            {               
                query.UserName = userName;
                query.Password = password;

                DatabaseFunctions.DataContext.SubmitChanges();                
            }
        }

        public static UserAccount GetUserNameByLoginDetails(string userName, string password)
        {            
            return
                (from userObject in DatabaseFunctions.DataContext.UserAccounts
                 where userObject.UserName.ToUpper().Equals(userName.ToUpper())
                 && userObject.Password.ToUpper().Equals(password.ToUpper())
                 select userObject).FirstOrDefault();
        }
    }
}
