﻿namespace ArcGIS_System_Profiler
{
    partial class AGSDatastoreValidations
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AGSDS_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_GetDataStores = new System.Windows.Forms.Button();
            this.btn_ValidateDataStores = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_NextStep = new System.Windows.Forms.Button();
            this.checkBoxCol_Service = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewImageColumn();
            this.Service_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Service_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AGSDS_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 676);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.AGSDS_dataGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 108);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 568);
            this.panel3.TabIndex = 1;
            // 
            // AGSDS_dataGridView
            // 
            this.AGSDS_dataGridView.AllowUserToResizeColumns = false;
            this.AGSDS_dataGridView.AllowUserToResizeRows = false;
            this.AGSDS_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AGSDS_dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.AGSDS_dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AGSDS_dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.AGSDS_dataGridView.ColumnHeadersHeight = 33;
            this.AGSDS_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.AGSDS_dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkBoxCol_Service,
            this.Status,
            this.Service_Name,
            this.Service_Type});
            this.AGSDS_dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AGSDS_dataGridView.Location = new System.Drawing.Point(0, 0);
            this.AGSDS_dataGridView.Name = "AGSDS_dataGridView";
            this.AGSDS_dataGridView.RowHeadersVisible = false;
            this.AGSDS_dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.AGSDS_dataGridView.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(5);
            this.AGSDS_dataGridView.RowTemplate.DividerHeight = 1;
            this.AGSDS_dataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AGSDS_dataGridView.Size = new System.Drawing.Size(1138, 568);
            this.AGSDS_dataGridView.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btn_GetDataStores);
            this.panel2.Controls.Add(this.btn_ValidateDataStores);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_NextStep);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 108);
            this.panel2.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(121, 66);
            this.button2.Margin = new System.Windows.Forms.Padding(6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 33);
            this.button2.TabIndex = 34;
            this.button2.Text = "Clear All";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(15, 66);
            this.button1.Margin = new System.Windows.Forms.Padding(6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 33);
            this.button1.TabIndex = 34;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_GetDataStores
            // 
            this.btn_GetDataStores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_GetDataStores.BackColor = System.Drawing.Color.LightGray;
            this.btn_GetDataStores.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GetDataStores.ForeColor = System.Drawing.Color.Black;
            this.btn_GetDataStores.Location = new System.Drawing.Point(580, 66);
            this.btn_GetDataStores.Margin = new System.Windows.Forms.Padding(6);
            this.btn_GetDataStores.Name = "btn_GetDataStores";
            this.btn_GetDataStores.Size = new System.Drawing.Size(173, 33);
            this.btn_GetDataStores.TabIndex = 33;
            this.btn_GetDataStores.Text = "Get Datastores Info";
            this.btn_GetDataStores.UseVisualStyleBackColor = false;
            this.btn_GetDataStores.Click += new System.EventHandler(this.btn_GetDataStores_Click);
            // 
            // btn_ValidateDataStores
            // 
            this.btn_ValidateDataStores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ValidateDataStores.BackColor = System.Drawing.Color.LightGray;
            this.btn_ValidateDataStores.Enabled = false;
            this.btn_ValidateDataStores.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValidateDataStores.ForeColor = System.Drawing.Color.Black;
            this.btn_ValidateDataStores.Location = new System.Drawing.Point(765, 66);
            this.btn_ValidateDataStores.Margin = new System.Windows.Forms.Padding(6);
            this.btn_ValidateDataStores.Name = "btn_ValidateDataStores";
            this.btn_ValidateDataStores.Size = new System.Drawing.Size(173, 33);
            this.btn_ValidateDataStores.TabIndex = 32;
            this.btn_ValidateDataStores.Text = "Validate Datastores";
            this.btn_ValidateDataStores.UseVisualStyleBackColor = false;
            this.btn_ValidateDataStores.Click += new System.EventHandler(this.btn_ValidateDataStores_Click);
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
            this.label1.Size = new System.Drawing.Size(477, 42);
            this.label1.TabIndex = 29;
            this.label1.Text = "Perform ArcGIS Datastore validations and checks";
            // 
            // btn_NextStep
            // 
            this.btn_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextStep.BackColor = System.Drawing.Color.LightGray;
            this.btn_NextStep.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextStep.ForeColor = System.Drawing.Color.Black;
            this.btn_NextStep.Location = new System.Drawing.Point(950, 66);
            this.btn_NextStep.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NextStep.Name = "btn_NextStep";
            this.btn_NextStep.Size = new System.Drawing.Size(173, 33);
            this.btn_NextStep.TabIndex = 28;
            this.btn_NextStep.Text = "Next Step";
            this.btn_NextStep.UseVisualStyleBackColor = false;
            this.btn_NextStep.Click += new System.EventHandler(this.btn_NextStep_Click);
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
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Image = global::ArcGIS_System_Profiler.Properties.Resources.initIcon;
            this.Status.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Service_Name
            // 
            this.Service_Name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Service_Name.DefaultCellStyle = dataGridViewCellStyle3;
            this.Service_Name.HeaderText = "Name";
            this.Service_Name.Name = "Service_Name";
            this.Service_Name.ReadOnly = true;
            this.Service_Name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Service_Name.ToolTipText = "Name";
            // 
            // Service_Type
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Service_Type.DefaultCellStyle = dataGridViewCellStyle4;
            this.Service_Type.HeaderText = "Type";
            this.Service_Type.Name = "Service_Type";
            this.Service_Type.ReadOnly = true;
            this.Service_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Service_Type.ToolTipText = "Service Type";
            this.Service_Type.Width = 200;
            // 
            // AGSDatastoreValidations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(44)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1138, 676);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AGSDatastoreValidations";
            this.Text = "AGSDatastoreValidations";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AGSDS_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_NextStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ValidateDataStores;
        private System.Windows.Forms.DataGridView AGSDS_dataGridView;
        private System.Windows.Forms.Button btn_GetDataStores;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkBoxCol_Service;
        private System.Windows.Forms.DataGridViewImageColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service_Type;
    }
}