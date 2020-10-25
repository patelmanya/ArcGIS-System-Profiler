using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class HealthChecksForm : Form
    {

        Bitmap serverBMP = new Bitmap(1024, 500);
        Bitmap portalBMP = new Bitmap(1024, 500);

        public HealthChecksForm()
        {
            InitializeComponent();
            txtBox_WebUrl.Text = globalVariables.portalCheckURL;
            globalVariables.portalCheckURL = "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName + "/portaladmin/healthCheck";

        }

        private void btn_PerformPortHealthCheck_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            globalVariables.portalCheckURL = "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName + "/portaladmin/healthCheck";
            var task = DoNavigationAsync(globalVariables.portalCheckURL);
            webBrowser1.Visible = true;
            task.ContinueWith((t) =>
            {
                portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
                string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                globalVariables.ImageList.Add("C:/temp/myPortalCheck_" + fileName + ".jpg");
                portalBMP.Save("C:/temp/myPortalCheck_" + fileName + ".jpg");
                btn_PerformPortHealthCheck.Visible = false;
                //https://lea-305263.services.esriaustralia.com.au/server/rest/info/healthCheck?f=pjson
                //https://lea-305263.services.esriaustralia.com.au/portal/portaladmin/healthCheck
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(globalVariables.portalCheckURL + "?f=json");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var encoding = ASCIIEncoding.ASCII;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    String JSONresults = reader.ReadToEnd();
                    globalVariables.agsPortalHealthCheckStatus = JSONresults;
                    JObject rss = JObject.Parse(JSONresults);
                }
                btn_PerformSrvrHealthCheck.Visible = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        private void btn_PerformSrvrHealthCheck_Click(object sender, EventArgs e)
        {

            globalVariables.ArcGISServerCheckURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/info/healthCheck";
            txtBox_WebUrl.Text = globalVariables.ArcGISServerCheckURL;

            var task = DoNavigationAsync(globalVariables.ArcGISServerCheckURL);
            webBrowser1.Visible = true;
            task.ContinueWith((t) =>
            {
                portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
                string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                globalVariables.ImageList.Add("C:/temp/myServerCheck_" + fileName + ".jpg");
                portalBMP.Save("C:/temp/myServerCheck_" + fileName + ".jpg");
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(globalVariables.ArcGISServerCheckURL + "?f=json");
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                var encoding = ASCIIEncoding.ASCII;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });
                using (var reader = new System.IO.StreamReader(response.GetResponseStream(), encoding))
                {
                    String JSONresults = reader.ReadToEnd();
                    globalVariables.agsServerHealthCheckStatus = JSONresults;
                    JObject rss = JObject.Parse(JSONresults);
                }
                btn_PerformSrvrHealthCheck.Visible = false;
                btn_NextStep.Visible = true;
            }, TaskScheduler.FromCurrentSynchronizationContext());
        }

        async Task DoNavigationAsync(string URL)
        {
            TaskCompletionSource<bool> tcsNavigation = null;
            TaskCompletionSource<bool> tcsDocument = null;

            this.webBrowser1.Navigated += (s, e) =>
            {
                if (tcsNavigation.Task.IsCompleted)
                    return;
                tcsNavigation.SetResult(true);
            };

            this.webBrowser1.DocumentCompleted += (s, e) =>
            {
                if (this.webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                    return;
                if (tcsDocument.Task.IsCompleted)
                    return;
                tcsDocument.SetResult(true);
            };

            for (var i = 0; i <= 12; i++)
            {
                tcsNavigation = new TaskCompletionSource<bool>();
                tcsDocument = new TaskCompletionSource<bool>();
                // automatically accept HTTPS certificates
                ServicePointManager
    .ServerCertificateValidationCallback +=
    (sender, cert, chain, sslPolicyErrors) => true;
                this.webBrowser1.Navigate(URL + "?i=" + i.ToString());
                await tcsNavigation.Task;
                //Debug.Print("Navigated: {0}", this.WB.Document.Url);
                // navigation completed, but the document may still be loading

                await tcsDocument.Task;
                //Debug.Print("Loaded: {0}", this.WB.DocumentText);
                // the document has been fully loaded, you can access DOM here
            }
        }

        private void btnUpdateURL_Click(object sender, EventArgs e)
        {
            if (btnUpdateURL.Text == "Edit")
            {
                txtBox_WebUrl.Enabled = true;
                btnUpdateURL.Text = "Update";
            }
            else if (btnUpdateURL.Text == "Update")
            {
                txtBox_WebUrl.Enabled = false;
                btnUpdateURL.Text = "Edit";
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            globalVariables.globalForm.btn_HealthChecks.PerformClick();
        }
    }
}
