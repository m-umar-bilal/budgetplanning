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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private Form _formSplash = null;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            try
            {
                //_formSplash = new frmSplash();
                //_formSplash.Show();
                //_formSplash.Update();               

                //this.Visible = true;     

                Controller.Utilities.FadeForm(this.FindForm(), Controller.FormFadeAction.Start);
            }
            catch (Exception ex)
            {
                //  Controller.Messager.ShowException(ex);
            }
            finally
            {
                if (_formSplash != null)
                    _formSplash.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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
                //    Controller.Messager.ShowMessage("Invalid login details.", MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public void OK()
        {
            if (IsAdminLogin())
            {
                this.Hide();

                // Form frmMn = new frmMain();
                Controller.Constants.WELCOME_NAME = "Admin";
                //  DialogResult dr = frmMn.ShowDialog();

                // if (dr == DialogResult.Cancel)
                //   this.Show();
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

                        //  Form frmMn = new frmMain(obj);
                        //   frmMn.ShowDialog();
                    }
                }
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

        public void CreateUser()
        {
            this.Hide();

            // Form frmPromptInput = new frmInput("Enter Password", "Enter Admin Password:", true);
            //  DialogResult dr = frmPromptInput.ShowDialog();

            //   if (dr == DialogResult.Cancel || dr == DialogResult.OK)
            // this.Show();
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
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

        private void lnklblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            //Form frmForgUser = new frmForgotUserDetail();
            // DialogResult dr = frmForgUser.ShowDialog();

            //  if (dr == DialogResult.Cancel)
            this.Show();
        }

        private void lnklblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();

            // Form frmNewUser = new frmCreateUser(true); // true to hide some fields on frmCreateUser.cs
            // DialogResult dr = frmNewUser.ShowDialog();

            //  if (dr == DialogResult.OK)
            this.Show();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(sender, e);
            }
        }

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnOk_Click(sender, e);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Utilities.FadeForm(this.FindForm(), Controller.FormFadeAction.Close);
        }
    }
}
