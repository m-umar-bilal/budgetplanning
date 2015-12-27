namespace BudgetPlanner.View
{
    partial class frmForgotUserDetail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotUserDetail));
            this.lblID = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.dgvUserDetail = new System.Windows.Forms.DataGridView();
            this.colUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new CloudToolkitN6.CloudDesktopButton();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnGoBack = new CloudToolkitN6.CloudDesktopButton();
            this.btnContinue = new CloudToolkitN6.CloudDesktopButton();
            this.btnEdit = new CloudToolkitN6.CloudDesktopButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetail)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.BackColor = System.Drawing.Color.Transparent;
            this.lblID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblID.Location = new System.Drawing.Point(7, 18);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(79, 15);
            this.lblID.TabIndex = 34;
            this.lblID.Text = "&Enter User ID";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(91, 12);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(198, 23);
            this.txtUserID.TabIndex = 33;
            this.txtUserID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserID_KeyPress);
            // 
            // dgvUserDetail
            // 
            this.dgvUserDetail.AllowUserToAddRows = false;
            this.dgvUserDetail.AllowUserToDeleteRows = false;
            this.dgvUserDetail.AllowUserToResizeColumns = false;
            this.dgvUserDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserDetail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvUserDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colUserName,
            this.colPassword});
            this.dgvUserDetail.Location = new System.Drawing.Point(10, 41);
            this.dgvUserDetail.Name = "dgvUserDetail";
            this.dgvUserDetail.ReadOnly = true;
            this.dgvUserDetail.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUserDetail.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserDetail.Size = new System.Drawing.Size(279, 57);
            this.dgvUserDetail.TabIndex = 50;
            // 
            // colUserName
            // 
            this.colUserName.HeaderText = "User Name";
            this.colUserName.Name = "colUserName";
            this.colUserName.ReadOnly = true;
            this.colUserName.Width = 85;
            // 
            // colPassword
            // 
            this.colPassword.HeaderText = "Password";
            this.colPassword.Name = "colPassword";
            this.colPassword.ReadOnly = true;
            this.colPassword.Width = 78;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.lblPassword);
            this.groupBox1.Controls.Add(this.lblUserName);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(11, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 118);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit User Details";
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
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Icon = global::BudgetPlanner.Properties.Resources.Save_icon;
            this.btnSave.Location = new System.Drawing.Point(228, 75);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(42, 37);
            this.btnSave.TabIndex = 35;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(7, 49);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 34;
            this.lblPassword.Text = "&Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(7, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 15);
            this.lblUserName.TabIndex = 33;
            this.lblUserName.Text = "&User Name";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(81, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(192, 23);
            this.txtPassword.TabIndex = 30;
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(81, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 23);
            this.txtUserName.TabIndex = 29;
            // 
            // btnGoBack
            // 
            this.btnGoBack.AnimationSpeed = 5;
            this.btnGoBack.BackColor = System.Drawing.Color.Transparent;
            this.btnGoBack.BackgroundOpacity = 100;
            this.btnGoBack.BackgroundOpacity_MouseDown = 170;
            this.btnGoBack.BorderColor = System.Drawing.Color.White;
            this.btnGoBack.BorderOpacity = 170;
            this.btnGoBack.BorderWidth = 1;
            this.btnGoBack.ControlText = "";
            this.btnGoBack.CornerRadius = 12;
            this.btnGoBack.DrawBlackTextBackground = true;
            this.btnGoBack.FillColor = System.Drawing.Color.Azure;
            this.btnGoBack.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.ForeColor = System.Drawing.Color.White;
            this.btnGoBack.Icon = global::BudgetPlanner.Properties.Resources.folder_blue_click_icon;
            this.btnGoBack.Location = new System.Drawing.Point(198, 102);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(42, 37);
            this.btnGoBack.TabIndex = 55;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.AnimationSpeed = 5;
            this.btnContinue.BackColor = System.Drawing.Color.Transparent;
            this.btnContinue.BackgroundOpacity = 100;
            this.btnContinue.BackgroundOpacity_MouseDown = 170;
            this.btnContinue.BorderColor = System.Drawing.Color.White;
            this.btnContinue.BorderOpacity = 170;
            this.btnContinue.BorderWidth = 1;
            this.btnContinue.ControlText = "";
            this.btnContinue.CornerRadius = 12;
            this.btnContinue.DrawBlackTextBackground = true;
            this.btnContinue.FillColor = System.Drawing.Color.Azure;
            this.btnContinue.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnContinue.ForeColor = System.Drawing.Color.White;
            this.btnContinue.Icon = global::BudgetPlanner.Properties.Resources.logout_icon;
            this.btnContinue.Location = new System.Drawing.Point(247, 102);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(42, 37);
            this.btnContinue.TabIndex = 56;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
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
            this.btnEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Icon = global::BudgetPlanner.Properties.Resources.Actions_document_edit_icon1;
            this.btnEdit.Location = new System.Drawing.Point(151, 102);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(42, 37);
            this.btnEdit.TabIndex = 57;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // frmForgotUserDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 279);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvUserDetail);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtUserID);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmForgotUserDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Detail";
            this.Load += new System.EventHandler(this.frmForgotUserDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserDetail)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.DataGridView dgvUserDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUserName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private CloudToolkitN6.CloudDesktopButton btnSave;
        private CloudToolkitN6.CloudDesktopButton btnGoBack;
        private CloudToolkitN6.CloudDesktopButton btnContinue;
        private CloudToolkitN6.CloudDesktopButton btnEdit;
    }
}