namespace BudgetPlanner.View
{
    partial class frmAddEarnings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEarnings));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.btnEditAmount = new CloudToolkitN6.CloudDesktopButton();
            this.panel2.SuspendLayout();
            this.pnlAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtPicker);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 90);
            this.panel2.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 46;
            this.label4.Text = "&Pick Date:";
            // 
            // dtPicker
            // 
            this.dtPicker.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dtPicker.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dtPicker.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtPicker.Location = new System.Drawing.Point(12, 35);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(249, 23);
            this.dtPicker.TabIndex = 45;
            // 
            // pnlAmount
            // 
            this.pnlAmount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlAmount.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmount.Controls.Add(this.btnEditAmount);
            this.pnlAmount.Controls.Add(this.txtPrice);
            this.pnlAmount.Controls.Add(this.label1);
            this.pnlAmount.Location = new System.Drawing.Point(6, 116);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(274, 46);
            this.pnlAmount.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 47;
            this.label1.Text = "Rs:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(38, 7);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(182, 20);
            this.txtPrice.TabIndex = 48;
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
            this.btnEditAmount.Location = new System.Drawing.Point(230, 7);
            this.btnEditAmount.Name = "btnEditAmount";
            this.btnEditAmount.Size = new System.Drawing.Size(31, 31);
            this.btnEditAmount.TabIndex = 50;
            this.btnEditAmount.Click += new System.EventHandler(this.btnEditAmount_Click);
            // 
            // frmAddEarnings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(292, 174);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddEarnings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEarnings";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label1;
        private CloudToolkitN6.CloudDesktopButton btnEditAmount;
    }
}