namespace BudgetPlanner.View
{
    partial class frmViewDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewDetails));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSearch = new CloudToolkitN6.CloudDesktopButton();
            this.chkAll = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.grpCategory = new CloudToolkitN6.CloudGroup();
            this.btnPersonal = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.btnHome = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.dgvInfo = new System.Windows.Forms.DataGridView();
            this.btnDone = new CloudToolkitN6.CloudDesktopButton();
            this.grpHome = new CloudToolkitN6.CloudGroup();
            this.btnGrocery = new CloudToolkitN6.CloudDesktopButton();
            this.btnAccess = new CloudToolkitN6.CloudDesktopButton();
            this.btnBill = new CloudToolkitN6.CloudDesktopButton();
            this.btnFood = new CloudToolkitN6.CloudDesktopButton();
            this.chkMonth = new System.Windows.Forms.CheckBox();
            this.chkYear = new System.Windows.Forms.CheckBox();
            this.chkDay = new System.Windows.Forms.CheckBox();
            this.grpPersonal = new CloudToolkitN6.CloudGroup();
            this.cloudDesktopButton3 = new CloudToolkitN6.CloudDesktopButton();
            this.cloudDesktopButton4 = new CloudToolkitN6.CloudDesktopButton();
            this.panel2.SuspendLayout();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).BeginInit();
            this.grpHome.SuspendLayout();
            this.grpPersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.chkDay);
            this.panel2.Controls.Add(this.chkYear);
            this.panel2.Controls.Add(this.chkMonth);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.chkAll);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.dtPicker);
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(296, 75);
            this.panel2.TabIndex = 49;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationSpeed = 5;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BackgroundOpacity = 100;
            this.btnSearch.BackgroundOpacity_MouseDown = 170;
            this.btnSearch.BorderColor = System.Drawing.Color.White;
            this.btnSearch.BorderOpacity = 170;
            this.btnSearch.BorderWidth = 1;
            this.btnSearch.ControlText = "";
            this.btnSearch.CornerRadius = 12;
            this.btnSearch.DrawBlackTextBackground = true;
            this.btnSearch.FillColor = System.Drawing.Color.Azure;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Icon = global::BudgetPlanner.Properties.Resources.Windows_Magnifier_icon;
            this.btnSearch.Location = new System.Drawing.Point(248, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(41, 29);
            this.btnSearch.TabIndex = 60;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chkAll
            // 
            this.chkAll.AutoSize = true;
            this.chkAll.BackColor = System.Drawing.Color.Transparent;
            this.chkAll.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAll.ForeColor = System.Drawing.Color.DimGray;
            this.chkAll.Location = new System.Drawing.Point(9, 53);
            this.chkAll.Name = "chkAll";
            this.chkAll.Size = new System.Drawing.Size(40, 19);
            this.chkAll.TabIndex = 47;
            this.chkAll.Text = "All";
            this.chkAll.UseVisualStyleBackColor = false;
            this.chkAll.CheckedChanged += new System.EventHandler(this.chkAll_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(6, 7);
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
            this.dtPicker.Location = new System.Drawing.Point(9, 27);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(235, 23);
            this.dtPicker.TabIndex = 45;
            // 
            // grpCategory
            // 
            this.grpCategory.AnimationEnabled = true;
            this.grpCategory.AnimationSpeed = 4;
            this.grpCategory.BackColor = System.Drawing.Color.Transparent;
            this.grpCategory.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpCategory.BorderColor = System.Drawing.Color.DimGray;
            this.grpCategory.BorderWidth = 1F;
            this.grpCategory.Controls.Add(this.btnPersonal);
            this.grpCategory.Controls.Add(this.btnHome);
            this.grpCategory.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpCategory.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpCategory.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpCategory.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCategory.FontColorMouseOn = System.Drawing.Color.DimGray;
            this.grpCategory.FontColorNormal = System.Drawing.Color.DimGray;
            this.grpCategory.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpCategory.HeaderCenter = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpCategory.HeaderText = "                    Category";
            this.grpCategory.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpCategory.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left;
            this.grpCategory.IconPadding = 5;
            this.grpCategory.ImageHeader = false;
            this.grpCategory.IsOpen = true;
            this.grpCategory.Location = new System.Drawing.Point(306, 4);
            this.grpCategory.MaximumHeight = 77;
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.PanelColor = System.Drawing.Color.DimGray;
            this.grpCategory.Size = new System.Drawing.Size(258, 75);
            this.grpCategory.TabIndex = 50;
            // 
            // btnPersonal
            // 
            this.btnPersonal.AnimationOpacityChange = 0.1D;
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.ButtonText = "Personal";
            this.btnPersonal.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnPersonal.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnPersonal.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnPersonal.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnPersonal.ControlOpacity = 255;
            this.btnPersonal.CornerRadius = 8;
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.DrawHoverOverIcon = false;
            this.btnPersonal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.White;
            this.btnPersonal.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnPersonal.Icon = global::BudgetPlanner.Properties.Resources.man_icon;
            this.btnPersonal.IsAnimated = true;
            this.btnPersonal.Location = new System.Drawing.Point(131, 30);
            this.btnPersonal.MaximumGlowOpacity = 0.8D;
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.NormalColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnPersonal.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnPersonal.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnPersonal.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnPersonal.Size = new System.Drawing.Size(122, 43);
            this.btnPersonal.StartMenuIndex = 0;
            this.btnPersonal.TabIndex = 67;
            this.btnPersonal.TextCentered = true;
            this.btnPersonal.TextDistanceFromBorder = 5;
            this.btnPersonal.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimationOpacityChange = 0.1D;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.ButtonText = "Home";
            this.btnHome.ClickedColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.btnHome.ClickedColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btnHome.ClickedColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.btnHome.ClickedColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.btnHome.ControlOpacity = 255;
            this.btnHome.CornerRadius = 8;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DrawHoverOverIcon = false;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.GlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(215)))), ((int)(((byte)(226)))));
            this.btnHome.Icon = global::BudgetPlanner.Properties.Resources.Actions_go_home_icon;
            this.btnHome.IsAnimated = true;
            this.btnHome.Location = new System.Drawing.Point(7, 30);
            this.btnHome.MaximumGlowOpacity = 0.8D;
            this.btnHome.Name = "btnHome";
            this.btnHome.NormalColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(176)))), ((int)(((byte)(176)))));
            this.btnHome.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btnHome.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(27)))), ((int)(((byte)(27)))));
            this.btnHome.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnHome.Size = new System.Drawing.Size(122, 43);
            this.btnHome.StartMenuIndex = 0;
            this.btnHome.TabIndex = 66;
            this.btnHome.TextCentered = true;
            this.btnHome.TextDistanceFromBorder = 5;
            this.btnHome.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // dgvInfo
            // 
            this.dgvInfo.AllowUserToAddRows = false;
            this.dgvInfo.AllowUserToDeleteRows = false;
            this.dgvInfo.AllowUserToResizeColumns = false;
            this.dgvInfo.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dgvInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInfo.Location = new System.Drawing.Point(4, 85);
            this.dgvInfo.Name = "dgvInfo";
            this.dgvInfo.ReadOnly = true;
            this.dgvInfo.RowHeadersVisible = false;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInfo.Size = new System.Drawing.Size(560, 209);
            this.dgvInfo.TabIndex = 51;
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
            this.btnDone.Location = new System.Drawing.Point(495, 315);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(64, 57);
            this.btnDone.TabIndex = 63;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // grpHome
            // 
            this.grpHome.AnimationEnabled = true;
            this.grpHome.AnimationSpeed = 4;
            this.grpHome.BackColor = System.Drawing.Color.Transparent;
            this.grpHome.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpHome.BorderColor = System.Drawing.Color.DimGray;
            this.grpHome.BorderWidth = 1F;
            this.grpHome.Controls.Add(this.btnGrocery);
            this.grpHome.Controls.Add(this.btnAccess);
            this.grpHome.Controls.Add(this.btnBill);
            this.grpHome.Controls.Add(this.btnFood);
            this.grpHome.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpHome.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpHome.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpHome.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHome.FontColorMouseOn = System.Drawing.Color.DimGray;
            this.grpHome.FontColorNormal = System.Drawing.Color.DimGray;
            this.grpHome.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpHome.HeaderCenter = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpHome.HeaderText = "              Home Category";
            this.grpHome.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpHome.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left;
            this.grpHome.IconPadding = 5;
            this.grpHome.ImageHeader = false;
            this.grpHome.IsOpen = true;
            this.grpHome.Location = new System.Drawing.Point(4, 300);
            this.grpHome.MaximumHeight = 77;
            this.grpHome.Name = "grpHome";
            this.grpHome.PanelColor = System.Drawing.Color.DimGray;
            this.grpHome.Size = new System.Drawing.Size(245, 72);
            this.grpHome.TabIndex = 65;
            // 
            // btnGrocery
            // 
            this.btnGrocery.AnimationSpeed = 5;
            this.btnGrocery.BackColor = System.Drawing.Color.Transparent;
            this.btnGrocery.BackgroundOpacity = 100;
            this.btnGrocery.BackgroundOpacity_MouseDown = 170;
            this.btnGrocery.BorderColor = System.Drawing.Color.White;
            this.btnGrocery.BorderOpacity = 170;
            this.btnGrocery.BorderWidth = 1;
            this.btnGrocery.ControlText = "";
            this.btnGrocery.CornerRadius = 12;
            this.btnGrocery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrocery.DrawBlackTextBackground = true;
            this.btnGrocery.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnGrocery.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrocery.ForeColor = System.Drawing.Color.DimGray;
            this.btnGrocery.Icon = global::BudgetPlanner.Properties.Resources.Misc_Misc_Box_icon;
            this.btnGrocery.Location = new System.Drawing.Point(183, 32);
            this.btnGrocery.Name = "btnGrocery";
            this.btnGrocery.Size = new System.Drawing.Size(50, 39);
            this.btnGrocery.TabIndex = 45;
            this.btnGrocery.Click += new System.EventHandler(this.btnGrocery_Click);
            // 
            // btnAccess
            // 
            this.btnAccess.AnimationSpeed = 5;
            this.btnAccess.BackColor = System.Drawing.Color.Transparent;
            this.btnAccess.BackgroundOpacity = 100;
            this.btnAccess.BackgroundOpacity_MouseDown = 170;
            this.btnAccess.BorderColor = System.Drawing.Color.White;
            this.btnAccess.BorderOpacity = 170;
            this.btnAccess.BorderWidth = 1;
            this.btnAccess.ControlText = "";
            this.btnAccess.CornerRadius = 12;
            this.btnAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccess.DrawBlackTextBackground = true;
            this.btnAccess.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnAccess.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccess.ForeColor = System.Drawing.Color.DimGray;
            this.btnAccess.Icon = global::BudgetPlanner.Properties.Resources.things_icon;
            this.btnAccess.Location = new System.Drawing.Point(124, 32);
            this.btnAccess.Name = "btnAccess";
            this.btnAccess.Size = new System.Drawing.Size(50, 39);
            this.btnAccess.TabIndex = 44;
            this.btnAccess.Click += new System.EventHandler(this.btnAccess_Click);
            // 
            // btnBill
            // 
            this.btnBill.AnimationSpeed = 5;
            this.btnBill.BackColor = System.Drawing.Color.Transparent;
            this.btnBill.BackgroundOpacity = 100;
            this.btnBill.BackgroundOpacity_MouseDown = 170;
            this.btnBill.BorderColor = System.Drawing.Color.White;
            this.btnBill.BorderOpacity = 170;
            this.btnBill.BorderWidth = 1;
            this.btnBill.ControlText = "";
            this.btnBill.CornerRadius = 12;
            this.btnBill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBill.DrawBlackTextBackground = true;
            this.btnBill.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnBill.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.DimGray;
            this.btnBill.Icon = global::BudgetPlanner.Properties.Resources.Device_Dont_tell_Bill_icon;
            this.btnBill.Location = new System.Drawing.Point(68, 32);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(50, 39);
            this.btnBill.TabIndex = 43;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnFood
            // 
            this.btnFood.AnimationSpeed = 5;
            this.btnFood.BackColor = System.Drawing.Color.Transparent;
            this.btnFood.BackgroundOpacity = 100;
            this.btnFood.BackgroundOpacity_MouseDown = 170;
            this.btnFood.BorderColor = System.Drawing.Color.White;
            this.btnFood.BorderOpacity = 170;
            this.btnFood.BorderWidth = 1;
            this.btnFood.ControlText = "";
            this.btnFood.CornerRadius = 12;
            this.btnFood.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFood.DrawBlackTextBackground = true;
            this.btnFood.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnFood.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFood.ForeColor = System.Drawing.Color.DimGray;
            this.btnFood.Icon = global::BudgetPlanner.Properties.Resources.Fruits_Persimmon_icon;
            this.btnFood.Location = new System.Drawing.Point(9, 32);
            this.btnFood.Name = "btnFood";
            this.btnFood.Size = new System.Drawing.Size(50, 39);
            this.btnFood.TabIndex = 42;
            this.btnFood.Click += new System.EventHandler(this.btnFood_Click);
            // 
            // chkMonth
            // 
            this.chkMonth.AutoSize = true;
            this.chkMonth.BackColor = System.Drawing.Color.Transparent;
            this.chkMonth.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMonth.ForeColor = System.Drawing.Color.DimGray;
            this.chkMonth.Location = new System.Drawing.Point(54, 53);
            this.chkMonth.Name = "chkMonth";
            this.chkMonth.Size = new System.Drawing.Size(63, 19);
            this.chkMonth.TabIndex = 61;
            this.chkMonth.Text = "Month";
            this.chkMonth.UseVisualStyleBackColor = false;
            this.chkMonth.CheckedChanged += new System.EventHandler(this.chkMonth_CheckedChanged);
            // 
            // chkYear
            // 
            this.chkYear.AutoSize = true;
            this.chkYear.BackColor = System.Drawing.Color.Transparent;
            this.chkYear.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkYear.ForeColor = System.Drawing.Color.DimGray;
            this.chkYear.Location = new System.Drawing.Point(124, 53);
            this.chkYear.Name = "chkYear";
            this.chkYear.Size = new System.Drawing.Size(50, 19);
            this.chkYear.TabIndex = 62;
            this.chkYear.Text = "Year";
            this.chkYear.UseVisualStyleBackColor = false;
            this.chkYear.CheckedChanged += new System.EventHandler(this.chkYear_CheckedChanged);
            // 
            // chkDay
            // 
            this.chkDay.AutoSize = true;
            this.chkDay.BackColor = System.Drawing.Color.Transparent;
            this.chkDay.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkDay.ForeColor = System.Drawing.Color.DimGray;
            this.chkDay.Location = new System.Drawing.Point(180, 53);
            this.chkDay.Name = "chkDay";
            this.chkDay.Size = new System.Drawing.Size(46, 19);
            this.chkDay.TabIndex = 63;
            this.chkDay.Text = "Day";
            this.chkDay.UseVisualStyleBackColor = false;
            this.chkDay.CheckedChanged += new System.EventHandler(this.chkDay_CheckedChanged);
            // 
            // grpPersonal
            // 
            this.grpPersonal.AnimationEnabled = true;
            this.grpPersonal.AnimationSpeed = 4;
            this.grpPersonal.BackColor = System.Drawing.Color.Transparent;
            this.grpPersonal.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpPersonal.BorderColor = System.Drawing.Color.DimGray;
            this.grpPersonal.BorderWidth = 1F;
            this.grpPersonal.Controls.Add(this.cloudDesktopButton3);
            this.grpPersonal.Controls.Add(this.cloudDesktopButton4);
            this.grpPersonal.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpPersonal.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpPersonal.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpPersonal.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpPersonal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpPersonal.FontColorMouseOn = System.Drawing.Color.DimGray;
            this.grpPersonal.FontColorNormal = System.Drawing.Color.DimGray;
            this.grpPersonal.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpPersonal.HeaderCenter = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpPersonal.HeaderText = "       Personal";
            this.grpPersonal.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpPersonal.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left;
            this.grpPersonal.IconPadding = 5;
            this.grpPersonal.ImageHeader = false;
            this.grpPersonal.IsOpen = true;
            this.grpPersonal.Location = new System.Drawing.Point(265, 298);
            this.grpPersonal.MaximumHeight = 77;
            this.grpPersonal.Name = "grpPersonal";
            this.grpPersonal.PanelColor = System.Drawing.Color.DimGray;
            this.grpPersonal.Size = new System.Drawing.Size(132, 72);
            this.grpPersonal.TabIndex = 66;
            // 
            // cloudDesktopButton3
            // 
            this.cloudDesktopButton3.AnimationSpeed = 5;
            this.cloudDesktopButton3.BackColor = System.Drawing.Color.Transparent;
            this.cloudDesktopButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloudDesktopButton3.BackgroundImage")));
            this.cloudDesktopButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudDesktopButton3.BackgroundOpacity = 100;
            this.cloudDesktopButton3.BackgroundOpacity_MouseDown = 170;
            this.cloudDesktopButton3.BorderColor = System.Drawing.Color.White;
            this.cloudDesktopButton3.BorderOpacity = 170;
            this.cloudDesktopButton3.BorderWidth = 1;
            this.cloudDesktopButton3.ControlText = "";
            this.cloudDesktopButton3.CornerRadius = 12;
            this.cloudDesktopButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloudDesktopButton3.DrawBlackTextBackground = true;
            this.cloudDesktopButton3.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.cloudDesktopButton3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudDesktopButton3.ForeColor = System.Drawing.Color.DimGray;
            this.cloudDesktopButton3.Icon = null;
            this.cloudDesktopButton3.Location = new System.Drawing.Point(79, 30);
            this.cloudDesktopButton3.Name = "cloudDesktopButton3";
            this.cloudDesktopButton3.Size = new System.Drawing.Size(50, 39);
            this.cloudDesktopButton3.TabIndex = 43;
            this.cloudDesktopButton3.Click += new System.EventHandler(this.cloudDesktopButton3_Click);
            // 
            // cloudDesktopButton4
            // 
            this.cloudDesktopButton4.AnimationSpeed = 5;
            this.cloudDesktopButton4.BackColor = System.Drawing.Color.Transparent;
            this.cloudDesktopButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cloudDesktopButton4.BackgroundImage")));
            this.cloudDesktopButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cloudDesktopButton4.BackgroundOpacity = 100;
            this.cloudDesktopButton4.BackgroundOpacity_MouseDown = 170;
            this.cloudDesktopButton4.BorderColor = System.Drawing.Color.White;
            this.cloudDesktopButton4.BorderOpacity = 170;
            this.cloudDesktopButton4.BorderWidth = 1;
            this.cloudDesktopButton4.ControlText = "";
            this.cloudDesktopButton4.CornerRadius = 12;
            this.cloudDesktopButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cloudDesktopButton4.DrawBlackTextBackground = true;
            this.cloudDesktopButton4.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.cloudDesktopButton4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cloudDesktopButton4.ForeColor = System.Drawing.Color.DimGray;
            this.cloudDesktopButton4.Icon = null;
            this.cloudDesktopButton4.Location = new System.Drawing.Point(9, 32);
            this.cloudDesktopButton4.Name = "cloudDesktopButton4";
            this.cloudDesktopButton4.Size = new System.Drawing.Size(50, 39);
            this.cloudDesktopButton4.TabIndex = 42;
            this.cloudDesktopButton4.Click += new System.EventHandler(this.cloudDesktopButton4_Click);
            // 
            // frmViewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(569, 382);
            this.Controls.Add(this.grpPersonal);
            this.Controls.Add(this.grpHome);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.dgvInfo);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmViewDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Budget Details";
            this.Load += new System.EventHandler(this.frmViewDetails_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfo)).EndInit();
            this.grpHome.ResumeLayout(false);
            this.grpPersonal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private CloudToolkitN6.CloudGroup grpCategory;
        private System.Windows.Forms.DataGridView dgvInfo;
        private CloudToolkitN6.CloudDesktopButton btnDone;
        private System.Windows.Forms.CheckBox chkAll;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnPersonal;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnHome;
        private CloudToolkitN6.CloudDesktopButton btnSearch;
        private CloudToolkitN6.CloudGroup grpHome;
        private CloudToolkitN6.CloudDesktopButton btnGrocery;
        private CloudToolkitN6.CloudDesktopButton btnAccess;
        private CloudToolkitN6.CloudDesktopButton btnBill;
        private CloudToolkitN6.CloudDesktopButton btnFood;
        private System.Windows.Forms.CheckBox chkDay;
        private System.Windows.Forms.CheckBox chkYear;
        private System.Windows.Forms.CheckBox chkMonth;
        private CloudToolkitN6.CloudGroup grpPersonal;
        private CloudToolkitN6.CloudDesktopButton cloudDesktopButton4;
        private CloudToolkitN6.CloudDesktopButton cloudDesktopButton3;
    }
}