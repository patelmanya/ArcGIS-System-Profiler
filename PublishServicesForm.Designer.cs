namespace ArcGIS_System_Profiler
{
    partial class PublishServicesForm
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
            this.btnPublishService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NextStep = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtBx_GenServStatus = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnPublishService);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_NextStep);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnPublishService
            // 
            this.btnPublishService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPublishService.BackColor = System.Drawing.Color.LightGray;
            this.btnPublishService.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPublishService.ForeColor = System.Drawing.Color.Black;
            this.btnPublishService.Location = new System.Drawing.Point(749, 78);
            this.btnPublishService.Margin = new System.Windows.Forms.Padding(6);
            this.btnPublishService.Name = "btnPublishService";
            this.btnPublishService.Size = new System.Drawing.Size(173, 33);
            this.btnPublishService.TabIndex = 32;
            this.btnPublishService.Text = "Publish Service";
            this.btnPublishService.UseVisualStyleBackColor = false;
            this.btnPublishService.Click += new System.EventHandler(this.btnPublishService_Click);
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
            this.label1.Size = new System.Drawing.Size(245, 42);
            this.label1.TabIndex = 31;
            this.label1.Text = "Publish ArcGIS Services";
            // 
            // btn_NextStep
            // 
            this.btn_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextStep.BackColor = System.Drawing.Color.LightGray;
            this.btn_NextStep.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextStep.ForeColor = System.Drawing.Color.Black;
            this.btn_NextStep.Location = new System.Drawing.Point(934, 78);
            this.btn_NextStep.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NextStep.Name = "btn_NextStep";
            this.btn_NextStep.Size = new System.Drawing.Size(173, 33);
            this.btn_NextStep.TabIndex = 30;
            this.btn_NextStep.Text = "Next Step";
            this.btn_NextStep.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 120);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 517);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtBx_GenServStatus);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel3.Size = new System.Drawing.Size(1122, 517);
            this.panel3.TabIndex = 2;
            // 
            // txtBx_GenServStatus
            // 
            this.txtBx_GenServStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtBx_GenServStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_GenServStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_GenServStatus.Font = new System.Drawing.Font("Arial", 14F);
            this.txtBx_GenServStatus.ForeColor = System.Drawing.Color.White;
            this.txtBx_GenServStatus.Location = new System.Drawing.Point(20, 0);
            this.txtBx_GenServStatus.Name = "txtBx_GenServStatus";
            this.txtBx_GenServStatus.ReadOnly = true;
            this.txtBx_GenServStatus.Size = new System.Drawing.Size(1082, 517);
            this.txtBx_GenServStatus.TabIndex = 0;
            this.txtBx_GenServStatus.Text = "";
            // 
            // PublishServicesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PublishServicesForm";
            this.Text = "PublishServicesForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPublishService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_NextStep;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RichTextBox txtBx_GenServStatus;
    }
}