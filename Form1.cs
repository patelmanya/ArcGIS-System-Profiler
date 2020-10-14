using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
using System.Web.Script.Serialization;
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
            String agsServerURL = txtBox_agsServerhostname.Text + "?f=json";
            //WebRequest request = WebRequest.Create(agsServerURL);
            //request.ContentType = "application/json; charset=utf-8";
            //WebResponse response = request.GetResponse();

            //var webRequest = WebRequest.Create(agsServerURL) as HttpWebRequest;
            //if (webRequest == null)
            //{
            //    return;
            //}

            //webRequest.ContentType = "application/json";
            //webRequest.UserAgent = "Nothing";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(agsServerURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var encoding = ASCIIEncoding.ASCII;

            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                String JSONresults = reader.ReadToEnd();

                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresults);
                System.Object[] ItemObject = new System.Object[dict.Count];
                for (int i = 0; i <= dict.Count; i++)
                {
                    if (i==0)
                    {
                        agsServerlistBox.Items.Insert(0, dict["currentVersion"]); 
                    }
                    if (i == 1)
                    {
                        agsServerlistBox.Items.Insert(0, dict["folders"]);
                    }
                    if (i == 2)
                    {
                        agsServerlistBox.Items.Insert(0, dict["services"]);
                    }


                }
            }


        }
    }
}
