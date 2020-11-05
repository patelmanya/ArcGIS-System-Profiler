using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class PublishServicesForm : Form
    {
        public PublishServicesForm()
        {
            try
            {
                InitializeComponent();
                webBrowser1.Visible = false;
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                //https://lea-305263.services.esriaustralia.com.au/server/admin/system/directories?f=pjson
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/system/directories?f=pjson&token=" + token;
                var directoriesrequest = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var directoriesresponse = (HttpWebResponse)directoriesrequest.GetResponse();
                var directoriesresponseString = new StreamReader(directoriesresponse.GetResponseStream()).ReadToEnd();

                JObject directoriesrss = JObject.Parse(directoriesresponseString);


                foreach (var item in directoriesrss)
                {
                    if (item.Key == "directories")
                    {
                        // JObject propertiesObj = (JObject)item.Value;
                        foreach (var propertiesObjitem in item.Value)
                        {
                            JObject propertiesObj = (JObject)propertiesObjitem;
                            foreach (var directoriesObjitem in propertiesObj)
                            {
                                if (directoriesObjitem.Key == "physicalPath")
                                {
                                    var folderName = directoriesObjitem.Value.ToString();
                                    folderName = folderName.Split('\\')[folderName.Split('\\').Length - 1];
                                    if (folderName == "arcgiscache")
                                    {
                                        globalVariables.cacheDirStr = directoriesObjitem.Value.ToString();
                                        break;
                                    }
                                    if (folderName == "arcgisindex")
                                    {
                                        var physicalPath = directoriesObjitem.Value.ToString();
                                        break;
                                    }
                                    if (folderName == "arcgisinput")
                                    {
                                        var physicalPath = directoriesObjitem.Value.ToString();
                                        break;
                                    }
                                    if (folderName == "arcgisoutput")
                                    {
                                        globalVariables.outputDirStr = directoriesObjitem.Value.ToString();
                                        break;
                                    }
                                    if (folderName == "arcgissystem")
                                    {
                                        var physicalPath = directoriesObjitem.Value.ToString();
                                        break;
                                    }

                                }
                            }
                        }
                    }

                }

                //System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();

                //if (!Directory.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService"))
                //{
                //    Directory.CreateDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService");
                //}

                ////initialcachesettings.json
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\initialcachesettings.json"), Properties.Resources.initialcachesettings);

                ////manifest.xml
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\manifest.xml"), Properties.Resources.manifest);

                ////serviceconfiguration.json
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\serviceconfiguration.json"), Properties.Resources.serviceconfiguration);

                ////tilingservice.xml
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\tilingservice.xml"), Properties.Resources.tilingservice);

                //if (!Directory.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101"))
                //{
                //    Directory.CreateDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101");
                //}

                ////SystemProfilerTestMapService.msd
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101\\SystemProfilerTestMapService.msd"), Properties.Resources.SystemProfilerTestMapService1);

                ////SystemProfilerTestMapService.mxd
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101\\SystemProfilerTestMapService.mxd"), Properties.Resources.SystemProfilerTestMapService2);

                //if (!Directory.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo"))
                //{
                //    Directory.CreateDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo");
                //}

                ////item.pkinfo
                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101\\item.pkinfo"), Properties.Resources.item);

                ////iteminfo.xml
                ////File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\v101\\iteminfo.xml"), Properties.Resources.iteminfo);


                //if (!Directory.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo\\metadata"))
                //{
                //    Directory.CreateDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo\\metadata");
                //}

                //if (!Directory.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo\\thumbnail"))
                //{
                //    Directory.CreateDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService\\esriinfo\\thumbnail");
                //}



                //File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip"), Properties.Resources.SystemProfilerTestMapService);

                // File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip"), Properties.Resources.SystemProfilerTestMapService);

                // string[] repnames = a.GetManifestResourceNames();

                //string extractPath = @"C:\Users\manishpatel\AppData\Roaming\SystemProfilerReport\";

                //// Normalizes the path.
                //extractPath = Path.GetFullPath(extractPath);

                //// Ensures that the last character on the extraction path
                //// is the directory separator char.
                //// Without this, a malicious zip file could try to traverse outside of the expected
                //// extraction path.
                //if (!extractPath.EndsWith(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal))
                //    extractPath += Path.DirectorySeparatorChar;

                // File.WriteAllBytes((globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip"), Properties.Resources.SystemProfilerTestMapService);

                //ZipFile.ExtractToDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip", globalVariables.globalFilePath + extractPath);
                //C:\Users\manishpatel\AppData\Roaming\SystemProfilerReport\SystemProfilerTestMapService
                //ZipFile.ExtractToDirectory(globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip", extractPath);

                //using (ZipArchive archive = ZipFile.OpenRead(globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip"))
                //{
                //    foreach (ZipArchiveEntry entry in archive.Entries)
                //    {
                //        //if (entry.FullName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                //        //{
                //            // Gets the full path to ensure that relative segments are removed.
                //            string destinationPath = Path.GetFullPath(Path.Combine(extractPath, entry.FullName));

                //            // Ordinal match is safest, case-sensitive volumes can be mounted within volumes that
                //            // are case-insensitive.
                //            if (destinationPath.StartsWith(extractPath, StringComparison.Ordinal))
                //                entry.ExtractToFile(destinationPath);
                //        //}
                //    }
                //}

                globalVariables.mapServiceMSDFile = Path.Combine(Environment.CurrentDirectory, "resources\\ServiceMSD\\v101\\SystemProfilerTestMapService.msd");

                globalVariables.mapServiceConfig = Path.Combine(Environment.CurrentDirectory, "mapServiceConfig.json");
                globalVariables.mapServiceConfigcontent = File.ReadAllText(globalVariables.mapServiceConfig);
                JObject rss = JObject.Parse(globalVariables.mapServiceConfigcontent);

                //change the filepath
                foreach (var item in rss)
                {
                    if (item.Key == "properties")
                    {
                        JObject propertiesObj = (JObject)item.Value;
                        foreach (var propertiesObjitem in propertiesObj)
                        {
                            if (propertiesObjitem.Key == "filePath")
                            {
                                propertiesObj.Property("filePath").Remove();
                                propertiesObj.Property("outputDir").AddBeforeSelf(new JProperty("filePath", globalVariables.mapServiceMSDFile));
                                break;
                            }
                        }
                    }
                }

                //change the outputDir
                foreach (var item in rss)
                {
                    if (item.Key == "properties")
                    {
                        JObject propertiesObj = (JObject)item.Value;
                        foreach (var propertiesObjitem in propertiesObj)
                        {
                            if (propertiesObjitem.Key == "outputDir")
                            {
                                propertiesObj.Property("outputDir").Remove();
                                propertiesObj.Property("virtualOutputDir").AddBeforeSelf(new JProperty("outputDir", globalVariables.outputDirStr));
                                break;
                            }
                        }
                    }
                }

                //change the cacheDir
                foreach (var item in rss)
                {
                    if (item.Key == "properties")
                    {
                        JObject propertiesObj = (JObject)item.Value;
                        foreach (var propertiesObjitem in propertiesObj)
                        {
                            if (propertiesObjitem.Key == "cacheDir")
                            {
                                propertiesObj.Property("cacheDir").Remove();
                                propertiesObj.Property("useLocalCacheDir").AddBeforeSelf(new JProperty("cacheDir", globalVariables.outputDirStr));
                                break;
                            }
                        }
                    }
                }

                //change the portalURL
                foreach (var item in rss)
                {
                    if (item.Key == "properties")
                    {
                        JObject propertiesObj = (JObject)item.Value;
                        foreach (var propertiesObjitem in propertiesObj)
                        {
                            if (propertiesObjitem.Key == "portalURL")
                            {
                                propertiesObj.Property("portalURL").Remove();
                                propertiesObj.Property("userName").AddBeforeSelf(new JProperty("portalURL", "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName));
                                break;
                            }
                        }
                    }
                }


                //change the extensions - properties - onlineResource
                //change the portalURL
                bool typeNameKmlServer = false;
                bool typeNameWMSServer = false;
                bool typeNameNAServer = false;
                bool typeNameWCSServer = false;
                bool typeNameFeatureServer = false;
                bool typeNameVersionManagementServer = false;
                bool typeNameWFSServer = false;

                foreach (var item in rss)
                {
                    if (item.Key == "extensions")
                    {
                        foreach (var extPropitem in item.Value)
                        {
                            JObject propertiesObj = (JObject)extPropitem;
                            foreach (var propertiesObjitem in propertiesObj)
                            {
                                if (propertiesObjitem.Key == "typeName")
                                {
                                    if (propertiesObjitem.Value.ToString() == "KmlServer")
                                    {
                                        typeNameKmlServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "WMSServer")
                                    {
                                        typeNameWMSServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "NAServer")
                                    {
                                        typeNameNAServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "WCSServer")
                                    {
                                        typeNameWCSServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "FeatureServer")
                                    {
                                        typeNameFeatureServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "VersionManagementServer")
                                    {
                                        typeNameVersionManagementServer = true;
                                    }

                                    if (propertiesObjitem.Value.ToString() == "WFSServer")
                                    {
                                        typeNameWFSServer = true;
                                    }

                                }
                                if (propertiesObjitem.Key == "properties")
                                {
                                    JObject propertiesItemValObj = (JObject)propertiesObjitem.Value;
                                    foreach (var propertiesItemValObjitem in propertiesItemValObj)
                                    {
                                        if (propertiesItemValObjitem.Key == "onlineResource")
                                        {
                                            if (typeNameKmlServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("useDefaultSnippets").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/KmlServer"));
                                                typeNameKmlServer = false;
                                                break;
                                            }

                                            if (typeNameWMSServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("customGetCapabilities").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/WMSServer"));
                                                typeNameWMSServer = false;
                                                break;
                                            }

                                            if (typeNameNAServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("locationAllocation_ForceHierarchyBeyondDistanceUnits").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/NAServer"));
                                                typeNameNAServer = false;
                                                break;
                                            }

                                            if (typeNameWCSServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("customGetCapabilities").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/WCSServer"));
                                                typeNameWCSServer = false;
                                                break;
                                            }

                                            if (typeNameFeatureServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("syncEnabled").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/FeatureServer"));
                                                typeNameFeatureServer = false;
                                                break;
                                            }

                                            if (typeNameVersionManagementServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("allowedUploadFileTypes").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/VersionManagementServer"));
                                                typeNameVersionManagementServer = false;
                                                break;
                                            }

                                            if (typeNameWFSServer)
                                            {
                                                propertiesItemValObj.Property("onlineResource").Remove();
                                                propertiesItemValObj.Property("appSchemaPrefix").AddBeforeSelf(new JProperty("onlineResource", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/WFSServer"));

                                                propertiesItemValObj.Property("appSchemaURI").Remove();
                                                propertiesItemValObj.Property("appSchemaPrefix").AddBeforeSelf(new JProperty("appSchemaURI", "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/services/VIC_Open_data_MIL2/MapServer/WFSServer"));
                                                typeNameWFSServer = false;
                                                break;
                                            }

                                        }
                                    }
                                }

                            }
                        }
                    }
                }

                //Update the global map service JSON
                globalVariables.mapServiceConfigcontent = rss.ToString();
                txtBx_GenServStatus.Text = "";
            }
            catch (Exception ex)
            {
                string errMsg = "PublishServicesForm.cs - PublishServicesForm InitializeComponent: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btnPublishService_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.loadingIconPic.Visible = true;
                webBrowser1.Visible = false;
                btnPreviewService.Visible = false;
                btnPreviewService.Enabled = false;
                txtBx_GenServStatus.Text = "Generating token for publishing the service to ArcGIS Server. \r\n";
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                txtBx_GenServStatus.Text += "Token generation successful. \r\n";
                //check if the service exists
                //https://lea-305263.services.esriaustralia.com.au/server/admin/services/exists
                bool serviceExists = false;
                bool serviceExistsDeleted = false;
                txtBx_GenServStatus.Text += "Checking if the service exists. \r\n";
                String agsCheckServServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/exists";
                var request = (HttpWebRequest)WebRequest.Create(agsCheckServServerURL);
                var checkServpostData = "serviceName=VIC_Open_data_MIL2"; //required
                checkServpostData += "&type=MapServer";
                checkServpostData += "&f=json";
                checkServpostData += "&token=" + token; //optional, default

                var checkServdata = Encoding.ASCII.GetBytes(checkServpostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = checkServdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(checkServdata, 0, checkServdata.Length);
                }

                var checkServresponse = (HttpWebResponse)request.GetResponse();

                var checkServresponseString = new StreamReader(checkServresponse.GetResponseStream()).ReadToEnd();

                JObject checkServrss = JObject.Parse(checkServresponseString);

                foreach (var checkServitem in checkServrss)
                {
                    if (checkServitem.Key == "exists")
                    {
                        if (checkServitem.Value.ToString().ToUpper() == "TRUE")
                        {
                            serviceExists = true;
                            txtBx_GenServStatus.Text += "Service exists..... \r\n";
                        }
                        else
                        {
                            serviceExists = false;
                            txtBx_GenServStatus.Text += "Service does not exists..... \r\n";
                        }
                    }
                }

                if (serviceExists)
                {
                    txtBx_GenServStatus.Text += "Deleting existing test service..... \r\n";
                    //https://lea-305263.services.esriaustralia.com.au/server/admin/services/VIC_Open_data_MIL2.MapServer/delete
                    String agsdeletServiceServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/VIC_Open_data_MIL2.MapServer/delete";
                    request = (HttpWebRequest)WebRequest.Create(agsdeletServiceServerURL);

                    var deleteServpostData = "f=json";
                    deleteServpostData += "&token=" + token; //optional, default

                    var deleteServdata = Encoding.ASCII.GetBytes(deleteServpostData);
                    request.Method = "POST";
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.ContentLength = deleteServdata.Length;
                    ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                    using (var stream = request.GetRequestStream())
                    {
                        stream.Write(deleteServdata, 0, deleteServdata.Length);
                    }

                    var deleteServresponse = (HttpWebResponse)request.GetResponse();
                    var deleteServresponseString = new StreamReader(deleteServresponse.GetResponseStream()).ReadToEnd();
                    JObject deleteServrss = JObject.Parse(deleteServresponseString);

                    foreach (var deleteServitem in deleteServrss)
                    {
                        if (deleteServitem.Key == "status")
                        {
                            if (deleteServitem.Value.ToString().ToUpper() == "SUCCESS")
                            {
                                serviceExistsDeleted = true;
                                txtBx_GenServStatus.Text += "Existing test service deleted..... \r\n";
                            }
                            else
                            {
                                serviceExistsDeleted = false;
                                txtBx_GenServStatus.Text += "Error in deleting existing test service..... \r\n";
                            }
                        }
                    }

                    serviceExists = false;
                }

                txtBx_GenServStatus.Text += "Creating the test service now...\r\n";
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/createService";
                request = (HttpWebRequest)WebRequest.Create(agsServerURL);

                ///==========/bigDataFileShares
                txtBx_GenServStatus.Text += "Passing the Service parameters to create service. \r\n";
                var postData = "service=" + globalVariables.mapServiceConfigcontent; //required
                postData += "&f=json";
                postData += "&token=" + token; //optional, default

                var data = Encoding.ASCII.GetBytes(postData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = data.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
                txtBx_GenServStatus.Text += "Creating service..... \r\n";
                var response = (HttpWebResponse)request.GetResponse();
                txtBx_GenServStatus.Text += "Service creation completed...waiting for status.. \r\n";
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();
                txtBx_GenServStatus.Text += "Status received. \r\n";
                JObject rss = JObject.Parse(responseString);
                //txtBx_GenServStatus.Text += "Status:" + responseString.ToString();
                //JArray items = (JArray)rss["items"];
                foreach (var Servitem in rss)
                {
                    if (Servitem.Key == "status")
                    {
                        if (Servitem.Value.ToString().ToUpper() == "SUCCESS")
                        {
                            txtBx_GenServStatus.Text += "Status: Success \r\n";
                        }
                        else
                        {
                            txtBx_GenServStatus.Text += "Status: Error \r\n";
                        }
                    }
                }

                btnPreviewService.Visible = true;
                btnPreviewService.Enabled = true;
                globalVariables.globalForm.loadingIconPic.Visible = false;
            }
            catch (Exception ex)
            {
                string errMsg = "PublishServicesForm.cs - btnPublishService_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btnPreviewService_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.loadingIconPic.Visible = true;
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/services/VIC_Open_data_MIL2/MapServer?f=jsapi&token=" + token;
               // textBox1.Text = agsServerURL;
                webBrowser1.Visible = true;
                webBrowser1.Navigate(agsServerURL);
                globalVariables.globalForm.loadingIconPic.Visible = false;
            }
            catch (Exception ex)
            {
                string errMsg = "PublishServicesForm.cs - btnPreviewService_Click: " + ex.Message.ToString();
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
                string errMsg = "PublishServicesForm.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
