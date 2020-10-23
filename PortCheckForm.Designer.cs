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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_PerformPortCheck = new System.Windows.Forms.Button();
            this.dataGridViewPorts = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.radioButtonClosed = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButtonAll = new System.Windows.Forms.RadioButton();
            this.txtBx_Filter = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonPortNoFilter = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Port_Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Port_Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPorts)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.Port_Status,
            this.Port_Type});
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_PerformPortCheck);
            this.panel1.Controls.Add(this.dataGridViewPorts);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.panel1.Size = new System.Drawing.Size(1106, 748);
            this.panel1.TabIndex = 2;
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonOpen.ForeColor = System.Drawing.Color.White;
            this.radioButtonOpen.Location = new System.Drawing.Point(655, 13);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(78, 26);
            this.radioButtonOpen.TabIndex = 32;
            this.radioButtonOpen.Text = "Open";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // radioButtonClosed
            // 
            this.radioButtonClosed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonClosed.AutoSize = true;
            this.radioButtonClosed.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonClosed.ForeColor = System.Drawing.Color.White;
            this.radioButtonClosed.Location = new System.Drawing.Point(756, 13);
            this.radioButtonClosed.Name = "radioButtonClosed";
            this.radioButtonClosed.Size = new System.Drawing.Size(93, 26);
            this.radioButtonClosed.TabIndex = 32;
            this.radioButtonClosed.Text = "Closed";
            this.radioButtonClosed.UseVisualStyleBackColor = true;
            this.radioButtonClosed.CheckedChanged += new System.EventHandler(this.radioButtonClosed_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.radioButtonAll);
            this.panel2.Controls.Add(this.radioButtonOpen);
            this.panel2.Controls.Add(this.radioButtonClosed);
            this.panel2.Location = new System.Drawing.Point(224, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(870, 51);
            this.panel2.TabIndex = 33;
            // 
            // radioButtonAll
            // 
            this.radioButtonAll.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonAll.AutoSize = true;
            this.radioButtonAll.Checked = true;
            this.radioButtonAll.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonAll.ForeColor = System.Drawing.Color.White;
            this.radioButtonAll.Location = new System.Drawing.Point(569, 13);
            this.radioButtonAll.Name = "radioButtonAll";
            this.radioButtonAll.Size = new System.Drawing.Size(51, 26);
            this.radioButtonAll.TabIndex = 32;
            this.radioButtonAll.TabStop = true;
            this.radioButtonAll.Text = "All";
            this.radioButtonAll.UseVisualStyleBackColor = true;
            this.radioButtonAll.CheckedChanged += new System.EventHandler(this.radioButtonAll_CheckedChanged);
            // 
            // txtBx_Filter
            // 
            this.txtBx_Filter.Location = new System.Drawing.Point(374, 17);
            this.txtBx_Filter.Name = "txtBx_Filter";
            this.txtBx_Filter.Size = new System.Drawing.Size(97, 20);
            this.txtBx_Filter.TabIndex = 33;
            this.txtBx_Filter.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBx_Filter_KeyUp);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.radioButton1);
            this.panel3.Controls.Add(this.radioButtonPortNoFilter);
            this.panel3.Controls.Add(this.txtBx_Filter);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(555, 51);
            this.panel3.TabIndex = 34;
            // 
            // radioButtonPortNoFilter
            // 
            this.radioButtonPortNoFilter.AutoSize = true;
            this.radioButtonPortNoFilter.Checked = true;
            this.radioButtonPortNoFilter.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButtonPortNoFilter.ForeColor = System.Drawing.Color.White;
            this.radioButtonPortNoFilter.Location = new System.Drawing.Point(272, 11);
            this.radioButtonPortNoFilter.Name = "radioButtonPortNoFilter";
            this.radioButtonPortNoFilter.Size = new System.Drawing.Size(96, 26);
            this.radioButtonPortNoFilter.TabIndex = 34;
            this.radioButtonPortNoFilter.TabStop = true;
            this.radioButtonPortNoFilter.Text = "Port no";
            this.radioButtonPortNoFilter.UseVisualStyleBackColor = true;
            this.radioButtonPortNoFilter.CheckedChanged += new System.EventHandler(this.radioButtonPortNoFilter_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(131, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 26);
            this.radioButton1.TabIndex = 34;
            this.radioButton1.Text = "Description";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 35;
            this.label1.Text = "Filter by: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(477, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 26);
            this.button1.TabIndex = 36;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Port_Number
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_Number.DefaultCellStyle = dataGridViewCellStyle2;
            this.Port_Number.HeaderText = "Port Number";
            this.Port_Number.Name = "Port_Number";
            this.Port_Number.ReadOnly = true;
            this.Port_Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Port_Number.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // Port_Type
            // 
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold);
            this.Port_Type.DefaultCellStyle = dataGridViewCellStyle5;
            this.Port_Type.HeaderText = "Port Type";
            this.Port_Type.Name = "Port_Type";
            this.Port_Type.ReadOnly = true;
            this.Port_Type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Port_Type.Width = 200;
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
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_PerformPortCheck;
        private System.Windows.Forms.DataGridView dataGridViewPorts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonOpen;
        private System.Windows.Forms.RadioButton radioButtonClosed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButtonPortNoFilter;
        private System.Windows.Forms.TextBox txtBx_Filter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Port_Type;
    }
}