using BudgetPlanner.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BudgetPlanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool IsAdminLogin()
        {
            if (txtUserName.Text.Equals("123") && txtPassword.Text.Equals("123"))
            {
                Controller.Constants.IS_ADMIN = true;
                return true;
            }

            return false;
        }

        public bool IsLoginSuccessfull()
        {
            Controller.UserAccountController obj = Controller.UserAccountController.LoginUser(txtUserName.Text, txtPassword.Text);

            if (obj == null)
            {
                Controller.Messager.ShowMessage("Invalid login details.", MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void OK()
        {
            if (IsAdminLogin())
            {
                this.Hide();

                Form frmMn = new frmMain();
                Controller.Constants.WELCOME_NAME = "Admin";
                DialogResult dr = frmMn.ShowDialog();

                if (dr == DialogResult.Cancel)
                    this.Show();
            }
            else
            {
                if (IsLoginSuccessfull())
                {
                    Controller.Messager.ShowMessage("Login Successfully.", MessageBoxIcon.Information);

                    Controller.UserAccountController obj = Controller.UserAccountController.GetUserNameByLoginDetails(txtUserName.Text, txtPassword.Text);

                    if (obj != null)
                    {
                        this.Hide();

                        Form frmMn = new frmMain(obj);
                        frmMn.ShowDialog();
                    }
                }
            }
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.SignIn_Hover));
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.loginBtn));
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeHover));
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.closeButton));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtUserName.Visible = true;
            button4.Enabled = false;
            button4.Visible = false;
            txtUserName.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtPassword.Visible = true;
            button5.Enabled = false;
            button5.Visible = false;
            txtPassword.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form frmForgUser = new frmForgotUserDetail();
            DialogResult dr = frmForgUser.ShowDialog();

            if (dr == DialogResult.Cancel)
                this.Show();
        }
        public void CreateUser()
        {
            this.Hide();

            //   Form frmPromptInput = new frmInput("Enter Password", "Enter Admin Password:", true);
            //  DialogResult dr = frmPromptInput.ShowDialog();

            this.Hide();

            Form frmCrtUser = new frmCreateUser();
            frmCrtUser.ShowDialog();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                CreateUser();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }
    }
}
