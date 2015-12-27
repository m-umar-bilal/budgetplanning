using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Threading;
using System.ComponentModel;
using System.Data;

#region History
/*
 * 17-Dec-2011 --- Fade form functionality added
 * 30-Nov-2011 --- Created By Osama
 */
#endregion

namespace BudgetPlanner.Controller
{
    public enum FormFadeAction
    {
        Start, Close
    }

    public class Utilities
    {    
        public static void FadeForm(Form thisForm, FormFadeAction action)
        {
            if (action == FormFadeAction.Start)
            {
                for (double fade = 0.0; fade <= 2.1; fade++)
                {
                    thisForm.Opacity = fade;
                    thisForm.Refresh();
                    Thread.Sleep(50);                    
                }
            }
            else
            {
                for (double fade = 2.1; fade >= 0.0; fade--)
                {
                    thisForm.Opacity = fade;
                    thisForm.Refresh();
                    Thread.Sleep(50);
                }
            }
        }

        public static void SetToolTipText(Control controlName, string toolTipText)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(controlName, toolTipText);
        }

        public static void StartUIThread(Form formObject)
        {
            Application.Run(formObject);

           
            //new Thread(() => new frmCreateUser(true, this._userAccntObject).ShowDialog()).Start();
        }

        public void StartFormInThread(Form thisForm)
        {
            ThreadStart threadStart = delegate { StartUIThread(thisForm); };
            Thread thread = new Thread(threadStart);            
            thread.Start();
        }

        /// <summary>
        /// Converting a string value to bool
        /// </summary>
        /// <param name="value"></param>
        /// <returns>converted value to bool</returns>
        public static Boolean ToBoolean(String value)
        {
            return bool.Parse(value);
        }
              
        /// <summary>
        /// Converting a string value to integer
        /// </summary>
        /// <param name="value"></param>
        /// <returns>converted value to integer</returns>
        public static int ToInteger(String value)
        {
            return int.Parse(value);
        }

        /// <summary>
        /// Writing a text to specified file
        /// </summary>
        /// <param name="textToWrite"></param>
        /// <param name="file"></param>
        public static void WriteTextToFile(String textToWrite, String file)
        {
            TextWriter tw = File.CreateText(file);
            tw.WriteLine(textToWrite);
            tw.Flush();

            tw.Close();
        }

        /// <summary>
        /// Appending text to file
        /// </summary>
        /// <param name="text"></param>
        /// <param name="file"></param>
        public static void AppendTextToFile(String text, String file)
        {
            if (File.Exists(file))
                File.AppendAllText(file, text);
        }

        /// <summary>
        /// Deleting a file from a folder by specifying filename that is to be deleted
        /// </summary>
        /// <param name="fileName"></param>
        public static void DeleteFile(String fileName)
        {
            if (File.Exists(fileName))
                File.Delete(fileName);
        }

        /// <summary>
        /// Creating directory of your mentioned name
        /// </summary>
        /// <param name="name"></param>
        public static void CreateDirectory(String name)
        {
            if (Directory.Exists(name))
                Directory.Delete(name);

            Directory.CreateDirectory(name);
        }

        /// <summary>
        /// Deleting a directory, if value = true means delete all the files also that folder contains in it
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void DeleteDirectory(String name, bool value)
        {
            if (Directory.Exists(name))
                Directory.Delete(name, value); // if value is true it means all containing files will be deleted as well
        }

        /// <summary>
        /// Checking if at mentioned path directory exists or not
        /// </summary>
        /// <param name="path"></param>
        /// <returns>true if exists, else false</returns>
        public static Boolean IsDirectoryExists(String path)
        {
            if (Directory.Exists(path))
                return true;

            return false;
        }

        /// <summary>
        /// Checking if at mentioned path file exists or not
        /// </summary>
        /// <param name="path"></param>
        /// <returns>true if exists, else false</returns>
        public static Boolean IsFileExists(String path)
        {
            if (File.Exists(path))
                return true;

            return false;
        }

        public static List<Month> GetAllMonthNames()
        {
            List<Month> lstOfMonths = new List<Month>();

            for (int i = 1; i <= 12; i++)            
                lstOfMonths.Add(new Month(i, DateTimeFormatInfo.CurrentInfo.GetMonthName(i)));
                        
            return lstOfMonths;
        }

        public static DateTime ToDateTime(int year, int month, int day)
        {
            return new DateTime(year, month, day);
        }

        public static int ValidateFields(string field)
        {
            if (String.IsNullOrEmpty(field))
                return 0;

            return (!String.IsNullOrEmpty(field) || ToInteger(field) > 0) ? ToInteger(field) : 0;
        }

        public DataTable ToDataTable(object classObject)
        {
            PropertyDescriptorCollection propCollection = TypeDescriptor.GetProperties(classObject.GetType());
            DataTable table = new DataTable();

            foreach (PropertyDescriptor prop in propCollection)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            return table;
        }
    }
}
