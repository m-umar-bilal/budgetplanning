using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region History
/*
 * 30-Nov-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.Controller
{
    public class UserAccountController
    {
        #region Private Properties

        private string _Id;      
        private string _name;
        private string _phoneNumber;
        private int _age;
        private bool _gender;
        private string _userName;
        private string _password;
        
        #endregion

        #region Public Properties

        public string ID
        {
            get { return _Id; }
            set { _Id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public bool Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string UserName
        {
            get { return _userName; }
            set { _userName = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        #endregion

        #region Public Methods

        public UserAccountController() { }
        public UserAccountController(string userName, string password)
        {
            this._userName = userName;
            this._password = password;
        }

        public static void SaveAccount(UserAccountController userAccntObject)
        {
            Model.UserAccountModel.SaveAccount(userAccntObject);
        }

        public static void UpdateAccount(UserAccountController userAccntObject)
        {
            Model.UserAccountModel.UpdateAccount(userAccntObject);
        }

        public static void DeleteAccount(string userID)
        {
            Model.UserAccountModel.DeleteAccount(userID);
        }

        public static UserAccountController GetUserDetailByID(string userID)
        {
            Model.UserAccount obj = Model.UserAccountModel.GetUserDetailByID(userID);

            UserAccountController newObj = new UserAccountController();
            newObj.ID = obj.ID;
            newObj.Name = obj.Name;
            newObj.PhoneNumber = obj.PhoneNumber;
            newObj.Age = obj.Age.Value;
            newObj.Gender = obj.Gender.Value;
            newObj.UserName = obj.UserName;
            newObj.Password = obj.Password;

            return (newObj != null) ? newObj : null;            
        }

        public static UserAccountController LoginUser(string userName, string password)
        {
            Model.UserAccount obj = Model.UserAccountModel.LoginUser(userName, password);

            if (obj != null)
                return new UserAccountController(obj.UserName, obj.Password);

            return null;
        }

        public static void UpdateLoginPassword(string userID, string userName, string password)
        {
            Model.UserAccountModel.UpdateLoginPassword(userID, userName, password);
        }

        public static List<UserAccountController> GetAllUsers()
        {
            List<Model.UserAccount> lstUsers = Model.UserAccountModel.GetAllUsers();
            List<UserAccountController> lstGetUsers = new List<UserAccountController>();

            if (lstUsers.Count == 0) return null;

            foreach (var obj in lstUsers)
            {
                UserAccountController newObj = new UserAccountController();
                newObj.ID = obj.ID;
                newObj.Name = obj.Name;
                newObj.PhoneNumber = obj.PhoneNumber;
                newObj.Age = obj.Age.Value;
                newObj.Gender = obj.Gender.Value;
                newObj.UserName = obj.UserName;
                newObj.Password = obj.Password;
                
                lstGetUsers.Add(newObj);                
            }

            return lstGetUsers;
        }

        public static UserAccountController GetUserNameByLoginDetails(string userName, string password)
        {
            Model.UserAccount obj = Model.UserAccountModel.GetUserNameByLoginDetails(userName, password);

            UserAccountController newObj = new UserAccountController();
            newObj.ID = obj.ID;
            newObj.Name = obj.Name;
            newObj.PhoneNumber = obj.PhoneNumber;
            newObj.Age = obj.Age.Value;
            newObj.Gender = obj.Gender.Value;
            newObj.UserName = obj.UserName;            
            newObj.Password = obj.Password;

            return (newObj != null) ? newObj : null;
        }

        #endregion
    }
}
