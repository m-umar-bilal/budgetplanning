namespace BudgetPlanner.View
{
    partial class frmAddPersonalBudget
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddPersonalBudget));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnCalc = new CloudToolkitN6.CloudDesktopButton();
            this.btnCancel = new CloudToolkitN6.CloudDesktopButton();
            this.btnAddCategory = new CloudToolkitN6.CloudDesktopButton();
            this.CategoryToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnAddExpenses = new CloudToolkitN6.CloudDesktopButton();
            this.cloudDesktopButton1 = new CloudToolkitN6.CloudDesktopButton();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtPicker);
            this.panel2.Location = new System.Drawing.Point(25, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(274, 90);
            this.panel2.TabIndex = 49;
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
            // btnCalc
            // 
            this.btnCalc.AnimationSpeed = 5;
            this.btnCalc.BackColor = System.Drawing.Color.Transparent;
            this.btnCalc.BackgroundOpacity = 100;
            this.btnCalc.BackgroundOpacity_MouseDown = 170;
            this.btnCalc.BorderColor = System.Drawing.Color.White;
            this.btnCalc.BorderOpacity = 170;
            this.btnCalc.BorderWidth = 1;
            this.btnCalc.ControlText = "Calculator";
            this.btnCalc.CornerRadius = 12;
            this.btnCalc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalc.DrawBlackTextBackground = true;
            this.btnCalc.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCalc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalc.Icon = global::BudgetPlanner.Properties.Resources.calculator_icon;
            this.btnCalc.Location = new System.Drawing.Point(55, 221);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(93, 79);
            this.btnCalc.TabIndex = 69;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
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
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DrawBlackTextBackground = true;
            this.btnCancel.FillColor = System.Drawing.Color.Azure;
            this.btnCancel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Icon = global::BudgetPlanner.Properties.Resources.Close_2_icon;
            this.btnCancel.Location = new System.Drawing.Point(181, 221);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 82);
            this.btnCancel.TabIndex = 67;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.AnimationSpeed = 5;
            this.btnAddCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnAddCategory.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCategory.BackgroundImage")));
            this.btnAddCategory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCategory.BackgroundOpacity = 100;
            this.btnAddCategory.BackgroundOpacity_MouseDown = 170;
            this.btnAddCategory.BorderColor = System.Drawing.Color.White;
            this.btnAddCategory.BorderOpacity = 170;
            this.btnAddCategory.BorderWidth = 1;
            this.btnAddCategory.ControlText = "";
            this.btnAddCategory.CornerRadius = 12;
            this.btnAddCategory.DrawBlackTextBackground = true;
            this.btnAddCategory.FillColor = System.Drawing.Color.Azure;
            this.btnAddCategory.ForeColor = System.Drawing.Color.White;
            this.btnAddCategory.Icon = null;
            this.btnAddCategory.Location = new System.Drawing.Point(25, 128);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(64, 55);
            this.btnAddCategory.TabIndex = 70;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnAddExpenses
            // 
            this.btnAddExpenses.AnimationSpeed = 5;
            this.btnAddExpenses.BackColor = System.Drawing.Color.Transparent;
            this.btnAddExpenses.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddExpenses.BackgroundImage")));
            this.btnAddExpenses.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddExpenses.BackgroundOpacity = 100;
            this.btnAddExpenses.BackgroundOpacity_MouseDown = 170;
            this.btnAddExpenses.BorderColor = System.Drawing.Color.White;
            this.btnAddExpenses.BorderOpacity = 170;
            this.btnAddExpenses.BorderWidth = 1;
            this.btnAddExpenses.ControlText = "";
            this.btnAddExpenses.CornerRadius = 12;
            this.btnAddExpenses.DrawBlackTextBackground = true;
            this.btnAddExpenses.FillColor = System.Drawing.Color.Azure;
            this.btnAddExpenses.ForeColor = System.Drawing.Color.White;
            this.btnAddExpenses.Icon = null;
            this.btnAddExpenses.Location = new System.Drawing.Point(119, 128);
            this.btnAddExpenses.Name = "btnAddExpenses";
            this.btnAddExpenses.Size = new System.Drawing.Size(64, 55);
            this.btnAddExpenses.TabIndex = 71;
            this.btnAddExpenses.Click += new System.EventHandler(this.btnAddExpenses_Click);
            // 
            // cloudDesktopButton1
            // 
            this.cloudDesktopButton1.AnimationSpeed = 5;
            this.cloudDesktopButton1.BackColor = System.Drawing.Color.Transparent;
            this.cloudDesktopButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloudDesktopButton1.BackgroundImage")));
            this.cloudDesktopButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudDesktopButton1.BackgroundOpacity = 100;
            this.cloudDesktopButton1.BackgroundOpacity_MouseDown = 170;
            this.cloudDesktopButton1.BorderColor = System.Drawing.Color.White;
            this.cloudDesktopButton1.BorderOpacity = 170;
            this.cloudDesktopButton1.BorderWidth = 1;
            this.cloudDesktopButton1.ControlText = "";
            this.cloudDesktopButton1.CornerRadius = 12;
            this.cloudDesktopButton1.DrawBlackTextBackground = true;
            this.cloudDesktopButton1.FillColor = System.Drawing.Color.Azure;
            this.cloudDesktopButton1.ForeColor = System.Drawing.Color.White;
            this.cloudDesktopButton1.Icon = null;
            this.cloudDesktopButton1.Location = new System.Drawing.Point(222, 128);
            this.cloudDesktopButton1.Name = "cloudDesktopButton1";
            this.cloudDesktopButton1.Size = new System.Drawing.Size(64, 55);
            this.cloudDesktopButton1.TabIndex = 72;
            this.cloudDesktopButton1.Click += new System.EventHandler(this.cloudDesktopButton1_Click);
            // 
            // frmAddPersonalBudget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(330, 329);
            this.Controls.Add(this.cloudDesktopButton1);
            this.Controls.Add(this.btnAddExpenses);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmAddPersonalBudget";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Personal Budget";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAddPersonalBudget_FormClosed);
            this.Load += new System.EventHandler(this.frmAddPersonalBudget_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private CloudToolkitN6.CloudDesktopButton btnCalc;
        private CloudToolkitN6.CloudDesktopButton btnCancel;
        private CloudToolkitN6.CloudDesktopButton btnAddCategory;
        private System.Windows.Forms.ToolTip CategoryToolTip;
        private CloudToolkitN6.CloudDesktopButton btnAddExpenses;
        private CloudToolkitN6.CloudDesktopButton cloudDesktopButton1;
    }
}