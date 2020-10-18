namespace ArcGIS_System_Profiler
{
    partial class ScreenCaptureForm
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnPortalCheck = new System.Windows.Forms.Button();
            this.labelStep = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnServerCheck = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdateURL = new System.Windows.Forms.Button();
            this.txtBox_WebUrl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(13, 81);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(845, 554);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Visible = false;
            // 
            // btnNextStep
            // 
            this.btnNextStep.BackColor = System.Drawing.Color.DimGray;
            this.btnNextStep.Enabled = false;
            this.btnNextStep.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnNextStep.ForeColor = System.Drawing.Color.Black;
            this.btnNextStep.Location = new System.Drawing.Point(886, 704);
            this.btnNextStep.Margin = new System.Windows.Forms.Padding(4);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(175, 34);
            this.btnNextStep.TabIndex = 4;
            this.btnNextStep.Text = "Next";
            this.btnNextStep.UseVisualStyleBackColor = false;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnPortalCheck
            // 
            this.btnPortalCheck.BackColor = System.Drawing.Color.DimGray;
            this.btnPortalCheck.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnPortalCheck.ForeColor = System.Drawing.Color.Black;
            this.btnPortalCheck.Location = new System.Drawing.Point(160, 704);
            this.btnPortalCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnPortalCheck.Name = "btnPortalCheck";
            this.btnPortalCheck.Size = new System.Drawing.Size(355, 34);
            this.btnPortalCheck.TabIndex = 4;
            this.btnPortalCheck.Text = "Perform Portal System Health Check";
            this.btnPortalCheck.UseVisualStyleBackColor = false;
            this.btnPortalCheck.Click += new System.EventHandler(this.btnPortalCheck_Click);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStep.Location = new System.Drawing.Point(94, 9);
            this.labelStep.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(93, 22);
            this.labelStep.TabIndex = 5;
            this.labelStep.Text = "Step 1 of ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 718);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 20);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save to Word";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Black;
            this.button4.Location = new System.Drawing.Point(12, 689);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 21);
            this.button4.TabIndex = 6;
            this.button4.Text = "Save multi image";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnServerCheck
            // 
            this.btnServerCheck.BackColor = System.Drawing.Color.DimGray;
            this.btnServerCheck.Enabled = false;
            this.btnServerCheck.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnServerCheck.ForeColor = System.Drawing.Color.Black;
            this.btnServerCheck.Location = new System.Drawing.Point(523, 704);
            this.btnServerCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnServerCheck.Name = "btnServerCheck";
            this.btnServerCheck.Size = new System.Drawing.Size(355, 34);
            this.btnServerCheck.TabIndex = 7;
            this.btnServerCheck.Text = "Perform ArcGIS Server System Health Check";
            this.btnServerCheck.UseVisualStyleBackColor = false;
            this.btnServerCheck.Click += new System.EventHandler(this.btnServerCheck_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelStep);
            this.panel1.Location = new System.Drawing.Point(864, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(281, 554);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(270, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 44);
            this.label1.TabIndex = 2;
            this.label1.Text = "1. Click Perform Portal System Health Check button";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 129);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.MaximumSize = new System.Drawing.Size(270, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 66);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. Click Perform ArcGIS Server System Health Check button";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(1069, 704);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 34);
            this.button2.TabIndex = 4;
            this.button2.Text = "Site Mgr";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // btnUpdateURL
            // 
            this.btnUpdateURL.BackColor = System.Drawing.Color.DimGray;
            this.btnUpdateURL.Font = new System.Drawing.Font("Arial", 9.8F, System.Drawing.FontStyle.Bold);
            this.btnUpdateURL.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateURL.Location = new System.Drawing.Point(962, 39);
            this.btnUpdateURL.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateURL.Name = "btnUpdateURL";
            this.btnUpdateURL.Size = new System.Drawing.Size(175, 34);
            this.btnUpdateURL.TabIndex = 11;
            this.btnUpdateURL.Text = "Edit";
            this.btnUpdateURL.UseVisualStyleBackColor = false;
            this.btnUpdateURL.Click += new System.EventHandler(this.btnUpdateURL_Click);
            // 
            // txtBox_WebUrl
            // 
            this.txtBox_WebUrl.Enabled = false;
            this.txtBox_WebUrl.Location = new System.Drawing.Point(118, 13);
            this.txtBox_WebUrl.Margin = new System.Windows.Forms.Padding(4);
            this.txtBox_WebUrl.Name = "txtBox_WebUrl";
            this.txtBox_WebUrl.Size = new System.Drawing.Size(1019, 22);
            this.txtBox_WebUrl.TabIndex = 10;
            this.txtBox_WebUrl.Text = "minint-4ja7213.services.esriaustralia.com.au";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Web URL";
            // 
            // ScreenCaptureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 751);
            this.Controls.Add(this.btnUpdateURL);
            this.Controls.Add(this.txtBox_WebUrl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnServerCheck);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPortalCheck);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.webBrowser1);
            this.Name = "ScreenCaptureForm";
            this.Text = "ScreenCaptureForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPortalCheck;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnServerCheck;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdateURL;
        private System.Windows.Forms.TextBox txtBox_WebUrl;
        private System.Windows.Forms.Label label3;
    }
}