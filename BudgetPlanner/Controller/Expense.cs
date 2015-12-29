using BudgetPlanner.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BudgetPlanner.Controller
{
    class Expense
    {

        public int EID { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public String Location { get; set; }
        public Category category { get; set; }
        public String UID { get; set; }

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

        public static DataTable getExpense(String date,String UID)
        {
            return ExpenseDb.getExpense(date, UID);
        }
        public static Earning getSingleExpense(int eid)
        {
            return ExpenseDb.getSingleExpense(eid);
        }

        public static bool deleteExpense(Expense expense)
        {
            return ExpenseDb.deleteExpense(expense);
        }

        public static bool updateExpense(Expense expense)
        {
            return ExpenseDb.updateExpense(expense);
        }

        public static bool addExpense(Expense expense)
        {
            return ExpenseDb.addExpense(expense);
        }
    }
}
