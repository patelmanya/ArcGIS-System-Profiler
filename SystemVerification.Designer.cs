namespace ArcGIS_System_Profiler
{
    partial class SystemVerification
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
            this.btn_PerformSysValidations = new System.Windows.Forms.Button();
            this.btn_NextStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelBody = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panelBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_PerformSysValidations);
            this.panel1.Controls.Add(this.btn_NextStep);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 64);
            this.panel1.TabIndex = 0;
            // 
            // btn_PerformSysValidations
            // 
            this.btn_PerformSysValidations.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PerformSysValidations.BackColor = System.Drawing.Color.LightGray;
            this.btn_PerformSysValidations.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformSysValidations.ForeColor = System.Drawing.Color.Black;
            this.btn_PerformSysValidations.Location = new System.Drawing.Point(699, 15);
            this.btn_PerformSysValidations.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PerformSysValidations.Name = "btn_PerformSysValidations";
            this.btn_PerformSysValidations.Size = new System.Drawing.Size(223, 33);
            this.btn_PerformSysValidations.TabIndex = 34;
            this.btn_PerformSysValidations.Text = "Perform System validation";
            this.btn_PerformSysValidations.UseVisualStyleBackColor = false;
            this.btn_PerformSysValidations.Click += new System.EventHandler(this.btn_PerformSysValidations_Click);
            // 
            // btn_NextStep
            // 
            this.btn_NextStep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_NextStep.BackColor = System.Drawing.Color.LightGray;
            this.btn_NextStep.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NextStep.ForeColor = System.Drawing.Color.Black;
            this.btn_NextStep.Location = new System.Drawing.Point(934, 15);
            this.btn_NextStep.Margin = new System.Windows.Forms.Padding(6);
            this.btn_NextStep.Name = "btn_NextStep";
            this.btn_NextStep.Size = new System.Drawing.Size(173, 33);
            this.btn_NextStep.TabIndex = 33;
            this.btn_NextStep.Text = "Next Step";
            this.btn_NextStep.UseVisualStyleBackColor = false;
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
            this.label1.Size = new System.Drawing.Size(195, 42);
            this.label1.TabIndex = 30;
            this.label1.Text = "System validations";
            // 
            // panelBody
            // 
            this.panelBody.Controls.Add(this.tableLayoutPanel1);
            this.panelBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBody.Location = new System.Drawing.Point(0, 64);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1122, 573);
            this.panelBody.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1122, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // SystemVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1122, 637);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemVerification";
            this.Text = "SystemVerification";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelBody.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PerformSysValidations;
        private System.Windows.Forms.Button btn_NextStep;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}