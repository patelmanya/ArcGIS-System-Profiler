namespace ArcGIS_System_Profiler
{
    partial class SystemVerification
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxVersion = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.btn_PerformSysValidations = new System.Windows.Forms.Button();
            this.btn_NextStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblDiskSpace1 = new System.Windows.Forms.Label();
            this.lblDiskSpaceTitle = new System.Windows.Forms.Label();
            this.lblMemory = new System.Windows.Forms.Label();
            this.lblProcessorType = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOperatingSystem = new System.Windows.Forms.Label();
            this.statusOS = new FontAwesome.Sharp.IconPictureBox();
            this.statusProcessor = new FontAwesome.Sharp.IconPictureBox();
            this.statusMemory = new FontAwesome.Sharp.IconPictureBox();
            this.statusDiskSpace = new FontAwesome.Sharp.IconPictureBox();
            this.lblDiskSpace2 = new System.Windows.Forms.Label();
            this.lblMachineName = new System.Windows.Forms.Label();
            this.lblInternetAccess = new System.Windows.Forms.Label();
            this.statusDiskSpace1 = new FontAwesome.Sharp.IconPictureBox();
            this.statusDiskSpace2 = new FontAwesome.Sharp.IconPictureBox();
            this.statusMachineName = new FontAwesome.Sharp.IconPictureBox();
            this.statusInternetAccess = new FontAwesome.Sharp.IconPictureBox();
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusProcessor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMemory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMachineName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInternetAccess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.comboBoxVersion);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.comboBoxProduct);
            this.panel1.Controls.Add(this.btn_PerformSysValidations);
            this.panel1.Controls.Add(this.btn_NextStep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 102);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(443, 42);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.label5.Size = new System.Drawing.Size(163, 42);
            this.label5.TabIndex = 38;
            this.label5.Text = "Select Product:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxVersion
            // 
            this.comboBoxVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxVersion.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxVersion.FormattingEnabled = true;
            this.comboBoxVersion.Location = new System.Drawing.Point(612, 54);
            this.comboBoxVersion.Name = "comboBoxVersion";
            this.comboBoxVersion.Size = new System.Drawing.Size(84, 26);
            this.comboBoxVersion.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 42);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.label4.Size = new System.Drawing.Size(163, 42);
            this.label4.TabIndex = 36;
            this.label4.Text = "Select Product:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxProduct.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(169, 54);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(268, 26);
            this.comboBoxProduct.TabIndex = 35;
            // 
            // btn_PerformSysValidations
            // 
            this.btn_PerformSysValidations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PerformSysValidations.BackColor = System.Drawing.Color.LightGray;
            this.btn_PerformSysValidations.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformSysValidations.ForeColor = System.Drawing.Color.Black;
            this.btn_PerformSysValidations.Location = new System.Drawing.Point(760, 54);
            this.btn_PerformSysValidations.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PerformSysValidations.Name = "btn_PerformSysValidations";
            this.btn_PerformSysValidations.Size = new System.Drawing.Size(206, 33);
            this.btn_PerformSysValidations.TabIndex = 34;
            this.btn_PerformSysValidations.Text = "Perform System validation";
            this.btn_PerformSysValidations.UseVisualStyleBackColor = false;
            this.btn_PerformSysValidations.Click += new System.EventHandler(this.btn_PerformSysValidations_Click);
            // 
            // btn_NextStep
            // 
            this.btn_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextStep.BackColor = System.Drawing.Color.LightGray;
            this.btn_NextStep.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextStep.ForeColor = System.Drawing.Color.Black;
            this.btn_NextStep.Location = new System.Drawing.Point(990, 54);
            this.btn_NextStep.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NextStep.Name = "btn_NextStep";
            this.btn_NextStep.Size = new System.Drawing.Size(117, 33);
            this.btn_NextStep.TabIndex = 33;
            this.btn_NextStep.Text = "Next Step";
            this.btn_NextStep.UseVisualStyleBackColor = false;
            this.btn_NextStep.Click += new System.EventHandler(this.btn_NextStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(10, 20, 0, 0);
            this.label1.Size = new System.Drawing.Size(218, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "System requirements";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 102);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1122, 535);
            this.panelBody.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.lblDiskSpace1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblDiskSpaceTitle, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblMemory, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblProcessorType, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblOperatingSystem, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusOS, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.statusProcessor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.statusMemory, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.statusDiskSpace, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDiskSpace2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblMachineName, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.lblInternetAccess, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.statusDiskSpace1, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.statusDiskSpace2, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.statusMachineName, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.statusInternetAccess, 1, 8);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666668F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.666667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 535);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblDiskSpace1
            // 
            this.lblDiskSpace1.AutoSize = true;
            this.lblDiskSpace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiskSpace1.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDiskSpace1.ForeColor = System.Drawing.Color.White;
            this.lblDiskSpace1.Location = new System.Drawing.Point(4, 296);
            this.lblDiskSpace1.Name = "lblDiskSpace1";
            this.lblDiskSpace1.Size = new System.Drawing.Size(1001, 58);
            this.lblDiskSpace1.TabIndex = 41;
            this.lblDiskSpace1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDiskSpaceTitle
            // 
            this.lblDiskSpaceTitle.AutoSize = true;
            this.lblDiskSpaceTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiskSpaceTitle.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDiskSpaceTitle.ForeColor = System.Drawing.Color.White;
            this.lblDiskSpaceTitle.Location = new System.Drawing.Point(4, 237);
            this.lblDiskSpaceTitle.Name = "lblDiskSpaceTitle";
            this.lblDiskSpaceTitle.Size = new System.Drawing.Size(1001, 58);
            this.lblDiskSpaceTitle.TabIndex = 40;
            this.lblDiskSpaceTitle.Text = "Disk space: ";
            this.lblDiskSpaceTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMemory
            // 
            this.lblMemory.AutoSize = true;
            this.lblMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMemory.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMemory.ForeColor = System.Drawing.Color.White;
            this.lblMemory.Location = new System.Drawing.Point(4, 178);
            this.lblMemory.Name = "lblMemory";
            this.lblMemory.Size = new System.Drawing.Size(1001, 58);
            this.lblMemory.TabIndex = 39;
            this.lblMemory.Text = "RAM:";
            this.lblMemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblProcessorType
            // 
            this.lblProcessorType.AutoSize = true;
            this.lblProcessorType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblProcessorType.Font = new System.Drawing.Font("Arial", 12F);
            this.lblProcessorType.ForeColor = System.Drawing.Color.White;
            this.lblProcessorType.Location = new System.Drawing.Point(4, 119);
            this.lblProcessorType.Name = "lblProcessorType";
            this.lblProcessorType.Size = new System.Drawing.Size(1001, 58);
            this.lblProcessorType.TabIndex = 38;
            this.lblProcessorType.Text = "Processer type (Only 64-bit is supported): ";
            this.lblProcessorType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1001, 58);
            this.label2.TabIndex = 31;
            this.label2.Text = "Descriptions";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1012, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 58);
            this.label3.TabIndex = 32;
            this.label3.Text = "Status";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOperatingSystem
            // 
            this.lblOperatingSystem.AutoSize = true;
            this.lblOperatingSystem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOperatingSystem.Font = new System.Drawing.Font("Arial", 12F);
            this.lblOperatingSystem.ForeColor = System.Drawing.Color.White;
            this.lblOperatingSystem.Location = new System.Drawing.Point(4, 60);
            this.lblOperatingSystem.Name = "lblOperatingSystem";
            this.lblOperatingSystem.Size = new System.Drawing.Size(1001, 58);
            this.lblOperatingSystem.TabIndex = 33;
            this.lblOperatingSystem.Text = "Operating System";
            this.lblOperatingSystem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusOS
            // 
            this.statusOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusOS.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusOS.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusOS.IconColor = System.Drawing.Color.LawnGreen;
            this.statusOS.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusOS.IconSize = 52;
            this.statusOS.Location = new System.Drawing.Point(1059, 63);
            this.statusOS.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusOS.Name = "statusOS";
            this.statusOS.Size = new System.Drawing.Size(59, 52);
            this.statusOS.TabIndex = 34;
            this.statusOS.TabStop = false;
            this.statusOS.Visible = false;
            // 
            // statusProcessor
            // 
            this.statusProcessor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusProcessor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusProcessor.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusProcessor.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusProcessor.IconColor = System.Drawing.Color.LawnGreen;
            this.statusProcessor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusProcessor.IconSize = 52;
            this.statusProcessor.Location = new System.Drawing.Point(1059, 122);
            this.statusProcessor.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusProcessor.Name = "statusProcessor";
            this.statusProcessor.Size = new System.Drawing.Size(59, 52);
            this.statusProcessor.TabIndex = 35;
            this.statusProcessor.TabStop = false;
            this.statusProcessor.Visible = false;
            // 
            // statusMemory
            // 
            this.statusMemory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusMemory.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusMemory.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusMemory.IconColor = System.Drawing.Color.LawnGreen;
            this.statusMemory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusMemory.IconSize = 52;
            this.statusMemory.Location = new System.Drawing.Point(1059, 181);
            this.statusMemory.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusMemory.Name = "statusMemory";
            this.statusMemory.Size = new System.Drawing.Size(59, 52);
            this.statusMemory.TabIndex = 36;
            this.statusMemory.TabStop = false;
            this.statusMemory.Visible = false;
            // 
            // statusDiskSpace
            // 
            this.statusDiskSpace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusDiskSpace.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDiskSpace.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusDiskSpace.IconColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusDiskSpace.IconSize = 52;
            this.statusDiskSpace.Location = new System.Drawing.Point(1059, 240);
            this.statusDiskSpace.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusDiskSpace.Name = "statusDiskSpace";
            this.statusDiskSpace.Size = new System.Drawing.Size(59, 52);
            this.statusDiskSpace.TabIndex = 37;
            this.statusDiskSpace.TabStop = false;
            this.statusDiskSpace.Visible = false;
            // 
            // lblDiskSpace2
            // 
            this.lblDiskSpace2.AutoSize = true;
            this.lblDiskSpace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDiskSpace2.Font = new System.Drawing.Font("Arial", 12F);
            this.lblDiskSpace2.ForeColor = System.Drawing.Color.White;
            this.lblDiskSpace2.Location = new System.Drawing.Point(4, 355);
            this.lblDiskSpace2.Name = "lblDiskSpace2";
            this.lblDiskSpace2.Size = new System.Drawing.Size(1001, 58);
            this.lblDiskSpace2.TabIndex = 47;
            this.lblDiskSpace2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMachineName
            // 
            this.lblMachineName.AutoSize = true;
            this.lblMachineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMachineName.Font = new System.Drawing.Font("Arial", 12F);
            this.lblMachineName.ForeColor = System.Drawing.Color.White;
            this.lblMachineName.Location = new System.Drawing.Point(4, 414);
            this.lblMachineName.Name = "lblMachineName";
            this.lblMachineName.Size = new System.Drawing.Size(1001, 58);
            this.lblMachineName.TabIndex = 48;
            this.lblMachineName.Text = "Machine name:";
            this.lblMachineName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInternetAccess
            // 
            this.lblInternetAccess.AutoSize = true;
            this.lblInternetAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInternetAccess.Font = new System.Drawing.Font("Arial", 12F);
            this.lblInternetAccess.ForeColor = System.Drawing.Color.White;
            this.lblInternetAccess.Location = new System.Drawing.Point(4, 473);
            this.lblInternetAccess.Name = "lblInternetAccess";
            this.lblInternetAccess.Size = new System.Drawing.Size(1001, 61);
            this.lblInternetAccess.TabIndex = 49;
            this.lblInternetAccess.Text = "Internet access:";
            this.lblInternetAccess.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusDiskSpace1
            // 
            this.statusDiskSpace1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusDiskSpace1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDiskSpace1.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace1.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusDiskSpace1.IconColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusDiskSpace1.IconSize = 52;
            this.statusDiskSpace1.Location = new System.Drawing.Point(1059, 299);
            this.statusDiskSpace1.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusDiskSpace1.Name = "statusDiskSpace1";
            this.statusDiskSpace1.Size = new System.Drawing.Size(59, 52);
            this.statusDiskSpace1.TabIndex = 56;
            this.statusDiskSpace1.TabStop = false;
            this.statusDiskSpace1.Visible = false;
            // 
            // statusDiskSpace2
            // 
            this.statusDiskSpace2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusDiskSpace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusDiskSpace2.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace2.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusDiskSpace2.IconColor = System.Drawing.Color.LawnGreen;
            this.statusDiskSpace2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusDiskSpace2.IconSize = 52;
            this.statusDiskSpace2.Location = new System.Drawing.Point(1059, 358);
            this.statusDiskSpace2.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusDiskSpace2.Name = "statusDiskSpace2";
            this.statusDiskSpace2.Size = new System.Drawing.Size(59, 52);
            this.statusDiskSpace2.TabIndex = 58;
            this.statusDiskSpace2.TabStop = false;
            this.statusDiskSpace2.Visible = false;
            // 
            // statusMachineName
            // 
            this.statusMachineName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusMachineName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusMachineName.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusMachineName.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusMachineName.IconColor = System.Drawing.Color.LawnGreen;
            this.statusMachineName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusMachineName.IconSize = 52;
            this.statusMachineName.Location = new System.Drawing.Point(1059, 417);
            this.statusMachineName.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusMachineName.Name = "statusMachineName";
            this.statusMachineName.Size = new System.Drawing.Size(59, 52);
            this.statusMachineName.TabIndex = 59;
            this.statusMachineName.TabStop = false;
            this.statusMachineName.Visible = false;
            // 
            // statusInternetAccess
            // 
            this.statusInternetAccess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.statusInternetAccess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusInternetAccess.ForeColor = System.Drawing.Color.LawnGreen;
            this.statusInternetAccess.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.statusInternetAccess.IconColor = System.Drawing.Color.LawnGreen;
            this.statusInternetAccess.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.statusInternetAccess.IconSize = 55;
            this.statusInternetAccess.Location = new System.Drawing.Point(1059, 476);
            this.statusInternetAccess.Margin = new System.Windows.Forms.Padding(50, 3, 3, 3);
            this.statusInternetAccess.Name = "statusInternetAccess";
            this.statusInternetAccess.Size = new System.Drawing.Size(59, 55);
            this.statusInternetAccess.TabIndex = 60;
            this.statusInternetAccess.TabStop = false;
            this.statusInternetAccess.Visible = false;
            // 
            // SystemVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemVerification";
            this.Text = "SystemVerification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusProcessor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMemory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDiskSpace2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusMachineName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInternetAccess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PerformSysValidations;
        private System.Windows.Forms.Button btn_NextStep;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxVersion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOperatingSystem;
        private System.Windows.Forms.Label lblDiskSpace1;
        private System.Windows.Forms.Label lblDiskSpaceTitle;
        private System.Windows.Forms.Label lblMemory;
        private System.Windows.Forms.Label lblProcessorType;
        private System.Windows.Forms.Label lblDiskSpace2;
        private System.Windows.Forms.Label lblMachineName;
        private System.Windows.Forms.Label lblInternetAccess;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconPictureBox statusOS;
        private FontAwesome.Sharp.IconPictureBox statusProcessor;
        private FontAwesome.Sharp.IconPictureBox statusMemory;
        private FontAwesome.Sharp.IconPictureBox statusDiskSpace;
        private FontAwesome.Sharp.IconPictureBox statusDiskSpace1;
        private FontAwesome.Sharp.IconPictureBox statusDiskSpace2;
        private FontAwesome.Sharp.IconPictureBox statusMachineName;
        private FontAwesome.Sharp.IconPictureBox statusInternetAccess;
    }
}