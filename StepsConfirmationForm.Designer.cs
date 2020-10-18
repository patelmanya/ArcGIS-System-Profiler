namespace ArcGIS_System_Profiler
{
    partial class StepsConfirmationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.btn_agsServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "The program will perform the below checks, you may choose to opt out of the list " +
    "below:";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(17, 54);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(741, 463);
            this.checkedListBox1.TabIndex = 2;
            // 
            // btn_agsServer
            // 
            this.btn_agsServer.BackColor = System.Drawing.Color.DimGray;
            this.btn_agsServer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agsServer.ForeColor = System.Drawing.Color.Black;
            this.btn_agsServer.Location = new System.Drawing.Point(632, 528);
            this.btn_agsServer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_agsServer.Name = "btn_agsServer";
            this.btn_agsServer.Size = new System.Drawing.Size(126, 34);
            this.btn_agsServer.TabIndex = 7;
            this.btn_agsServer.Text = "Next";
            this.btn_agsServer.UseVisualStyleBackColor = false;
            this.btn_agsServer.Click += new System.EventHandler(this.btn_agsServer_Click);
            // 
            // StepsConfirmationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 575);
            this.Controls.Add(this.btn_agsServer);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label1);
            this.Name = "StepsConfirmationForm";
            this.Text = "StepsConfirmationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button btn_agsServer;
    }
}