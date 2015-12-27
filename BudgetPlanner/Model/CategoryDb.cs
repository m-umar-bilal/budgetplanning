using BudgetPlanner.Controller;
using BudgiDesk.BLL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BudgiDesk.DAL
{
    class CategoryDb
    {
        public static SqlConnection cnn = new SqlConnection(Constants.CONNECTION_STRING);
       

        public static bool addCategory(Category c)
        {
            String query2 = "Select * from category where cname = '" + c.Name + "'";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
            cnn.Close();
            bool a = false;
            try
            {
                if (ds.IsClosed)
                {
                    MessageBox.Show("Category Already Exist");
                }
            }

            catch (Exception ex)
            {
               
                String query = "INSERT INTO Category (CName) VALUES('" + c.Name + "')";
                SqlCommand cmd = new SqlCommand(query, cnn);

                cnn.Open();
                int x = cmd.ExecuteNonQuery();
                cnn.Close();
            }
               

                return true;

            
        }

        public static bool deleteCategory(Category c)
        {
            try
            {
              
            String query2 = "delete category where cname = '" + c.Name + "'";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            int a = cmd2.ExecuteNonQuery();
            cnn.Close();
            if(a>0)
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

        public static Category getCategory(int cid)
        {
            Category cat = new Category();
            String query2 = "Select * from category where cid = '" + cid + "'";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
            cnn.Close();
            bool a = false;
            try
            {
                if (ds.Read())
                {
                    cat.CID = ds.GetInt32(1);
                    cat.Name = ds.GetString(2);
                    
                }
                return null;
            }

            catch (Exception ex)
            {
                return null;

               
            }

        }

        public static DataSet getAllCategories()
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * from Category ", cnn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            return ds;
        }



       }
    }


   

