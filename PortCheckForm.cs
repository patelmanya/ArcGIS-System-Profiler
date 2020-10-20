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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class PortCheckForm : Form
    {
        public PortCheckForm()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 2;
            if (progressBar1.Value > 99)
            {
                label1.Text = "";
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
                            label1.Text = label1.Text + "in Use : " + endPoint.Port + " - Port open\n";
                            //label1.Text = label1.Text + "in Use : " + endPoint.Port + " -< span style = \"color: green; \" >  Port open</ span >\n";
                        }
                    }
                    catch (Exception)
                    {
                        label1.Text = label1.Text + "in Use : " + endPoint.Port + " - Port closed\n";
                    }
                }
                timer1.Enabled = false;

            }


            if (progressBar1.Value == 100)
            {
                progressBar1.Hide();
            }
        }

        private void btn_PerformPortCheck_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
    }
}
