using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace BudgetPlanner.Controller
{
    public class Month
    {
        #region Private Properties

        private int _value;
        private string _name;

        #endregion                

        #region Public Properties

        public int Value
        {
            get { return _value; }
            set { _value = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public BillsController BillsController
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
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

        public Month() { }

        public Month(int value, string monthName) 
        {
            this._value = value;
            this._name = monthName;
        }

        #endregion
    }
}
