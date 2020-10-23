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

        public PortCheckForm()
        {
            InitializeComponent();
            try
            {
                //remove the existing rows in the datagridview
                do
                {
                    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                    {
                        try
                        {
                            dataGridViewPorts.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridViewPorts.Rows.Count > 1);
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (!progressBar1.Visible)
                {
                    progressBar1.Visible = true;
                    progressBar1.Value = 0;
                }

                progressBar1.Value = progressBar1.Value + 2;
                if (progressBar1.Value > 99)
                {

                    do
                    {
                        foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                        {
                            try
                            {
                                dataGridViewPorts.Rows.Remove(row);
                            }
                            catch (Exception) { }
                        }
                    } while (dataGridViewPorts.Rows.Count > 1);
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
                                dictionary["status"] = "Open";
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
                                row.Cells[2].Value = "Open";

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
                            dictionary["status"] = "Closed";
                            bool portExists = false;
                            DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                            row.Cells[0].Value = endPoint.Port;
                            row.Cells[2].Value = "Closed";
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
                }


                if (progressBar1.Value == 100)
                {
                    progressBar1.Hide();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_PerformPortCheck_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;

        }

        private void radioButtonClosed_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //remove the existing rows in the datagridview
                do
                {
                    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                    {
                        try
                        {
                            dataGridViewPorts.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridViewPorts.Rows.Count > 1);

                //add only the closed one from the globalVariables.portsList
                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                {
                    if (obj["status"].ToString() == "Closed")
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                        row.Cells[0].Value = obj["portNo"].ToString();
                        row.Cells[2].Value = obj["status"].ToString();
                        dataGridViewPorts.Rows.Add(row);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //remove the existing rows in the datagridview
                do
                {
                    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                    {
                        try
                        {
                            dataGridViewPorts.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridViewPorts.Rows.Count > 1);

                //add only the closed one from the globalVariables.portsList
                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                {
                    if (obj["status"].ToString() == "Open")
                    {
                        DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                        row.Cells[0].Value = obj["portNo"].ToString();
                        row.Cells[2].Value = obj["status"].ToString();
                        dataGridViewPorts.Rows.Add(row);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                //remove the existing rows in the datagridview
                do
                {
                    foreach (DataGridViewRow row in dataGridViewPorts.Rows)
                    {
                        try
                        {
                            dataGridViewPorts.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridViewPorts.Rows.Count > 1);

                //add only the closed one from the globalVariables.portsList
                foreach (Dictionary<string, object> obj in globalVariables.portsList)
                {
                    DataGridViewRow row = (DataGridViewRow)dataGridViewPorts.Rows[0].Clone();
                    row.Cells[0].Value = obj["portNo"].ToString();
                    row.Cells[2].Value = obj["status"].ToString();
                    dataGridViewPorts.Rows.Add(row);

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
