using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            IPGlobalProperties ipProperties = IPGlobalProperties.GetIPGlobalProperties();
            IPEndPoint[] ipEndPoints = ipProperties.GetActiveTcpListeners();

            foreach (IPEndPoint endPoint in ipEndPoints)
            {
                //label1.Text = label1.Text + "\n" + endPoint.Port + " in Use";
                label1.Text = label1.Text + "in Use : " + endPoint.Port + "\n";
            }

        } 
    }
}
