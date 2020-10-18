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

        private void btnPerformOps_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["dataGridViewCheckBoxColumn1"].Value);
                if (isSelected)
                {
                    globalVariables.checkedAGSServices.Add(row.Cells["dataGridViewTextBoxColumn1"].Value.ToString());
                }

            }

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

        private void btnGetServices_Click(object sender, EventArgs e)
        {
            btn_SelectAll.Enabled = false;
            btn_ClearSelection.Enabled = false;
            btn_GenerateReport.Enabled = false;
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
                    foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                    {
                        try
                        {
                            AGS_dataGridView.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (AGS_dataGridView.Rows.Count > 1);

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
                            agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item["name"]);
                            DataGridViewRow row = (DataGridViewRow)AGS_dataGridView.Rows[0].Clone();
                            row.Cells[1].Value = item["name"];
                            row.Cells[2].Value = item["type"];
                            var dictionary = new Dictionary<string, object>();
                            dictionary["name"] = item["name"];
                            dictionary["type"] = item["type"];
                            dictionary["checked"] = "false";
                            dictionary["id"] = item["name"] + "_" + item["type"];
                            globalVariables.checkedAGSServicesArray.Add(dictionary);
                            AGS_dataGridView.Rows.Add(row);
                            //agsServerlistBox.Items.Insert(agsServerlistBox.Items.Count, item["name"] + " Type: " + item["type"]);
                        }
                    }
                }

                //AGS_dataGridView.ReadOnly = true;

                btn_SelectAll.Enabled = true;
                btn_ClearSelection.Enabled = true;
                btn_GenerateReport.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //https://minint-4ja7213.services.esriaustralia.com.au/arcgis/admin/data/items/enterpriseDatabases
            token = GetToken(); // generateTokenFromPortal();
            //get the arcgis server url and make web request and get services
            String agsServerURL = "https://" + txtBox_agsServerhostname.Text + "/" + globalVariables.agsServerInstanceName + "/rest/?f=json";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://minint-4ja7213.services.esriaustralia.com.au/arcgis/admin/data/items/enterpriseDatabases?f=json&token=" + token);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            var encoding = ASCIIEncoding.ASCII;
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
            {
                String JSONresults = reader.ReadToEnd();
                JObject rss = JObject.Parse(JSONresults);
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresults);
                string[] result = dict.Select(kv => kv.Value.ToString()).ToArray();
            }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                row.Cells["dataGridViewCheckBoxColumn1"].Value = true;
            }
        }

        private void btn_ClearSelection_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                row.Cells["dataGridViewCheckBoxColumn1"].Value = false;
            }
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            //call admin url for generating report for selected services
            //https://minint-4ja7213.services.esriaustralia.com.au/arcgis/admin/services/Hosted/report

            //get selected services - globalVariables.checkedAGSServicesArray
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["dataGridViewCheckBoxColumn1"].Value);
                if (isSelected)
                {
                    foreach (Dictionary<string, object> obj in globalVariables.checkedAGSServicesArray)
                    {
                        if (obj["id"].ToString() == row.Cells["dataGridViewTextBoxColumn1"].Value.ToString() + "_" + row.Cells["dataGridViewTextBoxColumn2"].Value.ToString())
                        {
                            obj["checked"] = "true";
                        }
                    }

                }

            }

        }

        private void AGS_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AGS_dataGridView.CommitEdit(DataGridViewDataErrorContexts.Commit);
        }

        private void dataGridViewSites_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            UpdateDataGridViewSite();
        }

        private void UpdateDataGridViewSite()
        {
            //get selected services - globalVariables.checkedAGSServicesArray
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                bool isSelected = Convert.ToBoolean(row.Cells["dataGridViewCheckBoxColumn1"].Value);
                if (isSelected)
                {
                    foreach (Dictionary<string, object> obj in globalVariables.checkedAGSServicesArray)
                    {
                        if (obj["id"].ToString() == row.Cells["dataGridViewTextBoxColumn1"].Value.ToString() + "_" + row.Cells["dataGridViewTextBoxColumn2"].Value.ToString())
                        {
                            obj["checked"] = "true";
                        }
                    }

                }

            }
        }

        //public class ESRITokenResponse
        //{
        //    public string access_token { get; set; }
        //    public string expires_in { get; set; }
        //} 

    }
}
