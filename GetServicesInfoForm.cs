using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class GetServicesInfoForm : Form
    {
        public GetServicesInfoForm()
        {
            InitializeComponent();
            if (globalVariables.global_serverHostname != "")
            {
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services?f=json";
                txtBx_ServicesURL.Text = agsServerURL;
            }
        }
        private void btn_GetServices3_Click(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                var request = (HttpWebRequest)WebRequest.Create("https://lea-305263.services.esriaustralia.com.au/server/admin/services?f=json&token=" + token);

                var postData = "username=" + globalVariables.agsEntUserName; //required
                postData += "&password=" + globalVariables.agsEntUserPassword; //required
              
                var data = Encoding.ASCII.GetBytes(postData);

                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }

                var response = (HttpWebResponse)request.GetResponse();

                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JObject rss = JObject.Parse(responseString);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(responseString);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btn_GetServices_Click(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtBx_ServicesURL.Text + "&token=" + token);
                //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://lea-305263.services.esriaustralia.com.au/server/admin/services?fjson");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var encoding = ASCIIEncoding.ASCII;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    String JSONresults = reader.ReadToEnd();
                    JObject rss = JObject.Parse(JSONresults);
                    var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresults);
                    string[] result = dict.Select(kv => kv.Value.ToString()).ToArray();
                    System.Object[] ItemObject = new System.Object[dict.Count];
                    for (int i = 0; i <= dict.Count; i++)
                    {
                        if (i == 1)
                        {
                            JArray categories = (JArray)rss["folders"];
                            foreach (var item in categories)
                            {
                                //include folders checkbox is checked then web request to each of them and get the serivces
                                //includeFolderscheckBox  /services/
                                if (includeFolderscheckBox.Checked)
                                {
                                    //get the arcgis server url and make web request and get services
                                    String agsServerFolderURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + item + "?f=json&token=" + token;
                                    HttpWebRequest requestFolder = (HttpWebRequest)WebRequest.Create(agsServerFolderURL);
                                    HttpWebResponse responseFolder = (HttpWebResponse)requestFolder.GetResponse();
                                    using (var readerFolder = new System.IO.StreamReader(responseFolder.GetResponseStream(), encoding))
                                    {
                                        String JSONresultsFolder = readerFolder.ReadToEnd();
                                        JObject rssFolder = JObject.Parse(JSONresultsFolder);
                                        var dictFolder = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolder);
                                        string[] resultFolder = dictFolder.Select(kv => kv.Value.ToString()).ToArray();
                                        System.Object[] ItemObjectFolder = new System.Object[dictFolder.Count];

                                        JArray servicesCollectionFolder = (JArray)rssFolder["services"];
                                        foreach (var itemFolder in servicesCollectionFolder)
                                        {
                                            DataGridViewRow row = (DataGridViewRow)AGS_dataGridView.Rows[0].Clone();
                                            row.Cells[1].Value = itemFolder["name"];
                                            row.Cells[2].Value = itemFolder["type"];
                                            var dictionary = new Dictionary<string, object>();
                                            dictionary["name"] = itemFolder["name"];
                                            dictionary["type"] = itemFolder["type"];
                                            dictionary["checked"] = "false";
                                            dictionary["id"] = itemFolder["name"] + "_" + itemFolder["type"];
                                            globalVariables.checkedAGSServicesArray.Add(dictionary);
                                            AGS_dataGridView.Rows.Add(row);
                                        }

                                    }

                                }
                                else
                                {
                                    DataGridViewRow row = (DataGridViewRow)AGS_dataGridView.Rows[0].Clone();
                                    row.Cells[1].Value = item;
                                    row.Cells[2].Value = "Folder";
                                    AGS_dataGridView.Rows.Add(row);
                                }

                            }
                        }
                        if (i == 2)
                        {
                            //agsServerlistBox.Items.Insert(0, dict["services"]);
                            JArray servicesCollection = (JArray)rss["services"];
                            foreach (var item in servicesCollection)
                            {

                                DataGridViewRow row = (DataGridViewRow)AGS_dataGridView.Rows[0].Clone();
                                row.Cells[1].Value = item["serviceName"];
                                row.Cells[2].Value = item["type"];
                                var dictionary = new Dictionary<string, object>();
                                dictionary["name"] = item["serviceName"];
                                dictionary["type"] = item["type"];
                                dictionary["checked"] = "false";
                                dictionary["id"] = item["name"] + "_" + item["type"];
                                globalVariables.checkedAGSServicesArray.Add(dictionary);
                                AGS_dataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
