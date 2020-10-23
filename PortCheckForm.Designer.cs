namespace ArcGIS_System_Profiler
{
    partial class PortCheckForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_PerformPortCheck = new System.Windows.Forms.Button();
            this.dataGridViewPorts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Port_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 725);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1106, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_PerformPortCheck
            // 
            this.btn_PerformPortCheck.BackColor = System.Drawing.Color.DimGray;
            this.btn_PerformPortCheck.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PerformPortCheck.ForeColor = System.Drawing.Color.Black;
            this.btn_PerformPortCheck.Location = new System.Drawing.Point(28, 33);
            this.btn_PerformPortCheck.Margin = new System.Windows.Forms.Padding(6);
            this.btn_PerformPortCheck.Name = "btn_PerformPortCheck";
            this.btn_PerformPortCheck.Size = new System.Drawing.Size(173, 30);
            this.btn_PerformPortCheck.TabIndex = 30;
            this.btn_PerformPortCheck.Text = "Perform Port checks";
            this.btn_PerformPortCheck.UseVisualStyleBackColor = false;
            this.btn_PerformPortCheck.Click += new System.EventHandler(this.btn_PerformPortCheck_Click);
            // 
            // dataGridViewPorts
            // 
            this.dataGridViewPorts.AllowUserToResizeColumns = false;
            this.dataGridViewPorts.AllowUserToResizeRows = false;
            this.dataGridViewPorts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.dataGridViewPorts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPorts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPorts.ColumnHeadersHeight = 33;
            this.dataGridViewPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewPorts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Port_Number,
            this.Port_Description,
            this.Port_Status});
            this.dataGridViewPorts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPorts.Location = new System.Drawing.Point(0, 70);
            this.dataGridViewPorts.Name = "dataGridViewPorts";
            this.dataGridViewPorts.ReadOnly = true;
            this.dataGridViewPorts.RowHeadersVisible = false;
            this.dataGridViewPorts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPorts.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPorts.Size = new System.Drawing.Size(1106, 678);
            this.dataGridViewPorts.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.btn_PerformPortCheck);
            this.panel1.Controls.Add(this.dataGridViewPorts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1106, 748);
            this.panel1.TabIndex = 2;
            // 
            // Port_Number
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Port_Number.HeaderText = "Port Number";
            this.Port_Number.Name = "Port_Number";
            this.Port_Number.ReadOnly = true;
            this.Port_Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Port_Number.ToolTipText = "Port number";
            this.Port_Number.Width = 150;
            // 
            // Port_Description
            // 
            this.Port_Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Port_Description.DefaultCellStyle = dataGridViewCellStyle3;
            this.Port_Description.HeaderText = "Port Description";
            this.Port_Description.Name = "Port_Description";
            this.Port_Description.ReadOnly = true;
            this.Port_Description.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Port_Description.ToolTipText = "Description of Port";
            // 
            // Port_Status
            // 
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Port_Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Port_Status.HeaderText = "Port Status";
            this.Port_Status.Name = "Port_Status";
            this.Port_Status.ReadOnly = true;
            this.Port_Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Port_Status.ToolTipText = "Port Status";
            this.Port_Status.Width = 200;
            // 
            // PortCheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(79)))), ((int)(((byte)(105)))));
            this.ClientSize = new System.Drawing.Size(1106, 748);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "PortCheckForm";
            this.Text = "Port Checks";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_PerformPortCheck;
        private System.Windows.Forms.DataGridView dataGridViewPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Status;
    }
}