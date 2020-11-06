namespace ArcGIS_System_Profiler
{
    partial class LaunchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LaunchForm));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCreateReport = new FontAwesome.Sharp.IconButton();
            this.btnSetTheme = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelSlider = new System.Windows.Forms.Panel();
            this.btn_Publish = new FontAwesome.Sharp.IconButton();
            this.btn_Services = new FontAwesome.Sharp.IconButton();
            this.btnDataStoreValidate = new FontAwesome.Sharp.IconButton();
            this.btn_HealthChecks = new FontAwesome.Sharp.IconButton();
            this.btn_PortChecks = new FontAwesome.Sharp.IconButton();
            this.btn_Tasks = new FontAwesome.Sharp.IconButton();
            this.btnSystemValidation = new FontAwesome.Sharp.IconButton();
            this.btn_Home = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.loadingIconPic = new System.Windows.Forms.PictureBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_LoginUser = new System.Windows.Forms.Label();
            this.btn_Minimize = new FontAwesome.Sharp.IconButton();
            this.btn_Maximize = new FontAwesome.Sharp.IconButton();
            this.btn_Close = new FontAwesome.Sharp.IconButton();
            this.lbl_loggedInUser = new System.Windows.Forms.Label();
            this.currentStepLabel = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.globalProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.globalTimer1 = new System.Windows.Forms.Timer(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panelLoadingIconBar = new System.Windows.Forms.Panel();
            this.panelLoadingIconBartimer = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIconPic)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelShadow.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panelMenu.Controls.Add(this.btnCreateReport);
            this.panelMenu.Controls.Add(this.btnSetTheme);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.btn_Services);
            this.panelMenu.Controls.Add(this.btn_Publish);
            this.panelMenu.Controls.Add(this.btnDataStoreValidate);
            this.panelMenu.Controls.Add(this.btn_HealthChecks);
            this.panelMenu.Controls.Add(this.btn_PortChecks);
            this.panelMenu.Controls.Add(this.btn_Tasks);
            this.panelMenu.Controls.Add(this.btnSystemValidation);
            this.panelMenu.Controls.Add(this.btn_Home);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 821);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCreateReport
            // 
            this.btnCreateReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateReport.FlatAppearance.BorderSize = 0;
            this.btnCreateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReport.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnCreateReport.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateReport.ForeColor = System.Drawing.Color.White;
            this.btnCreateReport.IconChar = FontAwesome.Sharp.IconChar.Reacteurope;
            this.btnCreateReport.IconColor = System.Drawing.Color.White;
            this.btnCreateReport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateReport.IconSize = 36;
            this.btnCreateReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReport.Location = new System.Drawing.Point(0, 680);
            this.btnCreateReport.Name = "btnCreateReport";
            this.btnCreateReport.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCreateReport.Rotation = 0D;
            this.btnCreateReport.Size = new System.Drawing.Size(220, 60);
            this.btnCreateReport.TabIndex = 9;
            this.btnCreateReport.Text = "Generate Report";
            this.btnCreateReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreateReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateReport.UseVisualStyleBackColor = true;
            this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
            // 
            // btnSetTheme
            // 
            this.btnSetTheme.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetTheme.FlatAppearance.BorderSize = 0;
            this.btnSetTheme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetTheme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSetTheme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetTheme.ForeColor = System.Drawing.Color.White;
            this.btnSetTheme.IconChar = FontAwesome.Sharp.IconChar.PaintBrush;
            this.btnSetTheme.IconColor = System.Drawing.Color.White;
            this.btnSetTheme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetTheme.IconSize = 36;
            this.btnSetTheme.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetTheme.Location = new System.Drawing.Point(0, 620);
            this.btnSetTheme.Name = "btnSetTheme";
            this.btnSetTheme.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSetTheme.Rotation = 0D;
            this.btnSetTheme.Size = new System.Drawing.Size(220, 60);
            this.btnSetTheme.TabIndex = 13;
            this.btnSetTheme.Text = "Set Theme";
            this.btnSetTheme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetTheme.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetTheme.UseVisualStyleBackColor = true;
            this.btnSetTheme.Click += new System.EventHandler(this.btnSetTheme_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panelSlider);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 791);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 30);
            this.panel2.TabIndex = 10;
            this.panel2.Visible = false;
            // 
            // panelSlider
            // 
            this.panelSlider.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panelSlider.Location = new System.Drawing.Point(-2, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(55, 30);
            this.panelSlider.TabIndex = 11;
            // 
            // btn_Publish
            // 
            this.btn_Publish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Publish.FlatAppearance.BorderSize = 0;
            this.btn_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Publish.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Publish.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Publish.ForeColor = System.Drawing.Color.White;
            this.btn_Publish.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btn_Publish.IconColor = System.Drawing.Color.White;
            this.btn_Publish.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Publish.IconSize = 36;
            this.btn_Publish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Publish.Location = new System.Drawing.Point(0, 560);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Publish.Rotation = 0D;
            this.btn_Publish.Size = new System.Drawing.Size(220, 60);
            this.btn_Publish.TabIndex = 8;
            this.btn_Publish.Text = "Publish Services";
            this.btn_Publish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Publish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // btn_Services
            // 
            this.btn_Services.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Services.FlatAppearance.BorderSize = 0;
            this.btn_Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Services.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Services.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Services.ForeColor = System.Drawing.Color.White;
            this.btn_Services.IconChar = FontAwesome.Sharp.IconChar.SimCard;
            this.btn_Services.IconColor = System.Drawing.Color.White;
            this.btn_Services.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Services.IconSize = 36;
            this.btn_Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Services.Location = new System.Drawing.Point(0, 500);
            this.btn_Services.Name = "btn_Services";
            this.btn_Services.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Services.Rotation = 0D;
            this.btn_Services.Size = new System.Drawing.Size(220, 60);
            this.btn_Services.TabIndex = 7;
            this.btn_Services.Text = "Get Services Info";
            this.btn_Services.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Services.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Services.UseVisualStyleBackColor = true;
            this.btn_Services.Click += new System.EventHandler(this.btn_Services_Click);
            // 
            // btnDataStoreValidate
            // 
            this.btnDataStoreValidate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDataStoreValidate.FlatAppearance.BorderSize = 0;
            this.btnDataStoreValidate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataStoreValidate.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDataStoreValidate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDataStoreValidate.ForeColor = System.Drawing.Color.White;
            this.btnDataStoreValidate.IconChar = FontAwesome.Sharp.IconChar.Sitemap;
            this.btnDataStoreValidate.IconColor = System.Drawing.Color.White;
            this.btnDataStoreValidate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDataStoreValidate.IconSize = 36;
            this.btnDataStoreValidate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataStoreValidate.Location = new System.Drawing.Point(0, 440);
            this.btnDataStoreValidate.Name = "btnDataStoreValidate";
            this.btnDataStoreValidate.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDataStoreValidate.Rotation = 0D;
            this.btnDataStoreValidate.Size = new System.Drawing.Size(220, 60);
            this.btnDataStoreValidate.TabIndex = 11;
            this.btnDataStoreValidate.Text = "DataStore Validations";
            this.btnDataStoreValidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataStoreValidate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDataStoreValidate.UseVisualStyleBackColor = true;
            this.btnDataStoreValidate.Click += new System.EventHandler(this.btnDataStoreValidate_Click);
            // 
            // btn_HealthChecks
            // 
            this.btn_HealthChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HealthChecks.FlatAppearance.BorderSize = 0;
            this.btn_HealthChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HealthChecks.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_HealthChecks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HealthChecks.ForeColor = System.Drawing.Color.White;
            this.btn_HealthChecks.IconChar = FontAwesome.Sharp.IconChar.LaptopMedical;
            this.btn_HealthChecks.IconColor = System.Drawing.Color.White;
            this.btn_HealthChecks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_HealthChecks.IconSize = 36;
            this.btn_HealthChecks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HealthChecks.Location = new System.Drawing.Point(0, 380);
            this.btn_HealthChecks.Name = "btn_HealthChecks";
            this.btn_HealthChecks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_HealthChecks.Rotation = 0D;
            this.btn_HealthChecks.Size = new System.Drawing.Size(220, 60);
            this.btn_HealthChecks.TabIndex = 4;
            this.btn_HealthChecks.Text = "Health Checks";
            this.btn_HealthChecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_HealthChecks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_HealthChecks.UseVisualStyleBackColor = true;
            this.btn_HealthChecks.Click += new System.EventHandler(this.btn_HealthChecks_Click);
            // 
            // btn_PortChecks
            // 
            this.btn_PortChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_PortChecks.FlatAppearance.BorderSize = 0;
            this.btn_PortChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PortChecks.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_PortChecks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PortChecks.ForeColor = System.Drawing.Color.White;
            this.btn_PortChecks.IconChar = FontAwesome.Sharp.IconChar.Megaport;
            this.btn_PortChecks.IconColor = System.Drawing.Color.White;
            this.btn_PortChecks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_PortChecks.IconSize = 36;
            this.btn_PortChecks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PortChecks.Location = new System.Drawing.Point(0, 320);
            this.btn_PortChecks.Name = "btn_PortChecks";
            this.btn_PortChecks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_PortChecks.Rotation = 0D;
            this.btn_PortChecks.Size = new System.Drawing.Size(220, 60);
            this.btn_PortChecks.TabIndex = 5;
            this.btn_PortChecks.Text = "Port Checks";
            this.btn_PortChecks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_PortChecks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_PortChecks.UseVisualStyleBackColor = true;
            this.btn_PortChecks.Click += new System.EventHandler(this.btn_PortChecks_Click);
            // 
            // btn_Tasks
            // 
            this.btn_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tasks.FlatAppearance.BorderSize = 0;
            this.btn_Tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tasks.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Tasks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tasks.ForeColor = System.Drawing.Color.White;
            this.btn_Tasks.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btn_Tasks.IconColor = System.Drawing.Color.White;
            this.btn_Tasks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Tasks.IconSize = 36;
            this.btn_Tasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tasks.Location = new System.Drawing.Point(0, 260);
            this.btn_Tasks.Name = "btn_Tasks";
            this.btn_Tasks.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Tasks.Rotation = 0D;
            this.btn_Tasks.Size = new System.Drawing.Size(220, 60);
            this.btn_Tasks.TabIndex = 2;
            this.btn_Tasks.Text = "Tasks";
            this.btn_Tasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Tasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Tasks.UseVisualStyleBackColor = true;
            this.btn_Tasks.Click += new System.EventHandler(this.btn_Tasks_Click);
            // 
            // btnSystemValidation
            // 
            this.btnSystemValidation.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemValidation.FlatAppearance.BorderSize = 0;
            this.btnSystemValidation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemValidation.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSystemValidation.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSystemValidation.ForeColor = System.Drawing.Color.White;
            this.btnSystemValidation.IconChar = FontAwesome.Sharp.IconChar.Whmcs;
            this.btnSystemValidation.IconColor = System.Drawing.Color.White;
            this.btnSystemValidation.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSystemValidation.IconSize = 36;
            this.btnSystemValidation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemValidation.Location = new System.Drawing.Point(0, 200);
            this.btnSystemValidation.Name = "btnSystemValidation";
            this.btnSystemValidation.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSystemValidation.Rotation = 0D;
            this.btnSystemValidation.Size = new System.Drawing.Size(220, 60);
            this.btnSystemValidation.TabIndex = 12;
            this.btnSystemValidation.Text = "System Verification";
            this.btnSystemValidation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemValidation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSystemValidation.UseVisualStyleBackColor = true;
            this.btnSystemValidation.Visible = false;
            this.btnSystemValidation.Click += new System.EventHandler(this.btnSystemValidation_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Home.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btn_Home.IconColor = System.Drawing.Color.White;
            this.btn_Home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Home.IconSize = 36;
            this.btn_Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.Location = new System.Drawing.Point(0, 140);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Home.Rotation = 0D;
            this.btn_Home.Size = new System.Drawing.Size(220, 60);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.loadingIconPic);
            this.panelLogo.Controls.Add(this.iconButton1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 140);
            this.panelLogo.TabIndex = 0;
            // 
            // loadingIconPic
            // 
            this.loadingIconPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingIconPic.Image = ((System.Drawing.Image)(resources.GetObject("loadingIconPic.Image")));
            this.loadingIconPic.Location = new System.Drawing.Point(0, 0);
            this.loadingIconPic.Name = "loadingIconPic";
            this.loadingIconPic.Size = new System.Drawing.Size(220, 140);
            this.loadingIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingIconPic.TabIndex = 9;
            this.loadingIconPic.TabStop = false;
            this.loadingIconPic.Visible = false;
            this.loadingIconPic.WaitOnLoad = true;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.iconButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.React;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 150;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Rotation = 0D;
            this.iconButton1.Size = new System.Drawing.Size(220, 140);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panelTitleBar.Controls.Add(this.panel1);
            this.panelTitleBar.Controls.Add(this.lbl_loggedInUser);
            this.panelTitleBar.Controls.Add(this.currentStepLabel);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(220, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1083, 50);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_LoginUser);
            this.panel1.Controls.Add(this.btn_Minimize);
            this.panel1.Controls.Add(this.btn_Maximize);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(764, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 50);
            this.panel1.TabIndex = 21;
            // 
            // lbl_LoginUser
            // 
            this.lbl_LoginUser.AutoSize = true;
            this.lbl_LoginUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_LoginUser.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_LoginUser.Location = new System.Drawing.Point(32, 17);
            this.lbl_LoginUser.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoginUser.Name = "lbl_LoginUser";
            this.lbl_LoginUser.Size = new System.Drawing.Size(26, 17);
            this.lbl_LoginUser.TabIndex = 20;
            this.lbl_LoginUser.Text = "llllll";
            this.lbl_LoginUser.Visible = false;
            // 
            // btn_Minimize
            // 
            this.btn_Minimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Minimize.FlatAppearance.BorderSize = 0;
            this.btn_Minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Minimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Minimize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Minimize.ForeColor = System.Drawing.Color.White;
            this.btn_Minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_Minimize.IconColor = System.Drawing.Color.White;
            this.btn_Minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Minimize.IconSize = 22;
            this.btn_Minimize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Minimize.Location = new System.Drawing.Point(226, 0);
            this.btn_Minimize.Name = "btn_Minimize";
            this.btn_Minimize.Rotation = 0D;
            this.btn_Minimize.Size = new System.Drawing.Size(31, 50);
            this.btn_Minimize.TabIndex = 4;
            this.btn_Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Minimize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Minimize.UseVisualStyleBackColor = true;
            this.btn_Minimize.Click += new System.EventHandler(this.btn_Minimize_Click);
            // 
            // btn_Maximize
            // 
            this.btn_Maximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Maximize.FlatAppearance.BorderSize = 0;
            this.btn_Maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Maximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Maximize.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Maximize.ForeColor = System.Drawing.Color.White;
            this.btn_Maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_Maximize.IconColor = System.Drawing.Color.White;
            this.btn_Maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Maximize.IconSize = 22;
            this.btn_Maximize.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Maximize.Location = new System.Drawing.Point(257, 0);
            this.btn_Maximize.Name = "btn_Maximize";
            this.btn_Maximize.Rotation = 0D;
            this.btn_Maximize.Size = new System.Drawing.Size(31, 50);
            this.btn_Maximize.TabIndex = 3;
            this.btn_Maximize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Maximize.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Maximize.UseVisualStyleBackColor = true;
            this.btn_Maximize.Click += new System.EventHandler(this.btn_Maximize_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.FlatAppearance.BorderSize = 0;
            this.btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Close.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btn_Close.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Close.ForeColor = System.Drawing.Color.White;
            this.btn_Close.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.btn_Close.IconColor = System.Drawing.Color.White;
            this.btn_Close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_Close.IconSize = 22;
            this.btn_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Close.Location = new System.Drawing.Point(288, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Rotation = 0D;
            this.btn_Close.Size = new System.Drawing.Size(31, 50);
            this.btn_Close.TabIndex = 2;
            this.btn_Close.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // lbl_loggedInUser
            // 
            this.lbl_loggedInUser.AutoSize = true;
            this.lbl_loggedInUser.Font = new System.Drawing.Font("Arial", 12F);
            this.lbl_loggedInUser.ForeColor = System.Drawing.Color.White;
            this.lbl_loggedInUser.Location = new System.Drawing.Point(646, 15);
            this.lbl_loggedInUser.Name = "lbl_loggedInUser";
            this.lbl_loggedInUser.Size = new System.Drawing.Size(20, 18);
            this.lbl_loggedInUser.TabIndex = 1;
            this.lbl_loggedInUser.Text = "jjjj";
            this.lbl_loggedInUser.Visible = false;
            // 
            // currentStepLabel
            // 
            this.currentStepLabel.AutoSize = true;
            this.currentStepLabel.Font = new System.Drawing.Font("Arial", 12F);
            this.currentStepLabel.ForeColor = System.Drawing.Color.White;
            this.currentStepLabel.Location = new System.Drawing.Point(52, 16);
            this.currentStepLabel.Name = "currentStepLabel";
            this.currentStepLabel.Size = new System.Drawing.Size(50, 18);
            this.currentStepLabel.TabIndex = 1;
            this.currentStepLabel.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(14, 10);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panelShadow.Controls.Add(this.panelLoadingIconBar);
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 50);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1083, 8);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.panelDesktop.Controls.Add(this.globalProgressBar1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 58);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1083, 763);
            this.panelDesktop.TabIndex = 3;
            // 
            // globalProgressBar1
            // 
            this.globalProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.globalProgressBar1.Location = new System.Drawing.Point(0, 733);
            this.globalProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.globalProgressBar1.Name = "globalProgressBar1";
            this.globalProgressBar1.Size = new System.Drawing.Size(1083, 30);
            this.globalProgressBar1.TabIndex = 2;
            this.globalProgressBar1.Visible = false;
            // 
            // globalTimer1
            // 
            this.globalTimer1.Tick += new System.EventHandler(this.globalTimer1_Tick);
            // 
            // panelLoadingIconBar
            // 
            this.panelLoadingIconBar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLoadingIconBar.BackColor = System.Drawing.Color.Red;
            this.panelLoadingIconBar.Location = new System.Drawing.Point(0, 1);
            this.panelLoadingIconBar.Name = "panelLoadingIconBar";
            this.panelLoadingIconBar.Size = new System.Drawing.Size(100, 10);
            this.panelLoadingIconBar.TabIndex = 12;
            this.panelLoadingIconBar.Visible = false;
            // 
            // panelLoadingIconBartimer
            // 
            this.panelLoadingIconBartimer.Tick += new System.EventHandler(this.panelLoadingIconBartimer_Tick);
            // 
            // LaunchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 821);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "LaunchForm";
            this.Text = "LaunchForm";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingIconPic)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelShadow.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton btn_Home;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label currentStepLabel;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label lbl_loggedInUser;
        internal System.Windows.Forms.ProgressBar globalProgressBar1;
        internal System.Windows.Forms.Timer globalTimer1;
        internal FontAwesome.Sharp.IconButton btn_Tasks;
        private FontAwesome.Sharp.IconButton btn_Minimize;
        private FontAwesome.Sharp.IconButton btn_Maximize;
        private FontAwesome.Sharp.IconButton btn_Close;
        internal System.Windows.Forms.Label lbl_LoginUser;
        private System.Windows.Forms.Panel panel1;
        internal FontAwesome.Sharp.IconButton btn_Services;
        internal FontAwesome.Sharp.IconButton btn_Publish;
        internal FontAwesome.Sharp.IconButton btn_PortChecks;
        internal FontAwesome.Sharp.IconButton btn_HealthChecks;
        internal System.Windows.Forms.PictureBox loadingIconPic;
        internal FontAwesome.Sharp.IconButton btnCreateReport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelSlider;
        internal FontAwesome.Sharp.IconButton btnDataStoreValidate;
        internal FontAwesome.Sharp.IconButton btnSystemValidation;
        internal FontAwesome.Sharp.IconButton btnSetTheme;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer panelLoadingIconBartimer;
        internal System.Windows.Forms.Panel panelLoadingIconBar;
    }
}