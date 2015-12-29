using BudgetPlanner.Controller;
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
    class CategoryDb
    {
        public static SqlConnection cnn = new SqlConnection(Constants.CONNECTION_STRING);
       

        public static bool addCategory(Category c)
        {
            String query2 = "Select * from category where cname = '" + c.Name + "'";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
            
            bool a = false;
            try
            {
                if (!(ds.HasRows))
                {
                    cnn.Close();
                  
                    String query = "INSERT INTO Category (CName) VALUES('" + c.Name + "')";
                    SqlCommand cmd = new SqlCommand(query, cnn);

                    cnn.Open();
                    int x = cmd.ExecuteNonQuery();
                    cnn.Close();
                    
                }
                else
                {
                    MessageBox.Show("Category Already Exist");
                    cnn.Close();
                }
            }

            catch (Exception ex)
            {
               
               
            }


            return false; ;

            
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
           
        
            try
            {
                if (ds.Read())
                {
                    cat.CID = ds.GetInt32(1);
                    cat.Name = ds.GetString(2);
                    
                }
                cnn.Close();
                return cat;
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

        public static List<Category> getCategoriesInList()
        {
     
            List<Category> list= new List<Category>();
           String query2 = "Select * from category";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
           
      
            try
            {
              
                if(ds.HasRows)
                {
                    while(ds.Read())
                    {
                    Category cat = new Category();
                    cat.CID = ds.GetInt32(0);
                    cat.Name = ds.GetString(1);
                    list.Add(cat);
                   
                    }
                    cnn.Close();
                    return list;
                }

                cnn.Close();
            }

            catch (Exception ex)
            {
           

            }
                
                return null; ;

        }


       }
    }


   

