using Microsoft.Office.Interop.Word;
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
using System.Text.RegularExpressions;
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
            }
        }

        private void btn_GetServices_Click(object sender, EventArgs e)
        {
            try
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

                globalVariables.checkedAGSServicesArray.Clear();

                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(txtBx_ServicesURL.Text + "&token=" + token);
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
                                dictionary["id"] = item["serviceName"] + "_" + item["type"];
                                globalVariables.checkedAGSServicesArray.Add(dictionary);
                                AGS_dataGridView.Rows.Add(row);
                            }
                        }
                    }
                }
                AGS_dataGridView.AllowUserToAddRows = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_SelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                row.Cells["checkBoxCol_Service"].Value = true;
            }
        }

        private void btn_ClearAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
            {
                row.Cells["checkBoxCol_Service"].Value = false;
            }
        }

        private void btnGenerateServicesReport_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.loadingIconPic.Visible = true;
                //get selected services - globalVariables.checkedAGSServicesArray
                foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxCol_Service"].Value);
                    if (isSelected)
                    {
                        foreach (Dictionary<string, object> obj in globalVariables.checkedAGSServicesArray)
                        {
                            if (obj["id"].ToString() == row.Cells["Service_Name"].Value.ToString() + "_" + row.Cells["Service_Type"].Value.ToString())
                            {
                                obj["checked"] = "true";
                            }
                        }

                    }

                }

                //generate the report for each service selected
                foreach (Dictionary<string, object> obj in globalVariables.checkedAGSServicesArray)
                {
                    if (obj["checked"].ToString() == "true")
                    {
                        string token = "";
                        globalVariables gV = new globalVariables();
                        token = gV.GetToken();
                        //get the arcgis server url and make web request and get services - (obj["name"].ToString()).Contains("/")
                        String urlAddress = "";
                        if ((obj["name"].ToString()).Contains("/"))
                        {
                            urlAddress = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/" + (obj["name"].ToString()).Split('/')[0] + "/report?token=" + token;
                        }
                        else
                        {
                            urlAddress = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/report?token=" + token;
                        }


                        ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(urlAddress);
                        HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            Stream receiveStream = response.GetResponseStream();
                            StreamReader readStream = null;

                            if (String.IsNullOrWhiteSpace(response.CharacterSet))
                                readStream = new StreamReader(receiveStream);
                            else
                                readStream = new StreamReader(receiveStream, Encoding.GetEncoding(response.CharacterSet));

                            string data = readStream.ReadToEnd();
                            string TableExpression = "<table[^>]*>(.*?)</table>";
                            MatchCollection Tables = Regex.Matches(data, TableExpression, RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.IgnoreCase);
                            var fileCounterLoop = 0;
                            foreach (var item in Tables)
                            {
                                if (fileCounterLoop < 2)
                                {
                                    fileCounterLoop = fileCounterLoop + 1;
                                    continue;
                                }
                                else if (fileCounterLoop == Tables.Count - 1)
                                {
                                    continue;
                                }
                                if ((item.ToString()).Contains(obj["name"].ToString()))
                                {
                                    string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                                    string foldername = "tables";
                                    if (!Directory.Exists(@"C:\\temp\\" + foldername))
                                    {
                                        Directory.CreateDirectory(@"C:\\temp\\" + foldername);
                                    }
                                    TextWriter txt = new StreamWriter("C:\\temp\\tables\\demo_" + fileName + ".html");
                                    globalVariables.generateReportList.Add("C:\\temp\\tables\\demo_" + fileName + ".html");
                                    txt.Write(item);
                                    txt.Close();
                                    fileCounterLoop = fileCounterLoop + 1;
                                }
                                else if ((obj["name"].ToString()).Contains("/"))
                                {
                                    if ((item.ToString()).Contains((obj["name"].ToString()).Split('/')[1]))
                                    {
                                        string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                                        string foldername = "tables";
                                        if (!Directory.Exists(@"C:/temp/" + foldername))
                                        {
                                            Directory.CreateDirectory(@"C:/temp/" + foldername);
                                        }
                                        TextWriter txt = new StreamWriter("C:\\temp\\tables\\demo_" + fileName + ".html");
                                        globalVariables.generateReportList.Add("C:\\temp\\tables\\demo_" + fileName + ".html");
                                        txt.Write(item);
                                        txt.Close();
                                        fileCounterLoop = fileCounterLoop + 1;
                                    }
                                }

                            }

                            response.Close();
                            readStream.Close();
                        }
                    }
                } 
                globalVariables.globalForm.loadingIconPic.Visible = false;
                MessageBox.Show("Services Report generation completed. Please proceed to Next Step!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            globalVariables.globalForm.btn_Publish.PerformClick();
        }
         
    }
}
