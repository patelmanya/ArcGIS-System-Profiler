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

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(agsServerURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                String JSONresults = reader.ReadToEnd();

                JObject rss = JObject.Parse(JSONresults);
                
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresults);
                string[] result = dict.Select(kv => kv.Value.ToString()).ToArray();
                System.Object[] ItemObject = new System.Object[dict.Count];
                lbl_agsServerVer.Text = "ArcGIS Server version: " + dict["currentVersion"];
                for (int i = 0; i <= dict.Count; i++)
                {
                    if (i == 1)
                    {
                        JArray categories = (JArray)rss["folders"];
                        foreach (var item in categories)
                        {
                            agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item);
                            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                            row.Cells[1].Value = item;
                            row.Cells[2].Value = "Folder";
                            dataGridView2.Rows.Add(row);
                        }
                    }
                    if (i == 2)
                    {
                        //agsServerlistBox.Items.Insert(0, dict["services"]);
                        JArray servicesCollection = (JArray)rss["services"];
                        foreach (var item in servicesCollection)
                        {
                            agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item["name"] );
                            DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                            row.Cells[1].Value = item["name"];
                            row.Cells[2].Value = item["type"];
                            dataGridView2.Rows.Add(row);
                            //agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item["name"] + " Type: " + item["type"]);
                        }
                    }
                }

                dataGridView2.ReadOnly = true;
            }


        }
    }
}
