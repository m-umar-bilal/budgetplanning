using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

#region History
/*
 * 30-Nov-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.Controller
{
    public static class Constants
    {
        public static String APPLICATION_NAME = "Budgi Desk";
        public static String DATABASE_NAME = "BudgiDeskDB";
        public static String CONNECTION_STRING = @"Data Source=MAQSOOD-PC;Initial Catalog=" + DATABASE_NAME + ";Integrated Security=true";
        public static String INPUT_VALUE = string.Empty;
        public static String WELCOME_NAME = string.Empty;
        public static Boolean GENDER_FLAG = false;

        public static Boolean IS_ADMIN = false;
        public static Boolean FLAG = false;
        public static String FILE_NAME = Environment.SpecialFolder.DesktopDirectory + "BudgiDeskData.xml";
        public static String USER_LOGIN_ID = string.Empty;
        public static String TOTAL_AMOUNT = string.Empty;

        public static String Category = string.Empty;

        /// <summary>
        /// Extension method for removing characters from the end of string.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="suffix"></param>
        /// <returns>string that is excluded from last character of mentioned suffix</returns>
        public static String RemoveSuffix(this string value, string suffix)
        {
            if (value.EndsWith(suffix))
                return value.Substring(0, value.Length - suffix.Length);

            return value;
        }
    }
}
