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
                btnGenerateServicesExcelReport.Visible = true;
                btnGenerateServicesReport.Visible = true;
                btn_ClearAll.Visible = true;
                btn_SelectAll.Visible = true;
                btn_NextStep.Visible = true;
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

                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles();
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
                if (globalVariables.generateReportList.Count > 0)
                {
                    foreach (string objArr in globalVariables.generateReportList)
                    {

                        //delete the file if it exists
                        if (File.Exists(objArr))
                        {
                            File.Delete(objArr);
                        }
                    }
                    globalVariables.generateReportList.Clear();
                }

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
                                    var dictionary = new Dictionary<string, object>(); 
                                    dictionary["serviceName"] = obj["name"].ToString();
                                    dictionary["reportFileName"] = "C:\\temp\\tables\\demo_" + fileName + ".html";
                                    globalVariables.generateReportListServiceName.Add(dictionary);
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
                                        var dictionary = new Dictionary<string, object>();
                                        dictionary["serviceName"] = obj["name"].ToString();
                                        dictionary["reportFileName"] = "C:\\temp\\tables\\demo_" + fileName + ".html";
                                        globalVariables.generateReportListServiceName.Add(dictionary);
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
                //MessageBox.Show("Services Report generation completed. Please proceed to Next Step!");
            }
            catch (Exception)
            {

                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles();
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            globalVariables.globalForm.btnCreateReport.PerformClick();
        }

        private void btnGenerateServicesExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                //delete the file if it exists
                if (File.Exists(globalVariables.agsServerServicesReportName))
                {
                    File.Delete(globalVariables.agsServerServicesReportName);
                    globalVariables.agsServerServicesReportName = "";
                }
                globalVariables.globalForm.loadingIconPic.Visible = true;
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                string AllServicesReportURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services?f=json";
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
                        if (i == 1) //folders
                        {
                            JArray categories = (JArray)rss["folders"];
                            foreach (var item in categories)
                            {
                                //since this is folder make calls again and create new results so previous one dont overwrite
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
                                        //at service level
                                        String currentFolderNameStr = "";
                                        String currentServiceNameStr = "";
                                        String currentServiceTypeStr = "";

                                        currentFolderNameStr = (itemFolder["name"].ToString()).Split('/')[0];
                                        currentServiceNameStr = (itemFolder["name"].ToString()).Split('/')[1];
                                        currentServiceTypeStr = itemFolder["type"].ToString();

                                        var serviceDictionary = new Dictionary<string, object>();
                                        serviceDictionary["currentFolderNameStr"] = currentFolderNameStr;
                                        serviceDictionary["currentServiceNameStr"] = currentServiceNameStr;
                                        serviceDictionary["currentServiceTypeStr"] = currentServiceTypeStr;

                                        String agsServerFolderServiceURL = "";

                                        if (currentServiceTypeStr == "MapServer" || currentServiceTypeStr == "FeatureServer")
                                        {
                                            agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + itemFolder["name"].ToString() + "/" + itemFolder["type"].ToString() + "/layers?f=json&token=" + token;
                                        }
                                        else if (currentServiceTypeStr == "GPServer")
                                        {
                                            continue;
                                            //agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + itemFolder["name"].ToString() + "/" + itemFolder["type"].ToString() + "/layers?f=json&token=" + token;
                                        }

                                        HttpWebRequest requestFolderService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                        HttpWebResponse responseFolderService = (HttpWebResponse)requestFolderService.GetResponse();
                                        using (var readerFolderService = new System.IO.StreamReader(responseFolderService.GetResponseStream(), encoding))
                                        {
                                            String JSONresultsFolderService = readerFolderService.ReadToEnd();
                                            JObject rssFolderService = JObject.Parse(JSONresultsFolderService);
                                            var dictFolderService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderService);
                                            string[] resultFolderService = dictFolderService.Select(kv => kv.Value.ToString()).ToArray();
                                            System.Object[] ItemObjectFolderService = new System.Object[dictFolderService.Count];
                                            JArray servicesLayersCollectionFolder = (JArray)rssFolderService["layers"];

                                            String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                            serviceDictionary["layerCountStr"] = layerCountStr;

                                            foreach (var itemFolderServLayer in servicesLayersCollectionFolder)
                                            {
                                                var layerDictionary = new Dictionary<string, object>();
                                                String layerIdStr = itemFolderServLayer["id"].ToString();
                                                String layerNameStr = itemFolderServLayer["name"].ToString();
                                                String layerGeomtryTypeStr = itemFolderServLayer["geometryType"].ToString();
                                                String layerMinScaleStr = itemFolderServLayer["minScale"].ToString();
                                                String layerMaxScaleStr = itemFolderServLayer["maxScale"].ToString();
                                                String layerDisplayFieldStr = itemFolderServLayer["displayField"].ToString();
                                                String maxRecordCountStr = itemFolderServLayer["maxRecordCount"].ToString();

                                                layerDictionary["layerIdStr"] = layerIdStr;
                                                layerDictionary["layerNameStr"] = layerNameStr;
                                                layerDictionary["layerGeomtryTypeStr"] = layerGeomtryTypeStr;
                                                layerDictionary["layerMinScaleStr"] = layerMinScaleStr;
                                                layerDictionary["layerMaxScaleStr"] = layerMaxScaleStr;
                                                layerDictionary["layerDisplayFieldStr"] = layerDisplayFieldStr;
                                                layerDictionary["maxRecordCountStr"] = maxRecordCountStr;

                                                //String fieldCountStr = itemFolderServLayer["fields"].Count.ToString();
                                                var fieldsLoopCounter = 0;
                                                //List<Object> servicesFieldsReportArray = new List<Object>();
                                                var servicesFieldsReportArray = new Dictionary<string, object>();
                                                foreach (var fieldsItem in itemFolderServLayer["fields"])
                                                {
                                                    var fieldDictionary = new Dictionary<string, object>();
                                                    fieldDictionary["name"] = fieldsItem["name"].ToString();
                                                    fieldDictionary["type"] = fieldsItem["type"].ToString();
                                                    fieldDictionary["alias"] = fieldsItem["alias"].ToString();
                                                    fieldDictionary["domain"] = fieldsItem["domain"].ToString();
                                                    globalVariables.servicesFieldsReportArray.Add(fieldDictionary);
                                                    fieldsLoopCounter += 1;
                                                    servicesFieldsReportArray[fieldsLoopCounter.ToString()] = fieldDictionary;
                                                }
                                                layerDictionary["fieldDictionary"] = servicesFieldsReportArray;
                                                String fieldCountStr = fieldsLoopCounter.ToString();
                                                layerDictionary["fieldCountStr"] = fieldCountStr;
                                                serviceDictionary["layerDictionary"] = layerDictionary;
                                            }

                                            globalVariables.servicesMainReportArray.Add(serviceDictionary);

                                        }
                                    }
                                }
                            }
                        }
                        if (i == 2)  //services
                        {
                            //agsServerlistBox.Items.Insert(0, dict["services"]);
                            JArray servicesCollection = (JArray)rss["services"];
                            foreach (var item in servicesCollection)
                            {
                                //call each services and get details

                                //at service level
                                String currentFolderNameStr = "";
                                String currentServiceNameStr = "";
                                String currentServiceTypeStr = "";

                                currentFolderNameStr = "Root";
                                currentServiceNameStr = item["serviceName"].ToString();
                                currentServiceTypeStr = item["type"].ToString();

                                var serviceDictionary = new Dictionary<string, object>();
                                serviceDictionary["currentFolderNameStr"] = currentFolderNameStr;
                                serviceDictionary["currentServiceNameStr"] = currentServiceNameStr;
                                serviceDictionary["currentServiceTypeStr"] = currentServiceTypeStr;

                                String agsServerFolderServiceURL = "";

                                if (currentServiceTypeStr == "MapServer" || currentServiceTypeStr == "FeatureServer")
                                {
                                    agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + currentServiceNameStr + "/" + currentServiceTypeStr + "/layers?f=json&token=" + token;
                                }
                                else if (currentServiceTypeStr == "GPServer")
                                {
                                    continue;
                                    //agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + itemFolder["name"].ToString() + "/" + itemFolder["type"].ToString() + "/layers?f=json&token=" + token;
                                }

                                HttpWebRequest requestFolderService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                HttpWebResponse responseFolderService = (HttpWebResponse)requestFolderService.GetResponse();
                                using (var readerFolderService = new System.IO.StreamReader(responseFolderService.GetResponseStream(), encoding))
                                {
                                    String JSONresultsFolderService = readerFolderService.ReadToEnd();
                                    JObject rssFolderService = JObject.Parse(JSONresultsFolderService);
                                    var dictFolderService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderService);
                                    string[] resultFolderService = dictFolderService.Select(kv => kv.Value.ToString()).ToArray();
                                    System.Object[] ItemObjectFolderService = new System.Object[dictFolderService.Count];
                                    JArray servicesLayersCollectionFolder = (JArray)rssFolderService["layers"];

                                    String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                    serviceDictionary["layerCountStr"] = layerCountStr;

                                    foreach (var itemFolderServLayer in servicesLayersCollectionFolder)
                                    {
                                        var layerDictionary = new Dictionary<string, object>();
                                        String layerIdStr = itemFolderServLayer["id"].ToString();
                                        String layerNameStr = itemFolderServLayer["name"].ToString();
                                        String layerGeomtryTypeStr = itemFolderServLayer["geometryType"].ToString();
                                        String layerMinScaleStr = itemFolderServLayer["minScale"].ToString();
                                        String layerMaxScaleStr = itemFolderServLayer["maxScale"].ToString();
                                        String layerDisplayFieldStr = itemFolderServLayer["displayField"].ToString();
                                        String maxRecordCountStr = itemFolderServLayer["maxRecordCount"].ToString();

                                        layerDictionary["layerIdStr"] = layerIdStr;
                                        layerDictionary["layerNameStr"] = layerNameStr;
                                        layerDictionary["layerGeomtryTypeStr"] = layerGeomtryTypeStr;
                                        layerDictionary["layerMinScaleStr"] = layerMinScaleStr;
                                        layerDictionary["layerMaxScaleStr"] = layerMaxScaleStr;
                                        layerDictionary["layerDisplayFieldStr"] = layerDisplayFieldStr;
                                        layerDictionary["maxRecordCountStr"] = maxRecordCountStr;

                                        //String fieldCountStr = itemFolderServLayer["fields"].Count.ToString();
                                        var fieldsLoopCounter = 0;
                                        //List<Object> servicesFieldsReportArray = new List<Object>();
                                        var servicesFieldsReportArray = new Dictionary<string, object>();
                                        foreach (var fieldsItem in itemFolderServLayer["fields"])
                                        {
                                            var fieldDictionary = new Dictionary<string, object>();
                                            fieldDictionary["name"] = fieldsItem["name"].ToString();
                                            fieldDictionary["type"] = fieldsItem["type"].ToString();
                                            fieldDictionary["alias"] = fieldsItem["alias"].ToString();
                                            fieldDictionary["domain"] = fieldsItem["domain"].ToString();
                                            globalVariables.servicesFieldsReportArray.Add(fieldDictionary);
                                            fieldsLoopCounter += 1;
                                            servicesFieldsReportArray[fieldsLoopCounter.ToString()] = fieldDictionary;
                                        }
                                        layerDictionary["fieldDictionary"] = servicesFieldsReportArray;
                                        String fieldCountStr = fieldsLoopCounter.ToString();
                                        layerDictionary["fieldCountStr"] = fieldCountStr;
                                        serviceDictionary["layerDictionary"] = layerDictionary;
                                    }

                                    globalVariables.servicesMainReportArray.Add(serviceDictionary);

                                }

                            }
                        }
                    }

                }
                Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                if (excelApp != null)
                {
                    Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                    Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets.Add();

                    //COLUMN HEADERS
                    //excelWorksheet.Cells[1, 1] = "Folder Name";
                    //excelWorksheet.Cells[1, 2] = "Service Name";
                    //excelWorksheet.Cells[1, 3] = "Service Type";
                    //excelWorksheet.Cells[1, 4] = "Max Record Count";
                    ////excelWorksheet.Cells[1, 5] = "Layers Count";
                    //excelWorksheet.Cells[1, 6] = "Layer Id";
                    //excelWorksheet.Cells[1, 7] = "Layer Name";
                    //excelWorksheet.Cells[1, 8] = "Geometry Type";
                    //excelWorksheet.Cells[1, 9] = "Min Scale";
                    //excelWorksheet.Cells[1, 10] = "Max Scale";
                    //excelWorksheet.Cells[1, 11] = "Display Field";
                    ////excelWorksheet.Cells[1, 12] = "Fields Count";
                    //excelWorksheet.Cells[1, 13] = "Field Name";
                    //excelWorksheet.Cells[1, 14] = "Field Type";
                    //excelWorksheet.Cells[1, 15] = "Field Alias";
                    //excelWorksheet.Cells[1, 15] = "Field Domain";

                    excelWorksheet.Cells[1, 1] = "Folder Name";
                    excelWorksheet.Cells[1, 2] = "Service Name";
                    excelWorksheet.Cells[1, 3] = "Service Type";
                    excelWorksheet.Cells[1, 4] = "Max Record Count";
                    //excelWorksheet.Cells[1, 5] = "Layers Count";
                    excelWorksheet.Cells[1, 5] = "Layer Id";
                    excelWorksheet.Cells[1, 6] = "Layer Name";
                    excelWorksheet.Cells[1, 7] = "Geometry Type";
                    excelWorksheet.Cells[1, 8] = "Min Scale";
                    excelWorksheet.Cells[1, 9] = "Max Scale";
                    excelWorksheet.Cells[1, 10] = "Display Field";
                    //excelWorksheet.Cells[1, 12] = "Fields Count";
                    excelWorksheet.Cells[1, 11] = "Field Name";
                    excelWorksheet.Cells[1, 12] = "Field Type";
                    excelWorksheet.Cells[1, 13] = "Field Alias";
                    excelWorksheet.Cells[1, 14] = "Field Domain";

                    var rowIndex = 2;
                    var columnCounter = 1;
                    foreach (Dictionary<string, object> obj in globalVariables.servicesMainReportArray)
                    {

                        excelWorksheet.Cells[rowIndex, 1] = obj["currentFolderNameStr"].ToString();
                        columnCounter += 1;
                        excelWorksheet.Cells[rowIndex, 2] = obj["currentServiceNameStr"].ToString();
                        columnCounter += 1;
                        excelWorksheet.Cells[rowIndex, 3] = obj["currentServiceTypeStr"].ToString();
                        columnCounter += 1;
                        //if (obj["layerCountStr"].ToString() == "layerCountStr")
                        //{
                        //    excelWorksheet.Cells[rowIndex, 5] = obj["layerCountStr"].ToString();
                        //    columnCounter += 1;
                        //}

                        if ((obj["currentServiceTypeStr"].ToString() == "MapServer") || (obj["currentServiceTypeStr"].ToString() == "FeatureServer"))
                        {
                            foreach (var item in (IDictionary<string, object>)obj["layerDictionary"])
                            {
                                if (item.Key.ToString() == "maxRecordCountStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 4] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerIdStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 5] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerNameStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 6] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerGeomtryTypeStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 7] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerMinScaleStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 8] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerMaxScaleStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 9] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                else if (item.Key.ToString() == "layerDisplayFieldStr")
                                {
                                    excelWorksheet.Cells[rowIndex, 10] = item.Value.ToString();
                                    columnCounter += 1;
                                }

                                //else if (item.Key.ToString() == "fieldCountStr")
                                //{
                                //    excelWorksheet.Cells[rowIndex, 12] = item.Value.ToString();
                                //    columnCounter += 1;
                                //}
                                else if (item.Key.ToString() == "fieldDictionary")
                                {
                                    var fieldFilledinCounter = 0;
                                    //foreach (Dictionary<string, object> fieldItem in (IDictionary<string, object>)item.Value)
                                    foreach (var fieldItem in (IDictionary<string, object>)item.Value)
                                    //foreach (Dictionary<string, object>  fieldItem in item.Value)
                                    {
                                        foreach (var itemField in (IDictionary<string, object>)fieldItem.Value)
                                        {
                                            if (itemField.Key.ToString() == "name")
                                            {
                                                excelWorksheet.Cells[rowIndex, 11] = itemField.Value.ToString();
                                                fieldFilledinCounter = fieldFilledinCounter + 1;
                                            }
                                            else if (itemField.Key.ToString() == "type")
                                            {
                                                excelWorksheet.Cells[rowIndex, 12] = itemField.Value.ToString();
                                                fieldFilledinCounter = fieldFilledinCounter + 1;
                                            }
                                            else if (itemField.Key.ToString() == "alias")
                                            {
                                                excelWorksheet.Cells[rowIndex, 13] = itemField.Value.ToString();
                                                fieldFilledinCounter = fieldFilledinCounter + 1;
                                            }
                                            else if (itemField.Key.ToString() == "domain")
                                            {
                                                excelWorksheet.Cells[rowIndex, 14] = itemField.Value.ToString();
                                                fieldFilledinCounter = fieldFilledinCounter + 1;
                                            }

                                            if (fieldFilledinCounter == 4)
                                            {
                                                rowIndex = rowIndex + 1;
                                                fieldFilledinCounter = 0;
                                            }
                                        }
                                    }

                                    columnCounter += 4;

                                }
                            }
                        }
                        if (columnCounter == 15)
                        {
                            columnCounter = 0;
                            
                        }
                        rowIndex = rowIndex + 1;
                    }

                    string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                    excelApp.ActiveWorkbook.SaveAs(@"C:\temp\abc_" + fileName + " .xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                    globalVariables.agsServerServicesReportName = @"C:\temp\abc_" + fileName + " .xls";
                    excelWorkbook.Close();
                    excelApp.Quit();

                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorksheet);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorkbook);
                    System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                    //MessageBox.Show("Report complete");
                    globalVariables.globalForm.loadingIconPic.Visible = false;
                }
            }
            catch (Exception ex)
            {
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles();
            }
        }
    }
}
