using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //get the arcgis server url and make web request and get services
            String agsServerURL = txtBox_agsServerhostname.Text + "/?f=pjson";
            //WebRequest request = WebRequest.Create(agsServerURL);
            //request.ContentType = "application/json; charset=utf-8";
            //WebResponse response = request.GetResponse();

            var webRequest = WebRequest.Create(agsServerURL) as HttpWebRequest;
            if (webRequest == null)
            {
                return;
            }

            webRequest.ContentType = "application/json";
            webRequest.UserAgent = "Nothing";

            using (var s = webRequest.GetResponse().GetResponseStream())
            {
                using (var sr = new StreamReader(s))
                {
                    var contributorsAsJson = sr.ReadToEnd();
                    //var contributors = JsonConvert.DeserializeObject<List<Contributor>>(contributorsAsJson);
                    //contributors.ForEach(Console.WriteLine);

                    System.Object[] ItemObject = new System.Object[5];
                    for (int i = 0; i <= 5; i++)
                    {
                        agsServerlistBox.Items.Insert(0, "Copenhagen");
                    }
                    
                }
            }


        }
    }
}
