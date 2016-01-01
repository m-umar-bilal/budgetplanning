namespace BudgetPlanner.View
{
    partial class frmAddExpenses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddExpenses));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.grpExpenses = new CloudToolkitN6.CloudGroup();
            this.boxCat = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.budgiDeskDBDataSet = new BudgetPlanner.BudgiDeskDBDataSet();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblWater = new System.Windows.Forms.Label();
            this.txtDetails = new System.Windows.Forms.TextBox();
            this.lblGas = new System.Windows.Forms.Label();
            this.lblElectricity = new System.Windows.Forms.Label();
            this.categoryTableAdapter = new BudgetPlanner.BudgiDeskDBDataSetTableAdapters.CategoryTableAdapter();
            this.btnCalc = new CloudToolkitN6.CloudDesktopButton();
            this.btnSave = new CloudToolkitN6.CloudDesktopButton();
            this.btnCancel = new CloudToolkitN6.CloudDesktopButton();
            this.budgiDeskDBDataSet1 = new BudgetPlanner.BudgiDeskDBDataSet1();
            this.categoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter1 = new BudgetPlanner.BudgiDeskDBDataSet1TableAdapters.CategoryTableAdapter();
            this.panel2.SuspendLayout();
            this.grpExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgiDeskDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgiDeskDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Location = new System.Drawing.Point(27, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(254, 90);
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
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dateTimePicker2.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.dateTimePicker2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dateTimePicker2.Location = new System.Drawing.Point(9, 35);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(208, 23);
            this.dateTimePicker2.TabIndex = 45;
            // 
            // grpExpenses
            // 
            this.grpExpenses.AnimationEnabled = true;
            this.grpExpenses.AnimationSpeed = 12;
            this.grpExpenses.BackColor = System.Drawing.Color.Transparent;
            this.grpExpenses.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpExpenses.BorderColor = System.Drawing.Color.DimGray;
            this.grpExpenses.BorderWidth = 1F;
            this.grpExpenses.Controls.Add(this.boxCat);
            this.grpExpenses.Controls.Add(this.txtPrice);
            this.grpExpenses.Controls.Add(this.lblWater);
            this.grpExpenses.Controls.Add(this.txtDetails);
            this.grpExpenses.Controls.Add(this.lblGas);
            this.grpExpenses.Controls.Add(this.lblElectricity);
            this.grpExpenses.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpExpenses.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpExpenses.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpExpenses.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpExpenses.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExpenses.FontColorMouseOn = System.Drawing.Color.DimGray;
            this.grpExpenses.FontColorNormal = System.Drawing.Color.DimGray;
            this.grpExpenses.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpExpenses.HeaderCenter = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpExpenses.HeaderText = "                      Bills";
            this.grpExpenses.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpExpenses.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left;
            this.grpExpenses.IconPadding = 5;
            this.grpExpenses.ImageHeader = false;
            this.grpExpenses.IsOpen = true;
            this.grpExpenses.Location = new System.Drawing.Point(27, 121);
            this.grpExpenses.MaximumHeight = 220;
            this.grpExpenses.Name = "grpExpenses";
            this.grpExpenses.PanelColor = System.Drawing.Color.DimGray;
            this.grpExpenses.Size = new System.Drawing.Size(253, 223);
            this.grpExpenses.TabIndex = 49;
            // 
            // boxCat
            // 
            this.boxCat.DataSource = this.categoryBindingSource1;
            this.boxCat.DisplayMember = "CName";
            this.boxCat.FormattingEnabled = true;
            this.boxCat.Location = new System.Drawing.Point(75, 38);
            this.boxCat.Name = "boxCat";
            this.boxCat.Size = new System.Drawing.Size(169, 23);
            this.boxCat.TabIndex = 53;
            this.boxCat.ValueMember = "CID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.budgiDeskDBDataSet;
            // 
            // budgiDeskDBDataSet
            // 
            this.budgiDeskDBDataSet.DataSetName = "BudgiDeskDBDataSet";
            this.budgiDeskDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(75, 71);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(169, 23);
            this.txtPrice.TabIndex = 52;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.BackColor = System.Drawing.Color.Transparent;
            this.lblWater.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWater.Location = new System.Drawing.Point(1, 102);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(55, 19);
            this.lblWater.TabIndex = 51;
            this.lblWater.Text = "Details";
            // 
            // txtDetails
            // 
            this.txtDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetails.Location = new System.Drawing.Point(75, 102);
            this.txtDetails.Multiline = true;
            this.txtDetails.Name = "txtDetails";
            this.txtDetails.Size = new System.Drawing.Size(169, 100);
            this.txtDetails.TabIndex = 50;
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.BackColor = System.Drawing.Color.Transparent;
            this.lblGas.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblGas.Location = new System.Drawing.Point(1, 71);
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(43, 19);
            this.lblGas.TabIndex = 49;
            this.lblGas.Text = "Price";
            // 
            // lblElectricity
            // 
            this.lblElectricity.AutoSize = true;
            this.lblElectricity.BackColor = System.Drawing.Color.Transparent;
            this.lblElectricity.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblElectricity.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblElectricity.Location = new System.Drawing.Point(1, 41);
            this.lblElectricity.Name = "lblElectricity";
            this.lblElectricity.Size = new System.Drawing.Size(42, 19);
            this.lblElectricity.TabIndex = 34;
            this.lblElectricity.Text = "Type";
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
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
            this.btnCalc.Location = new System.Drawing.Point(323, 23);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(93, 79);
            this.btnCalc.TabIndex = 73;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click_2);
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
            this.btnSave.ControlText = "Save";
            this.btnSave.CornerRadius = 12;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DrawBlackTextBackground = true;
            this.btnSave.FillColor = System.Drawing.Color.Azure;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Icon = global::BudgetPlanner.Properties.Resources.Actions_document_save_all_icon;
            this.btnSave.Location = new System.Drawing.Point(323, 166);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(93, 82);
            this.btnSave.TabIndex = 72;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_2);
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
            this.btnCancel.Location = new System.Drawing.Point(323, 252);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(93, 82);
            this.btnCancel.TabIndex = 71;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click_1);
            // 
            // budgiDeskDBDataSet1
            // 
            this.budgiDeskDBDataSet1.DataSetName = "BudgiDeskDBDataSet1";
            this.budgiDeskDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource1
            // 
            this.categoryBindingSource1.DataMember = "Category";
            this.categoryBindingSource1.DataSource = this.budgiDeskDBDataSet1;
            // 
            // categoryTableAdapter1
            // 
            this.categoryTableAdapter1.ClearBeforeFill = true;
            // 
            // frmAddExpenses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 357);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.grpExpenses);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAddExpenses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddExpenses";
            this.Load += new System.EventHandler(this.frmAddExpenses_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpExpenses.ResumeLayout(false);
            this.grpExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgiDeskDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.budgiDeskDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private CloudToolkitN6.CloudGroup grpExpenses;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblWater;
        private System.Windows.Forms.TextBox txtDetails;
        private System.Windows.Forms.Label lblGas;
        private System.Windows.Forms.Label lblElectricity;
        private BudgiDeskDBDataSet budgiDeskDBDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private BudgiDeskDBDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox boxCat;
        private CloudToolkitN6.CloudDesktopButton btnCancel;
        private CloudToolkitN6.CloudDesktopButton btnSave;
        private CloudToolkitN6.CloudDesktopButton btnCalc;
        private BudgiDeskDBDataSet1 budgiDeskDBDataSet1;
        private System.Windows.Forms.BindingSource categoryBindingSource1;
        private BudgiDeskDBDataSet1TableAdapters.CategoryTableAdapter categoryTableAdapter1;
    }
}