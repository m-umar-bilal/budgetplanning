namespace BudgetPlanner.View
{
    partial class frmExportData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExportData));
            this.btnBrowseFiles = new CloudToolkitN6.CloudDesktopButton();
            this.rdbCSVFormat = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbExcelFile = new System.Windows.Forms.RadioButton();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.grpExportFormats = new System.Windows.Forms.GroupBox();
            this.btnOk = new CloudToolkitN6.CloudDesktopButton();
            this.btnCancel = new CloudToolkitN6.CloudDesktopButton();
            this.grpCategory = new CloudToolkitN6.CloudGroup();
            this.btnPersonal = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.btnHome = new CloudToolkitN6.Windows.Vista.CloudStartMenuButton();
            this.grpExportFormats.SuspendLayout();
            this.grpCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBrowseFiles
            // 
            this.btnBrowseFiles.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBrowseFiles.AnimationSpeed = 5;
            this.btnBrowseFiles.BackColor = System.Drawing.Color.Transparent;
            this.btnBrowseFiles.BackgroundOpacity = 100;
            this.btnBrowseFiles.BackgroundOpacity_MouseDown = 170;
            this.btnBrowseFiles.BorderColor = System.Drawing.Color.White;
            this.btnBrowseFiles.BorderOpacity = 170;
            this.btnBrowseFiles.BorderWidth = 1;
            this.btnBrowseFiles.ControlText = "";
            this.btnBrowseFiles.CornerRadius = 12;
            this.btnBrowseFiles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowseFiles.DrawBlackTextBackground = true;
            this.btnBrowseFiles.FillColor = System.Drawing.Color.Azure;
            this.btnBrowseFiles.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseFiles.ForeColor = System.Drawing.Color.White;
            this.btnBrowseFiles.Icon = global::BudgetPlanner.Properties.Resources.Open;
            this.btnBrowseFiles.Location = new System.Drawing.Point(445, 15);
            this.btnBrowseFiles.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBrowseFiles.Name = "btnBrowseFiles";
            this.btnBrowseFiles.Size = new System.Drawing.Size(39, 38);
            this.btnBrowseFiles.TabIndex = 52;
            this.btnBrowseFiles.Click += new System.EventHandler(this.btnBrowseFiles_Click);
            // 
            // rdbCSVFormat
            // 
            this.rdbCSVFormat.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbCSVFormat.AutoSize = true;
            this.rdbCSVFormat.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCSVFormat.Location = new System.Drawing.Point(14, 22);
            this.rdbCSVFormat.Name = "rdbCSVFormat";
            this.rdbCSVFormat.Size = new System.Drawing.Size(175, 19);
            this.rdbCSVFormat.TabIndex = 12;
            this.rdbCSVFormat.TabStop = true;
            this.rdbCSVFormat.Text = "&.CSV Comma Separated File";
            this.rdbCSVFormat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(5, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 15);
            this.label2.TabIndex = 57;
            this.label2.Text = "&Export File Path:";
            // 
            // rdbExcelFile
            // 
            this.rdbExcelFile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rdbExcelFile.AutoSize = true;
            this.rdbExcelFile.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbExcelFile.Location = new System.Drawing.Point(14, 46);
            this.rdbExcelFile.Name = "rdbExcelFile";
            this.rdbExcelFile.Size = new System.Drawing.Size(102, 19);
            this.rdbExcelFile.TabIndex = 13;
            this.rdbExcelFile.TabStop = true;
            this.rdbExcelFile.Text = "&To Excel Sheet";
            this.rdbExcelFile.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPath.Enabled = false;
            this.txtPath.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(8, 28);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(431, 23);
            this.txtPath.TabIndex = 51;
            // 
            // grpExportFormats
            // 
            this.grpExportFormats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grpExportFormats.Controls.Add(this.rdbExcelFile);
            this.grpExportFormats.Controls.Add(this.rdbCSVFormat);
            this.grpExportFormats.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExportFormats.Location = new System.Drawing.Point(271, 58);
            this.grpExportFormats.Name = "grpExportFormats";
            this.grpExportFormats.Size = new System.Drawing.Size(213, 75);
            this.grpExportFormats.TabIndex = 55;
            this.grpExportFormats.TabStop = false;
            this.grpExportFormats.Text = "&Export Formats";
            // 
            // btnOk
            // 
            this.btnOk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnOk.AnimationSpeed = 5;
            this.btnOk.BackColor = System.Drawing.Color.Transparent;
            this.btnOk.BackgroundOpacity = 100;
            this.btnOk.BackgroundOpacity_MouseDown = 170;
            this.btnOk.BorderColor = System.Drawing.Color.White;
            this.btnOk.BorderOpacity = 170;
            this.btnOk.BorderWidth = 1;
            this.btnOk.ControlText = "Ok";
            this.btnOk.CornerRadius = 12;
            this.btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOk.DrawBlackTextBackground = true;
            this.btnOk.FillColor = System.Drawing.Color.Azure;
            this.btnOk.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.ForeColor = System.Drawing.Color.White;
            this.btnOk.Icon = global::BudgetPlanner.Properties.Resources.Check_icon;
            this.btnOk.Location = new System.Drawing.Point(300, 144);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 74);
            this.btnOk.TabIndex = 53;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btnCancel.Location = new System.Drawing.Point(398, 144);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 74);
            this.btnCancel.TabIndex = 54;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpCategory
            // 
            this.grpCategory.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.grpCategory.Location = new System.Drawing.Point(7, 60);
            this.grpCategory.MaximumHeight = 77;
            this.grpCategory.Name = "grpCategory";
            this.grpCategory.PanelColor = System.Drawing.Color.DimGray;
            this.grpCategory.Size = new System.Drawing.Size(258, 75);
            this.grpCategory.TabIndex = 58;
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
            // frmExportData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(496, 231);
            this.Controls.Add(this.grpCategory);
            this.Controls.Add(this.btnBrowseFiles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.grpExportFormats);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmExportData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Export Data";
            this.Load += new System.EventHandler(this.frmExportData_Load);
            this.grpExportFormats.ResumeLayout(false);
            this.grpExportFormats.PerformLayout();
            this.grpCategory.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CloudToolkitN6.CloudDesktopButton btnBrowseFiles;
        private System.Windows.Forms.RadioButton rdbCSVFormat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbExcelFile;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.GroupBox grpExportFormats;
        private CloudToolkitN6.CloudDesktopButton btnOk;
        private CloudToolkitN6.CloudDesktopButton btnCancel;
        private CloudToolkitN6.CloudGroup grpCategory;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnPersonal;
        private CloudToolkitN6.Windows.Vista.CloudStartMenuButton btnHome;
    }
}