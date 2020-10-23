using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class HealthChecksForm : Form
    {

        Bitmap serverBMP = new Bitmap(1024, 728);
        Bitmap portalBMP = new Bitmap(1024, 728);

        public HealthChecksForm()
        {
            InitializeComponent();
            txtBox_WebUrl.Text = globalVariables.portalCheckURL;
            webBrowser1.Navigate(globalVariables.portalCheckURL);
        }

        private void btn_PerformPortHealthCheck_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate("https://lea-305263.services.esriaustralia.com.au/portal/portaladmin/healthCheck");

            //portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            //string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            //globalVariables.ImageList.Add("C:/temp/myPortalCheck_" + fileName + ".jpg");
            //portalBMP.Save("C:/temp/myPortalCheck_" + fileName + ".jpg");
        }

        private void btn_PerformSrvrHealthCheck_Click(object sender, EventArgs e)
        {
            txtBox_WebUrl.Text = globalVariables.ArcGISServerCheckURL;
            txtBox_WebUrl.Text = "https://lea-305263.services.esriaustralia.com.au/server/rest/info/healthCheck";
            portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            globalVariables.ImageList.Add("C:/temp/myPortalCheck_" + fileName + ".jpg");
            portalBMP.Save("C:/temp/myPortalCheck_" + fileName + ".jpg");

            webBrowser1.Navigate(globalVariables.ArcGISServerCheckURL);
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (this.webBrowser1.ReadyState != WebBrowserReadyState.Complete)
                return;
            //portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            //string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            //globalVariables.ImageList.Add("C:/temp/myPortalCheck_" + fileName + ".jpg");
            //portalBMP.Save("C:/temp/myPortalCheck_" + fileName + ".jpg");
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {

        }
    }
}
