using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{

    public class globalVariables
    {
        //https://lea-305263.services.esriaustralia.com.au/server/admin/system/directories?f=pjson

        public static string mapServiceMSDFile = "";
        public static string mapServiceConfig = "";
        public static string outputDirStr = "";
        public static string cacheDirStr = "";
        public static string mapServiceConfigcontent = "";
        public static string globalFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SystemProfilerReport");

        public static bool loggingEnabled = false;
        public static string strFileName = globalVariables.globalFilePath + "\\SystemProfilerLog_" + string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now) + ".log";

        public static string globalReportIcon = "";

        public static Color themeColor = Color.FromArgb(51, 44, 53);
        public static string iconFlag = "";
        public static string agsEntUserName = "";
        public static string agsEntUserPassword = "";
        public static string agsServerUserName = "";
        public static string agsServerUserPassword = "";
        public static string selectedSserviceURL = "";

        public static string global_portalHostname = "";
        public static string global_serverHostname = "";
        public static string global_datastoreHostname = "";

        public static string reportTemplateFileName = @"C:\temp\Report Template EA2.dotx";

        public static string portalCheckURL = "";
        public static string ArcGISServerCheckURL = "";
        public static string stepsCounter = "";
        public static string portalHostName = "";
        public static string agsServerHostName = "";
        public static string portalInstanceName = "";
        public static string agsServerInstanceName = "";
        public static List<string> ImageList = new List<string>();
        public static List<string> DataStoreImageList = new List<string>();
        public static string agsPortalHealthCheckStatus = "";
        public static string agsServerHealthCheckStatus = "";
        public static List<string> checkedAGSServices = new List<string>();
        public static List<Object> checkedAGSServicesArray = new List<Object>();
        public static List<Object> servicesMainReportArray = new List<Object>();
        public static List<Object> servicesLayersReportArray = new List<Object>();
        public static List<Object> servicesFieldsReportArray = new List<Object>();
        public static List<string> generateReportList = new List<string>();
        public static List<string> generateReportListDoc = new List<string>();
        public static List<Object> generateReportListServiceName = new List<Object>();
        public static string agsServerServicesReportName = "";
        public static string generatedFinalReportName = "";

        public static JArray globalbigDataFileSharesitems;
        public static JArray globalcloudStoresitems;
        public static JArray globalenterpriseDatabaseitems;
        public static JArray globalfileSharesitems;
        public static JArray globalnosqlDatabasesitems;
        public static JArray globalrasterStoresitems;

        public static JObject globalbigDataFileSharesrss;
        public static JObject globalcloudStoresrss;
        public static JObject globalenterpriseDatabaserss;
        public static JObject globalfileSharesrss;
        public static JObject globalnosqlDatabasesrss;
        public static JObject globalrasterStoresrss;

        public static string globalbigDataFileSharesValidation;
        public static string globalcloudStoresValidation;
        public static string globalenterpriseDatabaseValidation;
        public static string globalfileSharesValidation;
        public static string globalnosqlDatabasesValidation;
        public static string globalrasterStoresValidation;


        public static MakeMovable _move;
        public static String globalTokenStr = "";
        //public static TemplateForm globalForm = (TemplateForm)Application.OpenForms["TemplateForm"];
        public static LaunchForm globalForm = (LaunchForm)Application.OpenForms["LaunchForm"];
        public static List<Object> portsList = new List<Object>();
        public static List<Object> wkidPortList = new List<Object>();

        public void SaveData()
        {
            for (int i = 0; i < 300; i++)
            {
                Thread.Sleep(10);
            }
        }

        public string GetToken()
        {
            if (!Directory.Exists(globalVariables.globalFilePath))
            {
                Directory.CreateDirectory(globalVariables.globalFilePath);
                // globalFilePath = globalFilePath + "\\SystemProfilerReport";
            }

            //System.Drawing.Icon icnTask;
            //System.IO.Stream st;
            //System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();
            //st = a.GetManifestResourceStream("{{NameSpace}}.Resources.report.ico");
            //icnTask = new System.Drawing.Icon(st);

            System.Reflection.Assembly a = System.Reflection.Assembly.GetExecutingAssembly();


            string[] names = a.GetManifestResourceNames();
            foreach (string name in names)
                if (name.Contains("report.ico"))
                {
                    globalVariables.globalReportIcon = name;
                }
            //System.Console.WriteLine(name);

            //var MyShortcut = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(globalVariables.globalReportIcon);

            //Gets the image from Images Folder.
            System.IO.Stream streama = a.GetManifestResourceStream(globalVariables.globalReportIcon);

            if (null != streama)
            {
                //Fetch icon from stream.
                //globalVariables.globalFilePath
                Icon ico = new Icon(streama);
                string s = globalVariables.globalFilePath + "\\IconData.ico";
                using (FileStream fs = new FileStream(s, FileMode.Create))
                    ico.Save(fs);

                globalVariables.globalReportIcon = s;
            }

            string[] repnames = a.GetManifestResourceNames();
            foreach (string name in repnames)
                if (name.Contains("Report Template EA2.dotx"))
                {
                    globalVariables.reportTemplateFileName = name;
                }

            File.WriteAllBytes((globalVariables.globalFilePath + "\\ReportTemplate.dotx"), Properties.Resources.Report_Template);
            globalVariables.reportTemplateFileName = (globalVariables.globalFilePath + "\\ReportTemplate.dotx");


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

                // MessageBox.Show("Error generating token. Please check the parameters, URL, instance, credentials, etc" + ex.Message.ToString());
            }
            return tokenStr;
        }

        public void onErrorClearGeneratedFiles(string errorMessageStr)
        {
            try
            {
                //logg to file
                if (loggingEnabled)
                {
                    FileStream objFilestream = new FileStream(globalVariables.strFileName, FileMode.Append, FileAccess.Write);
                    StreamWriter objStreamWriter = new StreamWriter((Stream)objFilestream);
                    objStreamWriter.WriteLine(errorMessageStr);
                    objStreamWriter.Close();
                    objFilestream.Close();
                }

                for (int i = 0; i < globalVariables.ImageList.Count; i++)
                {
                    if (File.Exists(globalVariables.ImageList[i]))
                    {
                        File.Delete(globalVariables.ImageList[i]);
                    }
                }

                for (int i = 0; i < globalVariables.DataStoreImageList.Count; i++)
                {
                    if (File.Exists(globalVariables.DataStoreImageList[i]))
                    {
                        File.Delete(globalVariables.DataStoreImageList[i]);
                    }
                }

                //delete the file if it exists
                if (globalVariables.generateReportListDoc.Count > 0)
                {
                    foreach (string objArr in globalVariables.generateReportListDoc)
                    {
                        //delete the file if it exists
                        if (File.Exists(objArr))
                        {
                            File.Delete(objArr);
                        }
                    }

                }

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
                }


                //delete the file if it exists
                if (File.Exists(globalVariables.agsServerServicesReportName))
                {
                    File.Delete(globalVariables.agsServerServicesReportName);
                }

                //delete the file if it exists
                if (File.Exists(globalVariables.globalReportIcon))
                {
                    File.Delete(globalVariables.globalReportIcon);
                }

                //delete the file if it exists
                if (File.Exists(globalVariables.reportTemplateFileName))
                {
                    File.Delete(globalVariables.reportTemplateFileName);
                }
                
                //delete the file if it exists
                if (File.Exists(globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip"))
                {
                    File.Delete(globalVariables.globalFilePath + "\\SystemProfilerTestMapService.zip");
                }
                
                string foldername = "tables";
                if (Directory.Exists(globalVariables.globalFilePath + "\\" + foldername))
                {
                    Directory.Delete(globalVariables.globalFilePath + "\\" + foldername);
                }
            }
            catch (Exception)
            {


            }
           // Application.Exit();
        }
    }

    public class WinAPI {
        public const int HOR_Positive = 0X1;
        public const int HOR_NEGATIVE = 0X2;
        public const int VER_POSITIVE = 0X4;
        public const int VER_NEGATIVE = 0X8;
        public const int CENTER = 0X10;
        public const int BLEND = 0X80000;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int AnimateWindow(IntPtr hWand, int dwTime, int dwFlag);
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
