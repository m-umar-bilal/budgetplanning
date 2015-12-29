using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region History
/*
 * 25-Dec-2015 --- Created By U & A
 */
#endregion 

namespace BudgetPlanner.Controller
{
    public class BillsController
    {
        #region Private Properties

        private int _billsID;       
        private int _electricity;      
        private int _gas;
        private int _phone;
        private int _water;
        private int _education;
        private int _medical;
  
        #endregion

        #region Public Properties

        public int BillsID
        {
            get { return _billsID; }
            set { _billsID = value; }
        }
        public int Electricity
        {
            get { return _electricity; }
            set { _electricity = value; }
        }

        public int Gas
        {
            get { return _gas; }
            set { _gas = value; }
        }

        public int Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public int Water
        {
            get { return _water; }
            set { _water = value; }
        }

        public int Education
        {
            get { return _education; }
            set { _education = value; }
        }

        public int Medical
        {
            get { return _medical; }
            set { _medical = value; }
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

        public static void SaveBills(BillsController billsObject)
        {
            Model.BillsModel.SaveBills(billsObject);
        }

        public static void SaveBillsQuery(Controller.BillsController billsObject)
        {
            Model.BillsModel.SaveBillsQuery(billsObject);
        }

        public static void UpdateBills(string userID, Controller.BillsController billsObject)
        {
            Model.BillsModel.UpdateBills(userID, billsObject);
        }

        public static int GetLastEnteredBillsID()
        {
            return Model.BillsModel.GetLastEnteredBillsID();
        }

        public static Controller.BillsController GetBills(string userID)
        {
            Model.Bill obj = Model.BillsModel.GetBills(userID);
            BillsController billsObject = new BillsController();

            billsObject.BillsID = obj.BillsID;
            billsObject.Electricity = obj.Electricity.Value;
            billsObject.Gas = obj.Gas.Value;
            billsObject.Phone = obj.Phone.Value;
            billsObject.Water = obj.Water.Value;
            billsObject.Education = obj.Education.Value;
            billsObject.Medical = obj.Medical.Value;

            return billsObject;
        }

        public static int GetBillsByUserID(string userID)
        {
            return Model.BillsModel.GetBillsByUserID(userID);
        }

        #endregion
    }
}
