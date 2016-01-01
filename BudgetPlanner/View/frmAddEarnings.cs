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
    public partial class frmAddEarnings : Form
    {
        Label label;
        public frmAddEarnings()
        {
            InitializeComponent();
        }
        public frmAddEarnings(ref Label label):this()
        {
            this.label = label;
        }
        private void btnEditAmount_Click(object sender, EventArgs e)
        {
            string theDate = dtPicker.Value.ToString("yyyy-MM-dd");
            try
            {
                Earning ear = new Earning();
                ear.Price = Convert.ToInt32(txtPrice.Text);
                ear.Date = Convert.ToDateTime(theDate);
                ear.UID = Constants.USER_LOGIN_ID;
                Controller.AmountController _amountObject = null;
                if (EarningDb.addEarning(ear))
                {
                    _amountObject = Controller.AmountController.LoadUserTotalAmount(ear.UID);
                    Controller.Constants.TOTAL_AMOUNT = _amountObject.HomeAmount.ToString();
                    int totalHomeAmount = (Controller.Utilities.ToInteger(Controller.Constants.TOTAL_AMOUNT));
                    int homeAmount = Convert.ToInt32(txtPrice.Text);
                    int tempAmount = 0;
                   
                   

                       
                            MessageBox.Show("Previous Amount Was : " + totalHomeAmount);
                            tempAmount = (totalHomeAmount + homeAmount);
                            MessageBox.Show("New Amount Is : " + tempAmount);
                        

                    
                    Controller.AmountController.UpdateAmount(Controller.Constants.USER_LOGIN_ID, tempAmount);
                    //   MessageBox.Show("Expense Added Successfully");
                    label.Text = "" + tempAmount;
                }
                else
                {
                    MessageBox.Show("Earning Not Added");
                }

            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }


        }
    }
}
