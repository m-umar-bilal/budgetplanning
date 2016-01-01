using BudgetPlanner.Controller;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgetPlanner.Model
{
    class ExpenseDb
    {

        public static SqlConnection cnn = new SqlConnection(Constants.CONNECTION_STRING);


        public static bool addExpense(Expense expense)
        {
            try
            {
                String query2 = "Insert into expenses(uid,price,location,date,cid) values ('" + expense.UID + "'," + expense.Price + ",'" + expense.Location + "','" + expense.Date + "'," +expense.category.CID+ ")";

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
                MessageBox.Show(ex.StackTrace);
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
                    expense.UID = ds.GetString(3);
                    expense.Date = ds.GetDateTime(4);
                    

                }
                return null;
            }

            catch (Exception ex)
            {
                return null;


            }

        }

        public static DataTable getExpense(String date,String UID)
        {
          
           
            String query2 = "Select Price,Location,category.CName from expenses,category where UID= '" + UID+ "' and expenses.date=  '" + date+ "' and category.cid = expenses.cid";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();


            try
            {

                DataTable table = new DataTable();
                table.Columns.Add("Price", typeof(int));
                table.Columns.Add("Category", typeof(String));
                table.Columns.Add("Description", typeof(String));
           
                
                
              
                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                      table.Rows.Add(ds.GetInt32(0), ds.GetString(2), ds.GetString(1));
                       

                    }
                    cnn.Close();
                    return table;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

                cnn.Close();
                MessageBox.Show(ex.StackTrace);
            }

            return null; 

        }

        public static DataTable getALLExpense(String date, String UID)
        {


            String query2 = "Select Price,Location,category.CName from expenses,category where UID= '" + UID + "' and date like '" + date + "' and category.cid = expenses.cid";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();


            try
            {

                DataTable table = new DataTable();
                table.Columns.Add("Price", typeof(int));
                table.Columns.Add("Category", typeof(String));
                table.Columns.Add("Description", typeof(String));




                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        table.Rows.Add(ds.GetInt32(0), ds.GetString(2), ds.GetString(1));


                    }
                    cnn.Close();
                    return table;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

                cnn.Close();
                MessageBox.Show(ex.StackTrace);
            }

            return null;

        }


        public static DataTable getExpenseOfMonth(String date, String UID)
        {


            String query2 = "Select Price,Location,category.CName from expenses,category where UID= '" + UID + "' and Month(CONVERT(date,GETDATE())) =  '" + date + "' and category.cid = expenses.cid";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();


            try
            {

                DataTable table = new DataTable();
                table.Columns.Add("Price", typeof(int));
                table.Columns.Add("Category", typeof(String));
                table.Columns.Add("Description", typeof(String));




                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        table.Rows.Add(ds.GetInt32(0), ds.GetString(2), ds.GetString(1));


                    }
                    cnn.Close();
                    return table;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

                cnn.Close();
            }

            return null;

        }


        public static DataTable getExpenseOfYear(String date, String UID)
        {


            String query2 = "Select Price,Location,category.CName from expenses,category where UID= '" + UID + "' and year(CONVERT(date,GETDATE())) =  '" + date + "' and category.cid = expenses.cid";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();


            try
            {

                DataTable table = new DataTable();
                table.Columns.Add("Price", typeof(int));
                table.Columns.Add("Category", typeof(String));
                table.Columns.Add("Description", typeof(String));




                if (ds.HasRows)
                {
                    while (ds.Read())
                    {
                        table.Rows.Add(ds.GetInt32(0), ds.GetString(2), ds.GetString(1));


                    }
                    cnn.Close();
                    return table;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {

                cnn.Close();
            }

            return null;

        }
    }


    }

