using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MyExcel = Microsoft.Office.Interop.Excel;
using System.Reflection;

#region History
/*
 * 17-Dec-2011 --- Created By Osama
 */
#endregion

namespace BudgetPlanner.View
{
    public partial class frmExportData : Form
    {
        public frmExportData()
        {
            InitializeComponent();
        }

        private String _fileName = string.Empty;

        private void frmExportData_Load(object sender, EventArgs e)
        {
            try
            {
                Controller.Utilities.SetToolTipText(btnBrowseFiles, "Browse");
                grpCategory.IsOpen = false;
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetSelectedFormat()
        {
            if (rdbCSVFormat.Checked)
                return 1;
            else if (rdbExcelFile.Checked)
                return 2;

            return -1;
        }

        public void OK()
        {
            if (String.IsNullOrEmpty(txtPath.Text))
            {
                Controller.Messager.ShowMessage("You Must Choose File To Export Data In It.", MessageBoxIcon.Information);
                return;
            }

            int exportFormat = GetSelectedFormat();

            if (exportFormat != -1)
            {
                if (!String.IsNullOrEmpty(this._fileName))
                {
                    string extension = Path.GetExtension(this._fileName);

                    if (extension.ToUpper().Equals(".xls".ToUpper()))
                    {
                        ExportDataToExcelFile(this._fileName);
                    }
                    else if (extension.ToUpper().Equals(".txt".ToUpper()))
                    {
                        ExportDataToTextFile(this._fileName);
                    }
                }
            }
            else
            {
                Controller.Messager.ShowMessage("You must pick format.", MessageBoxIcon.Information);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                OK();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        /// <summary>
        /// Browse a file to export batch (each student) information in it
        /// </summary>
        public void BrowseFiles()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.Filter = "Text File (*.txt)|*.txt|Excel Sheet File(*.xls)|*.xls";
            fileDialog.Title = "Select A File To Export Information In It";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtPath.Text = fileDialog.FileName;
                this._fileName = txtPath.Text;
            }
            else
            {
                return;
            }
        }

        private void btnBrowseFiles_Click(object sender, EventArgs e)
        {
            try
            {
                BrowseFiles();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Controller.Constants.Category = "HOME";
            btnHome.Enabled = false;
            btnPersonal.Enabled = true;
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            Controller.Constants.Category = "PERSONAL";
            btnPersonal.Enabled = false;
            btnHome.Enabled = true;
        }

        /// <summary>
        /// For exporting batch data to Excel file.
        /// </summary>
        /// <param name="fileName"></param>       
        public void ExportDataToExcelFile(string fileName)
        {
            DataTable dt = null;

            MyExcel.Application excelApp;
            MyExcel.Workbook excelWorkBook;
            MyExcel.Worksheet excelWorkSheet;
            MyExcel.Range excelRange;

            // Start Excel and get Application object. 
            excelApp = new MyExcel.Application();

            // Set some properties 
            excelApp.Visible = true;
            excelApp.DisplayAlerts = false;

            // Get a new workbook. 
            excelWorkBook = excelApp.Workbooks.Add(Missing.Value);

            // Get the active sheet 
            excelWorkSheet = (MyExcel.Worksheet)excelWorkBook.ActiveSheet;
            excelWorkSheet.Name = "Personal Budget Details";

            if (Controller.Constants.Category.Equals("PERSONAL"))
                dt = Controller.BudgetController.GetPersonalBudget(Controller.Constants.USER_LOGIN_ID);
            else if (Controller.Constants.Category.Equals("HOME"))
                dt = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);

            if (dt.Rows.Count > 0)
            {
                int rowCount = 1;

                foreach (DataRow dr in dt.Rows)
                {
                    rowCount++;

                    for (int i = 1; i <= dt.Columns.Count; i++)
                    {
                        // add column names
                        if (rowCount == 2)
                        {
                            excelWorkSheet.Cells[1, i] = dt.Columns[i - 1].ColumnName;
                            MyExcel.Range oRng = excelWorkSheet.get_Range("A1", "BZ1");
                            oRng.Interior.Color = System.Drawing.ColorTranslator.ToOle(Color.LightSkyBlue);
                        }

                        excelWorkSheet.Cells[rowCount, i] = dr[i - 1].ToString();
                    }
                }

                // Resize the columns 
                excelRange = excelWorkSheet.get_Range(excelWorkSheet.Cells[1, 1], excelWorkSheet.Cells[rowCount, dt.Columns.Count]);
                excelRange.EntireColumn.AutoFit();

                // Save the sheet and close 
                excelWorkSheet = null;
                excelRange = null;

                excelWorkBook.SaveAs(fileName, MyExcel.XlFileFormat.xlWorkbookNormal,
                                     Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                                     MyExcel.XlSaveAsAccessMode.xlExclusive,
                                     Missing.Value, Missing.Value, Missing.Value,
                                     Missing.Value, Missing.Value);

                // excelWorkBook.Close(Missing.Value, Missing.Value, Missing.Value);

                excelWorkBook = null;
                //excelApp.Quit();

                // Clean up                 
                GC.WaitForPendingFinalizers();
                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();

                //Process.Start(fileName);
            }
        }

        public void ExportDataToTextFile(string fileName)
        {
            string textToWrite = string.Empty;
            string delimeter = ",";
            DataTable dt = null;

            if (Controller.Constants.Category.Equals("PERSONAL"))
                dt = Controller.BudgetController.GetPersonalBudget(Controller.Constants.USER_LOGIN_ID);
            else if (Controller.Constants.Category.Equals("HOME"))
                dt = Controller.BudgetController.GetHomeBudget(Controller.Constants.USER_LOGIN_ID);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++)
                {
                    if (j == dt.Columns.Count - 1)
                        continue;

                    textToWrite += dt.Rows[i][j] + delimeter;
                }

                Controller.Constants.RemoveSuffix(textToWrite, delimeter);

                if (!Controller.Utilities.IsFileExists(fileName))
                {
                    Controller.Utilities.WriteTextToFile(textToWrite, fileName);
                }
                else
                {
                    Controller.Utilities.AppendTextToFile(textToWrite, fileName);
                }

                textToWrite = string.Empty;
            }
        }
    }
}
