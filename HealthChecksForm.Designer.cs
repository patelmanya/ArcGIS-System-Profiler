namespace ArcGIS_System_Profiler
{
    partial class HealthChecksForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_PerformPortHealthCheck = new System.Windows.Forms.Button();
            this.btn_PerformSrvrHealthCheck = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnUpdateURL = new System.Windows.Forms.Button();
            this.txtBox_WebUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateURL);
            this.panel1.Controls.Add(this.txtBox_WebUrl);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_PerformSrvrHealthCheck);
            this.panel1.Controls.Add(this.btn_PerformPortHealthCheck);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1106, 88);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1106, 660);
            this.panel2.TabIndex = 1;
            // 
            // btn_PerformPortHealthCheck
            // 
            this.btn_PerformPortHealthCheck.BackColor = System.Drawing.Color.DimGray;
            this.btn_PerformPortHealthCheck.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformPortHealthCheck.ForeColor = System.Drawing.Color.Black;
            this.btn_PerformPortHealthCheck.Location = new System.Drawing.Point(183, 46);
            this.btn_PerformPortHealthCheck.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PerformPortHealthCheck.Name = "btn_PerformPortHealthCheck";
            this.btn_PerformPortHealthCheck.Size = new System.Drawing.Size(300, 30);
            this.btn_PerformPortHealthCheck.TabIndex = 31;
            this.btn_PerformPortHealthCheck.Text = "Perform Portal for ArcGIS Health Check";
            this.btn_PerformPortHealthCheck.UseVisualStyleBackColor = false;
            this.btn_PerformPortHealthCheck.Click += new System.EventHandler(this.btn_PerformPortHealthCheck_Click);
            // 
            // btn_PerformSrvrHealthCheck
            // 
            this.btn_PerformSrvrHealthCheck.BackColor = System.Drawing.Color.DimGray;
            this.btn_PerformSrvrHealthCheck.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformSrvrHealthCheck.ForeColor = System.Drawing.Color.Black;
            this.btn_PerformSrvrHealthCheck.Location = new System.Drawing.Point(512, 46);
            this.btn_PerformSrvrHealthCheck.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PerformSrvrHealthCheck.Name = "btn_PerformSrvrHealthCheck";
            this.btn_PerformSrvrHealthCheck.Size = new System.Drawing.Size(300, 30);
            this.btn_PerformSrvrHealthCheck.TabIndex = 31;
            this.btn_PerformSrvrHealthCheck.Text = "Perform ArcGIS Server Health Check";
            this.btn_PerformSrvrHealthCheck.UseVisualStyleBackColor = false;
            this.btn_PerformSrvrHealthCheck.Click += new System.EventHandler(this.btn_PerformSrvrHealthCheck_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1106, 660);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // btnUpdateURL
            // 
            this.btnUpdateURL.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateURL.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateURL.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateURL.Location = new System.Drawing.Point(884, 11);
            this.btnUpdateURL.Name = "btnUpdateURL";
            this.btnUpdateURL.Size = new System.Drawing.Size(131, 28);
            this.btnUpdateURL.TabIndex = 34;
            this.btnUpdateURL.Text = "Edit";
            this.btnUpdateURL.UseVisualStyleBackColor = false;
            this.btnUpdateURL.Click += new System.EventHandler(this.btnUpdateURL_Click);
            // 
            // txtBox_WebUrl
            // 
            this.txtBox_WebUrl.Enabled = false;
            this.txtBox_WebUrl.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_WebUrl.Location = new System.Drawing.Point(113, 12);
            this.txtBox_WebUrl.Name = "txtBox_WebUrl";
            this.txtBox_WebUrl.Size = new System.Drawing.Size(765, 25);
            this.txtBox_WebUrl.TabIndex = 33;
            this.txtBox_WebUrl.Text = "lea-305263.services.esriaustralia.com.au";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(14, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 22);
            this.label3.TabIndex = 32;
            this.label3.Text = "Web URL";
            // 
            // HealthChecksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1106, 748);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "HealthChecksForm";
            this.Text = "Health Checks";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_PerformSrvrHealthCheck;
        private System.Windows.Forms.Button btn_PerformPortHealthCheck;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnUpdateURL;
        private System.Windows.Forms.TextBox txtBox_WebUrl;
        private System.Windows.Forms.Label label3;
    }
}