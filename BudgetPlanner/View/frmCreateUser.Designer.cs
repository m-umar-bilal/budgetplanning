namespace BudgetPlanner.View
{
    partial class frmCreateUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateUser));
            this.grpLoginDetails = new System.Windows.Forms.GroupBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.grpPersonalDetails = new System.Windows.Forms.GroupBox();
            this.txtAutoID = new System.Windows.Forms.TextBox();
            this.lblAutoID = new System.Windows.Forms.Label();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAge = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSearchByName = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblUname = new System.Windows.Forms.Label();
            this.lstNames = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDone = new CloudToolkitN6.CloudDesktopButton();
            this.btnDelete = new CloudToolkitN6.CloudDesktopButton();
            this.btnClear = new CloudToolkitN6.CloudDesktopButton();
            this.btnSave = new CloudToolkitN6.CloudDesktopButton();
            this.btnEdit = new CloudToolkitN6.CloudDesktopButton();
            this.grpLoginDetails.SuspendLayout();
            this.grpPersonalDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpLoginDetails
            // 
            this.grpLoginDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpLoginDetails.Controls.Add(this.lblPassword);
            this.grpLoginDetails.Controls.Add(this.txtPassword);
            this.grpLoginDetails.Controls.Add(this.lblUserName);
            this.grpLoginDetails.Controls.Add(this.txtUserName);
            this.grpLoginDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLoginDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpLoginDetails.Location = new System.Drawing.Point(354, 19);
            this.grpLoginDetails.Name = "grpLoginDetails";
            this.grpLoginDetails.Size = new System.Drawing.Size(364, 106);
            this.grpLoginDetails.TabIndex = 47;
            this.grpLoginDetails.TabStop = false;
            this.grpLoginDetails.Text = "Login Details";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPassword.Location = new System.Drawing.Point(14, 68);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 50;
            this.lblPassword.Text = "&Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(108, 62);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUserName.Location = new System.Drawing.Point(13, 38);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 15);
            this.lblUserName.TabIndex = 48;
            this.lblUserName.Text = "&User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUserName.Location = new System.Drawing.Point(108, 32);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 23);
            this.txtUserName.TabIndex = 6;
            // 
            // grpPersonalDetails
            // 
            this.grpPersonalDetails.BackColor = System.Drawing.SystemColors.Control;
            this.grpPersonalDetails.Controls.Add(this.txtAutoID);
            this.grpPersonalDetails.Controls.Add(this.lblAutoID);
            this.grpPersonalDetails.Controls.Add(this.rdbFemale);
            this.grpPersonalDetails.Controls.Add(this.rdbMale);
            this.grpPersonalDetails.Controls.Add(this.lblGender);
            this.grpPersonalDetails.Controls.Add(this.lblAge);
            this.grpPersonalDetails.Controls.Add(this.txtAge);
            this.grpPersonalDetails.Controls.Add(this.lblPhoneNumber);
            this.grpPersonalDetails.Controls.Add(this.txtPhoneNumber);
            this.grpPersonalDetails.Controls.Add(this.lblName);
            this.grpPersonalDetails.Controls.Add(this.txtName);
            this.grpPersonalDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonalDetails.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpPersonalDetails.Location = new System.Drawing.Point(12, 19);
            this.grpPersonalDetails.Name = "grpPersonalDetails";
            this.grpPersonalDetails.Size = new System.Drawing.Size(339, 170);
            this.grpPersonalDetails.TabIndex = 48;
            this.grpPersonalDetails.TabStop = false;
            this.grpPersonalDetails.Text = "Personal Details";
            // 
            // txtAutoID
            // 
            this.txtAutoID.Enabled = false;
            this.txtAutoID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutoID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAutoID.Location = new System.Drawing.Point(219, 13);
            this.txtAutoID.Name = "txtAutoID";
            this.txtAutoID.Size = new System.Drawing.Size(111, 23);
            this.txtAutoID.TabIndex = 51;
            // 
            // lblAutoID
            // 
            this.lblAutoID.AutoSize = true;
            this.lblAutoID.BackColor = System.Drawing.Color.Transparent;
            this.lblAutoID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoID.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAutoID.Location = new System.Drawing.Point(168, 17);
            this.lblAutoID.Name = "lblAutoID";
            this.lblAutoID.Size = new System.Drawing.Size(48, 15);
            this.lblAutoID.TabIndex = 50;
            this.lblAutoID.Text = "&Auto ID";
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.BackColor = System.Drawing.Color.Transparent;
            this.rdbFemale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbFemale.Location = new System.Drawing.Point(165, 129);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(65, 19);
            this.rdbFemale.TabIndex = 5;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = false;
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.BackColor = System.Drawing.Color.Transparent;
            this.rdbMale.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rdbMale.Location = new System.Drawing.Point(110, 129);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(52, 19);
            this.rdbMale.TabIndex = 4;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = false;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGender.Location = new System.Drawing.Point(15, 131);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(48, 15);
            this.lblGender.TabIndex = 49;
            this.lblGender.Text = "&Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.BackColor = System.Drawing.Color.Transparent;
            this.lblAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAge.Location = new System.Drawing.Point(14, 103);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(28, 15);
            this.lblAge.TabIndex = 48;
            this.lblAge.Text = "&Age";
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtAge.Location = new System.Drawing.Point(108, 97);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(222, 23);
            this.txtAge.TabIndex = 3;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(13, 73);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.lblPhoneNumber.TabIndex = 46;
            this.lblPhoneNumber.Text = "&Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPhoneNumber.Location = new System.Drawing.Point(108, 70);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 23);
            this.txtPhoneNumber.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblName.Location = new System.Drawing.Point(13, 43);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(40, 15);
            this.lblName.TabIndex = 45;
            this.lblName.Text = "&Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtName.Location = new System.Drawing.Point(108, 42);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 23);
            this.txtName.TabIndex = 1;
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AllowUserToResizeColumns = false;
            this.dgvUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colName,
            this.colPhoneNumber,
            this.colAge,
            this.colGender,
            this.colUserName,
            this.colPassword});
            this.dgvUsers.Location = new System.Drawing.Point(188, 197);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsers.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.Size = new System.Drawing.Size(530, 226);
            this.dgvUsers.TabIndex = 49;
            // 
            // colID
            // 
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Width = 43;
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            this.colName.Width = 60;
            // 
            // colPhoneNumber
            // 
            this.colPhoneNumber.HeaderText = "Phone Number";
            this.colPhoneNumber.Name = "colPhoneNumber";
            this.colPhoneNumber.ReadOnly = true;
            this.colPhoneNumber.Width = 95;
            // 
            // colAge
            // 
            this.colAge.HeaderText = "Age";
            this.colAge.Name = "colAge";
            this.colAge.ReadOnly = true;
            this.colAge.Width = 51;
            // 
            // colGender
            // 
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            this.colGender.ReadOnly = true;
            this.colGender.Width = 67;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "User Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 78;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 78;
            // 
            // lblSearchByName
            // 
            this.lblSearchByName.AutoSize = true;
            this.lblSearchByName.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchByName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchByName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSearchByName.Location = new System.Drawing.Point(10, 192);
            this.lblSearchByName.Name = "lblSearchByName";
            this.lblSearchByName.Size = new System.Drawing.Size(99, 15);
            this.lblSearchByName.TabIndex = 53;
            this.lblSearchByName.Text = "&Search By Name:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(12, 210);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 23);
            this.txtSearch.TabIndex = 50;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblUname
            // 
            this.lblUname.AutoSize = true;
            this.lblUname.BackColor = System.Drawing.Color.Transparent;
            this.lblUname.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUname.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUname.Location = new System.Drawing.Point(11, 235);
            this.lblUname.Name = "lblUname";
            this.lblUname.Size = new System.Drawing.Size(73, 15);
            this.lblUname.TabIndex = 52;
            this.lblUname.Text = "&User Names";
            // 
            // lstNames
            // 
            this.lstNames.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lstNames.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNames.FormattingEnabled = true;
            this.lstNames.ItemHeight = 15;
            this.lstNames.Location = new System.Drawing.Point(12, 253);
            this.lstNames.Name = "lstNames";
            this.lstNames.ScrollAlwaysVisible = true;
            this.lstNames.Size = new System.Drawing.Size(170, 169);
            this.lstNames.TabIndex = 51;
            this.lstNames.Click += new System.EventHandler(this.lstNames_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel1.Controls.Add(this.btnDone);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Location = new System.Drawing.Point(355, 131);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 58);
            this.panel1.TabIndex = 59;
            // 
            // btnDone
            // 
            this.btnDone.AnimationSpeed = 5;
            this.btnDone.BackColor = System.Drawing.Color.Transparent;
            this.btnDone.BackgroundOpacity = 100;
            this.btnDone.BackgroundOpacity_MouseDown = 170;
            this.btnDone.BorderColor = System.Drawing.Color.White;
            this.btnDone.BorderOpacity = 170;
            this.btnDone.BorderWidth = 1;
            this.btnDone.ControlText = "";
            this.btnDone.CornerRadius = 12;
            this.btnDone.DrawBlackTextBackground = true;
            this.btnDone.FillColor = System.Drawing.Color.Azure;
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Icon = global::BudgetPlanner.Properties.Resources.semi_success_icon;
            this.btnDone.Location = new System.Drawing.Point(289, 3);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(64, 55);
            this.btnDone.TabIndex = 63;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.AnimationSpeed = 5;
            this.btnDelete.BackColor = System.Drawing.Color.Transparent;
            this.btnDelete.BackgroundOpacity = 100;
            this.btnDelete.BackgroundOpacity_MouseDown = 170;
            this.btnDelete.BorderColor = System.Drawing.Color.White;
            this.btnDelete.BorderOpacity = 170;
            this.btnDelete.BorderWidth = 1;
            this.btnDelete.ControlText = "";
            this.btnDelete.CornerRadius = 12;
            this.btnDelete.DrawBlackTextBackground = true;
            this.btnDelete.FillColor = System.Drawing.Color.Azure;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Icon = global::BudgetPlanner.Properties.Resources.Actions_user_group_delete_icon;
            this.btnDelete.Location = new System.Drawing.Point(215, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 55);
            this.btnDelete.TabIndex = 62;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.AnimationSpeed = 5;
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.BackgroundOpacity = 100;
            this.btnClear.BackgroundOpacity_MouseDown = 170;
            this.btnClear.BorderColor = System.Drawing.Color.White;
            this.btnClear.BorderOpacity = 170;
            this.btnClear.BorderWidth = 1;
            this.btnClear.ControlText = "";
            this.btnClear.CornerRadius = 12;
            this.btnClear.DrawBlackTextBackground = true;
            this.btnClear.FillColor = System.Drawing.Color.Azure;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Icon = global::BudgetPlanner.Properties.Resources.Recycle_Empty_icon;
            this.btnClear.Location = new System.Drawing.Point(143, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(64, 55);
            this.btnClear.TabIndex = 61;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.AnimationSpeed = 5;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BackgroundOpacity = 100;
            this.btnSave.BackgroundOpacity_MouseDown = 170;
            this.btnSave.BorderColor = System.Drawing.Color.White;
            this.btnSave.BorderOpacity = 170;
            this.btnSave.BorderWidth = 1;
            this.btnSave.ControlText = "";
            this.btnSave.CornerRadius = 12;
            this.btnSave.DrawBlackTextBackground = true;
            this.btnSave.FillColor = System.Drawing.Color.Azure;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Icon = global::BudgetPlanner.Properties.Resources.Floppy_Small_icon;
            this.btnSave.Location = new System.Drawing.Point(72, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 55);
            this.btnSave.TabIndex = 60;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationSpeed = 5;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BackgroundOpacity = 100;
            this.btnEdit.BackgroundOpacity_MouseDown = 170;
            this.btnEdit.BorderColor = System.Drawing.Color.White;
            this.btnEdit.BorderOpacity = 170;
            this.btnEdit.BorderWidth = 1;
            this.btnEdit.ControlText = "";
            this.btnEdit.CornerRadius = 12;
            this.btnEdit.DrawBlackTextBackground = true;
            this.btnEdit.FillColor = System.Drawing.Color.Azure;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Icon = global::BudgetPlanner.Properties.Resources.Actions_document_edit_icon;
            this.btnEdit.Location = new System.Drawing.Point(3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 55);
            this.btnEdit.TabIndex = 59;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmCreateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(730, 437);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSearchByName);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblUname);
            this.Controls.Add(this.lstNames);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.grpPersonalDetails);
            this.Controls.Add(this.grpLoginDetails);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmCreateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create New User";
            this.Load += new System.EventHandler(this.frmCreateUser_Load);
            this.grpLoginDetails.ResumeLayout(false);
            this.grpLoginDetails.PerformLayout();
            this.grpPersonalDetails.ResumeLayout(false);
            this.grpPersonalDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpLoginDetails;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox grpPersonalDetails;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Label lblSearchByName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblUname;
        private System.Windows.Forms.ListBox lstNames;
        private System.Windows.Forms.TextBox txtAutoID;
        private System.Windows.Forms.Label lblAutoID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAge;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.Panel panel1;
        private CloudToolkitN6.CloudDesktopButton btnDone;
        private CloudToolkitN6.CloudDesktopButton btnDelete;
        private CloudToolkitN6.CloudDesktopButton btnClear;
        private CloudToolkitN6.CloudDesktopButton btnSave;
        private CloudToolkitN6.CloudDesktopButton btnEdit;
    }
}