using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace BudgetPlanner.View
{
    public partial class frmCreateUser : Form
    {
        public frmCreateUser()
        {
            InitializeComponent();

        }

        private Controller.UserAccountController _userAccntObject = null;
        private bool _flag = false;
        private bool _showFlag = false;

        /// <summary>
        /// This calls when user logged in and press Edit Info button, for that hide and enable some fields
        /// </summary>
        /// <param name="value"></param>
        /// <param name="userAccntObject"></param>
        public frmCreateUser(bool value, Controller.UserAccountController userAccntObject = null) // optional Parameter userAccntObject
            : this()
        {
            if (value) // means Register is clicked by user from Login Form, so hide datagrid, listbox and other fields.
            {
                HideFields();
            }

            if (value && userAccntObject != null)
            {
                HideFields();
                this._userAccntObject = userAccntObject;
                this._flag = true;
                this._showFlag = true;
                this.Text = "Update Details";
                Controller.Utilities.SetToolTipText(btnSave, "Update");
                Controller.Utilities.SetToolTipText(btnDone, "Done");
                btnClear.Enabled = false;
            }
        }

        /// <summary>
        /// Hiding fields
        /// </summary>
        public void HideFields()
        {
            dgvUsers.Visible = false;
            lstNames.Visible = false;
            txtSearch.Visible = false;
            lblUname.Visible = false;
            btnEdit.Enabled = false;
            btnDelete.Enabled = false;
            lblSearchByName.Visible = false;
            this.Size = new Size(740, 225);
        }

        /// <summary>
        /// Generates auto id whenever new user is created.
        /// </summary>
        /// <returns>generated ID</returns>
        public int GenerateAutoID()
        {
            int id = 0;

            List<Controller.UserAccountController> lstAllUsers = Controller.UserAccountController.GetAllUsers();

            if (lstAllUsers == null) return -1;

            // ID is generated like BD-001, so splitting at "-" to separate,
            // it like 001 and then plus one each time like 002, 003 etc.
            string splitted = lstAllUsers[lstAllUsers.Count - 1].ID.ToString().Split(new Char[] { '-' })[1];
            id = Controller.Utilities.ToInteger(splitted);

            return ++id;
        }

        /// <summary>
        /// Show generated auto id in text box.
        /// </summary>
        public void ShowAudoIDInTextbox()
        {
            string showAutoID = string.Empty;

            // BD stands for Budgi Desk

            if (GenerateAutoID() == -1)
                txtAutoID.Text = "BD-001";

            if (GenerateAutoID() < 10)
                showAutoID = "BD-00" + GenerateAutoID().ToString(); // here making BD-1 to BD-001 upto BD-009
            else if (GenerateAutoID() <= 99)
                showAutoID = "BD-0" + GenerateAutoID().ToString(); // here making BD-10 to BD-010 upto BD-099
            else
                showAutoID = "BD-" + GenerateAutoID().ToString(); // else BD-100 to upto wherever

            txtAutoID.Text = showAutoID;
        }

        /// <summary>
        /// Setting tool tips to buttons.
        /// </summary>
        public void SettingToolTips()
        {
            Controller.Utilities.SetToolTipText(btnSave, "Save");
            Controller.Utilities.SetToolTipText(btnClear, "Clear");
            Controller.Utilities.SetToolTipText(btnEdit, "Edit");
            Controller.Utilities.SetToolTipText(btnDelete, "Delete");
            Controller.Utilities.SetToolTipText(btnDone, "Done");
        }

        /// <summary>
        /// Getting whether male or female selected.
        /// </summary>
        /// <returns></returns>
        public bool GetSelectedRadioButton()
        {
            if (rdbMale.Checked)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Setting auto suggest facility to search by name text field for easy user searching facility.
        /// </summary>
        public void SetAutoCompleteToTextSearch()
        {
            List<Controller.UserAccountController> lstAllUsers = Controller.UserAccountController.GetAllUsers();

            if (lstAllUsers == null) return;

            AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();

            foreach (var item in lstAllUsers)
                autoCompleteCollection.Add(item.Name);

            txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txtSearch.AutoCompleteCustomSource = autoCompleteCollection;
            txtSearch.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        /// <summary>
        /// Fill list box with all names of users.
        /// </summary>
        public void FillListbox()
        {
            if (lstNames.DataSource == null)
                lstNames.Items.Clear();

            List<Controller.UserAccountController> lstAllUsers = Controller.UserAccountController.GetAllUsers();

            if (lstAllUsers == null) return;

            lstNames.DataSource = new BindingSource(lstAllUsers, null);

            lstNames.DisplayMember = "Name";
            lstNames.ValueMember = "ID";

            lstNames.ClearSelected();
        }

        /// <summary>
        /// Fill data grid view with all info of users.
        /// </summary>
        public void FillDataGridView()
        {
            dgvUsers.Rows.Clear();

            List<Controller.UserAccountController> lstAllUsers = Controller.UserAccountController.GetAllUsers();

            if (lstAllUsers == null)
            {
                Controller.Messager.ShowMessage("No user data is available to load.", MessageBoxIcon.Information);
                return;
            }

            foreach (var obj in lstAllUsers)
            {
                int dgRow = dgvUsers.Rows.Add();

                dgvUsers.Rows[dgRow].Cells["colID"].Value = obj.ID;
                dgvUsers.Rows[dgRow].Cells["colName"].Value = obj.Name;
                dgvUsers.Rows[dgRow].Cells["colPhoneNumber"].Value = obj.PhoneNumber;
                dgvUsers.Rows[dgRow].Cells["colAge"].Value = obj.Age;

                if (obj.Gender)
                {
                    dgvUsers.Rows[dgRow].Cells["colGender"].Value = "Male";
                }
                else
                {
                    dgvUsers.Rows[dgRow].Cells["colGender"].Value = "Female";
                }

                dgvUsers.Rows[dgRow].Cells["colUserName"].Value = obj.UserName;
                dgvUsers.Rows[dgRow].Cells["colPassword"].Value = obj.Password;
            }

            dgvUsers.ClearSelection();
        }

        /// <summary>
        /// Calls whenever add, update, delete actions on form
        /// </summary>
        public void ReloadForm()
        {
            SettingToolTips();
            FillDataGridView();
            ShowAudoIDInTextbox();
            ClearFormFields();
            FillListbox();
            SetAutoCompleteToTextSearch();
        }

        public void EnableDisableFields(bool value)
        {
            if (value)
            {
                dgvUsers.Enabled = false;
                btnClear.Enabled = false;
                btnDelete.Enabled = false;
            }
            else
            {
                dgvUsers.Enabled = true;
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        /// <summary>
        /// For if user doesnot enter in username and password then dont let its information add.
        /// </summary>
        /// <returns>true if success else false</returns>
        public bool ColorRequiredLabels()
        {
            // if both User Name and Password left empty then color both and dont save user details.
            if (String.IsNullOrEmpty(txtUserName.Text) && String.IsNullOrEmpty(txtPassword.Text))
            {
                lblUserName.ForeColor = System.Drawing.Color.Red;
                lblUserName.Text = " * User Name";
                Controller.Utilities.SetToolTipText(lblUserName, "User Name is required");

                lblPassword.ForeColor = System.Drawing.Color.Red;
                lblPassword.Text = " * Password";
                Controller.Utilities.SetToolTipText(lblPassword, "Password is required");

                return false;
            }
            else
            {
                lblUserName.ForeColor = System.Drawing.Color.Black;
                lblUserName.Text = "User Name";

                lblPassword.ForeColor = System.Drawing.Color.Black;
                lblPassword.Text = "Password";
            }

            // if User Name left empty
            if (String.IsNullOrEmpty(txtUserName.Text))
            {
                lblUserName.ForeColor = System.Drawing.Color.Red;
                lblUserName.Text = " * User Name";
                Controller.Utilities.SetToolTipText(lblUserName, "User Name is required");
                return false;
            }
            else
            {
                lblUserName.ForeColor = System.Drawing.Color.Black;
                lblUserName.Text = "User Name";
            }

            // if Password left empty
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                lblPassword.ForeColor = System.Drawing.Color.Red;
                lblPassword.Text = " * Password";
                Controller.Utilities.SetToolTipText(lblPassword, "Password is required");
                return false;
            }
            else
            {
                lblPassword.ForeColor = System.Drawing.Color.Black;
                lblPassword.Text = "Password";
            }

            return true;
        }

        /// <summary>
        /// Getting data from text fields to object for later save, load etc.
        /// </summary>
        /// <returns> newUserAccnt object</returns>
        public Controller.UserAccountController GetDataFromFields()
        {
            Controller.UserAccountController newUserAccnt = new Controller.UserAccountController();

            newUserAccnt.ID = txtAutoID.Text;
            newUserAccnt.Name = txtName.Text;
            newUserAccnt.PhoneNumber = txtPhoneNumber.Text;

            if (!String.IsNullOrEmpty(txtAge.Text))
                newUserAccnt.Age = Controller.Utilities.ToInteger(txtAge.Text);
            else
                newUserAccnt.Age = 0;

            newUserAccnt.Gender = GetSelectedRadioButton();
            newUserAccnt.UserName = txtUserName.Text;
            newUserAccnt.Password = txtPassword.Text;

            return newUserAccnt;
        }

        private void frmCreateUser_Load(object sender, EventArgs e)
        {
            dgvUsers.Visible = false;
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            try
            {
                if (!this._flag)
                    ReloadForm();
                else
                {
                    txtAutoID.Text = this._userAccntObject.ID;
                    txtName.Text = this._userAccntObject.Name;
                    txtPhoneNumber.Text = this._userAccntObject.PhoneNumber;
                    txtAge.Text = this._userAccntObject.Age.ToString();

                    if (this._userAccntObject.Gender)
                        rdbMale.Checked = true;
                    else
                        rdbFemale.Checked = true;

                    txtUserName.Text = this._userAccntObject.UserName;
                    txtPassword.Text = this._userAccntObject.Password;
                }
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        /// <summary>
        /// For loading selected row from data grid to its respective fields for updating.
        /// </summary>
        public void Edit()
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                Controller.Messager.ShowMessage("You must select row from data grid to load its fields for editing.", MessageBoxIcon.Information);
                return;
            }
            _flag = true;

            txtAutoID.Text = dgvUsers.SelectedRows[0].Cells["colID"].Value.ToString();
            txtName.Text = dgvUsers.SelectedRows[0].Cells["colName"].Value.ToString();
            txtPhoneNumber.Text = dgvUsers.SelectedRows[0].Cells["colPhoneNumber"].Value.ToString();
            txtAge.Text = dgvUsers.SelectedRows[0].Cells["colAge"].Value.ToString();

            if (dgvUsers.SelectedRows[0].Cells["colGender"].Value.ToString().ToUpper().Equals("Male".ToUpper()))
                rdbMale.Checked = true;
            else
                rdbFemale.Checked = true;

            txtUserName.Text = dgvUsers.SelectedRows[0].Cells["colUserName"].Value.ToString();
            txtPassword.Text = dgvUsers.SelectedRows[0].Cells["colPassword"].Value.ToString();

            EnableDisableFields(true);
            Controller.Utilities.SetToolTipText(btnSave, "Update");
        }

        /// <summary>
        /// Save user information to Database.
        /// </summary>
        public void Save()
        {
            if (ColorRequiredLabels())
            {
                if (!this._flag)
                {
                    Controller.UserAccountController.SaveAccount(GetDataFromFields());
                    Controller.Messager.ShowMessage("Account Saved Successfully.", MessageBoxIcon.Information);
                }
                else
                {
                    Controller.UserAccountController.UpdateAccount(GetDataFromFields());
                    Controller.Messager.ShowMessage("Account Updated Successfully.", MessageBoxIcon.Information);

                    if (this._showFlag)
                    {
                        this.Close();
                        return;
                    }

                    EnableDisableFields(false);
                    this._flag = false;
                }
            }
            else
            {
                Controller.Messager.ShowMessage("You must fill in fields that are color red.", MessageBoxIcon.Information);
                return;
            }

            ReloadForm();
        }

        public void ClearFormFields()
        {
            txtName.Clear();
            txtPhoneNumber.Clear();
            txtAge.Clear();
            txtUserName.Clear();
            txtPassword.Clear();
            txtSearch.Clear();
            lstNames.ClearSelected();
            dgvUsers.ClearSelection();
            rdbMale.Checked = false;
            rdbFemale.Checked = false;
        }

        /// <summary>
        /// Delete selected row from data grid and also from Database.
        /// </summary>
        public void Delete()
        {
            string selectedUserID = dgvUsers.SelectedRows[0].Cells["colID"].Value.ToString();

            Controller.UserAccountController.DeleteAccount(selectedUserID);
            Controller.Messager.ShowMessage("Account Deleted Successfully.", MessageBoxIcon.Information);
            ReloadForm();
        }

        /// <summary>
        /// If user clicks on user names list box then higlight its data in data grid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstNames_Click(object sender, EventArgs e)
        {
            if (lstNames.SelectedIndex == -1) return;

            dgvUsers.ClearSelection();

            string userID = lstNames.SelectedValue.ToString();
            string userName = lstNames.Text;

            if (!String.IsNullOrEmpty(userID) && !String.IsNullOrEmpty(userName))
            {
                DataGridViewRow dgRow =
                    (from DataGridViewRow row in dgvUsers.Rows
                     where row.Cells["colID"].Value.ToString().ToUpper().Equals(userID)
                     && row.Cells["colName"].Value.ToString().ToUpper().Equals(userName.ToUpper())
                     select row).FirstOrDefault();

                if (dgRow != null)
                {
                    dgRow.Selected = true;
                    dgvUsers.FirstDisplayedScrollingRowIndex = dgRow.Index;
                    dgvUsers.PerformLayout();
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Hide();
       

            Form frmLgn = new Form1();
            frmLgn.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                Edit();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Save();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            try
            {
                ClearFormFields();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Delete();
            }
            catch (Exception ex)
            {
                Controller.Messager.ShowException(ex);
            }
        }

        /// <summary>
        /// Searching by name in text search by name and higlight in both list box and data grid.
        /// </summary>
        /// <param name="name"></param>
        public void SearchByName(string name)
        {
            dgvUsers.ClearSelection();
            lstNames.ClearSelected();

            if (!String.IsNullOrEmpty(name))
            {
                int index = lstNames.FindString(txtSearch.Text);
                lstNames.SetSelected(index, true);

                DataGridViewRow dgRow =
                    (from DataGridViewRow row in dgvUsers.Rows
                     where row.Cells["colName"].Value.ToString().ToUpper().Equals(name.ToUpper())
                     select row).FirstOrDefault();

                if (dgRow != null)
                {
                    dgRow.Selected = true;
                    dgvUsers.FirstDisplayedScrollingRowIndex = dgRow.Index;
                    dgvUsers.PerformLayout();
                }
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchByName(txtSearch.Text);
            }
        }
    }
}
