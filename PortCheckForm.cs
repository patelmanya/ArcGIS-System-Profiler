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
        private MakeMovable _move;
        public PortCheckForm()
        {
            InitializeComponent();
            label1.Text = "";
            richTextBox1.Text = "";
            _move = new MakeMovable(this);
            _move.SetMovable(panel2);
            _move.SetMovable(panel3);
            _move.SetMovable(panel4);
            _move.SetMovable(panel5);

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
                progressBar1.Value = 0; 
            }
            richTextBox1.Visible = false;
            label1.Text = "";
            richTextBox1.Text = "";
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
                            richTextBox1.Text = richTextBox1.Text + "in Use : " + endPoint.Port + " - Port open\n";
                            //label1.Text = label1.Text + "in Use : " + endPoint.Port + " -< span style = \"color: green; \" >  Port open</ span >\n";
                        }
                    }
                    catch (Exception)
                    {
                        label1.Text = label1.Text + "Not in Use : " + endPoint.Port + " - Port closed\n";
                        richTextBox1.Text = richTextBox1.Text + "Not in Use : " + endPoint.Port + " - Port closed\n";
                    }
                }
                timer1.Enabled = false;
                int index = richTextBox1.Text.IndexOf("Port closed");
                richTextBox1.Select(index, 11);
                richTextBox1.SelectionColor = Color.BlueViolet;
                string pattern = @"Port closed";
                Regex rgx = new Regex(pattern);
                string sentence = richTextBox1.Text;

                foreach (Match match in rgx.Matches(sentence))
                {
                    Console.WriteLine("Found '{0}' at position {1}",
                                      match.Value, match.Index);
                    richTextBox1.Select(match.Index, 11);
                    richTextBox1.SelectionColor = Color.Red;
                }
                    

                richTextBox1.Visible = true;
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
