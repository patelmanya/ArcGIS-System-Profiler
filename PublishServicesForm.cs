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
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class PublishServicesForm : Form
    {
        public PublishServicesForm()
        {
            InitializeComponent();

            globalVariables.mapServiceConfig = Path.Combine(Environment.CurrentDirectory, "mapServiceConfig.json");
            globalVariables.mapServiceConfigcontent = File.ReadAllText(globalVariables.mapServiceConfig);
            JObject rss = JObject.Parse(globalVariables.mapServiceConfigcontent);

            foreach (var item in rss)
            {
                if (item.Key == "properties")
                {
                    //JArray propertiesObj = (JArray) item.Value;
                    JObject propertiesObj = (JObject)item.Value;
                    foreach (var propertiesObjitem in propertiesObj)
                    {
                        if (propertiesObjitem.Key == "filePath")
                        {
                            propertiesObj.Property("filePath").Remove();
                            propertiesObj.Property("outputDir").AddBeforeSelf(new JProperty("filePath", "C:\\Users\\manishpatel\\OneDrive\\Repo\\System Profiler\\TestData\\New folder\\SystemProfilerTestMapService\\v101\\SystemProfilerTestMapService.msd"));
                            break;
                            //propertiesObj.Property("filePath").AddAfterSelf(new JProperty("new", "New value"));
                        }
                    }
                }

                //JObject propertiesObj = JObject.Parse(item."properties"));
                //var propertiesObj = item["properties"];
            }
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
