namespace BudgetPlanner.View
{
    partial class frmAddAmount
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
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.btnUpdate = new CloudToolkitN6.CloudDesktopButton();
            this.txtAmountEdit = new System.Windows.Forms.TextBox();
            this.btnAmountClose = new CloudToolkitN6.CloudDesktopButton();
            this.btnEditAmount = new CloudToolkitN6.CloudDesktopButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddAmount = new CloudToolkitN6.CloudDesktopButton();
            this.pnlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAmount
            // 
            this.pnlAmount.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmount.Controls.Add(this.btnUpdate);
            this.pnlAmount.Controls.Add(this.txtAmountEdit);
            this.pnlAmount.Controls.Add(this.btnAmountClose);
            this.pnlAmount.Controls.Add(this.btnEditAmount);
            this.pnlAmount.Controls.Add(this.txtAmount);
            this.pnlAmount.Controls.Add(this.label1);
            this.pnlAmount.Controls.Add(this.btnAddAmount);
            this.pnlAmount.Location = new System.Drawing.Point(2, 1);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(260, 119);
            this.pnlAmount.TabIndex = 47;
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationSpeed = 5;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BackgroundOpacity = 100;
            this.btnUpdate.BackgroundOpacity_MouseDown = 170;
            this.btnUpdate.BorderColor = System.Drawing.Color.White;
            this.btnUpdate.BorderOpacity = 170;
            this.btnUpdate.BorderWidth = 1;
            this.btnUpdate.ControlText = "";
            this.btnUpdate.CornerRadius = 12;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DrawBlackTextBackground = true;
            this.btnUpdate.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnUpdate.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.DimGray;
            this.btnUpdate.Icon = global::BudgetPlanner.Properties.Resources.Save_icon1;
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(175, 72);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(31, 31);
            this.btnUpdate.TabIndex = 51;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtAmountEdit
            // 
            this.txtAmountEdit.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountEdit.Location = new System.Drawing.Point(8, 74);
            this.txtAmountEdit.Name = "txtAmountEdit";
            this.txtAmountEdit.Size = new System.Drawing.Size(164, 23);
            this.txtAmountEdit.TabIndex = 50;
            // 
            // btnAmountClose
            // 
            this.btnAmountClose.AnimationSpeed = 5;
            this.btnAmountClose.BackColor = System.Drawing.Color.Transparent;
            this.btnAmountClose.BackgroundOpacity = 100;
            this.btnAmountClose.BackgroundOpacity_MouseDown = 170;
            this.btnAmountClose.BorderColor = System.Drawing.Color.White;
            this.btnAmountClose.BorderOpacity = 170;
            this.btnAmountClose.BorderWidth = 1;
            this.btnAmountClose.ControlText = "";
            this.btnAmountClose.CornerRadius = 12;
            this.btnAmountClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAmountClose.DrawBlackTextBackground = true;
            this.btnAmountClose.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAmountClose.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAmountClose.ForeColor = System.Drawing.Color.DimGray;
            this.btnAmountClose.Icon = global::BudgetPlanner.Properties.Resources.Button_Delete_icon;
            this.btnAmountClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAmountClose.Location = new System.Drawing.Point(219, 82);
            this.btnAmountClose.Name = "btnAmountClose";
            this.btnAmountClose.Size = new System.Drawing.Size(31, 31);
            this.btnAmountClose.TabIndex = 49;
            this.btnAmountClose.Click += new System.EventHandler(this.btnAmountClose_Click);
            // 
            // btnEditAmount
            // 
            this.btnEditAmount.AnimationSpeed = 5;
            this.btnEditAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnEditAmount.BackgroundOpacity = 100;
            this.btnEditAmount.BackgroundOpacity_MouseDown = 170;
            this.btnEditAmount.BorderColor = System.Drawing.Color.White;
            this.btnEditAmount.BorderOpacity = 170;
            this.btnEditAmount.BorderWidth = 1;
            this.btnEditAmount.ControlText = "";
            this.btnEditAmount.CornerRadius = 12;
            this.btnEditAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAmount.DrawBlackTextBackground = true;
            this.btnEditAmount.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAmount.ForeColor = System.Drawing.Color.DimGray;
            this.btnEditAmount.Icon = global::BudgetPlanner.Properties.Resources.edit_icon;
            this.btnEditAmount.Location = new System.Drawing.Point(220, 42);
            this.btnEditAmount.Name = "btnEditAmount";
            this.btnEditAmount.Size = new System.Drawing.Size(31, 31);
            this.btnEditAmount.TabIndex = 48;
            this.btnEditAmount.Click += new System.EventHandler(this.btnEditAmount_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Enabled = false;
            this.txtAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.Location = new System.Drawing.Point(8, 45);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(204, 23);
            this.txtAmount.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(5, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 15);
            this.label1.TabIndex = 46;
            this.label1.Text = "&Enter Amount (Rs.) :";
            // 
            // btnAddAmount
            // 
            this.btnAddAmount.AnimationSpeed = 5;
            this.btnAddAmount.BackColor = System.Drawing.Color.Transparent;
            this.btnAddAmount.BackgroundOpacity = 100;
            this.btnAddAmount.BackgroundOpacity_MouseDown = 170;
            this.btnAddAmount.BorderColor = System.Drawing.Color.White;
            this.btnAddAmount.BorderOpacity = 170;
            this.btnAddAmount.BorderWidth = 1;
            this.btnAddAmount.ControlText = "";
            this.btnAddAmount.CornerRadius = 12;
            this.btnAddAmount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddAmount.DrawBlackTextBackground = true;
            this.btnAddAmount.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAddAmount.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAmount.ForeColor = System.Drawing.Color.DimGray;
            this.btnAddAmount.Icon = global::BudgetPlanner.Properties.Resources.Actions_list_add_icon;
            this.btnAddAmount.Location = new System.Drawing.Point(220, 5);
            this.btnAddAmount.Name = "btnAddAmount";
            this.btnAddAmount.Size = new System.Drawing.Size(31, 31);
            this.btnAddAmount.TabIndex = 47;
            this.btnAddAmount.Click += new System.EventHandler(this.btnAddAmount_Click);
            // 
            // frmAddAmount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 121);
            this.Controls.Add(this.pnlAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddAmount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Budget Amount";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAddAmount_FormClosing);
            this.Load += new System.EventHandler(this.frmAddAmount_Load);
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAmount;
        private CloudToolkitN6.CloudDesktopButton btnAmountClose;
        private CloudToolkitN6.CloudDesktopButton btnEditAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label1;
        private CloudToolkitN6.CloudDesktopButton btnAddAmount;
        private System.Windows.Forms.TextBox txtAmountEdit;
        private CloudToolkitN6.CloudDesktopButton btnUpdate;
    }
}