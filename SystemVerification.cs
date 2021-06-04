﻿using FontAwesome.Sharp;
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
            
            try
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

                comboBoxProduct.Items.Add("...");
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

                comboBoxVersion.Items.Add("...");
                comboBoxVersion.Items.Add("10.8");
                comboBoxVersion.Items.Add("10.7");
                comboBoxVersion.Items.Add("10.6");
                comboBoxVersion.Items.Add("10.5");

                //set the selected index
                comboBoxProduct.SelectedIndex = 0;
                comboBoxVersion.SelectedIndex = 0;
                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.RowCount = 1;
            }
            catch (System.Exception ex)
            {
                string errMsg = "SystemVerification.cs - SystemVerification InitializeComponent : " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_PerformSysValidations_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables gv = new globalVariables();

                tableLayoutPanel1.Visible = false;
                tableLayoutPanel1.RowCount = 1;
                tableLayoutPanel1.Controls.Clear(); //to remove all controls
                
                ////to remove control by Name     
                //foreach (Control item in tableLayoutPanel1.Controls.OfType<Control>())
                //{
                //    if (item.Name == "MACHINENAMEICON")
                //        panel1.Controls.Remove(item);
                //    if (item.Name == "MACHINENAMEICON")
                //        panel1.Controls.Remove(item);
                //    if (item.Name == "MACHINENAMEICON")
                //        panel1.Controls.Remove(item);
                //}

                //ADD THE HEADERS
                //tableLayoutPanel1.RowCount += 1;
                //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                Label lblDynHeaderDesc = new Label();
                lblDynHeaderDesc.Text = "DESCRIPTION";
                lblDynHeaderDesc.Font = new Font("Arial", 14, lblDynHeaderDesc.Font.Style & ~FontStyle.Bold);
                lblDynHeaderDesc.ForeColor = Color.White;
                lblDynHeaderDesc.Dock = DockStyle.Fill;
                lblDynHeaderDesc.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(lblDynHeaderDesc, 0, 0);

                //tableLayoutPanel1.RowCount += 1;
                //tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                Label lblDynHeaderStatus = new Label();
                lblDynHeaderStatus.Text = "STATUS";
                lblDynHeaderStatus.Font = new Font("Arial", 14, lblDynHeaderStatus.Font.Style & ~FontStyle.Bold);
                lblDynHeaderStatus.ForeColor = Color.White;
                lblDynHeaderStatus.Dock = DockStyle.Fill;
                lblDynHeaderStatus.TextAlign = ContentAlignment.MiddleCenter;
                tableLayoutPanel1.Controls.Add(lblDynHeaderStatus, 1, 0);

                if (comboBoxProduct.SelectedItem.ToString() == "..." && comboBoxVersion.SelectedItem.ToString() == "...")
                {
                    MessageBox.Show("Please select Product and Version!");
                }
                else if (comboBoxProduct.SelectedItem.ToString() != "..." && comboBoxVersion.SelectedItem.ToString() == "...")
                {
                    MessageBox.Show("Please select Version!");
                }
                else if (comboBoxProduct.SelectedItem.ToString() == "..." && comboBoxVersion.SelectedItem.ToString() != "...")
                {
                    MessageBox.Show("Please select Product!");
                }
                else if (comboBoxProduct.SelectedItem.ToString() == "Portal for ArcGIS" && comboBoxVersion.SelectedItem.ToString() == "10.8")
                {

                    //OPERATING SYSTEM
                    //lblOperatingSystem.Text = "Operating System: ";
                    //statusOS.Visible = true;
                    gv.loggerFunc("OPERATING SYSTEM");
                    var name = (from x in new ManagementObjectSearcher("SELECT Caption FROM Win32_OperatingSystem").Get().Cast<ManagementObject>()
                                select x.GetPropertyValue("Caption")).FirstOrDefault();
                    gv.loggerFunc(name.ToString());
                    tableLayoutPanel1.RowCount += 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                    Label lblOperatingSystem = new Label();
                    lblOperatingSystem.Text = "Operating System: " + name;
                    lblOperatingSystem.Font = new Font("Arial", 14);
                    lblOperatingSystem.ForeColor = Color.White;
                    lblOperatingSystem.Dock = DockStyle.Fill;
                    lblOperatingSystem.TextAlign = ContentAlignment.MiddleLeft;
                    tableLayoutPanel1.Controls.Add(lblOperatingSystem, 0, tableLayoutPanel1.RowCount - 1);
                    
                    gv.loggerFunc("OPERATING SYSTEM - details");

                    IconPictureBox statusOS = new IconPictureBox();
                    statusOS.Dock = DockStyle.Fill;
                    statusOS.ForeColor = Color.LawnGreen;
                    statusOS.IconChar = IconChar.CheckCircle;
                    statusOS.Margin = new Padding(50, 3, 3, 3);
                    tableLayoutPanel1.Controls.Add(statusOS, 1, tableLayoutPanel1.RowCount - 1);

                    gv.loggerFunc("OPERATING SYSTEM - icon");



                    //PROCESSOR TYPE

                    gv.loggerFunc("PROCESSOR TYPE");

                    tableLayoutPanel1.RowCount += 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                    Label lblProcessorType = new Label();
                    lblProcessorType.Font = new Font("Arial", 14);
                    lblProcessorType.ForeColor = Color.White;
                    lblProcessorType.Dock = DockStyle.Fill;
                    lblProcessorType.TextAlign = ContentAlignment.MiddleLeft;

                    gv.loggerFunc("PROCESSOR TYPE _ Details");

                    IconPictureBox statusProcessor = new IconPictureBox();
                    statusProcessor.Dock = DockStyle.Fill;
                    statusProcessor.Margin = new Padding(50, 3, 3, 3);


                    if (Environment.Is64BitOperatingSystem)
                    {
                        lblProcessorType.Text = "Processer type (Only 64-bit is supported): 64 bit Processor,";

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
                        statusProcessor.ForeColor = Color.LawnGreen;
                        statusProcessor.IconChar = IconChar.CheckCircle;

                    }
                    else
                    {
                        lblProcessorType.Text = "Processer type (Only 64-bit is supported): 32 bit Processor";
                        statusProcessor.ForeColor = Color.Red;
                        statusProcessor.IconChar = IconChar.TimesCircle;
                    }

                    gv.loggerFunc("OPERATING SYSTEM - ICON");

                    tableLayoutPanel1.Controls.Add(lblProcessorType, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(statusProcessor, 1, tableLayoutPanel1.RowCount - 1);


                    //TotalVisibleMemorySize: 
                    //This value specifies the total amount, in kilobytes, of physical memory available to the operating system. This value does not necessarily indicate the true amount of physical memory, but what is reported to the operating system as available to it.
                    //FreePhysicalMemory: 
                    //Number, in kilobytes, of physical memory currently unused and available.
                    //TotalVirtualMemorySize: 
                    //Number, in kilobytes, of virtual memory.For example, this may be calculated by adding the amount of total RAM to the amount of paging space, that is, adding the amount of memory in or aggregated by the computer system to the property, SizeStoredInPagingFiles.
                    //FreeVirtualMemory: 
                    //Specifies the number, in kilobytes, of virtual memory currently unused and available.

                    //MEMORY

                    gv.loggerFunc("MEMORY");

                    ObjectQuery wql = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
                    
                    gv.loggerFunc(wql.ToString());

                    ManagementObjectSearcher searcher = new ManagementObjectSearcher(wql);
                    ManagementObjectCollection results = searcher.Get();

                    double res;

                    tableLayoutPanel1.RowCount += 1;
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                    Label lblMemory = new Label();

                    lblMemory.Font = new Font("Arial", 14);
                    lblMemory.ForeColor = Color.White;
                    lblMemory.Dock = DockStyle.Fill;
                    lblMemory.TextAlign = ContentAlignment.MiddleLeft;

                    gv.loggerFunc("MEMORY Details");

                    IconPictureBox statusMemory = new IconPictureBox();
                    statusMemory.Dock = DockStyle.Fill;
                    statusMemory.Margin = new Padding(50, 3, 3, 3);


                    foreach (ManagementObject result in results)
                    {
                        res = Convert.ToDouble(result["TotalVisibleMemorySize"]);
                        double fres = Math.Round((res / (1024 * 1024)), 2);
                        lblMemory.Text = "RAM: ";
                        lblMemory.Text += Math.Ceiling(fres).ToString() + " GB";
                        if (Math.Ceiling(fres) > 8)
                        {
                            statusMemory.ForeColor = Color.LawnGreen;
                            statusMemory.IconChar = IconChar.CheckCircle;
                        }
                        else
                        {
                            statusMemory.ForeColor = Color.Red;
                            statusMemory.IconChar = IconChar.TimesCircle;
                        }

                        res = Convert.ToDouble(result["FreePhysicalMemory"]);

                        res = Convert.ToDouble(result["TotalVirtualMemorySize"]);

                        res = Convert.ToDouble(result["FreeVirtualMemory"]);
                    }

                    tableLayoutPanel1.Controls.Add(lblMemory, 0, tableLayoutPanel1.RowCount - 1);
                    tableLayoutPanel1.Controls.Add(statusMemory, 1, tableLayoutPanel1.RowCount - 1);
                    gv.loggerFunc("MEMORY - icon");


                    //DISK SPACE 
                    
                    gv.loggerFunc("DISK SPACE");
                    tableLayoutPanel1.RowCount += 1;

                    gv.loggerFunc("DISK SPACE rowcount+1");
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));

                    gv.loggerFunc("DISK SPACE row add styles");

                    Label lblDiskSpaceTitle = new Label();
                    lblDiskSpaceTitle.Text = "Disk Space Requirements";
                    lblDiskSpaceTitle.Font = new Font("Arial", 14, lblDiskSpaceTitle.Font.Style & ~FontStyle.Bold);
                    lblDiskSpaceTitle.ForeColor = Color.White;
                    lblDiskSpaceTitle.Dock = DockStyle.Fill;
                    lblDiskSpaceTitle.TextAlign = ContentAlignment.MiddleLeft;
                    tableLayoutPanel1.Controls.Add(lblDiskSpaceTitle, 0, tableLayoutPanel1.RowCount - 1);
                    gv.loggerFunc("DISK SPACE details");




                    foreach (var drive in DriveInfo.GetDrives())
                    {
                        gv.loggerFunc("DISK SPACE GetDrives");
                        if (drive.DriveType.ToString() == "Removable")
                        {
                            continue;
                        }
                        gv.loggerFunc(drive.DriveType.ToString());
                        gv.loggerFunc(drive.IsReady.ToString());
                        gv.loggerFunc(drive.VolumeLabel.ToString());
                        gv.loggerFunc(drive.DriveFormat.ToString());
                        gv.loggerFunc(drive.TotalSize.ToString());
                        gv.loggerFunc(drive.RootDirectory.ToString());

                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        
                        gv.loggerFunc("DISK SPACE add new row and styles");
                        gv.loggerFunc(drive.Name.Substring(0, 1));
                        double freeSpace = drive.TotalFreeSpace;
                        gv.loggerFunc("DISK SPACE freeSpace");
                        double totalSpace = drive.TotalSize;
                        gv.loggerFunc("DISK SPACE totalSpace");
                        double percentFree = (freeSpace / totalSpace) * 100;
                        gv.loggerFunc("DISK SPACE percentFree");
                        float num = (float)percentFree;
                        gv.loggerFunc("DISK SPACE num");
                        lblDiskSpaceTitle = new Label();
                        lblDiskSpaceTitle.Name = "driveLabel" + drive.Name.Substring(0, 1);
                        
                        gv.loggerFunc("DISK SPACE driveName");


                        lblDiskSpaceTitle.Font = new Font("Arial", 14);
                        lblDiskSpaceTitle.ForeColor = Color.White;
                        lblDiskSpaceTitle.Dock = DockStyle.Fill;
                        lblDiskSpaceTitle.TextAlign = ContentAlignment.MiddleLeft;
                        lblDiskSpaceTitle.Text = drive.Name.Substring(0, 1) + " drive " + (Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)).ToString() + " GB free of " + (Math.Round((totalSpace / (1024 * 1024 * 1024)), 0)).ToString() + " GB ";
                        gv.loggerFunc("DISK SPACE details");
                        if ((Math.Round((freeSpace / (1024 * 1024 * 1024)), 2)) > 10)
                        {
                            statusMemory = new IconPictureBox();
                            statusMemory.Dock = DockStyle.Fill;
                            statusMemory.Margin = new Padding(50, 3, 3, 3);
                            statusMemory.ForeColor = Color.LawnGreen;
                            statusMemory.IconChar = IconChar.CheckCircle;
                        }
                        else
                        {
                            statusMemory = new IconPictureBox();
                            statusMemory.Dock = DockStyle.Fill;
                            statusMemory.Margin = new Padding(50, 3, 3, 3); ;
                            statusMemory.ForeColor = Color.Red;
                            statusMemory.IconChar = IconChar.TimesCircle;
                        }
                        gv.loggerFunc("DISK SPACE icon");
                        tableLayoutPanel1.Controls.Add(lblDiskSpaceTitle, 0, tableLayoutPanel1.RowCount - 1);
                        tableLayoutPanel1.Controls.Add(statusMemory, 1, tableLayoutPanel1.RowCount - 1);
                        gv.loggerFunc("DISK SPACE control added");
                    }
                    gv.loggerFunc("MEMORY - Details and Icon");


                    //MACHINE NAME

                    gv.loggerFunc("MACHINE NAME");

                    string domainName = IPGlobalProperties.GetIPGlobalProperties().DomainName;
                    string hostName = Dns.GetHostName();

                    domainName = "." + domainName;
                    if (!hostName.EndsWith(domainName))  // if hostname does not already include domain name
                    {
                        hostName += domainName;   // add the domain name part
                        if (hostName.Contains("_"))
                        {
                            //statusMachineName.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                            // statusMachineName.ForeColor = Color.Red;
                            tableLayoutPanel1.RowCount += 1;
                            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                            Label lblDynMachineName = new Label();
                            lblDynMachineName.Text = "Machine name: " + hostName.ToString() + " Reason: Machine name cannot contain '_' underscore";
                            lblDynMachineName.Font = new Font("Arial", 14);
                            lblDynMachineName.Name = "MACHINENAMELABEL";
                            lblDynMachineName.ForeColor = Color.White;
                            lblDynMachineName.TextAlign = ContentAlignment.MiddleLeft;
                            lblDynMachineName.Dock = DockStyle.Fill;
                            tableLayoutPanel1.Controls.Add(lblDynMachineName, 0, tableLayoutPanel1.RowCount - 1);

                            IconPictureBox iCPicBxMachineName = new IconPictureBox();
                            iCPicBxMachineName.Dock = DockStyle.Fill;
                            iCPicBxMachineName.ForeColor = Color.Red;
                            iCPicBxMachineName.IconChar = IconChar.TimesCircle;
                            iCPicBxMachineName.Name = "MACHINENAMEICON";
                            iCPicBxMachineName.Margin = new Padding(50, 3, 3, 3);
                            tableLayoutPanel1.Controls.Add(iCPicBxMachineName, 1, tableLayoutPanel1.RowCount - 1);
                        }
                        else
                        {
                            //statusMachineName.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                            //statusMachineName.ForeColor = Color.LawnGreen;
                            tableLayoutPanel1.RowCount += 1;
                            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                            Label lblDynMachineName = new Label();
                            lblDynMachineName.Text = "Machine name: " + hostName.ToString();
                            lblDynMachineName.Font = new Font("Arial", 14);
                            lblDynMachineName.ForeColor = Color.White;
                            lblDynMachineName.Name = "MACHINENAMELABEL";
                            lblDynMachineName.Dock = DockStyle.Fill;
                            lblDynMachineName.TextAlign = ContentAlignment.MiddleLeft;
                            tableLayoutPanel1.Controls.Add(lblDynMachineName, 0, tableLayoutPanel1.RowCount - 1);

                            IconPictureBox iCPicBxMachineName = new IconPictureBox();
                            iCPicBxMachineName.Dock = DockStyle.Fill;
                            iCPicBxMachineName.ForeColor = Color.LawnGreen;
                            iCPicBxMachineName.IconChar = IconChar.CheckCircle;
                            iCPicBxMachineName.Name = "MACHINENAMEICON";
                            iCPicBxMachineName.Margin = new Padding(50, 3, 3, 3);
                            tableLayoutPanel1.Controls.Add(iCPicBxMachineName, 1, tableLayoutPanel1.RowCount - 1);
                        }

                        //statusMachineName.Visible = true;
                    }
                    else
                    {
                        //hostName = hostName;
                        //statusMachineName.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                        //statusMachineName.ForeColor = Color.Red;
                        //statusMachineName.Visible = true;

                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        Label lblDynMachineName = new Label();
                        lblDynMachineName.Text = "Machine name: " + hostName.ToString();
                        lblDynMachineName.Font = new Font("Arial", 14);
                        lblDynMachineName.ForeColor = Color.White;
                        lblDynMachineName.Name = "MACHINENAMELABEL";
                        lblDynMachineName.TextAlign = ContentAlignment.MiddleLeft;
                        lblDynMachineName.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(lblDynMachineName, 0, tableLayoutPanel1.RowCount - 1);

                        IconPictureBox iCPicBxMachineName = new IconPictureBox();
                        iCPicBxMachineName.Dock = DockStyle.Fill;
                        iCPicBxMachineName.Name = "MACHINENAMEICON";
                        iCPicBxMachineName.ForeColor = Color.Red;
                        iCPicBxMachineName.IconChar = IconChar.TimesCircle;
                        iCPicBxMachineName.Margin = new Padding(50, 3, 3, 3);
                        tableLayoutPanel1.Controls.Add(iCPicBxMachineName, 1, tableLayoutPanel1.RowCount - 1);

                    }
                    gv.loggerFunc("MACHINE NAME Details and Icon");
                    //lblMachineName.Text = "Machine name: " + hostName.ToString();



                    //INTERNET ACCESS
                    gv.loggerFunc("INTERNET ACCESS");
                    bool interAccess = CheckForInternetConnection();
                    if (interAccess)
                    {
                        //lblInternetAccess.Text = "Internet access: Available";
                        //statusInternetAccess.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                        //statusInternetAccess.ForeColor = Color.LawnGreen;
                        //statusInternetAccess.Visible = true;
                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        Label lblDynMachineName = new Label();
                        lblDynMachineName.Text = "Internet access: Available";
                        lblDynMachineName.Font = new Font("Arial", 14);
                        lblDynMachineName.ForeColor = Color.White;
                        lblDynMachineName.TextAlign = ContentAlignment.MiddleLeft;
                        lblDynMachineName.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(lblDynMachineName, 0, tableLayoutPanel1.RowCount - 1);

                        IconPictureBox iCPicBxMachineName = new IconPictureBox();
                        iCPicBxMachineName.Dock = DockStyle.Fill;
                        iCPicBxMachineName.ForeColor = Color.LawnGreen;
                        iCPicBxMachineName.IconChar = IconChar.CheckCircle;
                        iCPicBxMachineName.Margin = new Padding(50, 3, 3, 3);
                        tableLayoutPanel1.Controls.Add(iCPicBxMachineName, 1, tableLayoutPanel1.RowCount - 1);
                    }
                    else
                    {
                        //lblInternetAccess.Text = "Internet access: Unavailable";
                        //statusInternetAccess.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
                        //statusInternetAccess.ForeColor = Color.Red;
                        //statusInternetAccess.Visible = true;

                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        Label lblDynMachineName = new Label();
                        lblDynMachineName.Text = "Internet access: Unavailable";
                        lblDynMachineName.Font = new Font("Arial", 14);
                        lblDynMachineName.ForeColor = Color.White;
                        lblDynMachineName.TextAlign = ContentAlignment.MiddleLeft;
                        lblDynMachineName.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(lblDynMachineName, 0, tableLayoutPanel1.RowCount - 1);

                        IconPictureBox iCPicBxMachineName = new IconPictureBox();
                        iCPicBxMachineName.Dock = DockStyle.Fill;
                        iCPicBxMachineName.ForeColor = Color.Red;
                        iCPicBxMachineName.IconChar = IconChar.TimesCircle;
                        iCPicBxMachineName.Margin = new Padding(50, 3, 3, 3);
                        tableLayoutPanel1.Controls.Add(iCPicBxMachineName, 1, tableLayoutPanel1.RowCount - 1);
                    }

                    gv.loggerFunc("INTERNET ACCESS Details and Icon");


                    //ENTRY IN HOSTS FILE

                    gv.loggerFunc("HOSTS FILE");

                    //Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SystemProfilerReport");
                    string[] HostFiletext = System.IO.File.ReadAllLines(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), @"drivers\etc\hosts"));
                    bool hostnameFoundinHostFile = false;
                    foreach (var lineinHost in HostFiletext)
                    {
                        if (lineinHost.Contains("#"))
                        {
                            continue;
                        }
                        else
                        {
                            if (lineinHost.ToUpper().Contains(hostName.ToString().ToUpper()))
                            {
                                hostnameFoundinHostFile = true;
                            }
                        }
                    }

                    if (hostnameFoundinHostFile)
                    {
                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        Label lblDyn2 = new Label();
                        lblDyn2.Text = "Hosts file entry: " + hostName.ToString();
                        lblDyn2.Font = new Font("Arial", 14);
                        lblDyn2.ForeColor = Color.White;
                        lblDyn2.TextAlign = ContentAlignment.MiddleLeft;
                        lblDyn2.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(lblDyn2, 0, tableLayoutPanel1.RowCount - 1);

                        IconPictureBox iCPicBx2 = new IconPictureBox();
                        iCPicBx2.Dock = DockStyle.Fill;
                        iCPicBx2.ForeColor = Color.LawnGreen;
                        iCPicBx2.IconChar = IconChar.CheckCircle;
                        iCPicBx2.Margin = new Padding(50, 3, 3, 3);
                        tableLayoutPanel1.Controls.Add(iCPicBx2, 1, tableLayoutPanel1.RowCount - 1);
                    }
                    else
                    {
                        tableLayoutPanel1.RowCount += 1;
                        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
                        Label lblDyn2 = new Label();
                        lblDyn2.Text = "Hosts file entry:" + hostName.ToString();
                        lblDyn2.TextAlign = ContentAlignment.MiddleLeft;
                        lblDyn2.Font = new Font("Arial", 14);
                        lblDyn2.ForeColor = Color.White;
                        lblDyn2.Dock = DockStyle.Fill;
                        tableLayoutPanel1.Controls.Add(lblDyn2, 0, tableLayoutPanel1.RowCount - 1);

                        IconPictureBox iCPicBx2 = new IconPictureBox();
                        iCPicBx2.Dock = DockStyle.Fill;
                        iCPicBx2.ForeColor = Color.Red;
                        iCPicBx2.IconChar = IconChar.TimesCircle;
                        iCPicBx2.Margin = new Padding(50, 3, 3, 3);
                        tableLayoutPanel1.Controls.Add(iCPicBx2, 1, tableLayoutPanel1.RowCount - 1);
                    }
                    gv.loggerFunc("HOSTS FILE Details and Icon");

                    tableLayoutPanel1.Visible = true;
                }
            }
            catch (System.Exception ex)
            {
                string errMsg = "SystemVerification.cs - btn_PerformSysValidations_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }

        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.btn_Tasks.PerformClick();
            }
            catch (System.Exception ex)
            {
                string errMsg = "SystemVerification.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
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
