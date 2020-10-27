﻿namespace ArcGIS_System_Profiler
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
            this.btn_Publish = new FontAwesome.Sharp.IconButton();
            this.btn_Services = new FontAwesome.Sharp.IconButton();
            this.btn_PortChecks = new FontAwesome.Sharp.IconButton();
            this.btn_HealthChecks = new FontAwesome.Sharp.IconButton();
            this.btn_Tasks = new FontAwesome.Sharp.IconButton();
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
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingIconPic)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(68)))));
            this.panelMenu.Controls.Add(this.btnCreateReport);
            this.panelMenu.Controls.Add(this.btn_Publish);
            this.panelMenu.Controls.Add(this.btn_Services);
            this.panelMenu.Controls.Add(this.btn_PortChecks);
            this.panelMenu.Controls.Add(this.btn_HealthChecks);
            this.panelMenu.Controls.Add(this.btn_Tasks);
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
            this.btnCreateReport.Location = new System.Drawing.Point(0, 500);
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
            this.btn_Publish.Location = new System.Drawing.Point(0, 440);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_Publish.Rotation = 0D;
            this.btn_Publish.Size = new System.Drawing.Size(220, 60);
            this.btn_Publish.TabIndex = 8;
            this.btn_Publish.Text = "Publish Services";
            this.btn_Publish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Publish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Visible = false;
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
            this.btn_Services.Location = new System.Drawing.Point(0, 380);
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
            this.btn_HealthChecks.Location = new System.Drawing.Point(0, 260);
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
            this.btn_Tasks.Location = new System.Drawing.Point(0, 200);
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
            this.loadingIconPic.Image = ((System.Drawing.Image)(resources.GetObject("loadingIconPic.Image")));
            this.loadingIconPic.Location = new System.Drawing.Point(41, 10);
            this.loadingIconPic.Name = "loadingIconPic";
            this.loadingIconPic.Size = new System.Drawing.Size(120, 107);
            this.loadingIconPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
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
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
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
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(24)))), ((int)(((byte)(58)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(220, 50);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1083, 5);
            this.panelShadow.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panelDesktop.Controls.Add(this.globalProgressBar1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 55);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1083, 766);
            this.panelDesktop.TabIndex = 3;
            // 
            // globalProgressBar1
            // 
            this.globalProgressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.globalProgressBar1.Location = new System.Drawing.Point(0, 736);
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
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingIconPic)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
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
    }
}