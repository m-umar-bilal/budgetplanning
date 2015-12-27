namespace BudgetPlanner.View
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnLogout = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.pnlAmount = new System.Windows.Forms.Panel();
            this.btnEditAmount = new CloudToolkitN6.CloudDesktopButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.grpData = new CloudToolkitN6.CloudGroup();
            this.btnExport = new CloudToolkitN6.CloudDesktopButton();
            this.grpCategory = new CloudToolkitN6.CloudGroup();
            this.btnPersonal = new CloudToolkitN6.CloudDesktopButton();
            this.btnHome = new CloudToolkitN6.CloudDesktopButton();
            this.picBoxGender = new System.Windows.Forms.PictureBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnCalc = new CloudToolkitN6.CloudDesktopButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnCategory = new CloudToolkitN6.CloudDesktopButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCreateUser = new CloudToolkitN6.CloudDesktopButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnEditDetails = new CloudToolkitN6.CloudDesktopButton();
            this.btnView = new CloudToolkitN6.CloudDesktopButton();
            this.digitalClock = new CloudToolkitN6.CloudDigitalClock();
            this.pnlAmount.SuspendLayout();
            this.grpData.SuspendLayout();
            this.grpCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGender)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.AnimationOpacityChange = 0.1D;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.ButtonText = "Logout";
            this.btnLogout.ClickedColors_1 = System.Drawing.Color.DimGray;
            this.btnLogout.ClickedColors_2 = System.Drawing.Color.DimGray;
            this.btnLogout.ClickedColors_3 = System.Drawing.Color.DimGray;
            this.btnLogout.ClickedColors_4 = System.Drawing.Color.DimGray;
            this.btnLogout.ControlOpacity = 255;
            this.btnLogout.CornerRadius = 8;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.DrawHoverOverIcon = false;
            this.btnLogout.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.DimGray;
            this.btnLogout.GlowColor = System.Drawing.Color.DimGray;
            this.btnLogout.Icon = global::BudgetPlanner.Properties.Resources.Log_Out_icon;
            this.btnLogout.IsAnimated = true;
            this.btnLogout.Location = new System.Drawing.Point(213, -1);
            this.btnLogout.MaximumGlowOpacity = 0.8D;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.NormalColors_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnLogout.NormalColors_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnLogout.NormalColors_3 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnLogout.NormalColors_4 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.btnLogout.Size = new System.Drawing.Size(112, 25);
            this.btnLogout.StartMenuIndex = 0;
            this.btnLogout.TabIndex = 60;
            this.btnLogout.TextCentered = true;
            this.btnLogout.TextDistanceFromBorder = 5;
            this.btnLogout.TextIconRelation = CloudToolkitN6.Windows.Vista.CloudStartMenuButton.TextIconRelation_Enum.TextOverIcon;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pnlAmount
            // 
            this.pnlAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlAmount.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.pnlAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlAmount.Controls.Add(this.btnEditAmount);
            this.pnlAmount.Controls.Add(this.label1);
            this.pnlAmount.Controls.Add(this.lblAmount);
            this.pnlAmount.Location = new System.Drawing.Point(576, 432);
            this.pnlAmount.Name = "pnlAmount";
            this.pnlAmount.Size = new System.Drawing.Size(129, 46);
            this.pnlAmount.TabIndex = 48;
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
            this.btnEditAmount.Location = new System.Drawing.Point(94, 3);
            this.btnEditAmount.Name = "btnEditAmount";
            this.btnEditAmount.Size = new System.Drawing.Size(31, 31);
            this.btnEditAmount.TabIndex = 49;
            this.btnEditAmount.Click += new System.EventHandler(this.btnEditAmount_Click);
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
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lblAmount.Location = new System.Drawing.Point(37, 18);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(50, 18);
            this.lblAmount.TabIndex = 46;
            this.lblAmount.Text = "______";
            // 
            // grpData
            // 
            this.grpData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpData.AnimationEnabled = true;
            this.grpData.AnimationSpeed = 5;
            this.grpData.BackColor = System.Drawing.Color.Transparent;
            this.grpData.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpData.BorderColor = System.Drawing.Color.DarkGray;
            this.grpData.BorderWidth = 1F;
            this.grpData.Controls.Add(this.btnExport);
            this.grpData.FillColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpData.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpData.FillColor2_1 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpData.FillColor2_2 = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(222)))), ((int)(((byte)(241)))));
            this.grpData.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpData.FontColorMouseOn = System.Drawing.Color.DimGray;
            this.grpData.FontColorNormal = System.Drawing.Color.DimGray;
            this.grpData.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.grpData.HeaderCenter = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpData.HeaderText = "";
            this.grpData.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpData.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Center;
            this.grpData.IconPadding = 5;
            this.grpData.ImageHeader = false;
            this.grpData.IsOpen = true;
            this.grpData.Location = new System.Drawing.Point(634, 95);
            this.grpData.MaximumHeight = 73;
            this.grpData.Name = "grpData";
            this.grpData.PanelColor = System.Drawing.Color.DimGray;
            this.grpData.Size = new System.Drawing.Size(60, 73);
            this.grpData.TabIndex = 40;
            // 
            // btnExport
            // 
            this.btnExport.AnimationSpeed = 5;
            this.btnExport.BackColor = System.Drawing.Color.Transparent;
            this.btnExport.BackgroundOpacity = 100;
            this.btnExport.BackgroundOpacity_MouseDown = 170;
            this.btnExport.BorderColor = System.Drawing.Color.White;
            this.btnExport.BorderOpacity = 170;
            this.btnExport.BorderWidth = 1;
            this.btnExport.ControlText = "";
            this.btnExport.CornerRadius = 12;
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.DrawBlackTextBackground = true;
            this.btnExport.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnExport.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.DimGray;
            this.btnExport.Icon = global::BudgetPlanner.Properties.Resources.Upload_icon;
            this.btnExport.Location = new System.Drawing.Point(5, 30);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(50, 39);
            this.btnExport.TabIndex = 40;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.AnimationEnabled = true;
            this.grpCategory.AnimationSpeed = 4;
            this.grpCategory.BackColor = System.Drawing.Color.Transparent;
            this.grpCategory.BackgroundImage = global::BudgetPlanner.Properties.Resources.straight_grey_plain_design_1;
            this.grpCategory.BorderColor = System.Drawing.Color.DarkGray;
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
            this.grpCategory.HeaderText = "      Category";
            this.grpCategory.Icon = global::BudgetPlanner.Properties.Resources.navigate_down_icon;
            this.grpCategory.IconAlign = CloudToolkitN6.CloudHeader.IconAlignement.Left;
            this.grpCategory.IconPadding = 5;
            this.grpCategory.ImageHeader = false;
            this.grpCategory.IsOpen = true;
            this.grpCategory.Location = new System.Drawing.Point(94, 108);
            this.grpCategory.MaximumHeight = 73;
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.PanelColor = System.Drawing.Color.DimGray;
            this.grpCategory.Size = new System.Drawing.Size(119, 73);
            this.grpCategory.TabIndex = 39;
            // 
            // btnPersonal
            // 
            this.btnPersonal.AnimationSpeed = 5;
            this.btnPersonal.BackColor = System.Drawing.Color.Transparent;
            this.btnPersonal.BackgroundOpacity = 100;
            this.btnPersonal.BackgroundOpacity_MouseDown = 170;
            this.btnPersonal.BorderColor = System.Drawing.Color.White;
            this.btnPersonal.BorderOpacity = 170;
            this.btnPersonal.BorderWidth = 1;
            this.btnPersonal.ControlText = "";
            this.btnPersonal.CornerRadius = 12;
            this.btnPersonal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPersonal.DrawBlackTextBackground = true;
            this.btnPersonal.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPersonal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonal.ForeColor = System.Drawing.Color.DimGray;
            this.btnPersonal.Icon = global::BudgetPlanner.Properties.Resources.man_icon;
            this.btnPersonal.Location = new System.Drawing.Point(66, 30);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(50, 39);
            this.btnPersonal.TabIndex = 41;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnHome
            // 
            this.btnHome.AnimationSpeed = 5;
            this.btnHome.BackColor = System.Drawing.Color.Transparent;
            this.btnHome.BackgroundOpacity = 100;
            this.btnHome.BackgroundOpacity_MouseDown = 170;
            this.btnHome.BorderColor = System.Drawing.Color.White;
            this.btnHome.BorderOpacity = 170;
            this.btnHome.BorderWidth = 1;
            this.btnHome.ControlText = "";
            this.btnHome.CornerRadius = 12;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.DrawBlackTextBackground = true;
            this.btnHome.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnHome.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.DimGray;
            this.btnHome.Icon = global::BudgetPlanner.Properties.Resources.Actions_go_home_icon;
            this.btnHome.Location = new System.Drawing.Point(7, 30);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(50, 39);
            this.btnHome.TabIndex = 40;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // picBoxGender
            // 
            this.picBoxGender.BackColor = System.Drawing.Color.Transparent;
            this.picBoxGender.BackgroundImage = global::BudgetPlanner.Properties.Resources.Bin_Empty_icon;
            this.picBoxGender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picBoxGender.InitialImage = null;
            this.picBoxGender.Location = new System.Drawing.Point(12, 51);
            this.picBoxGender.Name = "picBoxGender";
            this.picBoxGender.Size = new System.Drawing.Size(50, 38);
            this.picBoxGender.TabIndex = 38;
            this.picBoxGender.TabStop = false;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.BackColor = System.Drawing.Color.Transparent;
            this.lblUserName.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUserName.Location = new System.Drawing.Point(142, 57);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(109, 23);
            this.lblUserName.TabIndex = 34;
            this.lblUserName.Text = "___________";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblWelcome.Location = new System.Drawing.Point(66, 61);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(84, 19);
            this.lblWelcome.TabIndex = 33;
            this.lblWelcome.Text = "&Welcome , ";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 12);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip
            // 
            this.menuStrip.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.menuStrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(203, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.Close_2_icon;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.personalToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.settingsToolStripMenuItem.Text = "&Category";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.Actions_go_home_icon;
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.man_icon;
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.personalToolStripMenuItem.Text = "Personal";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportDataToolStripMenuItem,
            this.viewBudgetToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // exportDataToolStripMenuItem
            // 
            this.exportDataToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.Upload_icon;
            this.exportDataToolStripMenuItem.Name = "exportDataToolStripMenuItem";
            this.exportDataToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.exportDataToolStripMenuItem.Text = "Export Data";
            this.exportDataToolStripMenuItem.Click += new System.EventHandler(this.exportDataToolStripMenuItem_Click);
            // 
            // viewBudgetToolStripMenuItem
            // 
            this.viewBudgetToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.Actions_contact_date_icon;
            this.viewBudgetToolStripMenuItem.Name = "viewBudgetToolStripMenuItem";
            this.viewBudgetToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.viewBudgetToolStripMenuItem.Text = "View Budget";
            this.viewBudgetToolStripMenuItem.Click += new System.EventHandler(this.viewBudgetToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::BudgetPlanner.Properties.Resources.Bin_Empty_icon;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackgroundImage = global::BudgetPlanner.Properties.Resources.images;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnCalc);
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.btnCategory);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.btnCreateUser);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.btnEditDetails);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Location = new System.Drawing.Point(12, 108);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(82, 462);
            this.panel2.TabIndex = 36;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackgroundImage = global::BudgetPlanner.Properties.Resources.light_grey_stippled;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(-3, 414);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(85, 10);
            this.panel3.TabIndex = 42;
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
            this.btnCalc.ForeColor = System.Drawing.Color.DimGray;
            this.btnCalc.Icon = global::BudgetPlanner.Properties.Resources.calculator_icon;
            this.btnCalc.Location = new System.Drawing.Point(0, 340);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(78, 72);
            this.btnCalc.TabIndex = 41;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.BackgroundImage = global::BudgetPlanner.Properties.Resources.light_grey_stippled;
            this.panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel7.Location = new System.Drawing.Point(-1, 73);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(86, 10);
            this.panel7.TabIndex = 40;
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.BackgroundImage = global::BudgetPlanner.Properties.Resources.light_grey_stippled;
            this.panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel6.Location = new System.Drawing.Point(-2, 328);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(85, 10);
            this.panel6.TabIndex = 39;
            // 
            // btnCategory
            // 
            this.btnCategory.AnimationSpeed = 5;
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.BackgroundOpacity = 100;
            this.btnCategory.BackgroundOpacity_MouseDown = 170;
            this.btnCategory.BorderColor = System.Drawing.Color.White;
            this.btnCategory.BorderOpacity = 170;
            this.btnCategory.BorderWidth = 1;
            this.btnCategory.ControlText = "Category";
            this.btnCategory.CornerRadius = 12;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.DrawBlackTextBackground = true;
            this.btnCategory.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCategory.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategory.ForeColor = System.Drawing.Color.DimGray;
            this.btnCategory.Icon = global::BudgetPlanner.Properties.Resources._1322904316_Department;
            this.btnCategory.Location = new System.Drawing.Point(0, -1);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(80, 72);
            this.btnCategory.TabIndex = 39;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.BackgroundImage = global::BudgetPlanner.Properties.Resources.light_grey_stippled;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Location = new System.Drawing.Point(-2, 242);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(86, 10);
            this.panel5.TabIndex = 39;
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.AnimationSpeed = 5;
            this.btnCreateUser.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateUser.BackgroundOpacity = 100;
            this.btnCreateUser.BackgroundOpacity_MouseDown = 170;
            this.btnCreateUser.BorderColor = System.Drawing.Color.White;
            this.btnCreateUser.BorderOpacity = 170;
            this.btnCreateUser.BorderWidth = 1;
            this.btnCreateUser.ControlText = "Create User";
            this.btnCreateUser.CornerRadius = 12;
            this.btnCreateUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateUser.DrawBlackTextBackground = true;
            this.btnCreateUser.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnCreateUser.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateUser.ForeColor = System.Drawing.Color.DimGray;
            this.btnCreateUser.Icon = global::BudgetPlanner.Properties.Resources._1322905735_user_group_new;
            this.btnCreateUser.Location = new System.Drawing.Point(1, 254);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(78, 72);
            this.btnCreateUser.TabIndex = 38;
            this.btnCreateUser.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackgroundImage = global::BudgetPlanner.Properties.Resources.light_grey_stippled;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Location = new System.Drawing.Point(-3, 159);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(86, 10);
            this.panel4.TabIndex = 39;
            // 
            // btnEditDetails
            // 
            this.btnEditDetails.AnimationSpeed = 5;
            this.btnEditDetails.BackColor = System.Drawing.Color.Transparent;
            this.btnEditDetails.BackgroundOpacity = 100;
            this.btnEditDetails.BackgroundOpacity_MouseDown = 170;
            this.btnEditDetails.BorderColor = System.Drawing.Color.White;
            this.btnEditDetails.BorderOpacity = 170;
            this.btnEditDetails.BorderWidth = 1;
            this.btnEditDetails.ControlText = "Edit Info";
            this.btnEditDetails.CornerRadius = 12;
            this.btnEditDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDetails.DrawBlackTextBackground = true;
            this.btnEditDetails.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnEditDetails.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDetails.ForeColor = System.Drawing.Color.DimGray;
            this.btnEditDetails.Icon = global::BudgetPlanner.Properties.Resources.Actions_document_edit_icon;
            this.btnEditDetails.Location = new System.Drawing.Point(0, 168);
            this.btnEditDetails.Name = "btnEditDetails";
            this.btnEditDetails.Size = new System.Drawing.Size(78, 72);
            this.btnEditDetails.TabIndex = 38;
            this.btnEditDetails.Click += new System.EventHandler(this.btnEditDetails_Click);
            // 
            // btnView
            // 
            this.btnView.AnimationSpeed = 5;
            this.btnView.BackColor = System.Drawing.Color.Transparent;
            this.btnView.BackgroundOpacity = 100;
            this.btnView.BackgroundOpacity_MouseDown = 170;
            this.btnView.BorderColor = System.Drawing.Color.White;
            this.btnView.BorderOpacity = 170;
            this.btnView.BorderWidth = 1;
            this.btnView.ControlText = "View";
            this.btnView.CornerRadius = 12;
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.DrawBlackTextBackground = true;
            this.btnView.FillColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnView.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.DimGray;
            this.btnView.Icon = global::BudgetPlanner.Properties.Resources.Actions_contact_date_icon;
            this.btnView.Location = new System.Drawing.Point(0, 85);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(78, 72);
            this.btnView.TabIndex = 38;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // digitalClock
            // 
            this.digitalClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.digitalClock.BackColor = System.Drawing.Color.Transparent;
            this.digitalClock.ColorLower_1 = System.Drawing.Color.Transparent;
            this.digitalClock.ColorLower_2 = System.Drawing.Color.Transparent;
            this.digitalClock.ColorUpper_1 = System.Drawing.Color.Transparent;
            this.digitalClock.ColorUpper_2 = System.Drawing.Color.Transparent;
            this.digitalClock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.digitalClock.DateColor = System.Drawing.Color.White;
            this.digitalClock.DateFont = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock.DrawDate = true;
            this.digitalClock.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock.Location = new System.Drawing.Point(543, 19);
            this.digitalClock.Name = "digitalClock";
            this.digitalClock.NumberColor = System.Drawing.Color.White;
            this.digitalClock.NumberFont = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digitalClock.Size = new System.Drawing.Size(151, 61);
            this.digitalClock.TabIndex = 35;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(707, 574);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.pnlAmount);
            this.Controls.Add(this.grpData);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.picBoxGender);
            this.Controls.Add(this.digitalClock);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Planner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlAmount.ResumeLayout(false);
            this.pnlAmount.PerformLayout();
            this.grpData.ResumeLayout(false);
            this.grpCategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxGender)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private CloudToolkitN6.CloudDesktopButton btnEditDetails;
        private CloudToolkitN6.CloudDesktopButton btnView;
        private System.Windows.Forms.Panel panel6;
        private CloudToolkitN6.CloudDesktopButton btnCreateUser;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBoxGender;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.Panel panel7;
        private CloudToolkitN6.CloudDesktopButton btnCategory;
        private CloudToolkitN6.CloudGroup grpCategory;
        private CloudToolkitN6.CloudDesktopButton btnHome;
        private CloudToolkitN6.CloudDesktopButton btnPersonal;
        private CloudToolkitN6.CloudGroup grpData;
        private CloudToolkitN6.CloudDesktopButton btnExport;
        private System.Windows.Forms.Panel panel3;
        private CloudToolkitN6.CloudDesktopButton btnCalc;
        private System.Windows.Forms.Panel pnlAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label label1;
        private CloudToolkitN6.CloudDesktopButton btnEditAmount;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnLogout;
        private System.Windows.Forms.ToolStripMenuItem exportDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBudgetToolStripMenuItem;
        private CloudToolkitN6.CloudDigitalClock digitalClock;
    }
}