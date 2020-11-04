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
            InitializeComponent();
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

            globalVariables.mapServiceConfigcontent = rss.ToString();
        }

        private void btnPublishService_Click(object sender, EventArgs e)
        {
            try
            {
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();

                //;
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/services/createService";
                var request = (HttpWebRequest)WebRequest.Create(agsServerURL);

                ///==========/bigDataFileShares
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

                var response = (HttpWebResponse)request.GetResponse();
                var responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

                JObject rss = JObject.Parse(responseString);

                //JArray items = (JArray)rss["items"];
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
