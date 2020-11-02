namespace ArcGIS_System_Profiler
{
    partial class InitialForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBx_DataStoreHostName = new System.Windows.Forms.TextBox();
            this.txtBx_ServerHostName = new System.Windows.Forms.TextBox();
            this.txtBx_ServerInstance = new System.Windows.Forms.TextBox();
            this.txtBx_PortalInstance = new System.Windows.Forms.TextBox();
            this.txtBx_PortalHostName = new System.Windows.Forms.TextBox();
            this.btn_EditInstanceName = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel_Enterprise = new System.Windows.Forms.Panel();
            this.txtPortalPassword = new System.Windows.Forms.TextBox();
            this.txtPortalUserName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_agsEnt = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_LoginStatus = new System.Windows.Forms.Label();
            this.panel_Server = new System.Windows.Forms.Panel();
            this.txtAGSServerPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAGSServerUserName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_agsServer = new System.Windows.Forms.Button();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.chkBx_DataStore = new System.Windows.Forms.CheckBox();
            this.chkBx_Server = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel_Enterprise.SuspendLayout();
            this.panel_Server.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBx_DataStoreHostName);
            this.panel1.Controls.Add(this.txtBx_ServerHostName);
            this.panel1.Controls.Add(this.txtBx_ServerInstance);
            this.panel1.Controls.Add(this.txtBx_PortalInstance);
            this.panel1.Controls.Add(this.txtBx_PortalHostName);
            this.panel1.Controls.Add(this.btn_EditInstanceName);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.panel_Enterprise);
            this.panel1.Controls.Add(this.panel_Server);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.chkBx_DataStore);
            this.panel1.Controls.Add(this.chkBx_Server);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 676);
            this.panel1.TabIndex = 0;
            // 
            // txtBx_DataStoreHostName
            // 
            this.txtBx_DataStoreHostName.Location = new System.Drawing.Point(308, 292);
            this.txtBx_DataStoreHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_DataStoreHostName.Name = "txtBx_DataStoreHostName";
            this.txtBx_DataStoreHostName.Size = new System.Drawing.Size(356, 26);
            this.txtBx_DataStoreHostName.TabIndex = 20;
            // 
            // txtBx_ServerHostName
            // 
            this.txtBx_ServerHostName.Location = new System.Drawing.Point(308, 247);
            this.txtBx_ServerHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_ServerHostName.Name = "txtBx_ServerHostName";
            this.txtBx_ServerHostName.Size = new System.Drawing.Size(356, 26);
            this.txtBx_ServerHostName.TabIndex = 20;
            this.txtBx_ServerHostName.Text = "lea-305263.services.esriaustralia.com.au";
            this.txtBx_ServerHostName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_ServerHostName_Validating);
            // 
            // txtBx_ServerInstance
            // 
            this.txtBx_ServerInstance.Enabled = false;
            this.txtBx_ServerInstance.Location = new System.Drawing.Point(874, 248);
            this.txtBx_ServerInstance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_ServerInstance.Name = "txtBx_ServerInstance";
            this.txtBx_ServerInstance.Size = new System.Drawing.Size(194, 26);
            this.txtBx_ServerInstance.TabIndex = 20;
            this.txtBx_ServerInstance.Text = "server";
            this.txtBx_ServerInstance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_ServerInstance_Validating);
            // 
            // txtBx_PortalInstance
            // 
            this.txtBx_PortalInstance.Enabled = false;
            this.txtBx_PortalInstance.Location = new System.Drawing.Point(874, 196);
            this.txtBx_PortalInstance.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_PortalInstance.Name = "txtBx_PortalInstance";
            this.txtBx_PortalInstance.Size = new System.Drawing.Size(194, 26);
            this.txtBx_PortalInstance.TabIndex = 20;
            this.txtBx_PortalInstance.Text = "portal";
            this.txtBx_PortalInstance.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_PortalInstance_Validating);
            // 
            // txtBx_PortalHostName
            // 
            this.txtBx_PortalHostName.Location = new System.Drawing.Point(308, 196);
            this.txtBx_PortalHostName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_PortalHostName.Name = "txtBx_PortalHostName";
            this.txtBx_PortalHostName.Size = new System.Drawing.Size(356, 26);
            this.txtBx_PortalHostName.TabIndex = 20;
            this.txtBx_PortalHostName.Text = "lea-305263.services.esriaustralia.com.au";
            this.txtBx_PortalHostName.Validating += new System.ComponentModel.CancelEventHandler(this.txtBx_PortalHostName_Validating);
            // 
            // btn_EditInstanceName
            // 
            this.btn_EditInstanceName.BackColor = System.Drawing.Color.LightGray;
            this.btn_EditInstanceName.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EditInstanceName.ForeColor = System.Drawing.Color.Black;
            this.btn_EditInstanceName.Location = new System.Drawing.Point(955, 284);
            this.btn_EditInstanceName.Margin = new System.Windows.Forms.Padding(6);
            this.btn_EditInstanceName.Name = "btn_EditInstanceName";
            this.btn_EditInstanceName.Size = new System.Drawing.Size(113, 34);
            this.btn_EditInstanceName.TabIndex = 6;
            this.btn_EditInstanceName.Text = "Edit";
            this.btn_EditInstanceName.UseVisualStyleBackColor = false;
            this.btn_EditInstanceName.Click += new System.EventHandler(this.btn_EditInstanceName_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.OrangeRed;
            this.label19.Location = new System.Drawing.Point(1009, 146);
            this.label19.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(17, 22);
            this.label19.TabIndex = 19;
            this.label19.Text = "*";
            this.label19.Visible = false;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.OrangeRed;
            this.label18.Location = new System.Drawing.Point(271, 247);
            this.label18.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(17, 22);
            this.label18.TabIndex = 19;
            this.label18.Text = "*";
            this.label18.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.OrangeRed;
            this.label17.Location = new System.Drawing.Point(289, 200);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(17, 22);
            this.label17.TabIndex = 19;
            this.label17.Text = "*";
            this.label17.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(29, 292);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(277, 22);
            this.label13.TabIndex = 19;
            this.label13.Text = "ArcGIS DataStore Hostname:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(29, 247);
            this.label12.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(247, 22);
            this.label12.TabIndex = 19;
            this.label12.Text = "ArcGIS Server Hostname:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(870, 148);
            this.label14.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(145, 22);
            this.label14.TabIndex = 19;
            this.label14.Text = "Instance name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(29, 196);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(269, 22);
            this.label11.TabIndex = 19;
            this.label11.Text = "Portal for ArcGIS hostname:";
            // 
            // panel_Enterprise
            // 
            this.panel_Enterprise.Controls.Add(this.txtPortalPassword);
            this.panel_Enterprise.Controls.Add(this.txtPortalUserName);
            this.panel_Enterprise.Controls.Add(this.label10);
            this.panel_Enterprise.Controls.Add(this.label8);
            this.panel_Enterprise.Controls.Add(this.label9);
            this.panel_Enterprise.Controls.Add(this.btn_agsEnt);
            this.panel_Enterprise.Controls.Add(this.label16);
            this.panel_Enterprise.Controls.Add(this.label15);
            this.panel_Enterprise.Controls.Add(this.lbl_LoginStatus);
            this.panel_Enterprise.Location = new System.Drawing.Point(28, 385);
            this.panel_Enterprise.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Enterprise.Name = "panel_Enterprise";
            this.panel_Enterprise.Size = new System.Drawing.Size(531, 276);
            this.panel_Enterprise.TabIndex = 18;
            // 
            // txtPortalPassword
            // 
            this.txtPortalPassword.Location = new System.Drawing.Point(156, 115);
            this.txtPortalPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortalPassword.Name = "txtPortalPassword";
            this.txtPortalPassword.PasswordChar = '*';
            this.txtPortalPassword.Size = new System.Drawing.Size(356, 26);
            this.txtPortalPassword.TabIndex = 5;
            this.txtPortalPassword.Text = "password123";
            this.txtPortalPassword.Validating += new System.ComponentModel.CancelEventHandler(this.txtPortalPassword_Validating);
            // 
            // txtPortalUserName
            // 
            this.txtPortalUserName.Location = new System.Drawing.Point(156, 66);
            this.txtPortalUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortalUserName.Name = "txtPortalUserName";
            this.txtPortalUserName.Size = new System.Drawing.Size(356, 26);
            this.txtPortalUserName.TabIndex = 4;
            this.txtPortalUserName.Text = "portaladmin";
            this.txtPortalUserName.Validating += new System.ComponentModel.CancelEventHandler(this.txtPortalUserName_Validating);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(6, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "ArcGIS Enterprise";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(6, 63);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 22);
            this.label8.TabIndex = 1;
            this.label8.Text = "Username:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // btn_agsEnt
            // 
            this.btn_agsEnt.BackColor = System.Drawing.Color.LightGray;
            this.btn_agsEnt.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsEnt.ForeColor = System.Drawing.Color.Black;
            this.btn_agsEnt.Location = new System.Drawing.Point(340, 170);
            this.btn_agsEnt.Margin = new System.Windows.Forms.Padding(6);
            this.btn_agsEnt.Name = "btn_agsEnt";
            this.btn_agsEnt.Size = new System.Drawing.Size(173, 49);
            this.btn_agsEnt.TabIndex = 6;
            this.btn_agsEnt.Text = "Start";
            this.btn_agsEnt.UseVisualStyleBackColor = false;
            this.btn_agsEnt.Click += new System.EventHandler(this.btn_agsEnt_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.OrangeRed;
            this.label16.Location = new System.Drawing.Point(115, 115);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 22);
            this.label16.TabIndex = 19;
            this.label16.Text = "*";
            this.label16.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.OrangeRed;
            this.label15.Location = new System.Drawing.Point(115, 63);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(17, 22);
            this.label15.TabIndex = 19;
            this.label15.Text = "*";
            this.label15.Visible = false;
            // 
            // lbl_LoginStatus
            // 
            this.lbl_LoginStatus.AutoSize = true;
            this.lbl_LoginStatus.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lbl_LoginStatus.ForeColor = System.Drawing.Color.Aqua;
            this.lbl_LoginStatus.Location = new System.Drawing.Point(21, 239);
            this.lbl_LoginStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_LoginStatus.Name = "lbl_LoginStatus";
            this.lbl_LoginStatus.Size = new System.Drawing.Size(98, 22);
            this.lbl_LoginStatus.TabIndex = 19;
            this.lbl_LoginStatus.Text = "aassassa";
            this.lbl_LoginStatus.Visible = false;
            // 
            // panel_Server
            // 
            this.panel_Server.Controls.Add(this.txtAGSServerPassword);
            this.panel_Server.Controls.Add(this.label7);
            this.panel_Server.Controls.Add(this.label5);
            this.panel_Server.Controls.Add(this.txtAGSServerUserName);
            this.panel_Server.Controls.Add(this.label6);
            this.panel_Server.Controls.Add(this.btn_agsServer);
            this.panel_Server.Location = new System.Drawing.Point(567, 385);
            this.panel_Server.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Server.Name = "panel_Server";
            this.panel_Server.Size = new System.Drawing.Size(542, 276);
            this.panel_Server.TabIndex = 17;
            this.panel_Server.Visible = false;
            // 
            // txtAGSServerPassword
            // 
            this.txtAGSServerPassword.Location = new System.Drawing.Point(173, 115);
            this.txtAGSServerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAGSServerPassword.Name = "txtAGSServerPassword";
            this.txtAGSServerPassword.PasswordChar = '*';
            this.txtAGSServerPassword.Size = new System.Drawing.Size(356, 26);
            this.txtAGSServerPassword.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "ArcGIS Server";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(23, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username:";
            // 
            // txtAGSServerUserName
            // 
            this.txtAGSServerUserName.Location = new System.Drawing.Point(173, 66);
            this.txtAGSServerUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAGSServerUserName.Name = "txtAGSServerUserName";
            this.txtAGSServerUserName.Size = new System.Drawing.Size(356, 26);
            this.txtAGSServerUserName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // btn_agsServer
            // 
            this.btn_agsServer.BackColor = System.Drawing.Color.LightGray;
            this.btn_agsServer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsServer.ForeColor = System.Drawing.Color.Black;
            this.btn_agsServer.Location = new System.Drawing.Point(357, 170);
            this.btn_agsServer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_agsServer.Name = "btn_agsServer";
            this.btn_agsServer.Size = new System.Drawing.Size(173, 49);
            this.btn_agsServer.TabIndex = 6;
            this.btn_agsServer.Text = "Start";
            this.btn_agsServer.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(434, 146);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 26);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(328, 146);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 26);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(258, 101);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 26);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.Text = "Portal for ArcGIS";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // chkBx_DataStore
            // 
            this.chkBx_DataStore.AutoSize = true;
            this.chkBx_DataStore.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.chkBx_DataStore.ForeColor = System.Drawing.Color.White;
            this.chkBx_DataStore.Location = new System.Drawing.Point(681, 292);
            this.chkBx_DataStore.Margin = new System.Windows.Forms.Padding(4);
            this.chkBx_DataStore.Name = "chkBx_DataStore";
            this.chkBx_DataStore.Size = new System.Drawing.Size(170, 26);
            this.chkBx_DataStore.TabIndex = 14;
            this.chkBx_DataStore.Text = "Same as above";
            this.chkBx_DataStore.UseVisualStyleBackColor = true;
            this.chkBx_DataStore.CheckedChanged += new System.EventHandler(this.chkBx_DataStore_CheckedChanged);
            // 
            // chkBx_Server
            // 
            this.chkBx_Server.AutoSize = true;
            this.chkBx_Server.Checked = true;
            this.chkBx_Server.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBx_Server.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.chkBx_Server.ForeColor = System.Drawing.Color.White;
            this.chkBx_Server.Location = new System.Drawing.Point(681, 247);
            this.chkBx_Server.Margin = new System.Windows.Forms.Padding(4);
            this.chkBx_Server.Name = "chkBx_Server";
            this.chkBx_Server.Size = new System.Drawing.Size(170, 26);
            this.chkBx_Server.TabIndex = 14;
            this.chkBx_Server.Text = "Same as above";
            this.chkBx_Server.UseVisualStyleBackColor = true;
            this.chkBx_Server.CheckedChanged += new System.EventHandler(this.chkBx_Server_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(35, 101);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 26);
            this.checkBox1.TabIndex = 14;
            this.checkBox1.Text = "ArcGIS Server";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Provide the user credentials:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(31, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "Is the environment federated?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select the environment below to run the checks";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 22);
            this.label1.TabIndex = 12;
            this.label1.Text = "This application is developed for performing ArcGIS System profiling to generate " +
    "report for ArcGIS Enterprise";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1138, 676);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InitialForm";
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_Enterprise.ResumeLayout(false);
            this.panel_Enterprise.PerformLayout();
            this.panel_Server.ResumeLayout(false);
            this.panel_Server.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_Enterprise;
        private System.Windows.Forms.TextBox txtPortalPassword;
        private System.Windows.Forms.TextBox txtPortalUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_agsEnt;
        private System.Windows.Forms.Panel panel_Server;
        private System.Windows.Forms.TextBox txtAGSServerPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAGSServerUserName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_agsServer;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBx_DataStoreHostName;
        private System.Windows.Forms.TextBox txtBx_ServerHostName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox chkBx_DataStore;
        private System.Windows.Forms.CheckBox chkBx_Server;
        private System.Windows.Forms.TextBox txtBx_ServerInstance;
        private System.Windows.Forms.TextBox txtBx_PortalInstance;
        private System.Windows.Forms.TextBox txtBx_PortalHostName;
        private System.Windows.Forms.Button btn_EditInstanceName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_LoginStatus;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}