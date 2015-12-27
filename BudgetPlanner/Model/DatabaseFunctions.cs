using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Reflection;
using System.Data.SqlClient;

#region History
/*
 * 30-Nov-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.Model
{
    
    /// <summary>
    /// A class which provides all the functionality related to databases, creating connection with DB
    /// executing queries, getting information in dataTables or dataReader etc.
    /// </summary>

    public class DatabaseFunctions
    {
        private static BudgetPlannerDBDataContext _dataContext;
        private static SqlConnection _sqlConnection = new SqlConnection();

        public static BudgetPlannerDBDataContext DataContext
        {
            get
            {
                if (_dataContext == null)
                {
                    _dataContext = new BudgetPlannerDBDataContext(Controller.Constants.CONNECTION_STRING);
                }

                return _dataContext;
            }
            set
            {
                _dataContext = value;
            }
        }
        
        public static Boolean CheckConnection()
        {
            if (_sqlConnection != null || _sqlConnection.State == ConnectionState.Open)
                _sqlConnection.Close();

            _sqlConnection = new SqlConnection();          
            _sqlConnection.ConnectionString = Controller.Constants.CONNECTION_STRING;
            _sqlConnection.Open();

            return true;
        }

        public static SqlDataReader GetDataReader(string query)
        {
            SqlDataReader dr = null;
            CheckConnection();
            SqlCommand cmd = new SqlCommand(query, _sqlConnection);

            dr = cmd.ExecuteReader();

            if (dr != null && dr.HasRows)
                return dr;

            return null;
        }

        public static DataTable GetDataTable(string query)
        {
            CheckConnection();
            SqlCommand cmd = new SqlCommand(query, _sqlConnection);
            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(table);

            return table;
        }

        public static void ExecuteQuery(string query)
        {
            CheckConnection();
            SqlCommand cmd = new SqlCommand(query, _sqlConnection);
            cmd.ExecuteNonQuery();
        }

        /// <summary>
        /// Tranforming a LINQ query to a DataTable
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="varlist"></param>
        /// <returns>datatable of information</returns>
        public static DataTable LINQToDataTable<T>(IEnumerable<T> varlist)
        {
            DataTable dtReturn = new DataTable();

            // column names 
            PropertyInfo[] propInfo = null;

            if (varlist == null) return dtReturn;

            foreach (T rec in varlist)
            {
                // Use reflection to get property names, to create table, Only first time, others 
                // will follow 

                if (propInfo == null)
                {
                    propInfo = ((Type)rec.GetType()).GetProperties();

                    foreach (PropertyInfo pi in propInfo)
                    {
                        Type colType = pi.PropertyType;

                        if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                            colType = colType.GetGenericArguments()[0];

                        dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                    }
                }

                DataRow dataRow = dtReturn.NewRow();

                foreach (PropertyInfo pi in propInfo)
                    dataRow[pi.Name] = pi.GetValue(rec, null) == null ? DBNull.Value : pi.GetValue(rec, null);

                dtReturn.Rows.Add(dataRow);
            }

            return dtReturn;
        }
    }
}
