﻿
namespace ArcGIS_System_Profiler
{
    partial class AGOLReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AGOLReport));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.includeFolderscheckBox = new System.Windows.Forms.CheckBox();
            this.btnGenerateServicesExcelReport = new System.Windows.Forms.Button();
            this.btn_GetServices = new System.Windows.Forms.Button();
            this.txtBx_ServicesURL = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AGS_dataGridView = new System.Windows.Forms.DataGridView();
            this.checkBoxCol_Service = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Service_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGS_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.includeFolderscheckBox);
            this.panel1.Controls.Add(this.btnGenerateServicesExcelReport);
            this.panel1.Controls.Add(this.btn_GetServices);
            this.panel1.Controls.Add(this.txtBx_ServicesURL);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 136);
            this.panel1.TabIndex = 0;
            // 
            // includeFolderscheckBox
            // 
            this.includeFolderscheckBox.AutoSize = true;
            this.includeFolderscheckBox.Checked = true;
            this.includeFolderscheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.includeFolderscheckBox.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.includeFolderscheckBox.ForeColor = System.Drawing.Color.White;
            this.includeFolderscheckBox.Location = new System.Drawing.Point(246, 95);
            this.includeFolderscheckBox.Name = "includeFolderscheckBox";
            this.includeFolderscheckBox.Size = new System.Drawing.Size(167, 26);
            this.includeFolderscheckBox.TabIndex = 31;
            this.includeFolderscheckBox.Text = "Include folders";
            this.includeFolderscheckBox.UseVisualStyleBackColor = true;
            // 
            // btnGenerateServicesExcelReport
            // 
            this.btnGenerateServicesExcelReport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateServicesExcelReport.BackColor = System.Drawing.Color.LightGray;
            this.btnGenerateServicesExcelReport.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateServicesExcelReport.ForeColor = System.Drawing.Color.Black;
            this.btnGenerateServicesExcelReport.Location = new System.Drawing.Point(646, 94);
            this.btnGenerateServicesExcelReport.Margin = new System.Windows.Forms.Padding(6);
            this.btnGenerateServicesExcelReport.Name = "btnGenerateServicesExcelReport";
            this.btnGenerateServicesExcelReport.Size = new System.Drawing.Size(276, 33);
            this.btnGenerateServicesExcelReport.TabIndex = 30;
            this.btnGenerateServicesExcelReport.Text = "Generate All Services Excel Report";
            this.btnGenerateServicesExcelReport.UseVisualStyleBackColor = false;
            this.btnGenerateServicesExcelReport.Visible = false;
            this.btnGenerateServicesExcelReport.Click += new System.EventHandler(this.btnGenerateServicesExcelReport_Click);
            // 
            // btn_GetServices
            // 
            this.btn_GetServices.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetServices.BackColor = System.Drawing.Color.LightGray;
            this.btn_GetServices.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetServices.ForeColor = System.Drawing.Color.Black;
            this.btn_GetServices.Location = new System.Drawing.Point(934, 94);
            this.btn_GetServices.Margin = new System.Windows.Forms.Padding(6);
            this.btn_GetServices.Name = "btn_GetServices";
            this.btn_GetServices.Size = new System.Drawing.Size(173, 33);
            this.btn_GetServices.TabIndex = 27;
            this.btn_GetServices.Text = "Get";
            this.btn_GetServices.UseVisualStyleBackColor = false;
            this.btn_GetServices.Click += new System.EventHandler(this.btn_GetServices_Click);
            // 
            // txtBx_ServicesURL
            // 
            this.txtBx_ServicesURL.Font = new System.Drawing.Font("Arial", 12F);
            this.txtBx_ServicesURL.Location = new System.Drawing.Point(246, 62);
            this.txtBx_ServicesURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtBx_ServicesURL.Name = "txtBx_ServicesURL";
            this.txtBx_ServicesURL.Size = new System.Drawing.Size(878, 26);
            this.txtBx_ServicesURL.TabIndex = 26;
            this.txtBx_ServicesURL.Text = resources.GetString("txtBx_ServicesURL.Text");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(14, 66);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 22);
            this.label11.TabIndex = 25;
            this.label11.Text = "ArcGIS Online Endpoint: ";
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
            this.label1.Size = new System.Drawing.Size(352, 42);
            this.label1.TabIndex = 24;
            this.label1.Text = "Get the services from ArcGIS Online";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AGS_dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1122, 501);
            this.panel2.TabIndex = 1;
            // 
            // AGS_dataGridView
            // 
            this.AGS_dataGridView.AllowUserToResizeColumns = false;
            this.AGS_dataGridView.AllowUserToResizeRows = false;
            this.AGS_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.AGS_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AGS_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AGS_dataGridView.ColumnHeadersHeight = 33;
            this.AGS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AGS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxCol_Service,
            this.Service_Name,
            this.Service_Type});
            this.AGS_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AGS_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.AGS_dataGridView.Name = "AGS_dataGridView";
            this.AGS_dataGridView.RowHeadersVisible = false;
            this.AGS_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AGS_dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AGS_dataGridView.Size = new System.Drawing.Size(1122, 501);
            this.AGS_dataGridView.TabIndex = 33;
            // 
            // checkBoxCol_Service
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.NullValue = false;
            this.checkBoxCol_Service.DefaultCellStyle = dataGridViewCellStyle2;
            this.checkBoxCol_Service.HeaderText = "";
            this.checkBoxCol_Service.Name = "checkBoxCol_Service";
            this.checkBoxCol_Service.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.checkBoxCol_Service.Width = 150;
            // 
            // Service_Name
            // 
            this.Service_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Service_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.Service_Name.HeaderText = "Service Name";
            this.Service_Name.Name = "Service_Name";
            this.Service_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Service_Name.ToolTipText = "Service Name";
            // 
            // Service_Type
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Service_Type.DefaultCellStyle = dataGridViewCellStyle4;
            this.Service_Type.HeaderText = "Type";
            this.Service_Type.Name = "Service_Type";
            this.Service_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Service_Type.ToolTipText = "Service Type";
            this.Service_Type.Width = 200;
            // 
            // AGOLReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGOLReport";
            this.Text = "AGOLReport";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AGS_dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_GetServices;
        private System.Windows.Forms.TextBox txtBx_ServicesURL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AGS_dataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxCol_Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Type;
        private System.Windows.Forms.Button btnGenerateServicesExcelReport;
        private System.Windows.Forms.CheckBox includeFolderscheckBox;
    }
}