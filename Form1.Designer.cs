namespace ArcGIS_System_Profiler
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBox_agsServerhostname = new System.Windows.Forms.TextBox();
            this.txtBox_agsEnterprisehostname = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.agsEnterpriselistBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.agsServerlistBox = new System.Windows.Forms.CheckedListBox();
            this.includeFolderscheckBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.FolderORServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.lbl_agsServerVer = new System.Windows.Forms.Label();
            this.lbl_agsEnterVer = new System.Windows.Forms.Label();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(706, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "This application is developed for performing ArcGIS System profiling to generate " +
    "report for ArcGIS Enterprise";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parameters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "ArcGIS Server endpoint";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ArcGIS Enterprise endpoint";
            // 
            // txtBox_agsServerhostname
            // 
            this.txtBox_agsServerhostname.Location = new System.Drawing.Point(221, 72);
            this.txtBox_agsServerhostname.Name = "txtBox_agsServerhostname";
            this.txtBox_agsServerhostname.Size = new System.Drawing.Size(375, 20);
            this.txtBox_agsServerhostname.TabIndex = 2;
            this.txtBox_agsServerhostname.Text = "https://minint-4ja7213.services.esriaustralia.com.au/arcgis/rest/";
            // 
            // txtBox_agsEnterprisehostname
            // 
            this.txtBox_agsEnterprisehostname.Location = new System.Drawing.Point(222, 135);
            this.txtBox_agsEnterprisehostname.Name = "txtBox_agsEnterprisehostname";
            this.txtBox_agsEnterprisehostname.Size = new System.Drawing.Size(375, 20);
            this.txtBox_agsEnterprisehostname.TabIndex = 2;
            this.txtBox_agsEnterprisehostname.Text = "https://minint-4ja7213.services.esriaustralia.com.au/portal/";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(603, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Get Services";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(603, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Get Items";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 241);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(772, 377);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.agsServerlistBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(764, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "ArcGIS Server";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.agsEnterpriselistBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ArcGIS Portal";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // agsEnterpriselistBox
            // 
            this.agsEnterpriselistBox.FormattingEnabled = true;
            this.agsEnterpriselistBox.Location = new System.Drawing.Point(7, 242);
            this.agsEnterpriselistBox.Name = "agsEnterpriselistBox";
            this.agsEnterpriselistBox.Size = new System.Drawing.Size(751, 147);
            this.agsEnterpriselistBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Details";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(219, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(351, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Example: https://minint-4ja7213.services.esriaustralia.com.au/arcgis/rest/";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(218, 158);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(326, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "Example: https://minint-4ja7213.services.esriaustralia.com.au/portal";
            // 
            // agsServerlistBox
            // 
            this.agsServerlistBox.FormattingEnabled = true;
            this.agsServerlistBox.Location = new System.Drawing.Point(7, 7);
            this.agsServerlistBox.Name = "agsServerlistBox";
            this.agsServerlistBox.Size = new System.Drawing.Size(747, 94);
            this.agsServerlistBox.TabIndex = 1;
            this.agsServerlistBox.Visible = false;
            // 
            // includeFolderscheckBox
            // 
            this.includeFolderscheckBox.AutoSize = true;
            this.includeFolderscheckBox.Location = new System.Drawing.Point(222, 114);
            this.includeFolderscheckBox.Name = "includeFolderscheckBox";
            this.includeFolderscheckBox.Size = new System.Drawing.Size(95, 17);
            this.includeFolderscheckBox.TabIndex = 6;
            this.includeFolderscheckBox.Text = "Include folders";
            this.includeFolderscheckBox.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.FolderORServiceName,
            this.ItemType});
            this.dataGridView1.Location = new System.Drawing.Point(9, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(747, 179);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // FolderORServiceName
            // 
            this.FolderORServiceName.HeaderText = "Folder OR Service Name";
            this.FolderORServiceName.Name = "FolderORServiceName";
            this.FolderORServiceName.Width = 400;
            // 
            // ItemType
            // 
            this.ItemType.HeaderText = "Item Type";
            this.ItemType.Name = "ItemType";
            this.ItemType.Width = 200;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeight = 30;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView2.Location = new System.Drawing.Point(7, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.Size = new System.Drawing.Size(747, 384);
            this.dataGridView2.TabIndex = 4;
            // 
            // lbl_agsServerVer
            // 
            this.lbl_agsServerVer.AutoSize = true;
            this.lbl_agsServerVer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agsServerVer.Location = new System.Drawing.Point(16, 211);
            this.lbl_agsServerVer.Name = "lbl_agsServerVer";
            this.lbl_agsServerVer.Size = new System.Drawing.Size(160, 17);
            this.lbl_agsServerVer.TabIndex = 1;
            this.lbl_agsServerVer.Text = "ArcGIS Server version: ";
            // 
            // lbl_agsEnterVer
            // 
            this.lbl_agsEnterVer.AutoSize = true;
            this.lbl_agsEnterVer.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_agsEnterVer.Location = new System.Drawing.Point(414, 211);
            this.lbl_agsEnterVer.Name = "lbl_agsEnterVer";
            this.lbl_agsEnterVer.Size = new System.Drawing.Size(184, 17);
            this.lbl_agsEnterVer.TabIndex = 1;
            this.lbl_agsEnterVer.Text = "ArcGIS Enterprise version: ";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.FillWeight = 38.07107F;
            this.dataGridViewCheckBoxColumn1.HeaderText = "";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.FillWeight = 130.9645F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Folder OR Service Name";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.FillWeight = 130.9645F;
            this.dataGridViewTextBoxColumn2.HeaderText = "Item Type";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 630);
            this.Controls.Add(this.includeFolderscheckBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBox_agsEnterprisehostname);
            this.Controls.Add(this.txtBox_agsServerhostname);
            this.Controls.Add(this.lbl_agsEnterVer);
            this.Controls.Add(this.lbl_agsServerVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "ArcGIS System Profiler";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBox_agsServerhostname;
        private System.Windows.Forms.TextBox txtBox_agsEnterprisehostname;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox agsEnterpriselistBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox agsServerlistBox;
        private System.Windows.Forms.CheckBox includeFolderscheckBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn FolderORServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemType;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label lbl_agsServerVer;
        private System.Windows.Forms.Label lbl_agsEnterVer;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}

