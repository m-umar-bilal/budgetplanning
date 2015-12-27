using BudgiDesk.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace BudgiDesk.BLL
{
    partial class Category
    {


        public Category()
        {
           // Category = new HashSet<Category>();
        }
        public int CID { get; set; }
        public String Name { get; set; }

        public static bool addCategory(Category c)
        { 
        return CategoryDb.addCategory(c);
        }
        public static bool deleteCategory(Category c)
        {
            return CategoryDb.deleteCategory(c);
        }
        public static Category getCategory(int cid)
        {
            return CategoryDb.getCategory(cid);
        }
        public static DataSet getAllCategories()
        {
            
            return CategoryDb.getAllCategories();
        }
    }
}
