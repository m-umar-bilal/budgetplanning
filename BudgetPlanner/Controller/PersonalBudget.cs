using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BudgetPlanner.Controller
{
    public class PersonalBudget
    {
        #region Private Properties

        private string _userID;
        private int _busFair;       
        private int _withFriends;       
        private int _gifts;      
        private int _onMySelf;      
        private int _extra;      
        private int _clothes;      
        private int _phone;
        private DateTime _date;
       
        #endregion

        #region Public Properties

        public string UserID
        {
            get { return _userID; }
            set { _userID = value; }
        }

        public int BusFair
        {
            get { return _busFair; }
            set { _busFair = value; }
        }

        public int WithFriends
        {
            get { return _withFriends; }
            set { _withFriends = value; }
        }

        public int Gifts
        {
            get { return _gifts; }
            set { _gifts = value; }
        }

        public int OnMySelf
        {
            get { return _onMySelf; }
            set { _onMySelf = value; }
        }

        public int Extra
        {
            get { return _extra; }
            set { _extra = value; }
        }

        public int Clothes
        {
            get { return _clothes; }
            set { _clothes = value; }
        }

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        #endregion

        public Model.Amount Amount
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }
    }
}
