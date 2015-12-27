namespace BudgetPlanner.View
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnOk = new CloudToolkitN6.CloudDesktopButton();
            this.btnCancel = new CloudToolkitN6.CloudDesktopButton();
            this.btnCreateNew = new CloudToolkitN6.CloudDesktopButton();
            this.lnklblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.lnklblRegister = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPassword.Location = new System.Drawing.Point(19, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(59, 15);
            this.lblPassword.TabIndex = 33;
            this.lblPassword.Text = "&Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(102, 50);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(222, 23);
            this.txtPassword.TabIndex = 28;
            this.txtPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPassword_KeyPress);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(18, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(68, 15);
            this.lblUserName.TabIndex = 32;
            this.lblUserName.Text = "&User Name";
            // 
            // txtUserName
            // 
            this.txtUserName.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(102, 16);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(222, 23);
            this.txtUserName.TabIndex = 27;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // btnOk
            // 
            this.btnOk.AnimationSpeed = 5;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundOpacity = 100;
            this.btnOk.BackgroundOpacity_MouseDown = 170;
            this.btnOk.BorderColor = System.Drawing.Color.White;
            this.btnOk.BorderOpacity = 170;
            this.btnOk.BorderWidth = 1;
            this.btnOk.ControlText = "Ok";
            this.btnOk.CornerRadius = 12;
            this.btnOk.DrawBlackTextBackground = true;
            this.btnOk.FillColor = System.Drawing.Color.Azure;
            this.btnOk.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Icon = ((System.Drawing.Bitmap)(resources.GetObject("btnOk.Icon")));
            this.btnOk.Location = new System.Drawing.Point(28, 109);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(93, 72);
            this.btnOk.TabIndex = 34;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationSpeed = 5;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BackgroundOpacity = 100;
            this.btnCancel.BackgroundOpacity_MouseDown = 170;
            this.btnCancel.BorderColor = System.Drawing.Color.White;
            this.btnCancel.BorderOpacity = 170;
            this.btnCancel.BorderWidth = 1;
            this.btnCancel.ControlText = "Cancel";
            this.btnCancel.CornerRadius = 12;
            this.btnCancel.DrawBlackTextBackground = true;
            this.btnCancel.FillColor = System.Drawing.Color.Azure;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Icon = ((System.Drawing.Bitmap)(resources.GetObject("btnCancel.Icon")));
            this.btnCancel.Location = new System.Drawing.Point(127, 109);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 72);
            this.btnCancel.TabIndex = 35;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCreateNew
            // 
            this.btnCreateNew.AnimationSpeed = 5;
            this.btnCreateNew.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateNew.BackgroundOpacity = 100;
            this.btnCreateNew.BackgroundOpacity_MouseDown = 170;
            this.btnCreateNew.BorderColor = System.Drawing.Color.White;
            this.btnCreateNew.BorderOpacity = 170;
            this.btnCreateNew.BorderWidth = 1;
            this.btnCreateNew.ControlText = "Create User";
            this.btnCreateNew.CornerRadius = 12;
            this.btnCreateNew.DrawBlackTextBackground = true;
            this.btnCreateNew.FillColor = System.Drawing.Color.Azure;
            this.btnCreateNew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateNew.ForeColor = System.Drawing.Color.White;
            this.btnCreateNew.Icon = ((System.Drawing.Bitmap)(resources.GetObject("btnCreateNew.Icon")));
            this.btnCreateNew.Location = new System.Drawing.Point(226, 109);
            this.btnCreateNew.Name = "btnCreateNew";
            this.btnCreateNew.Size = new System.Drawing.Size(93, 72);
            this.btnCreateNew.TabIndex = 36;
            this.btnCreateNew.Click += new System.EventHandler(this.btnCreateNew_Click);
            // 
            // lnklblForgotPassword
            // 
            this.lnklblForgotPassword.AutoSize = true;
            this.lnklblForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.lnklblForgotPassword.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblForgotPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnklblForgotPassword.LinkColor = System.Drawing.Color.SkyBlue;
            this.lnklblForgotPassword.Location = new System.Drawing.Point(157, 82);
            this.lnklblForgotPassword.Name = "lnklblForgotPassword";
            this.lnklblForgotPassword.Size = new System.Drawing.Size(104, 15);
            this.lnklblForgotPassword.TabIndex = 37;
            this.lnklblForgotPassword.TabStop = true;
            this.lnklblForgotPassword.Text = "Forgot Password?";
            this.lnklblForgotPassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblForgotPassword_LinkClicked);
            // 
            // lnklblRegister
            // 
            this.lnklblRegister.AutoSize = true;
            this.lnklblRegister.BackColor = System.Drawing.Color.Transparent;
            this.lnklblRegister.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnklblRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lnklblRegister.LinkColor = System.Drawing.Color.SkyBlue;
            this.lnklblRegister.Location = new System.Drawing.Point(99, 82);
            this.lnklblRegister.Name = "lnklblRegister";
            this.lnklblRegister.Size = new System.Drawing.Size(60, 15);
            this.lnklblRegister.TabIndex = 38;
            this.lnklblRegister.TabStop = true;
            this.lnklblRegister.Text = "Register!!";
            this.lnklblRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnklblRegister_LinkClicked);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(340, 187);
            this.Controls.Add(this.lnklblRegister);
            this.Controls.Add(this.lnklblForgotPassword);
            this.Controls.Add(this.btnCreateNew);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.txtUserName);
            this.MaximizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox txtUserName;
        private CloudToolkitN6.CloudDesktopButton btnOk;
        private CloudToolkitN6.CloudDesktopButton btnCancel;
        private CloudToolkitN6.CloudDesktopButton btnCreateNew;
        private System.Windows.Forms.LinkLabel lnklblForgotPassword;
        private System.Windows.Forms.LinkLabel lnklblRegister;
    }
}