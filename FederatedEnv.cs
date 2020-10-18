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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class FederatedEnv : Form
    {


        public static string token = "";

        public FederatedEnv()
        {
            InitializeComponent();
            globalVariables.agsServerInstanceName = txtServerInstanceName.Text;
            globalVariables.portalInstanceName = txtPortalInstanceName.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            token = GetToken(); // generateTokenFromPortal();
            //get the arcgis server url and make web request and get services
            String agsServerURL = "https://" + txtBox_agsServerhostname.Text + "/" + globalVariables.agsServerInstanceName + "/rest/?f=json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(agsServerURL);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                //remove the existing rows in the datagridview
                do
                {
                    foreach (DataGridViewRow row in dataGridView2.Rows)
                    {
                        try
                        {
                            dataGridView2.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (dataGridView2.Rows.Count > 1);

                String JSONresults = reader.ReadToEnd();
                JObject rss = JObject.Parse(JSONresults);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresults);
                string[] result = dict.Select(kv => kv.Value.ToString()).ToArray();
                System.Object[] ItemObject = new System.Object[dict.Count];
                lbl_agsServerVer.Text = "ArcGIS Server version: " + dict["currentVersion"];
                lbl_agsEnterVer.Text = "ArcGIS Enterprise version: " + dict["currentVersion"];
                for (int i = 0; i <= dict.Count; i++)
                {
                    if (i == 1)
                    {
                        JArray categories = (JArray)rss["folders"];
                        foreach (var item in categories)
                        {
                            agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item);

                            //include folders checkbox is checked then web request to each of them and get the serivces
                            //includeFolderscheckBox  /services/
                            if (includeFolderscheckBox.Checked)
                            {
                                //get the arcgis server url and make web request and get services
                                //String token = "NK-S6TK4XN80WMjSLPaMptbtyq_tsxJRehc3tyskU9KkIc8BE08KeqOJnR9ZlsXH9AZKKGGIn5i_g0HYMAt0LMigrxDIgSV8-1UJffEENGjBkRSUhzVe3AyeP7X-PXEkJitEukLhRSVQePehUKcwMZPAiYQbon3ltSWxZhvbsgTeBlLMCCS99QeZMfmJ0Qk_fN5tiNHHYBuQZieIUlQrOmF3K4L7JauFZg1f8mdRpP8.";
                                String agsServerFolderURL = "https://" + txtBox_agsServerhostname.Text + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + item + "?f=json&token=" + token;
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
                                        DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                                        row.Cells[1].Value = itemFolder["name"];
                                        row.Cells[2].Value = itemFolder["type"];
                                        dataGridView2.Rows.Add(row);
                                    }

                                }

                            }
                            else
                            {
                                DataGridViewRow row = (DataGridViewRow)dataGridView2.Rows[0].Clone();
                                row.Cells[1].Value = item;
                                row.Cells[2].Value = "Folder";
                                dataGridView2.Rows.Add(row);
                            }

                        }
                    }
                    if (i == 2)
                    {
                        //agsServerlistBox.Items.Insert(0, dict["services"]);
                        JArray servicesCollection = (JArray)rss["services"];
                        foreach (var item in servicesCollection)
                        {
                            agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item["name"]);
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

        private string GetToken()
        {
            var userPortalName = InitialForm.agsEnterpriseUserName;
            var userPortalPassword = InitialForm.agsEnterprisePassword;
            //var request = (HttpWebRequest)WebRequest.Create("https://minint-4ja7213.services.esriaustralia.com.au/portal/sharing/rest/generateToken/");
            String agsServerURL = "https://" + txtBox_agsEnterprisehostname.Text + "/portal/sharing/rest/generateToken";
            var request = (HttpWebRequest)WebRequest.Create(agsServerURL);

            var postData = "username=" + userPortalName; //required
            postData += "&password=" + userPortalPassword; //required
            postData += "&client=referer"; //required
            postData += "&referer=requestip"; //required
            postData += "&expiration=600"; //optional, default
            postData += "&f=json"; //optional, default

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
            String tokenStr = dict["token"].ToString();
            //ESRITokenResponse eToken = Newtonsoft.Json.JsonConvert.DeserializeObject<ESRITokenResponse>(responseString);

            //return eToken.access_token;
            return tokenStr;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            globalVariables.portalHostName = "";
            globalVariables.agsServerHostName = "";
            globalVariables.portalHostName = txtBox_agsEnterprisehostname.Text;
            globalVariables.agsServerHostName = txtBox_agsServerhostname.Text;
            globalVariables.portalCheckURL = "https://" + globalVariables.portalHostName + "/portal/portaladmin/healthCheck";
            globalVariables.ArcGISServerCheckURL = "https://" + globalVariables.agsServerHostName + "/" + globalVariables.agsServerInstanceName + "/rest/info/healthCheck";
            ScreenCaptureForm sc = new ScreenCaptureForm();
            sc.ShowDialog();
        }

        private void btnEditInstanceName_Click(object sender, EventArgs e)
        {
            if (btnEditInstanceName.Text == "Edit instance")
            {
                txtPortalInstanceName.Enabled = true;
                txtServerInstanceName.Enabled = true;
                btnEditInstanceName.Text = "Update & Save";
            }
            else if (btnEditInstanceName.Text == "Update & Save")
            {
                globalVariables.agsServerInstanceName = txtServerInstanceName.Text;
                globalVariables.portalInstanceName = txtPortalInstanceName.Text;
                txtPortalInstanceName.Enabled = false;
                txtServerInstanceName.Enabled = false;
                btnEditInstanceName.Text = "Edit instance";
            }
        }

        //public class ESRITokenResponse
        //{
        //    public string access_token { get; set; }
        //    public string expires_in { get; set; }
        //} 

    }
}
