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

            panel1.BackColor = globalVariables.themeColor;
            panel2.BackColor = globalVariables.themeColor;
            AGS_dataGridView.BackgroundColor = globalVariables.themeColor;

            if (globalVariables.global_serverHostname != "")
            {
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services?f=json";
                txtBx_ServicesURL.Text = agsServerURL;

                //remove the existing rows in the datagridview
                //do
                //{
                //    foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                //    {
                //        try
                //        {
                //            AGS_dataGridView.Rows.Remove(row);
                //        }
                //        catch (Exception) { }
                //    }
                //} while (AGS_dataGridView.Rows.Count > 1);
                AGS_dataGridView.Rows.Clear();
                //AGS_dataGridView.AllowUserToAddRows = false;
                //AGS_dataGridView.Rows.RemoveAt(0);
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
                //do
                //{
                //    foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                //    {
                //        try
                //        {
                //            AGS_dataGridView.Rows.Remove(row);
                //        }
                //        catch (Exception) { }
                //    }
                //} while (AGS_dataGridView.Rows.Count > 1);
                AGS_dataGridView.Rows.Clear();
                AGS_dataGridView.Rows.Add();

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
                AGS_dataGridView.Rows.RemoveAt(0);
            }
            catch (Exception ex)
            {
                string errMsg = "GetServicesInfoForm.cs - btn_GetServices_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
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
                    else
                    {
                        foreach (Dictionary<string, object> obj in globalVariables.checkedAGSServicesArray)
                        {
                            if (obj["id"].ToString() == row.Cells["Service_Name"].Value.ToString() + "_" + row.Cells["Service_Type"].Value.ToString())
                            {
                                obj["checked"] = "false";
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
                                    if (!Directory.Exists(globalVariables.globalFilePath + "\\" + foldername))
                                    {
                                        Directory.CreateDirectory(globalVariables.globalFilePath + "\\" + foldername);
                                    }
                                    TextWriter txt = new StreamWriter(globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html");
                                    globalVariables.generateReportList.Add(globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html");
                                    var dictionary = new Dictionary<string, object>();
                                    dictionary["serviceName"] = obj["name"].ToString();
                                    dictionary["reportFileName"] = globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html";
                                    globalVariables.generateReportListServiceName.Add(dictionary);
                                    txt.Write(item);
                                    txt.Close();
                                    fileCounterLoop = fileCounterLoop + 1;
                                    break;
                                }
                                else if ((obj["name"].ToString()).Contains("/"))
                                {
                                    if ((item.ToString()).Contains((obj["name"].ToString()).Split('/')[1]))
                                    {
                                        string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                                        string foldername = "tables";
                                        if (!Directory.Exists(globalVariables.globalFilePath + "\\" + foldername))
                                        {
                                            Directory.CreateDirectory(globalVariables.globalFilePath + "\\" + foldername);
                                        }
                                        TextWriter txt = new StreamWriter(globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html");
                                        globalVariables.generateReportList.Add(globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html");
                                        var dictionary = new Dictionary<string, object>();
                                        dictionary["serviceName"] = obj["name"].ToString();
                                        dictionary["reportFileName"] = globalVariables.globalFilePath + "\\tables\\demo_" + fileName + ".html";
                                        globalVariables.generateReportListServiceName.Add(dictionary);
                                        txt.Write(item);
                                        txt.Close();
                                        fileCounterLoop = fileCounterLoop + 1;
                                        break;
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
            catch (Exception ex)
            {
                string errMsg = "GetServicesInfoForm.cs - btnGenerateServicesReport_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.btnCreateReport.PerformClick();


            }
            catch (System.Exception ex)
            {
                string errMsg = "GetServicesInfoForm.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btnGenerateServicesExcelReport_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables gvLoading = new globalVariables();
                using (formWaiting frm = new formWaiting(gvLoading.SaveData))
                {
                    frm.ShowDialog(this);

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
                                            else if (currentServiceTypeStr == "GPServer")
                                            {
                                                //continue;
                                                agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + itemFolder["name"].ToString() + "/" + itemFolder["type"].ToString() + "?f=json&token=" + token;

                                                HttpWebRequest requestFolderService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                                HttpWebResponse responseFolderService = (HttpWebResponse)requestFolderService.GetResponse();
                                                using (var readerFolderService = new System.IO.StreamReader(responseFolderService.GetResponseStream(), encoding))
                                                {
                                                    String JSONresultsFolderService = readerFolderService.ReadToEnd();
                                                    JObject rssFolderService = JObject.Parse(JSONresultsFolderService);
                                                    var dictFolderService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderService);
                                                    string[] resultFolderService = dictFolderService.Select(kv => kv.Value.ToString()).ToArray();
                                                    System.Object[] ItemObjectFolderService = new System.Object[dictFolderService.Count];
                                                    JArray servicesTasksCollectionFolder = (JArray)rssFolderService["tasks"];

                                                    //String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                                    //serviceDictionary["layerCountStr"] = layerCountStr;
                                                    var tasksNameDictionary = new Dictionary<string, object>();
                                                    var taskNameLoopCounter = 1;
                                                    foreach (var itemFolderServTask in servicesTasksCollectionFolder)
                                                    {
                                                        String taskNameStr = itemFolderServTask.ToString();
                                                        //for each task
                                                        agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + itemFolder["name"].ToString() + "/" + itemFolder["type"].ToString() + "/" + taskNameStr + "?f=json&token=" + token;

                                                        HttpWebRequest requestFolderTasksService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                                        HttpWebResponse responseFolderTasksService = (HttpWebResponse)requestFolderTasksService.GetResponse();
                                                        using (var readerTasksService = new System.IO.StreamReader(responseFolderTasksService.GetResponseStream(), encoding))
                                                        {
                                                            String JSONresultsFolderTasksService = readerTasksService.ReadToEnd();
                                                            JObject rssFolderTasksService = JObject.Parse(JSONresultsFolderTasksService);
                                                            var dictFolderTasksService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderTasksService);
                                                            string[] resultFolderTasksService = dictFolderTasksService.Select(kv => kv.Value.ToString()).ToArray();
                                                            System.Object[] ItemObjectFolderTasksService = new System.Object[dictFolderTasksService.Count];
                                                            JArray servicesTasksCollectionTasksFolder = (JArray)rssFolderTasksService["parameters"];
                                                            string ServiceExecutionTypeStr = rssFolderTasksService["executionType"].ToString();

                                                            //String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                                            //serviceDictionary["layerCountStr"] = layerCountStr;
                                                            var taskParamNameLoopCounter = 1;
                                                            var tasksParamsDictionary = new Dictionary<string, object>();

                                                            foreach (JObject itemFolderServTaskParams in servicesTasksCollectionTasksFolder)
                                                            {
                                                                var taskParamDictionary = new Dictionary<string, object>();
                                                                String TaskParameterNameStr = itemFolderServTaskParams["name"].ToString();
                                                                String TaskParameterdataTypeStr = itemFolderServTaskParams["dataType"].ToString();
                                                                String TaskParameterdisplayNameStr = itemFolderServTaskParams["displayName"].ToString();
                                                                String TaskParameterdescriptionStr = itemFolderServTaskParams["description"].ToString();
                                                                String TaskParameterdirectionStr = itemFolderServTaskParams["direction"].ToString();
                                                                String TaskParameterdefaultValueStr = itemFolderServTaskParams["defaultValue"].ToString();
                                                                String TaskParameterparameterTypeStr = itemFolderServTaskParams["parameterType"].ToString();
                                                                String TaskParametercategoryStr = itemFolderServTaskParams["category"].ToString();

                                                                String TaskParameterchoiceListStr = "";

                                                                if (itemFolderServTaskParams.ContainsKey("choiceList"))
                                                                {
                                                                    TaskParameterchoiceListStr = itemFolderServTaskParams["choiceList"].ToString();
                                                                }
                                                                taskParamDictionary["taskNameStr"] = taskNameStr;
                                                                taskParamDictionary["TaskParameterNameStr"] = TaskParameterNameStr;
                                                                taskParamDictionary["TaskParameterdataTypeStr"] = TaskParameterdataTypeStr;
                                                                taskParamDictionary["TaskParameterdisplayNameStr"] = TaskParameterdisplayNameStr;
                                                                taskParamDictionary["TaskParameterdescriptionStr"] = TaskParameterdescriptionStr;
                                                                taskParamDictionary["TaskParameterdirectionStr"] = TaskParameterdirectionStr;
                                                                taskParamDictionary["TaskParameterdefaultValueStr"] = TaskParameterdefaultValueStr;
                                                                taskParamDictionary["TaskParameterparameterTypeStr"] = TaskParameterparameterTypeStr;
                                                                taskParamDictionary["TaskParametercategoryStr"] = TaskParametercategoryStr;
                                                                taskParamDictionary["TaskParameterchoiceListStr"] = TaskParameterchoiceListStr;
                                                                tasksParamsDictionary[taskParamNameLoopCounter.ToString()] = taskParamDictionary;
                                                                taskParamNameLoopCounter += 1;
                                                            }
                                                            serviceDictionary["taskNameStr"] = taskNameStr;
                                                            serviceDictionary["ServiceExecutionTypeStr"] = ServiceExecutionTypeStr;
                                                            tasksNameDictionary[taskNameLoopCounter.ToString()] = tasksParamsDictionary;
                                                            taskNameLoopCounter += 1;
                                                        }

                                                    }

                                                    serviceDictionary["NoOfTasks"] = taskNameLoopCounter.ToString();
                                                    serviceDictionary["taskParamDictionary"] = tasksNameDictionary;
                                                    globalVariables.servicesMainReportArray.Add(serviceDictionary);

                                                }
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
                                    else if (currentServiceTypeStr == "GPServer")
                                    {
                                        //continue;
                                        agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + currentServiceNameStr + "/" + currentServiceTypeStr + "?f=json&token=" + token;

                                        HttpWebRequest requestFolderService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                        HttpWebResponse responseFolderService = (HttpWebResponse)requestFolderService.GetResponse();
                                        using (var readerFolderService = new System.IO.StreamReader(responseFolderService.GetResponseStream(), encoding))
                                        {
                                            String JSONresultsFolderService = readerFolderService.ReadToEnd();
                                            JObject rssFolderService = JObject.Parse(JSONresultsFolderService);
                                            var dictFolderService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderService);
                                            string[] resultFolderService = dictFolderService.Select(kv => kv.Value.ToString()).ToArray();
                                            System.Object[] ItemObjectFolderService = new System.Object[dictFolderService.Count];
                                            JArray servicesTasksCollectionFolder = (JArray)rssFolderService["tasks"];

                                            //String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                            //serviceDictionary["layerCountStr"] = layerCountStr;

                                            foreach (var itemFolderServTask in servicesTasksCollectionFolder)
                                            {
                                                String taskNameStr = itemFolderServTask.ToString();
                                                //for each task
                                                agsServerFolderServiceURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/" + currentServiceNameStr + "/" + currentServiceTypeStr + "/" + taskNameStr + "?f=json&token=" + token;

                                                HttpWebRequest requestFolderTasksService = (HttpWebRequest)WebRequest.Create(agsServerFolderServiceURL);
                                                HttpWebResponse responseFolderTasksService = (HttpWebResponse)requestFolderTasksService.GetResponse();
                                                using (var readerTasksService = new System.IO.StreamReader(responseFolderTasksService.GetResponseStream(), encoding))
                                                {
                                                    String JSONresultsFolderTasksService = readerTasksService.ReadToEnd();
                                                    JObject rssFolderTasksService = JObject.Parse(JSONresultsFolderTasksService);
                                                    var dictFolderTasksService = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(JSONresultsFolderTasksService);
                                                    string[] resultFolderTasksService = dictFolderTasksService.Select(kv => kv.Value.ToString()).ToArray();
                                                    System.Object[] ItemObjectFolderTasksService = new System.Object[dictFolderTasksService.Count];
                                                    JArray servicesTasksCollectionTasksFolder = (JArray)rssFolderTasksService["parameters"];
                                                    string ServiceExecutionTypeStr = rssFolderTasksService["executionType"].ToString();

                                                    //String layerCountStr = servicesLayersCollectionFolder.Count.ToString();
                                                    //serviceDictionary["layerCountStr"] = layerCountStr;
                                                    var taskNameLoopCounter = 0;
                                                    var tasksParamsDictionary = new Dictionary<string, object>();
                                                    foreach (JObject itemFolderServTaskParams in servicesTasksCollectionTasksFolder)
                                                    {
                                                        var taskParamDictionary = new Dictionary<string, object>();
                                                        String TaskParameterNameStr = itemFolderServTaskParams["name"].ToString();
                                                        String TaskParameterdataTypeStr = itemFolderServTaskParams["dataType"].ToString();
                                                        String TaskParameterdisplayNameStr = itemFolderServTaskParams["displayName"].ToString();
                                                        String TaskParameterdescriptionStr = itemFolderServTaskParams["description"].ToString();
                                                        String TaskParameterdirectionStr = itemFolderServTaskParams["direction"].ToString();
                                                        String TaskParameterdefaultValueStr = itemFolderServTaskParams["defaultValue"].ToString();
                                                        String TaskParameterparameterTypeStr = itemFolderServTaskParams["parameterType"].ToString();
                                                        String TaskParametercategoryStr = itemFolderServTaskParams["category"].ToString();

                                                        String TaskParameterchoiceListStr = "";

                                                        if (itemFolderServTaskParams.ContainsKey("choiceList"))
                                                        {
                                                            TaskParameterchoiceListStr = itemFolderServTaskParams["choiceList"].ToString();
                                                        }

                                                        taskParamDictionary["TaskParameterNameStr"] = TaskParameterNameStr;
                                                        taskParamDictionary["TaskParameterdataTypeStr"] = TaskParameterdataTypeStr;
                                                        taskParamDictionary["TaskParameterdisplayNameStr"] = TaskParameterdisplayNameStr;
                                                        taskParamDictionary["TaskParameterdescriptionStr"] = TaskParameterdescriptionStr;
                                                        taskParamDictionary["TaskParameterdirectionStr"] = TaskParameterdirectionStr;
                                                        taskParamDictionary["TaskParameterdefaultValueStr"] = TaskParameterdefaultValueStr;
                                                        taskParamDictionary["TaskParameterparameterTypeStr"] = TaskParameterparameterTypeStr;
                                                        taskParamDictionary["TaskParametercategoryStr"] = TaskParametercategoryStr;
                                                        taskParamDictionary["TaskParameterchoiceListStr"] = TaskParameterchoiceListStr;


                                                        taskNameLoopCounter += 1;
                                                        tasksParamsDictionary[taskNameLoopCounter.ToString()] = taskParamDictionary;
                                                    }
                                                    serviceDictionary["taskNameStr"] = taskNameStr;
                                                    serviceDictionary["ServiceExecutionTypeStr"] = ServiceExecutionTypeStr;
                                                    serviceDictionary["taskParamDictionary"] = tasksParamsDictionary;
                                                    globalVariables.servicesMainReportArray.Add(serviceDictionary);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                    Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
                    if (excelApp != null)
                    {
                        Microsoft.Office.Interop.Excel.Workbook excelWorkbook = excelApp.Workbooks.Add();
                        Microsoft.Office.Interop.Excel.Worksheet excelGPWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets.Add();
                        excelGPWorksheet.Name = "GP Services";

                        //COLUMN HEADERS
                        excelGPWorksheet.Cells[1, 1] = "Folder Name";
                        excelGPWorksheet.Cells[1, 2] = "Service Name";
                        excelGPWorksheet.Cells[1, 3] = "Service Type";
                        excelGPWorksheet.Cells[1, 4] = "Execution Type";
                        excelGPWorksheet.Cells[1, 5] = "Supported Operations"; //Submit Job in Async and Execute in Sync
                        excelGPWorksheet.Cells[1, 6] = "Task Name";
                        excelGPWorksheet.Cells[1, 7] = "Parameter Name";
                        excelGPWorksheet.Cells[1, 8] = "Parameter Data Type";
                        excelGPWorksheet.Cells[1, 9] = "Parameter Display Name";
                        excelGPWorksheet.Cells[1, 10] = "Parameter Description";
                        excelGPWorksheet.Cells[1, 11] = "Parameter Direction";
                        excelGPWorksheet.Cells[1, 12] = "Parameter Default Value";
                        excelGPWorksheet.Cells[1, 13] = "Parameter Parameter Type";
                        excelGPWorksheet.Cells[1, 14] = "Parameter Category";
                        excelGPWorksheet.Cells[1, 15] = "Parameter Choice List";

                        Microsoft.Office.Interop.Excel.Worksheet excelWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)excelWorkbook.Sheets.Add();
                        excelWorksheet.Name = "Map and Feature Services";

                        //COLUMN HEADERS
                        excelWorksheet.Cells[1, 1] = "Folder Name";
                        excelWorksheet.Cells[1, 2] = "Service Name";
                        excelWorksheet.Cells[1, 3] = "Service Type";
                        excelWorksheet.Cells[1, 4] = "Max Record Count";
                        excelWorksheet.Cells[1, 5] = "Layer Id";
                        excelWorksheet.Cells[1, 6] = "Layer Name";
                        excelWorksheet.Cells[1, 7] = "Geometry Type";
                        excelWorksheet.Cells[1, 8] = "Min Scale";
                        excelWorksheet.Cells[1, 9] = "Max Scale";
                        excelWorksheet.Cells[1, 10] = "Display Field";
                        excelWorksheet.Cells[1, 11] = "Field Name";
                        excelWorksheet.Cells[1, 12] = "Field Type";
                        excelWorksheet.Cells[1, 13] = "Field Alias";
                        excelWorksheet.Cells[1, 14] = "Field Domain";

                        var rowIndex = 2;
                        var rowGPIndex = 2;
                        var columnCounter = 1;
                        var columnGPCounter = 1;
                        foreach (Dictionary<string, object> obj in globalVariables.servicesMainReportArray)
                        {
                              
                            foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                            {
                                if (obj["currentServiceNameStr"].ToString() + "_" + obj["currentServiceTypeStr"].ToString() == row.Cells["Service_Name"].Value.ToString() + "_" + row.Cells["Service_Type"].Value.ToString())
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(203, 145, 105);
                                }
                                else
                                {
                                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                                }

                            }

                            if (obj["currentServiceTypeStr"].ToString() == "GPServer")
                            {
                                //continue;
                                columnGPCounter = 1;
                                string currentFolderNameStrinLoop = "";
                                string currentServiceNameStrinLoop = "";
                                string currentServiceTypeStrinLoop = "";
                                string currentServiceExecutionTypeStrinLoop = "";

                                string TaskParameterNameStr = "";
                                string TaskParameterdataTypeStr = "";
                                string TaskParameterdisplayNameStr = "";
                                string TaskParameterdescriptionStr = "";
                                string TaskParameterdirectionStr = "";
                                string TaskParameterdefaultValueStr = "";
                                string TaskParameterparameterTypeStr = "";
                                string TaskParametercategoryStr = "";
                                string TaskParameterchoiceListStr = "";


                                TaskParameterNameStr = "";
                                TaskParameterdataTypeStr = "";
                                TaskParameterdisplayNameStr = "";
                                TaskParameterdescriptionStr = "";
                                TaskParameterdirectionStr = "";
                                TaskParameterdefaultValueStr = "";
                                TaskParameterparameterTypeStr = "";
                                TaskParametercategoryStr = "";
                                TaskParameterchoiceListStr = "";


                                currentFolderNameStrinLoop = obj["currentFolderNameStr"].ToString();
                                currentServiceNameStrinLoop = obj["currentServiceNameStr"].ToString();
                                currentServiceTypeStrinLoop = obj["currentServiceTypeStr"].ToString();
                                //currentServiceExecutionTypeStrinLoop = obj["ServiceExecutionTypeStr"].ToString();

                                excelGPWorksheet.Cells[rowGPIndex, 1] = obj["currentFolderNameStr"].ToString();
                                columnGPCounter += 1;
                                excelGPWorksheet.Cells[rowGPIndex, 2] = obj["currentServiceNameStr"].ToString();
                                columnGPCounter += 1;
                                excelGPWorksheet.Cells[rowGPIndex, 3] = obj["currentServiceTypeStr"].ToString();
                                columnGPCounter += 1;

                                if (obj["ServiceExecutionTypeStr"].ToString() == "esriExecutionTypeAsynchronous")
                                {
                                    currentServiceExecutionTypeStrinLoop = "Submit Job";
                                }
                                else if (obj["ServiceExecutionTypeStr"].ToString() == "esriExecutionTypeSynchronous")
                                {
                                    currentServiceExecutionTypeStrinLoop = "Execute Task";
                                }

                                excelGPWorksheet.Cells[rowGPIndex, 4] = obj["ServiceExecutionTypeStr"].ToString();
                                columnGPCounter += 1;

                                excelGPWorksheet.Cells[rowGPIndex, 5] = currentServiceExecutionTypeStrinLoop;
                                columnGPCounter += 1;

                                excelGPWorksheet.Cells[rowGPIndex, 6] = obj["taskNameStr"].ToString();
                                columnGPCounter += 1;

                                foreach (var item in (IDictionary<string, object>)obj["taskParamDictionary"])
                                {

                                    foreach (var itemtaskNameDictionary in (IDictionary<string, object>)item.Value)
                                    {
                                        excelGPWorksheet.Cells[rowGPIndex, 1] = currentFolderNameStrinLoop;
                                        excelGPWorksheet.Cells[rowGPIndex, 2] = currentServiceNameStrinLoop;
                                        excelGPWorksheet.Cells[rowGPIndex, 3] = currentServiceTypeStrinLoop;
                                        excelGPWorksheet.Cells[rowGPIndex, 4] = obj["ServiceExecutionTypeStr"].ToString();
                                        excelGPWorksheet.Cells[rowGPIndex, 5] = currentServiceExecutionTypeStrinLoop;
                                        excelGPWorksheet.Cells[rowGPIndex, 6] = obj["taskNameStr"].ToString();


                                        foreach (var itemtaskParamDictionary in (IDictionary<string, object>)itemtaskNameDictionary.Value)
                                        {
                                            if (itemtaskParamDictionary.Key.ToString() == "TaskParameterNameStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 7] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterNameStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterdataTypeStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 8] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterdataTypeStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterdisplayNameStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 9] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterdisplayNameStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterdescriptionStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 10] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterdescriptionStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterdirectionStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 11] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterdirectionStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterdefaultValueStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 12] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterdefaultValueStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterparameterTypeStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 13] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterparameterTypeStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParametercategoryStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 14] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParametercategoryStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            else if (itemtaskParamDictionary.Key.ToString() == "TaskParameterchoiceListStr")
                                            {
                                                excelGPWorksheet.Cells[rowGPIndex, 15] = itemtaskParamDictionary.Value.ToString();
                                                columnGPCounter += 1;
                                                TaskParameterchoiceListStr = itemtaskParamDictionary.Value.ToString();
                                            }

                                            if (columnGPCounter == 16)
                                            {
                                                rowGPIndex = rowGPIndex + 1;
                                                columnGPCounter = 7;

                                            }
                                        }

                                    }

                                }

                            }


                            if ((obj["currentServiceTypeStr"].ToString() == "MapServer") || (obj["currentServiceTypeStr"].ToString() == "FeatureServer"))
                            {
                                string currentFolderNameStrinLoop = "";
                                string currentServiceNameStrinLoop = "";
                                string currentServiceTypeStrinLoop = "";
                                string currentmaxRecordCountStrStrinLoop = "";
                                string currentlayerIdStrStrinLoop = "";
                                string currentlayerNameStrStrinLoop = "";
                                string currentlayerGeomtryTypeStrStrinLoop = "";
                                string currentlayerMinScaleStrStrinLoop = "";
                                string currentlayerMaxScaleStrStrinLoop = "";
                                string currentlayerDisplayFieldStrStrinLoop = "";

                                currentFolderNameStrinLoop = "";
                                currentServiceNameStrinLoop = "";
                                currentServiceTypeStrinLoop = "";
                                currentmaxRecordCountStrStrinLoop = "";
                                currentlayerIdStrStrinLoop = "";
                                currentlayerNameStrStrinLoop = "";
                                currentlayerGeomtryTypeStrStrinLoop = "";
                                currentlayerMinScaleStrStrinLoop = "";
                                currentlayerMaxScaleStrStrinLoop = "";
                                currentlayerDisplayFieldStrStrinLoop = "";

                                currentFolderNameStrinLoop = obj["currentFolderNameStr"].ToString();
                                currentServiceNameStrinLoop = obj["currentServiceNameStr"].ToString();
                                currentServiceTypeStrinLoop = obj["currentServiceTypeStr"].ToString();

                                excelWorksheet.Cells[rowIndex, 1] = obj["currentFolderNameStr"].ToString();
                                columnCounter += 1;
                                excelWorksheet.Cells[rowIndex, 2] = obj["currentServiceNameStr"].ToString();
                                columnCounter += 1;
                                excelWorksheet.Cells[rowIndex, 3] = obj["currentServiceTypeStr"].ToString();
                                columnCounter += 1;

                                foreach (var item in (IDictionary<string, object>)obj["layerDictionary"])
                                {
                                    if (item.Key.ToString() == "maxRecordCountStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 4] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentmaxRecordCountStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerIdStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 5] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerIdStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerNameStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 6] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerNameStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerGeomtryTypeStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 7] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerGeomtryTypeStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerMinScaleStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 8] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerMinScaleStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerMaxScaleStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 9] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerMaxScaleStrStrinLoop = item.Value.ToString();
                                    }

                                    else if (item.Key.ToString() == "layerDisplayFieldStr")
                                    {
                                        excelWorksheet.Cells[rowIndex, 10] = item.Value.ToString();
                                        columnCounter += 1;
                                        currentlayerDisplayFieldStrStrinLoop = item.Value.ToString();
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

                                                excelWorksheet.Cells[rowIndex, 1] = currentFolderNameStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 2] = currentServiceNameStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 3] = currentServiceTypeStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 4] = currentmaxRecordCountStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 5] = currentlayerIdStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 6] = currentlayerNameStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 7] = currentlayerGeomtryTypeStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 8] = currentlayerMinScaleStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 9] = currentlayerMaxScaleStrStrinLoop;
                                                excelWorksheet.Cells[rowIndex, 10] = currentlayerDisplayFieldStrStrinLoop;

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
                                if (columnCounter == 15)
                                {
                                    columnCounter = 0;

                                }
                            }
                        }

                        foreach (DataGridViewRow row in AGS_dataGridView.Rows)
                        {
                            row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 255);
                        }

                        //autofit all columns based on content
                        excelGPWorksheet.Columns.AutoFit();
                        excelWorksheet.Columns.AutoFit();

                        //delete the default Sheet1 that is added
                        excelWorkbook.Sheets[excelWorkbook.Sheets.Count].Delete();

                        string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                        excelApp.ActiveWorkbook.SaveAs(globalVariables.globalFilePath + "\\abc_" + fileName + " .xls", Microsoft.Office.Interop.Excel.XlFileFormat.xlWorkbookNormal);
                        globalVariables.agsServerServicesReportName = globalVariables.globalFilePath + "\\abc_" + fileName + " .xls";
                        excelWorkbook.Close();
                        excelApp.Quit();

                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelGPWorksheet);
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorksheet);
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelWorkbook);
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(excelApp);
                        GC.Collect();
                        GC.WaitForPendingFinalizers();
                        //MessageBox.Show("Report complete");
                        globalVariables.globalForm.loadingIconPic.Visible = false;
                        frm.Hide();
                    }


                }

            }
            catch (Exception ex)
            {
                string errMsg = "GetServicesInfoForm.cs - btnGenerateServicesExcelReport_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
