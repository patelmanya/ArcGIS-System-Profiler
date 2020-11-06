namespace ArcGIS_System_Profiler
{
    partial class GenerateReport
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
            this.btnOpenReport = new System.Windows.Forms.Button();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBx_GenRepStatus = new System.Windows.Forms.RichTextBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSendEmail);
            this.panel1.Controls.Add(this.btnOpenReport);
            this.panel1.Controls.Add(this.btn_GenerateReport);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 64);
            this.panel1.TabIndex = 0;
            // 
            // btnOpenReport
            // 
            this.btnOpenReport.BackColor = System.Drawing.Color.LightGray;
            this.btnOpenReport.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenReport.ForeColor = System.Drawing.Color.Black;
            this.btnOpenReport.Location = new System.Drawing.Point(474, 14);
            this.btnOpenReport.Name = "btnOpenReport";
            this.btnOpenReport.Size = new System.Drawing.Size(178, 28);
            this.btnOpenReport.TabIndex = 11;
            this.btnOpenReport.Text = "Open Report";
            this.btnOpenReport.UseVisualStyleBackColor = false;
            this.btnOpenReport.Visible = false;
            this.btnOpenReport.Click += new System.EventHandler(this.btnOpenReport_Click);
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.BackColor = System.Drawing.Color.LightGray;
            this.btn_GenerateReport.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateReport.ForeColor = System.Drawing.Color.Black;
            this.btn_GenerateReport.Location = new System.Drawing.Point(280, 14);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(178, 28);
            this.btn_GenerateReport.TabIndex = 10;
            this.btn_GenerateReport.Text = "Generate Report";
            this.btn_GenerateReport.UseVisualStyleBackColor = false;
            this.btn_GenerateReport.Click += new System.EventHandler(this.btn_GenerateReport_Click);
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
            this.label1.Size = new System.Drawing.Size(274, 42);
            this.label1.TabIndex = 9;
            this.label1.Text = "Final step: Generate report ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtBx_GenRepStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 64);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.panel2.Size = new System.Drawing.Size(1138, 612);
            this.panel2.TabIndex = 1;
            // 
            // txtBx_GenRepStatus
            // 
            this.txtBx_GenRepStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.txtBx_GenRepStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBx_GenRepStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBx_GenRepStatus.Font = new System.Drawing.Font("Arial", 14F);
            this.txtBx_GenRepStatus.ForeColor = System.Drawing.Color.White;
            this.txtBx_GenRepStatus.Location = new System.Drawing.Point(20, 0);
            this.txtBx_GenRepStatus.Name = "txtBx_GenRepStatus";
            this.txtBx_GenRepStatus.ReadOnly = true;
            this.txtBx_GenRepStatus.Size = new System.Drawing.Size(1098, 612);
            this.txtBx_GenRepStatus.TabIndex = 0;
            this.txtBx_GenRepStatus.Text = "";
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.BackColor = System.Drawing.Color.LightGray;
            this.btnSendEmail.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendEmail.ForeColor = System.Drawing.Color.Black;
            this.btnSendEmail.Location = new System.Drawing.Point(658, 14);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(178, 28);
            this.btnSendEmail.TabIndex = 11;
            this.btnSendEmail.Text = "Send Report to Email";
            this.btnSendEmail.UseVisualStyleBackColor = false;
            this.btnSendEmail.Visible = false;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // GenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1138, 676);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateReport";
            this.Text = "Generate Report";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.RichTextBox txtBx_GenRepStatus;
        private System.Windows.Forms.Button btnOpenReport;
        private System.Windows.Forms.Button btnSendEmail;
    }
}