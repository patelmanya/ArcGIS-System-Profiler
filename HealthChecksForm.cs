﻿using Newtonsoft.Json.Linq;
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
            try
            {
                InitializeComponent();
                panel1.BackColor = globalVariables.themeColor;
                panel2.BackColor = globalVariables.themeColor;
                webBrowser1.BackColor = globalVariables.themeColor;

                globalVariables.portalCheckURL = "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName + "/portaladmin/healthCheck";
                txtBox_WebUrl.Text = globalVariables.portalCheckURL;
            }
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - HealthChecksForm InitializeComponent: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_PerformPortHealthCheck_Click(object sender, EventArgs e)
        {
            try
            {
                btn_PerformPortHealthCheck.Visible = false;
                webBrowser1.Visible = true;
                globalVariables.portalCheckURL = "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName + "/portaladmin/healthCheck";
                var task = DoNavigationAsync(globalVariables.portalCheckURL);
                webBrowser1.Visible = true;
                task.ContinueWith((t) =>
                {
                    portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
                    string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                    
                    globalVariables.ImageList.Add(globalVariables.globalFilePath + "\\myPortalCheck_" + fileName + ".jpg");
                    portalBMP.Save(globalVariables.globalFilePath + "\\myPortalCheck_" + fileName + ".jpg");

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
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - btn_PerformPortHealthCheck_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_PerformSrvrHealthCheck_Click(object sender, EventArgs e)
        {

            try
            {
                globalVariables.ArcGISServerCheckURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/rest/info/healthCheck";
                txtBox_WebUrl.Text = globalVariables.ArcGISServerCheckURL;

                var task = DoNavigationAsync(globalVariables.ArcGISServerCheckURL);
                webBrowser1.Visible = true;
                task.ContinueWith((t) =>
                {
                    portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
                    string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                    globalVariables.ImageList.Add(globalVariables.globalFilePath + "\\myServerCheck_" + fileName + ".jpg");
                    portalBMP.Save(globalVariables.globalFilePath + "\\myServerCheck_" + fileName + ".jpg");
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
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - btn_PerformSrvrHealthCheck_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        async Task DoNavigationAsync(string URL)
        {
            try
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
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - DoNavigationAsync: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btnUpdateURL_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - btnUpdateURL_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                //globalVariables.globalForm.btn_Services.PerformClick();
                //globalVariables.globalForm.btnDataStoreValidate.PerformClick();

                 if (globalVariables.DataStoreValidateTaskIncluded)
                {
                    globalVariables.globalForm.btnDataStoreValidate.PerformClick();
                }
                else if (globalVariables.PublishTaskIncluded)
                {
                    globalVariables.globalForm.btn_Publish.PerformClick();
                }
                else if (globalVariables.ServicesTaskIncluded)
                {
                    globalVariables.globalForm.btn_Services.PerformClick();
                }
                else
                {
                    globalVariables.globalForm.btnCreateReport.Visible = true;
                    globalVariables.globalForm.btnCreateReport.PerformClick();
                }
            }
            catch (Exception ex)
            {
                string errMsg = "HealthChecksForm.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
