﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{

    public class globalVariables
    {
        public static string iconFlag = "";
        public static string agsEntUserName = "";
        public static string agsEntUserPassword = "";
        public static string agsServerUserName = "";
        public static string agsServerUserPassword = "";
        public static string selectedSserviceURL = "";

        public static string global_portalHostname = "";
        public static string global_serverHostname = "";
        public static string global_datastoreHostname = "";

        public static string reportTemplateFileName = @"C:\temp\Report Template.dotx";

        public static string portalCheckURL = "";
        public static string ArcGISServerCheckURL = "";
        public static string stepsCounter = "";
        public static string portalHostName = "";
        public static string agsServerHostName = "";
        public static string portalInstanceName = "";
        public static string agsServerInstanceName = "";
        public static List<string> ImageList = new List<string>();
        public static string agsPortalHealthCheckStatus = "";
        public static string agsServerHealthCheckStatus = "";
        public static List<string> checkedAGSServices = new List<string>();
        public static List<Object> checkedAGSServicesArray = new List<Object>();
        public static List<Object> servicesMainReportArray = new List<Object>();
        public static List<Object> servicesLayersReportArray = new List<Object>();
        public static List<Object> servicesFieldsReportArray = new List<Object>();
        public static List<string> generateReportList = new List<string>();
        public static List<string> generateReportListDoc = new List<string>();
        public static string agsServerServicesReportName = "";

        public static MakeMovable _move;
        public static String globalTokenStr = "";
        //public static TemplateForm globalForm = (TemplateForm)Application.OpenForms["TemplateForm"];
        public static LaunchForm globalForm = (LaunchForm)Application.OpenForms["LaunchForm"];
        public static List<Object> portsList = new List<Object>();
        public static List<Object> wkidPortList = new List<Object>();

        public string GetToken()
        {
            String tokenStr = "";
            try
            {
                var userPortalName = globalVariables.agsEntUserName;
                var userPortalPassword = globalVariables.agsEntUserPassword;
                String agsServerURL = "https://" + globalVariables.global_portalHostname + "/" + globalVariables.portalInstanceName + "/sharing/rest/generateToken";
                var request = (HttpWebRequest)WebRequest.Create(agsServerURL);

                var postData = "username=" + userPortalName; //required
                postData += "&password=" + userPortalPassword; //required
                postData += "&client=referer"; //required
                postData += "&referer=requestip"; //required
                postData += "&expiration=600"; //optional, default
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
                var dict = new JavaScriptSerializer().Deserialize<Dictionary<string, object>>(responseString);
                tokenStr = dict["token"].ToString();
                globalVariables.globalTokenStr = tokenStr;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Error generating token. Please check the parameters, URL, instance, credentials, etc" + ex.Message.ToString());
            }
            return tokenStr;
        }
    }



    public class MakeMovable
    {
        private Form form;
        private bool _dragging = false;
        private Point _start_point = new Point(0, 0);

        public MakeMovable(Form form)
        {
            this.form = form;
        }

        public void SetMovable(params Control[] controls)
        {
            foreach (Control control in controls)
            {
                control.MouseDown += new MouseEventHandler(_MouseDown);
                control.MouseUp += new MouseEventHandler(_MouseUp);
                control.MouseMove += new MouseEventHandler(_MouseMove);
            }
        }

        private void _MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragging = true;
                _start_point = new Point(e.X, e.Y);
            }

        }

        private void _MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void _MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = form.PointToScreen(e.Location);
                form.Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }
    }



}
