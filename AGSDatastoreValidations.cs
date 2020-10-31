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
    public partial class AGSDatastoreValidations : Form
    {
        public AGSDatastoreValidations()
        {
            InitializeComponent();
        }

        private void btn_GetDataStores_Click(object sender, EventArgs e)
        {
            try
            {  
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();

                //var request = (HttpWebRequest)WebRequest.Create("https://lea-305263.services.esriaustralia.com.au/server/admin/data/findItems");
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/data/findItems";
                var request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var postData = "parentPath=/enterpriseDatabases"; //required
                postData += "&token=" + token; //optional, default
                postData += "&f=json"; //optional, default

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

                JArray items = (JArray)rss["items"];
                foreach (var item in items)
                {
                    var dsName = item["path"].ToString();
                }
            }
            catch (Exception)
            { 
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles();
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {

        }
    }
}
