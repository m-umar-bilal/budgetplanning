using BudgiDesk.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BudgiDesk.BLL
{
    class Expense
    {

        public int EID { get; set; }
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public String Location { get; set; }
        public Category category { get; set; }
        public int UID { get; set; }

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

        public static DataSet getExpense(String date)
        {
            return ExpenseDb.getExpense(date);
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
