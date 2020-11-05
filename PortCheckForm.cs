using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class PortCheckForm : Form
    {
        private string textFilterFlag = "portNo";
        public PortCheckForm()
        {
            InitializeComponent();

            panel1.BackColor = globalVariables.themeColor;
            panel2.BackColor = globalVariables.themeColor;
            panel3.BackColor = globalVariables.themeColor;
            panel4.BackColor = globalVariables.themeColor;
            panel5.BackColor = globalVariables.themeColor;
            dataGridViewPorts.BackgroundColor = globalVariables.themeColor;

            try
            {
                //initialize the port list from the wkid listed in portsInfo.cs
                portsInfo pInfo = new portsInfo();
                pInfo.loadPortList();
                btnShowAGSOnly.Visible = false;
                //remove the existing rows in the datagridview
                dataGridViewPorts.Rows.Clear();
                //do
                //{
                //    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                //    {
                //        try
                //        {
                //            dataGridViewPorts.Rows.Remove(row);
                //        }
                //        catch (Exception) { }
                //    }
                //} while (dataGridViewPorts.Rows.Count > 1);
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - PortCheckForm InitializeComponent: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!globalVariables.globalForm.loadingIconPic.Visible)
                {
                    globalVariables.globalForm.loadingIconPic.Visible = true;
                   // globalVariables.globalForm.panelLoadingIconBar.Visible = true;
                    
                    //progressBar1.Visible = true;
                    progressBar1.Value = 0;
                }

                progressBar1.Value = progressBar1.Value + 2;
                if (progressBar1.Value > 99)
                {

                    //do
                    //{
                    //    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                    //    {
                    //        try
                    //        {
                    //            dataGridViewPorts.Rows.Remove(row);
                    //        }
                    //        catch (Exception)
                    //        {


                    //        }

                    //    }
                    //} while (dataGridViewPorts.Rows.Count > 1);
                    dataGridViewPorts.Rows.Clear();
                    dataGridViewPorts.Rows.Add();
                    globalVariables.portsList.Clear();


                    IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
                    IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();




                    foreach (IPEndPoint endPoint in ipEndPoints)
                    {
                        //label1.Text = label1.Text + "\n" + endPoint.Port + " in Use";

                        try
                        {
                            using (TcpClient tcpClient = new TcpClient())
                            {
                                tcpClient.Connect("127.0.0.1", endPoint.Port);

                                var dictionary = new Dictionary<string, object>();
                                dictionary["portNo"] = endPoint.Port;
                                string descriptionText = "";
                                string protocoltxt = "";
                                foreach (Dictionary<string, object> obj in globalVariables.wkidPortList)
                                {
                                    if (obj["portNumber"].ToString() == endPoint.Port.ToString())
                                    {
                                        descriptionText = obj["description"].ToString();
                                        protocoltxt = obj["protocol"].ToString();
                                        break;
                                    }
                                }
                                dictionary["description"] = descriptionText;
                                dictionary["status"] = "Open";
                                dictionary["protocol"] = protocoltxt;
                                bool portExists = false;
                                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                                {
                                    if (obj["portNo"].ToString() == endPoint.Port.ToString())
                                    {
                                        portExists = true;
                                    }
                                }

                                DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                                row.Cells[0].Value = endPoint.Port;
                                row.Cells[1].Value = descriptionText;
                                row.Cells[2].Value = "Open";
                                row.Cells[3].Value = protocoltxt;

                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);

                                if (!portExists)
                                {
                                    globalVariables.portsList.Add(dictionary);
                                    //row.DefaultCellStyle.BackColor = Color.FromArgb(137, 189, 123);
                                    dataGridViewPorts.Rows.Add(row);
                                }

                            }
                        }
                        catch (Exception)
                        {
                            var dictionary = new Dictionary<string, object>();
                            dictionary["portNo"] = endPoint.Port;
                            string descriptionText = "";
                            string protocoltxt = "";
                            foreach (Dictionary<string, object> obj in globalVariables.wkidPortList)
                            {
                                if (obj["portNumber"].ToString() == endPoint.Port.ToString())
                                {
                                    descriptionText = obj["description"].ToString();
                                    protocoltxt = obj["protocol"].ToString();
                                    break;
                                }
                            }
                            dictionary["description"] = descriptionText;
                            dictionary["status"] = "Closed";
                            dictionary["protocol"] = protocoltxt;
                            bool portExists = false;
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            row.Cells[0].Value = endPoint.Port;
                            row.Cells[1].Value = descriptionText;
                            row.Cells[2].Value = "Closed";
                            row.Cells[3].Value = protocoltxt;
                            row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);

                            foreach (Dictionary<string, object> obj in globalVariables.portsList)
                            {
                                if (obj["portNo"].ToString() == endPoint.Port.ToString())
                                {
                                    portExists = true;
                                }
                            }
                            if (!portExists)
                            {
                                globalVariables.portsList.Add(dictionary);
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }
                    }
                    timer1.Enabled = false;
                    dataGridViewPorts.AllowUserToAddRows = false;
                    dataGridViewPorts.Rows.RemoveAt(0);
                    
                }


                if (progressBar1.Value == 100)
                {
                    //globalVariables.globalForm.panelLoadingIconBar.Visible = false;
                    globalVariables.globalForm.loadingIconPic.Hide();
                    progressBar1.Hide();
                    btnShowAGSOnly.Visible = true;
                }
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - timer1_Tick: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_PerformPortCheck_Click(object sender, EventArgs e)
        {
            try
            {
                timer1.Enabled = true;
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - btn_PerformPortCheck_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }

        }

        private void txtBx_Filter_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    MessageBox.Show("Enter key pressed");
            //}

            if (e.KeyCode.ToString().Length > 3)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //remove the existing rows in the datagridview
                //do
                //{
                //    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                //    {
                //        try
                //        {
                //            dataGridViewPorts.Rows.Remove(row);
                //        }
                //        catch (Exception)
                //        {

                //        }

                //    }
                //} while (dataGridViewPorts.Rows.Count > 1);
                dataGridViewPorts.Rows.Clear();
                dataGridViewPorts.Rows.Add();

                //add only the closed one from the globalVariables.portsList
                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                {
                    if (textFilterFlag == "portNo")
                    {
                        if (obj["portNo"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            dataGridViewPorts.Rows.Add(row);
                        }
                    }
                    if (textFilterFlag == "description")
                    {
                        if (obj["description"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            dataGridViewPorts.Rows.Add(row);
                        }
                    }
                    if (textFilterFlag == "agsonly")
                    {
                        if (obj["description"].ToString().ToUpper().Contains("ArcGIS"))
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            dataGridViewPorts.Rows.Add(row);
                        }
                    }
                }

                dataGridViewPorts.AllowUserToAddRows = false;
                dataGridViewPorts.Rows.RemoveAt(0);
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - button1_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textFilterFlag = "description";
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - radioButton1_CheckedChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void radioButtonPortNoFilter_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                textFilterFlag = "portNo";
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - radioButtonPortNoFilter_CheckedChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                //globalVariables.globalForm.btn_Services.PerformClick();
                globalVariables.globalForm.btn_HealthChecks.PerformClick();
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btnShowAGSOnly_Click(object sender, EventArgs e)
        {
            try
            {
                //textFilterFlag = "";

                //remove the existing rows in the datagridview
                //do
                //{
                //    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                //    {
                //        try
                //        {
                //            dataGridViewPorts.Rows.Remove(row);
                //        }
                //        catch (Exception)
                //        {

                //        }

                //    }
                //} while (dataGridViewPorts.Rows.Count > 1);
                dataGridViewPorts.Rows.Clear();
                dataGridViewPorts.Rows.Add();

                //add only the closed one from the globalVariables.portsList
                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                    if (textFilterFlag == "portNo")
                    {
                        if (obj["portNo"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                        {
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            if (obj["description"].ToString().Contains("ArcGIS"))
                            {
                                dataGridViewPorts.Rows.Add(row);
                            }
                                
                        }
                        else if (txtBx_Filter.Text == "")
                        {
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            if (obj["description"].ToString().Contains("ArcGIS"))
                            {
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }
                    }
                    if (textFilterFlag == "description")
                    {
                        if (obj["description"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                        {
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            if (obj["description"].ToString().Contains("ArcGIS"))
                            {
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }
                        else if (txtBx_Filter.Text == "")
                        {
                            row.Cells[0].Value = obj["portNo"].ToString();
                            row.Cells[1].Value = obj["description"].ToString();
                            row.Cells[2].Value = obj["status"].ToString();
                            row.Cells[3].Value = obj["protocol"].ToString();
                            if (obj["status"].ToString() == "Closed")
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                            }
                            else
                            {
                                row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                            }
                            if (obj["description"].ToString().Contains("ArcGIS"))
                            {
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }
                    }

                }
                dataGridViewPorts.AllowUserToAddRows = false;
                dataGridViewPorts.Rows.RemoveAt(0);
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - btnShowAGSOnly_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //remove the existing rows in the datagridview
                //do
                //{
                //    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                //    {
                //        try
                //        {
                //            dataGridViewPorts.Rows.Remove(row);
                //        }
                //        catch (Exception)
                //        {

                //        }

                //    }
                //} while (dataGridViewPorts.Rows.Count > 1);
                dataGridViewPorts.Rows.Clear();
                dataGridViewPorts.Rows.Add();

                if (radioButtonAll.Checked == true)
                {
                    //add only the closed one from the globalVariables.portsList
                    foreach (Dictionary<string, object> obj in globalVariables.portsList)
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                        if (textFilterFlag == "portNo")
                        {
                            if (obj["portNo"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                            {
                                row.Cells[0].Value = obj["portNo"].ToString();
                                row.Cells[1].Value = obj["description"].ToString();
                                row.Cells[2].Value = obj["status"].ToString();
                                row.Cells[3].Value = obj["protocol"].ToString();
                                if (obj["status"].ToString() == "Closed")
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                }
                                dataGridViewPorts.Rows.Add(row);
                            }
                            else if (txtBx_Filter.Text == "")
                            {
                                row.Cells[0].Value = obj["portNo"].ToString();
                                row.Cells[1].Value = obj["description"].ToString();
                                row.Cells[2].Value = obj["status"].ToString();
                                row.Cells[3].Value = obj["protocol"].ToString();
                                if (obj["status"].ToString() == "Closed")
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                }
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }
                        if (textFilterFlag == "description")
                        {
                            if (obj["description"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                            {
                                row.Cells[0].Value = obj["portNo"].ToString();
                                row.Cells[1].Value = obj["description"].ToString();
                                row.Cells[2].Value = obj["status"].ToString();
                                row.Cells[3].Value = obj["protocol"].ToString();
                                if (obj["status"].ToString() == "Closed")
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                }
                                dataGridViewPorts.Rows.Add(row);
                            }
                            else if (txtBx_Filter.Text == "")
                            {
                                row.Cells[0].Value = obj["portNo"].ToString();
                                row.Cells[1].Value = obj["description"].ToString();
                                row.Cells[2].Value = obj["status"].ToString();
                                row.Cells[3].Value = obj["protocol"].ToString();
                                if (obj["status"].ToString() == "Closed")
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                }
                                dataGridViewPorts.Rows.Add(row);
                            }
                        }

                    }
                }
                else if (radioButtonOpen.Checked == true)
                {
                    //add only the closed one from the globalVariables.portsList
                    foreach (Dictionary<string, object> obj in globalVariables.portsList)
                    {
                        if (obj["status"].ToString() == "Open")
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            if (textFilterFlag == "portNo")
                            {
                                if (obj["portNo"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    dataGridViewPorts.Rows.Add(row);
                                }
                                else if (txtBx_Filter.Text == "")
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    dataGridViewPorts.Rows.Add(row);
                                }
                            }
                            if (textFilterFlag == "description")
                            {
                                if (obj["description"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    dataGridViewPorts.Rows.Add(row);
                                }
                                else if (txtBx_Filter.Text == "")
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    dataGridViewPorts.Rows.Add(row);
                                }
                            }
                        }
                    }
                }
                else if (radioButtonClosed.Checked == true)
                {
                    //add only the closed one from the globalVariables.portsList
                    foreach (Dictionary<string, object> obj in globalVariables.portsList)
                    {
                        if (obj["status"].ToString() == "Closed")
                        {
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            if (textFilterFlag == "portNo")
                            {
                                if (obj["portNo"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    // row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    if (obj["status"].ToString() == "Closed")
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    dataGridViewPorts.Rows.Add(row);
                                }
                                else if (txtBx_Filter.Text == "")
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    //row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    if (obj["status"].ToString() == "Closed")
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    dataGridViewPorts.Rows.Add(row);
                                }
                            }
                            if (textFilterFlag == "description")
                            {
                                if (obj["description"].ToString().ToUpper().Contains(txtBx_Filter.Text.ToUpper()))
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    // row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105); if (obj["status"].ToString() == "Closed")
                                    if (obj["status"].ToString() == "Closed")
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    dataGridViewPorts.Rows.Add(row);
                                }
                                else if (txtBx_Filter.Text == "")
                                {
                                    row.Cells[0].Value = obj["portNo"].ToString();
                                    row.Cells[1].Value = obj["description"].ToString();
                                    row.Cells[2].Value = obj["status"].ToString();
                                    //row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    if (obj["status"].ToString() == "Closed")
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                    }
                                    else
                                    {
                                        row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                    }
                                    row.Cells[3].Value = obj["protocol"].ToString();
                                    dataGridViewPorts.Rows.Add(row);
                                }
                            }
                        }
                    }
                }
                dataGridViewPorts.AllowUserToAddRows = false;
                dataGridViewPorts.Rows.RemoveAt(0);
            }
            catch (Exception ex)
            {
                string errMsg = "PortCheckForm.cs - radioButton_CheckedChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
