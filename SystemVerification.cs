using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class SystemVerification : Form
    {
        public SystemVerification()
        {
            InitializeComponent();
        }

        private void btn_PerformSysValidations_Click(object sender, EventArgs e)
        {
            string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);

            DriveInfo drive1 = new DriveInfo(driveLetter);

            //ProgressBar pBar = new ProgressBar();
            //pBar.Value = 50;
            //pBar.Dock = DockStyle.Bottom;
            //panelBody.Controls.Add(pBar);

            // txtBx_SysVerResponse.Text += drive1.TotalFreeSpace + "\r\n";
            //txtBx_SysVerResponse.Text += drive1.AvailableFreeSpace + "\r\n"; ;

            //tableLayoutPanel1.ColumnCount = DriveInfo.GetDrives().Length;
            //tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
           // tableLayoutPanel1.ColumnStyles[0].Width = 50;
            tableLayoutPanel1.RowCount = DriveInfo.GetDrives().Length * 2;
            tableLayoutPanel1.Dock = DockStyle.Top;
            

            int loopRowCounter = 1;

            //get all logical drives info
            foreach (var drive in DriveInfo.GetDrives())
            {
                double freeSpace = drive.TotalFreeSpace;
                double totalSpace = drive.TotalSize;
                double percentFree = (freeSpace / totalSpace) * 100;
                float num = (float)percentFree;

                Console.WriteLine("Drive:{0} With {1} % free", drive.Name, num);
                Console.WriteLine("Space Remaining:{0}", drive.AvailableFreeSpace);
                Console.WriteLine("Percent Free Space:{0}", percentFree);
                Console.WriteLine("Space used:{0}", drive.TotalSize);
                Console.WriteLine("Type: {0}", drive.DriveType);

               // tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

                Label lblDriveName = new Label();
                lblDriveName.Name = "DriveName_" + loopRowCounter.ToString();
                lblDriveName.Dock = DockStyle.Top;
                lblDriveName.Text = drive.Name;
                lblDriveName.Font = label1.Font;
                lblDriveName.ForeColor = label1.ForeColor;
                tableLayoutPanel1.Controls.Add(lblDriveName, loopRowCounter, 1);
                loopRowCounter += loopRowCounter;

                //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
                ProgressBar pBar = new ProgressBar();
                pBar.Value = (int) percentFree;
                pBar.Dock = DockStyle.Top;
                tableLayoutPanel1.Controls.Add(pBar, loopRowCounter, 1);
                loopRowCounter += loopRowCounter;
            }

            tableLayoutPanel1.AutoSize = true;
        }
    }
}
