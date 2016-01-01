using BudgetPlanner.Controller;
using BudgetPlanner.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner.View
{
    public partial class frmAddExpenses : Form
    {
        Label label;
        public frmAddExpenses()
        {
            InitializeComponent();
        }
    
            public frmAddExpenses(ref Label label) : this()
        {
            this.label = label;
        }
        private void frmAddExpenses_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'budgiDeskDBDataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.budgiDeskDBDataSet1.Category);
            // TODO: This line of code loads data into the 'budgiDeskDBDataSet.Category' table. You can move, or remove it, as needed.
           // this.categoryTableAdapter.Fill(this.budgiDeskDBDataSet.Category);

        }


        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    
  

        private void btnSave_Click_2(object sender, EventArgs e)
        {
            string theDate = dateTimePicker2.Value.ToString("yyyy-MM-dd");
            try
            {
                Expense ex = new Expense();
                ex.Price = Convert.ToInt32(txtPrice.Text);
                ex.Date = Convert.ToDateTime(theDate);
                ex.Location = txtDetails.Text;
               
                DataRowView drv = (DataRowView)boxCat.SelectedItem;
                String valueOfItem = drv["CID"].ToString();
                ex.category = new Category();
                ex.category.CID = Convert.ToInt32(valueOfItem);
                ex.UID = Controller.Constants.USER_LOGIN_ID;
                Controller.AmountController _amountObject = null;
                if (ExpenseDb.addExpense(ex))
                {
                    _amountObject = Controller.AmountController.LoadUserTotalAmount(ex.UID);
                    Controller.Constants.TOTAL_AMOUNT =_amountObject.HomeAmount.ToString();
                    int totalHomeAmount = (Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT));
                    int homeAmount = Convert.ToInt32(txtPrice.Text);
                    int tempAmount = 0;
                    
                    if (totalHomeAmount != 0)
                    {

                        if (homeAmount > totalHomeAmount)
                        {
                            Controller.Messager.ShowMessage("Calculated Amount is more than actual balance, exiting without saving.", MessageBoxIcon.Information);
                            return;
                        }
                        else if (homeAmount >= 0 && homeAmount <= Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT))
                        {
                            MessageBox.Show("Previous Amount Was : " + totalHomeAmount);
                            tempAmount = (totalHomeAmount - homeAmount);
                            MessageBox.Show("New Amount Is : " + tempAmount);
                        }

                    }
                    Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, tempAmount);
                 //   MessageBox.Show("Expense Added Successfully");
                    label.Text = ""+tempAmount;
                }
                else
                {
                    MessageBox.Show("Expense Not Added");
                }

            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnCalc_Click_2(object sender, EventArgs e)
        {

            Form frmCalc = new frmCalculator();
            frmCalc.Show();
        }
    }
}
