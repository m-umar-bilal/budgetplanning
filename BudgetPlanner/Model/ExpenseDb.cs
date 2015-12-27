using BudgetPlanner.Controller;
using BudgiDesk.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BudgiDesk.DAL
{
    class ExpenseDb
    {

        public static SqlConnection cnn = new SqlConnection(Constants.CONNECTION_STRING);


        public static bool addExpense(Expense expense)
        {
            try
            {
                String query2 = "Insert into earning(uid,price,location,date,cid) values ( " + expense.UID + "," + expense.Price + "," + expense.Location + "," + expense.Date + "," +expense.category.CID+ ")";
                SqlCommand cmd2 = new SqlCommand(query2, cnn);
                cnn.Open();
                int a = cmd2.ExecuteNonQuery();
                cnn.Close();


                if (a > 0)
                {
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                return false;
            }


        }


        public static bool updateExpense(Expense expense)
        {
            try
            {
                String query2 = "update earning set price = " + expense.Price + ",date="+ expense.Date + ",Location="+expense.Location+" , Category="+expense.category.CID+" where eid = " + expense.EID + "";
                SqlCommand cmd2 = new SqlCommand(query2, cnn);
                cnn.Open();
                int a = cmd2.ExecuteNonQuery();
                cnn.Close();


                if (a > 0)
                {
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                return false;
            }


        }

        public static bool deleteExpense(Expense expense)
        {
            try
            {
                String query2 = "delete expense where eid = " + expense.EID + "";
                SqlCommand cmd2 = new SqlCommand(query2, cnn);
                cnn.Open();
                int a = cmd2.ExecuteNonQuery();
                cnn.Close();


                if (a > 0)
                {
                    return true;
                }
                return false;
            }

            catch (Exception ex)
            {
                return false;
            }


        }

        public static Earning getSingleExpense(int eid)
        {
            Expense expense = new Expense();
            expense.EID = eid;
            String query2 = "Select * from expense where eid = " + eid + "";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
            cnn.Close();
           
            try
            {
                if (ds.Read())
                {
                    expense.Price = ds.GetInt32(2);
                    expense.UID = ds.GetInt32(3);
                    expense.Date = ds.GetDateTime(4);
                    

                }
                return null;
            }

            catch (Exception ex)
            {
                return null;


            }

        }

        public static DataSet getExpense(String date)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * from expense where date like '" + date + "' ", cnn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            return ds;
        }


    }
}
