using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

#region History
/*
 * 06-Dec-2011 --- Created By Osama
 */
#endregion 

namespace BudgetPlanner.View
{
    public partial class frmCalculator : Form
    {
        public frmCalculator()
        {
            InitializeComponent();
        }

        int addBit = 0, subBit = 0, mulBit = 0, divBit = 0;
        Double num = 0.0, num1 = 0.0, result = 0.0;
        String str;

        public void ResetBits()
        {
            addBit = 0;
            subBit = 0;
            mulBit = 0;
            divBit = 0;
        }

        public void ClearResult()
        {
            num = 0.0;
            num1 = 0.0;
            result = 0.0;
            txtAnswer.Text = string.Empty;
            ResetBits();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "1";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "2";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "3";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "4";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "5";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "6";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "7";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "8";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "9";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtAnswer.Text.Contains("."))
                {
                    txtAnswer.Text = txtAnswer.Text + ".";
                    str = txtAnswer.Text;
                    num = Double.Parse(str);
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            try
            {
                txtAnswer.Text = txtAnswer.Text + "0";
                str = txtAnswer.Text;
                num = Double.Parse(str);
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                if (addBit == 1)
                    result = num1 + num;
                if (subBit == 1)
                    result = num1 - num;
                if (mulBit == 1)
                    result = num1 * num;
                if (divBit == 1)
                    result = num1 / num;

                txtAnswer.Text = result.ToString();
                ResetBits();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                addBit = 1;
                str = txtAnswer.Text;
                num1 = Double.Parse(str);
                txtAnswer.Text = "";
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            try
            {
                subBit = 1;
                str = txtAnswer.Text;
                num1 = Double.Parse(str);
                txtAnswer.Text = "";
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            try
            {
                mulBit = 1;
                str = txtAnswer.Text;
                num1 = Double.Parse(str);
                txtAnswer.Text = "";
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            try
            {
                divBit = 1;
                str = txtAnswer.Text;
                num1 = Double.Parse(str);
                txtAnswer.Text = "";
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }
    }
}
