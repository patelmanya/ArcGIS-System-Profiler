using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
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

            panel1.BackColor = globalVariables.themeColor;
            panelBody.BackColor = globalVariables.themeColor;
            tableLayoutPanel1.BackColor = globalVariables.themeColor;
            //System.Object[] ItemObject = new System.Object[10];
            //for (int i = 0; i <= 9; i++)
            //{
            //    ItemObject[i] = "Item" + i;
            //}
            //comboBoxProduct.Items.AddRange(ItemObject);
            ////comboBoxProduct.Items.Add();

            comboBoxProduct.Items.Add("Select Product");
            comboBoxProduct.Items.Add("ArcGIS Enterprise Builder");
            comboBoxProduct.Items.Add("Portal for ArcGIS");
            comboBoxProduct.Items.Add("Scene Viewer");
            comboBoxProduct.Items.Add("ArcGIS Server");
            comboBoxProduct.Items.Add("ArcGIS Web Adaptor");
            comboBoxProduct.Items.Add("ArcGIS Data Store");
            comboBoxProduct.Items.Add("ArcGIS Enterprise SDK");
            comboBoxProduct.Items.Add("ArcGIS Notebook Server");
            comboBoxProduct.Items.Add("ArcGIS Mission Server");
            //comboBoxProduct.Items.Add("");

            comboBoxVersion.Items.Add("Select Version");
            comboBoxVersion.Items.Add("10.8");
            comboBoxVersion.Items.Add("10.7");
            comboBoxVersion.Items.Add("10.6");
            comboBoxVersion.Items.Add("10.5");

            //set the selected index
            comboBoxProduct.SelectedIndex = 0;
            comboBoxVersion.SelectedIndex = 0;
        }

        private void btn_PerformSysValidations_Click(object sender, EventArgs e)
        {
            if (comboBoxProduct.SelectedItem.ToString() == "Select Product" && comboBoxVersion.SelectedItem.ToString() == "Select Version")
            {
                MessageBox.Show("Please select Product and Version!");
            }
            else if (comboBoxProduct.SelectedItem.ToString() != "Select Product" && comboBoxVersion.SelectedItem.ToString() == "Select Version")
            {
                MessageBox.Show("Please select Version!");
            }
            else if (comboBoxProduct.SelectedItem.ToString() == "Select Product" && comboBoxVersion.SelectedItem.ToString() != "Select Version")
            {
                MessageBox.Show("Please select Product!");
            }
            else if (comboBoxProduct.SelectedItem.ToString() == "Portal for ArcGIS" && comboBoxVersion.SelectedItem.ToString() == "10.8")
            {

                //OPERATING SYSTEM
                lblOperatingSystem.Text = "Operating System: ";
                var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                            select x.GetPropertyValue("Caption")).FirstOrDefault();
                lblOperatingSystem.Text += name;
                statusOS.Visible = true;


                //PROCESSOR TYPE
                if (Environment.Is64BitOperatingSystem)
                {
                    lblProcessorType.Text = "Processer type (Only 64-bit is supported): 64 bit Processor,";
                    statusProcessor.Visible = true;
                    // failProcessor.Visible = false;
                    //get the number of cores for processor
                    if (Environment.ProcessorCount < 2)
                    {
                        lblProcessorType.Text += " NOT SUITABLE, 2 cores development and testing, 4 cores minimum for production systems.";
                    }
                    else if (Environment.ProcessorCount == 2)
                    {
                        lblProcessorType.Text += " SUITABLE, 2 cores development and testing, 4 cores minimum for production systems.";
                    }
                    else if (Environment.ProcessorCount > 2)
                    {
                        lblProcessorType.Text += Environment.ProcessorCount.ToString() + " Processors. \r\n 2 cores development and testing, 4 cores minimum for production systems.";
                    }

                }
                else
                {
                    lblProcessorType.Text = "Processer type (Only 64-bit is supported): 32 bit Processor";
                    statusProcessor.Visible = false;
                    // failProcessor.Visible = true;
                }


                //TotalVisibleMemorySize: 
                //This value specifies the total amount, in kilobytes, of physical memory available to the operating system. This value does not necessarily indicate the true amount of physical memory, but what is reported to the operating system as available to it.
                //FreePhysicalMemory: 
                //Number, in kilobytes, of physical memory currently unused and available.
                //TotalVirtualMemorySize: 
                //Number, in kilobytes, of virtual memory.For example, this may be calculated by adding the amount of total RAM to the amount of paging space, that is, adding the amount of memory in or aggregated by the computer system to the property, SizeStoredInPagingFiles.
                //FreeVirtualMemory: 
                //Specifies the number, in kilobytes, of virtual memory currently unused and available.

                //MEMORY
                ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
                ManagementObjectCollection results = searcher.Get();

                double res;

                foreach (ManagementObject result in results)
                {
                    res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                    double fres = Math.Round((res / (1024 * 1024)), 2);
                    lblMemory.Text = "RAM: ";
                    lblMemory.Text += Math.Ceiling(fres).ToString() + " GB";
                    if (Math.Ceiling(fres) > 8)
                    {
                        statusMemory.Visible = true;
                        // failMemory.Visible = false;
                    }
                    else
                    {
                        // failMemory.Visible = true;
                        statusMemory.Visible = false;
                    }

                    res = Convert.ToDouble(result["FreePhysicalMemory"]);

                    res = Convert.ToDouble(result["TotalVirtualMemorySize"]);

                    res = Convert.ToDouble(result["FreeVirtualMemory"]);
                }


                //DISK SPACE
                lblDiskSpaceTitle.Text = "Disk space: ";
                var count = tableLayoutPanel1.RowCount;
                var totalDrives = DriveInfo.GetDrives().Length;
                if (totalDrives == 2)
                {
                    tableLayoutPanel1.RowCount += 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                    Label lblDyn = new Label();
                    lblDyn.Text = "This is Dynamic Text";
                    lblDyn.Font = new Font("Arial", 12);
                    lblDyn.ForeColor = Color.White;
                    lblDyn.Dock = DockStyle.Fill;
                    tableLayoutPanel1.Controls.Add(lblDyn, 0, tableLayoutPanel1.RowCount);

                    IconPictureBox iCPicBx = new IconPictureBox();
                    iCPicBx.Dock = DockStyle.Fill;
                    iCPicBx.ForeColor = Color.LawnGreen;
                    iCPicBx.IconChar = IconChar.CheckCircle;
                    iCPicBx.Margin = new Padding(50, 3, 3, 3); ;
                    tableLayoutPanel1.Controls.Add(iCPicBx, 1, tableLayoutPanel1.RowCount);

                }
                foreach (var drive in DriveInfo.GetDrives())
                {
                    double freeSpace = drive.TotalFreeSpace;
                    double totalSpace = drive.TotalSize;
                    double percentFree = (freeSpace / totalSpace) * 100;
                    float num = (float)percentFree;

                    if ((drive.Name.Substring(0, 1)).ToUpper() == "C")
                    {
                        lblDiskSpace1.Text = drive.Name.Substring(0, 1) + " drive " + (Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)).ToString() + " GB free of " + (Math.Round((totalSpace / (1024 * 1024 * 1024)), 0)).ToString() + " GB ";

                        if ((Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)) > 10)
                        {
                            statusDiskSpace1.Visible = true;
                            //failDiskSpace1.Visible = false;
                        }
                        else
                        {
                            //failDiskSpace1.Visible = true;
                            statusDiskSpace1.Visible = false;
                        }
                    }
                    else
                    {
                        lblDiskSpace2.Text = drive.Name.Substring(0, 1) + " drive " + (Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)).ToString() + " GB free of " + (Math.Round((totalSpace / (1024 * 1024 * 1024)), 0)).ToString() + " GB ";

                        //if ((Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)) > 10)
                        //{
                        //    passDiskSpace2.Visible = true;
                        //    failDiskSpace2.Visible = false;
                        //}
                        //else
                        //{
                        //    failDiskSpace2.Visible = true;
                        //    passDiskSpace2.Visible = false;
                        //}

                        if ((Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)) > 10)
                        {
                            statusDiskSpace2.Visible = true;
                        }
                        else
                        {
                            statusDiskSpace2.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                            statusDiskSpace2.ForeColor = Color.Red;
                            statusDiskSpace2.Visible = true;
                        }
                    }
                }



                //MACHINE NAME
                string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
                string hostName = Dns.GetHostName();

                domainName = "." + domainName;
                if (!hostName.EndsWith(domainName))  // if hostname does not already include domain name
                {
                    hostName += domainName;   // add the domain name part
                    if (hostName.Contains("_"))
                    {
                        statusMachineName.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                        statusMachineName.ForeColor = Color.Red;
                    }
                    else
                    {
                        statusMachineName.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                        statusMachineName.ForeColor = Color.LawnGreen;
                    }

                    statusMachineName.Visible = true;
                }
                else
                {
                    //hostName = hostName;
                    statusMachineName.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    statusMachineName.ForeColor = Color.Red;
                    statusMachineName.Visible = true;
                }

                lblMachineName.Text = "Machine name: " + hostName.ToString();

                //INTERNET ACCESS
                bool interAccess = CheckForInternetConnection();
                if (interAccess)
                {
                    lblInternetAccess.Text = "Internet access: Available";
                    statusInternetAccess.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                    statusInternetAccess.ForeColor = Color.LawnGreen;
                    statusInternetAccess.Visible = true;
                }
                else
                {
                    lblInternetAccess.Text = "Internet access: Unavailable";
                    statusInternetAccess.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                    statusInternetAccess.ForeColor = Color.Red;
                    statusInternetAccess.Visible = true;
                }


            }
            // string driveLetter = Path.GetPathRoot(Environment.CurrentDirectory);

            // DriveInfo drive1 = new DriveInfo(driveLetter);

            // //ProgressBar pBar = new ProgressBar();
            // //pBar.Value = 50;
            // //pBar.Dock = DockStyle.Bottom;
            // //panelBody.Controls.Add(pBar);

            // // txtBx_SysVerResponse.Text += drive1.TotalFreeSpace + "\r\n";
            // //txtBx_SysVerResponse.Text += drive1.AvailableFreeSpace + "\r\n"; ;

            // //tableLayoutPanel1.ColumnCount = DriveInfo.GetDrives().Length;
            // //tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
            //// tableLayoutPanel1.ColumnStyles[0].Width = 50;
            // tableLayoutPanel1.RowCount = DriveInfo.GetDrives().Length * 2;
            // tableLayoutPanel1.Dock = DockStyle.Top;


            // int loopRowCounter = 1;

            // //get all logical drives info
            // foreach (var drive in DriveInfo.GetDrives())
            // {
            //     double freeSpace = drive.TotalFreeSpace;
            //     double totalSpace = drive.TotalSize;
            //     double percentFree = (freeSpace / totalSpace) * 100;
            //     float num = (float)percentFree;

            //     Console.WriteLine("Drive:{0} With {1} % free", drive.Name, num);
            //     Console.WriteLine("Space Remaining:{0}", drive.AvailableFreeSpace);
            //     Console.WriteLine("Percent Free Space:{0}", percentFree);
            //     Console.WriteLine("Space used:{0}", drive.TotalSize);
            //     Console.WriteLine("Type: {0}", drive.DriveType);

            //    // tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50));

            //     Label lblDriveName = new Label();
            //     lblDriveName.Name = "DriveName_" + loopRowCounter.ToString();
            //     lblDriveName.Dock = DockStyle.Top;
            //     lblDriveName.Text = drive.Name;
            //     lblDriveName.Font = label1.Font;
            //     lblDriveName.ForeColor = label1.ForeColor;
            //     tableLayoutPanel1.Controls.Add(lblDriveName, loopRowCounter, 1);
            //     loopRowCounter += loopRowCounter;

            //     //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50));
            //     ProgressBar pBar = new ProgressBar();
            //     pBar.Value = (int) percentFree;
            //     pBar.Dock = DockStyle.Top;
            //     tableLayoutPanel1.Controls.Add(pBar, loopRowCounter, 1);
            //     loopRowCounter += loopRowCounter;
            // }

            // tableLayoutPanel1.AutoSize = true;
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            globalVariables.globalForm.btn_Tasks.PerformClick();
        }

        public static bool CheckForInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://google.com/generate_204"))
                    return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
