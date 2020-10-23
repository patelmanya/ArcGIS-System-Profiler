namespace ArcGIS_System_Profiler
{
    partial class TemplateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TemplateForm));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.topPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Publish = new System.Windows.Forms.Button();
            this.btn_HealthChecks = new System.Windows.Forms.Button();
            this.btn_Configuration = new System.Windows.Forms.Button();
            this.btn_Tasks = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panelCurrentStep = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formContainer = new System.Windows.Forms.Panel();
            this.globalProgressBar1 = new System.Windows.Forms.ProgressBar();
            this.globalTimer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 8);
            this.leftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(8, 718);
            this.leftPanel.TabIndex = 10;
            // 
            // rightPanel
            // 
            this.rightPanel.BackColor = System.Drawing.Color.White;
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Location = new System.Drawing.Point(1611, 8);
            this.rightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(8, 718);
            this.rightPanel.TabIndex = 11;
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Margin = new System.Windows.Forms.Padding(2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1619, 8);
            this.topPanel.TabIndex = 12;
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.White;
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 726);
            this.bottomPanel.Margin = new System.Windows.Forms.Padding(2);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(1619, 8);
            this.bottomPanel.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Controls.Add(this.btn_Publish);
            this.panel1.Controls.Add(this.btn_HealthChecks);
            this.panel1.Controls.Add(this.btn_Configuration);
            this.panel1.Controls.Add(this.btn_Tasks);
            this.panel1.Controls.Add(this.btn_Home);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(203, 718);
            this.panel1.TabIndex = 14;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Exit.FlatAppearance.BorderSize = 0;
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.White;
            this.btn_Exit.Image = ((System.Drawing.Image)(resources.GetObject("btn_Exit.Image")));
            this.btn_Exit.Location = new System.Drawing.Point(0, 578);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(203, 98);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Publish
            // 
            this.btn_Publish.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Publish.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Publish.Enabled = false;
            this.btn_Publish.FlatAppearance.BorderSize = 0;
            this.btn_Publish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Publish.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Publish.ForeColor = System.Drawing.Color.White;
            this.btn_Publish.Image = ((System.Drawing.Image)(resources.GetObject("btn_Publish.Image")));
            this.btn_Publish.Location = new System.Drawing.Point(0, 480);
            this.btn_Publish.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Publish.Name = "btn_Publish";
            this.btn_Publish.Size = new System.Drawing.Size(203, 98);
            this.btn_Publish.TabIndex = 5;
            this.btn_Publish.Text = "Publish";
            this.btn_Publish.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Publish.UseVisualStyleBackColor = true;
            this.btn_Publish.Click += new System.EventHandler(this.btn_Publish_Click);
            // 
            // btn_HealthChecks
            // 
            this.btn_HealthChecks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_HealthChecks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_HealthChecks.Enabled = false;
            this.btn_HealthChecks.FlatAppearance.BorderSize = 0;
            this.btn_HealthChecks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_HealthChecks.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_HealthChecks.ForeColor = System.Drawing.Color.White;
            this.btn_HealthChecks.Image = ((System.Drawing.Image)(resources.GetObject("btn_HealthChecks.Image")));
            this.btn_HealthChecks.Location = new System.Drawing.Point(0, 382);
            this.btn_HealthChecks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_HealthChecks.Name = "btn_HealthChecks";
            this.btn_HealthChecks.Size = new System.Drawing.Size(203, 98);
            this.btn_HealthChecks.TabIndex = 4;
            this.btn_HealthChecks.Text = "Health Checks";
            this.btn_HealthChecks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_HealthChecks.UseVisualStyleBackColor = true;
            this.btn_HealthChecks.Click += new System.EventHandler(this.btn_HealthChecks_Click);
            // 
            // btn_Configuration
            // 
            this.btn_Configuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Configuration.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Configuration.Enabled = false;
            this.btn_Configuration.FlatAppearance.BorderSize = 0;
            this.btn_Configuration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Configuration.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Configuration.ForeColor = System.Drawing.Color.White;
            this.btn_Configuration.Image = ((System.Drawing.Image)(resources.GetObject("btn_Configuration.Image")));
            this.btn_Configuration.Location = new System.Drawing.Point(0, 284);
            this.btn_Configuration.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Configuration.Name = "btn_Configuration";
            this.btn_Configuration.Size = new System.Drawing.Size(203, 98);
            this.btn_Configuration.TabIndex = 3;
            this.btn_Configuration.Text = "Configuration";
            this.btn_Configuration.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Configuration.UseVisualStyleBackColor = true;
            this.btn_Configuration.Click += new System.EventHandler(this.btn_Configuration_Click);
            // 
            // btn_Tasks
            // 
            this.btn_Tasks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Tasks.Enabled = false;
            this.btn_Tasks.FlatAppearance.BorderSize = 0;
            this.btn_Tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tasks.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Tasks.ForeColor = System.Drawing.Color.White;
            this.btn_Tasks.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tasks.Image")));
            this.btn_Tasks.Location = new System.Drawing.Point(0, 186);
            this.btn_Tasks.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Tasks.Name = "btn_Tasks";
            this.btn_Tasks.Size = new System.Drawing.Size(203, 98);
            this.btn_Tasks.TabIndex = 2;
            this.btn_Tasks.Text = "Tasks";
            this.btn_Tasks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Tasks.UseVisualStyleBackColor = true;
            this.btn_Tasks.Click += new System.EventHandler(this.btn_Tasks_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Home.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Home.FlatAppearance.BorderSize = 0;
            this.btn_Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Home.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Home.ForeColor = System.Drawing.Color.White;
            this.btn_Home.Image = ((System.Drawing.Image)(resources.GetObject("btn_Home.Image")));
            this.btn_Home.Location = new System.Drawing.Point(0, 88);
            this.btn_Home.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(203, 98);
            this.btn_Home.TabIndex = 1;
            this.btn_Home.Text = "Home";
            this.btn_Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 88);
            this.button1.TabIndex = 0;
            this.button1.Text = "System Tool";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panelCurrentStep
            // 
            this.panelCurrentStep.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelCurrentStep.Location = new System.Drawing.Point(0, 90);
            this.panelCurrentStep.Margin = new System.Windows.Forms.Padding(2);
            this.panelCurrentStep.Name = "panelCurrentStep";
            this.panelCurrentStep.Size = new System.Drawing.Size(10, 96);
            this.panelCurrentStep.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.formContainer);
            this.panel2.Controls.Add(this.globalProgressBar1);
            this.panel2.Controls.Add(this.panelCurrentStep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(211, 8);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 718);
            this.panel2.TabIndex = 15;
            // 
            // formContainer
            // 
            this.formContainer.Location = new System.Drawing.Point(15, 5);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(1380, 672);
            this.formContainer.TabIndex = 2;
            // 
            // globalProgressBar1
            // 
            this.globalProgressBar1.Location = new System.Drawing.Point(4, 682);
            this.globalProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.globalProgressBar1.Name = "globalProgressBar1";
            this.globalProgressBar1.Size = new System.Drawing.Size(1391, 30);
            this.globalProgressBar1.TabIndex = 1;
            this.globalProgressBar1.Visible = false;
            // 
            // globalTimer1
            // 
            this.globalTimer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TemplateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1619, 734);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TemplateForm";
            this.Text = "TemplateForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCurrentStep;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Publish;
        private System.Windows.Forms.Button btn_HealthChecks;
        private System.Windows.Forms.Button btn_Configuration;
        private System.Windows.Forms.Panel formContainer;
        private System.Windows.Forms.Button btn_Exit;
        internal System.Windows.Forms.Button btn_Tasks;
        internal System.Windows.Forms.ProgressBar globalProgressBar1;
        internal System.Windows.Forms.Timer globalTimer1;
    }
}