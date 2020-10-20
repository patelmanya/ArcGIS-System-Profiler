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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAGSServerUserName = new System.Windows.Forms.TextBox();
            this.txtAGSServerPassword = new System.Windows.Forms.TextBox();
            this.btn_agsServer = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPortalUserName = new System.Windows.Forms.TextBox();
            this.txtPortalPassword = new System.Windows.Forms.TextBox();
            this.btn_agsEnt = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel_Server = new System.Windows.Forms.Panel();
            this.panel_Enterprise = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_Server.SuspendLayout();
            this.panel_Enterprise.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1019, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "This application is developed for performing ArcGIS System profiling to generate " +
    "report for ArcGIS Enterprise";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(31, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(449, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select the environment below to run the checks";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(37, 95);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(161, 26);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "ArcGIS Server";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.checkBox2.ForeColor = System.Drawing.Color.White;
            this.checkBox2.Location = new System.Drawing.Point(260, 95);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(184, 26);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Portal for ArcGIS";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(33, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Is the environment federated?";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(330, 140);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 26);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Yes";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(436, 140);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(53, 26);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.Text = "No";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(278, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Provide the user credentials:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Username:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 141);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 1;
            this.label6.Text = "Password:";
            // 
            // txtAGSServerUserName
            // 
            this.txtAGSServerUserName.Location = new System.Drawing.Point(175, 92);
            this.txtAGSServerUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtAGSServerUserName.Name = "txtAGSServerUserName";
            this.txtAGSServerUserName.Size = new System.Drawing.Size(356, 26);
            this.txtAGSServerUserName.TabIndex = 4;
            // 
            // txtAGSServerPassword
            // 
            this.txtAGSServerPassword.Location = new System.Drawing.Point(175, 141);
            this.txtAGSServerPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtAGSServerPassword.Name = "txtAGSServerPassword";
            this.txtAGSServerPassword.Size = new System.Drawing.Size(356, 26);
            this.txtAGSServerPassword.TabIndex = 5;
            // 
            // btn_agsServer
            // 
            this.btn_agsServer.BackColor = System.Drawing.Color.DimGray;
            this.btn_agsServer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsServer.ForeColor = System.Drawing.Color.Black;
            this.btn_agsServer.Location = new System.Drawing.Point(359, 196);
            this.btn_agsServer.Margin = new System.Windows.Forms.Padding(6);
            this.btn_agsServer.Name = "btn_agsServer";
            this.btn_agsServer.Size = new System.Drawing.Size(173, 49);
            this.btn_agsServer.TabIndex = 6;
            this.btn_agsServer.Text = "Start";
            this.btn_agsServer.UseVisualStyleBackColor = false;
            this.btn_agsServer.Click += new System.EventHandler(this.btn_agsServer_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(25, 23);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "ArcGIS Server";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 89);
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
            this.label9.Location = new System.Drawing.Point(10, 141);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 22);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password:";
            // 
            // txtPortalUserName
            // 
            this.txtPortalUserName.Location = new System.Drawing.Point(160, 92);
            this.txtPortalUserName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortalUserName.Name = "txtPortalUserName";
            this.txtPortalUserName.Size = new System.Drawing.Size(356, 26);
            this.txtPortalUserName.TabIndex = 4;
            this.txtPortalUserName.Text = "portaladmin";
            // 
            // txtPortalPassword
            // 
            this.txtPortalPassword.Location = new System.Drawing.Point(160, 141);
            this.txtPortalPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPortalPassword.Name = "txtPortalPassword";
            this.txtPortalPassword.Size = new System.Drawing.Size(356, 26);
            this.txtPortalPassword.TabIndex = 5;
            this.txtPortalPassword.Text = "password123";
            // 
            // btn_agsEnt
            // 
            this.btn_agsEnt.BackColor = System.Drawing.Color.DimGray;
            this.btn_agsEnt.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsEnt.ForeColor = System.Drawing.Color.Black;
            this.btn_agsEnt.Location = new System.Drawing.Point(344, 196);
            this.btn_agsEnt.Margin = new System.Windows.Forms.Padding(6);
            this.btn_agsEnt.Name = "btn_agsEnt";
            this.btn_agsEnt.Size = new System.Drawing.Size(173, 49);
            this.btn_agsEnt.TabIndex = 6;
            this.btn_agsEnt.Text = "Start";
            this.btn_agsEnt.UseVisualStyleBackColor = false;
            this.btn_agsEnt.Click += new System.EventHandler(this.btn_agsEnt_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 23);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 22);
            this.label10.TabIndex = 6;
            this.label10.Text = "ArcGIS Enterprise";
            // 
            // panel_Server
            // 
            this.panel_Server.Controls.Add(this.txtAGSServerPassword);
            this.panel_Server.Controls.Add(this.label7);
            this.panel_Server.Controls.Add(this.label5);
            this.panel_Server.Controls.Add(this.txtAGSServerUserName);
            this.panel_Server.Controls.Add(this.label6);
            this.panel_Server.Controls.Add(this.btn_agsServer);
            this.panel_Server.Location = new System.Drawing.Point(570, 226);
            this.panel_Server.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Server.Name = "panel_Server";
            this.panel_Server.Size = new System.Drawing.Size(542, 262);
            this.panel_Server.TabIndex = 7;
            this.panel_Server.Visible = false;
            // 
            // panel_Enterprise
            // 
            this.panel_Enterprise.Controls.Add(this.txtPortalPassword);
            this.panel_Enterprise.Controls.Add(this.txtPortalUserName);
            this.panel_Enterprise.Controls.Add(this.label10);
            this.panel_Enterprise.Controls.Add(this.label8);
            this.panel_Enterprise.Controls.Add(this.label9);
            this.panel_Enterprise.Controls.Add(this.btn_agsEnt);
            this.panel_Enterprise.Location = new System.Drawing.Point(31, 226);
            this.panel_Enterprise.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Enterprise.Name = "panel_Enterprise";
            this.panel_Enterprise.Size = new System.Drawing.Size(531, 262);
            this.panel_Enterprise.TabIndex = 8;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 546);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1138, 10);
            this.bottomPanel.TabIndex = 9;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1128, 10);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(10, 536);
            this.rightPanel.TabIndex = 9;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1138, 10);
            this.topPanel.TabIndex = 9;
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 10);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(10, 536);
            this.leftPanel.TabIndex = 9;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(31, 504);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1081, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1138, 556);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.panel_Enterprise);
            this.Controls.Add(this.panel_Server);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "InitialForm";
            this.Text = "InitialForm";
            this.panel_Server.ResumeLayout(false);
            this.panel_Server.PerformLayout();
            this.panel_Enterprise.ResumeLayout(false);
            this.panel_Enterprise.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAGSServerUserName;
        private System.Windows.Forms.TextBox txtAGSServerPassword;
        private System.Windows.Forms.Button btn_agsServer;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_agsEnt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPortalPassword;
        private System.Windows.Forms.TextBox txtPortalUserName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel_Server;
        private System.Windows.Forms.Panel panel_Enterprise;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}