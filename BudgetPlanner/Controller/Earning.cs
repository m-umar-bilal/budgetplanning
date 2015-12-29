using BudgetPlanner.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BudgetPlanner.Controller
{
    class Earning
    {
      public int ErID { get; set; }
      public int Price  { get; set; }
      public DateTime Date { get; set; }
      public  String UID { get; set; }

        public BudgetPlanner.Model.AmountSpent AmountSpent
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

      /*  public static DataSet getEarning(String date)
      {
         // return EarningDb.getEarning(date);
      }*/
      public static Earning getSingleEarning(int erid)
      {
          return EarningDb.getSingleEarning(erid);
      }

      public static bool deleteEarning(Earning earning)
      {
          return EarningDb.deleteEarning(earning);
      }

      public static bool updateEarning(Earning earning)
      {
          return EarningDb.updateEarning(earning);
      }

      public static bool addEarning(Earning earning)
      {
          return EarningDb.addEarning(earning);
      }
      public static int getTotalEarning()
      {
          return EarningDb.getTotalEarning();
      }
    }
}
