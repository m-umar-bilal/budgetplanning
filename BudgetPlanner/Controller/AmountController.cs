using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BudgetPlanner.Controller
{
    public class AmountController
    {
        #region Private Properties

        private string _userID;      
        private int _personalAmount;
        private int _homeAmount;
     
        #endregion

        #region Public Properties

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }     

        public int PersonalAmount
        {
            get { return _personalAmount; }
            set { _personalAmount = value; }
        }

        public int HomeAmount
        {
            get { return _homeAmount; }
            set { _homeAmount = value; }
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

        public AmountController() { }

        public AmountController(string userID, int personalAmount, int totalAmount)
        {
            this._userID = userID;
            this._personalAmount = totalAmount;
            this._personalAmount = personalAmount;
        }

        public static AmountController LoadUserTotalAmount(string userID, bool value = false)
        {
            Model.Amount amountObject = Model.AmountModel.LoadUserTotalAmount(userID);
            
            if (amountObject == null)
                return null;

            AmountController obj = new AmountController();

            obj.UserID = amountObject.UserID;
            obj.HomeAmount = amountObject.HomeAmount.Value;

            if (value)  // if value true then load also personal amount.
            {
                if (amountObject.PersonalAmount.HasValue)
                    obj.PersonalAmount = amountObject.PersonalAmount.Value;
                else
                    obj.PersonalAmount = 000;
            }

            return (obj != null) ? obj : null;
        }

        public static void AddAmount(string userID, int homeAmount, int personalAmount = 0)
        {
            Model.AmountModel.AddAmount(userID, homeAmount, personalAmount);
        }

        public static void UpdateAmount(string userID, int homeAmount, int personalAmount = 0)
        {
            Model.AmountModel.UpdateAmount(userID, homeAmount, personalAmount);   
        }

        public static void SaveSpentAmount(string userID, DateTime date, int homeAmount, int personalAmount = 0)
        {
            Model.AmountModel.SaveSpentAmount(userID, date, homeAmount, personalAmount);
        }

        public static void UpdateSpentAmount(string userID, DateTime date, int homeAmount, int personalAmount = 0)
        {
            Model.AmountModel.UpdateSpentAmount(userID, date, homeAmount, personalAmount);
        }

        public static long GetSpentHomeAmount(string userID)
        {
            return Model.AmountModel.GetSpentHomeAmount(userID);
        }

        public static long GetSpentPersonalAmount(string userID)
        {
            return Model.AmountModel.GetSpentPersonalAmount(userID);
        }

        #endregion
    }
}
