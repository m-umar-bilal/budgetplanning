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
    class EarningDb
    {

        public static SqlConnection cnn = new SqlConnection(Constants.CONNECTION_STRING);


           public static bool addEarning(Earning earning)
             {
            try
            {
            String query2 = "Insert into earning(price,uid,date) values ( "+earning.Price+","+earning.UID+","+earning.Date+")";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            int a =cmd2.ExecuteNonQuery();
            cnn.Close();
            
           
                if (a>0)
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


           public static bool updateEarning(Earning earning)
           {
               try
               {
                   String query2 = "update earning set price = "+earning.Price + ", uid=" + earning.UID + ",date=" + earning.Date + " where erid = " + earning.ErID + "";
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

           public static bool deleteEarning(Earning earning)
           {
               try
               {
                   String query2 = "delete earning where erid = " + earning.ErID + "";
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

        public static Earning getSingleEarning(int erid)
         {
             Earning earning = new Earning();
             earning.ErID = erid;
             String query2 = "Select * from earning where erid = " + erid + "";
             SqlCommand cmd2 = new SqlCommand(query2, cnn);
             cnn.Open();
             SqlDataReader ds = cmd2.ExecuteReader();
             cnn.Close();
             bool a = false;
             try
             {
                 if (ds.Read())
                 {
                     earning.Price = ds.GetInt32(2);
                     earning.UID = ds.GetInt32(3);
                     earning.Date = ds.GetDateTime(4);

                 }
                 return null;
             }

             catch (Exception ex)
             {
                 return null;


             }

         }

        public static int getTotalEarning()
        {
            String query2 = "Select sum(Price) from earning";
            SqlCommand cmd2 = new SqlCommand(query2, cnn);
            cnn.Open();
            SqlDataReader ds = cmd2.ExecuteReader();
            cnn.Close();
           
            try
            {
                if (ds.Read())
                {
                    return ds.GetInt32(1);

                }
                return 0;
            }

            catch (Exception ex)
            {
                return 0;


            }
        }

        public static DataSet getEarning(String date)
        {
            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT * from earning where date like '"+date+"' ", cnn);
            DataSet ds = new DataSet();
            Adapter.Fill(ds);
            return ds;
        }
    }
}
