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
            panel1.BackColor = globalVariables.themeColor;
            panel2.BackColor = globalVariables.themeColor;
            panel3.BackColor = globalVariables.themeColor;
            AGSDS_dataGridView.BackgroundColor = globalVariables.themeColor;
            //AGSDS_dataGridView.Visible = false;
        }

        private void btn_GetDataStores_Click(object sender, EventArgs e)
        {
            try
            {
                do
                {
                    foreach (DataGridViewRow row in AGSDS_dataGridView.Rows)
                    {
                        try
                        {
                            AGSDS_dataGridView.Rows.Remove(row);
                        }
                        catch (Exception) { }
                    }
                } while (AGSDS_dataGridView.Rows.Count > 1);

                AGSDS_dataGridView.AllowUserToAddRows = true;
                string token = "";
                globalVariables gV = new globalVariables();
                token = gV.GetToken();

                JArray bigDataFileSharesitems;
                JArray cloudStoresitems;
                JArray enterpriseDatabaseitems;
                JArray fileSharesitems;
                JArray nosqlDatabasesitems;
                JArray rasterStoresitems;


                //var request = (HttpWebRequest)WebRequest.Create("https://lea-305263.services.esriaustralia.com.au/server/admin/data/findItems");
                String agsServerURL = "https://" + globalVariables.global_serverHostname + "/" + globalVariables.agsServerInstanceName + "/admin/data/findItems";
                var request = (HttpWebRequest)WebRequest.Create(agsServerURL);

                ///==========/bigDataFileShares
                var bigDataFileSharespostData = "parentPath=/bigDataFileShares"; //required
                bigDataFileSharespostData += "&token=" + token; //optional, default
                bigDataFileSharespostData += "&f=json"; //optional, default
                var bigDataFileSharesdata = Encoding.ASCII.GetBytes(bigDataFileSharespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = bigDataFileSharesdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(bigDataFileSharesdata, 0, bigDataFileSharesdata.Length);
                }

                var bigDataFileSharesresponse = (HttpWebResponse)request.GetResponse();
                var bigDataFileSharesresponseString = new StreamReader(bigDataFileSharesresponse.GetResponseStream()).ReadToEnd();

                JObject bigDataFileSharesrss = JObject.Parse(bigDataFileSharesresponseString);

                bigDataFileSharesitems = (JArray)bigDataFileSharesrss["items"];
                ///==========/bigDataFileShares


                ///==========/cloudStores
                request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var cloudStorespostData = "parentPath=/cloudStores"; //required
                cloudStorespostData += "&token=" + token; //optional, default
                cloudStorespostData += "&f=json"; //optional, default
                var cloudStoresdata = Encoding.ASCII.GetBytes(cloudStorespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = cloudStoresdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(cloudStoresdata, 0, cloudStoresdata.Length);
                }

                var cloudStoresresponse = (HttpWebResponse)request.GetResponse();
                var cloudStoresresponseString = new StreamReader(cloudStoresresponse.GetResponseStream()).ReadToEnd();

                JObject cloudStoressrss = JObject.Parse(cloudStoresresponseString);

                cloudStoresitems = (JArray)cloudStoressrss["items"];
                ///==========/cloudStores


                //============/enterpriseDatabases
                request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var enterpriseDatabasespostData = "parentPath=/enterpriseDatabases"; //required
                enterpriseDatabasespostData += "&token=" + token; //optional, default
                enterpriseDatabasespostData += "&f=json"; //optional, default
                var enterpriseDatabasesdata = Encoding.ASCII.GetBytes(enterpriseDatabasespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = enterpriseDatabasesdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(enterpriseDatabasesdata, 0, enterpriseDatabasesdata.Length);
                }

                var enterpriseDatabasesresponse = (HttpWebResponse)request.GetResponse();
                var enterpriseDatabasesresponseString = new StreamReader(enterpriseDatabasesresponse.GetResponseStream()).ReadToEnd();

                JObject enterpriseDatabasesrss = JObject.Parse(enterpriseDatabasesresponseString);

                enterpriseDatabaseitems = (JArray)enterpriseDatabasesrss["items"];
                foreach (var item in enterpriseDatabaseitems)
                    //============/enterpriseDatabases

                    ///==========/fileShares
                    request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var fileSharespostData = "parentPath=/fileShares"; //required
                fileSharespostData += "&token=" + token; //optional, default
                fileSharespostData += "&f=json"; //optional, default
                var fileSharesdata = Encoding.ASCII.GetBytes(fileSharespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = fileSharesdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(fileSharesdata, 0, fileSharesdata.Length);
                }

                var fileSharesresponse = (HttpWebResponse)request.GetResponse();
                var fileSharesresponseString = new StreamReader(fileSharesresponse.GetResponseStream()).ReadToEnd();

                JObject fileSharesrss = JObject.Parse(fileSharesresponseString);

                fileSharesitems = (JArray)fileSharesrss["items"];
                ///==========/fileShares


                ///==========/nosqlDatabases
                request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var nosqlDatabasespostData = "parentPath=/nosqlDatabases"; //required
                nosqlDatabasespostData += "&token=" + token; //optional, default
                nosqlDatabasespostData += "&f=json"; //optional, default
                var nosqlDatabasesdata = Encoding.ASCII.GetBytes(nosqlDatabasespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = nosqlDatabasesdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(nosqlDatabasesdata, 0, nosqlDatabasesdata.Length);
                }

                var nosqlDatabasesresponse = (HttpWebResponse)request.GetResponse();
                var nosqlDatabasesresponseString = new StreamReader(nosqlDatabasesresponse.GetResponseStream()).ReadToEnd();

                JObject nosqlDatabasesrss = JObject.Parse(nosqlDatabasesresponseString);

                nosqlDatabasesitems = (JArray)nosqlDatabasesrss["items"];
                ///==========/nosqlDatabases

                ///==========/rasterStores
                request = (HttpWebRequest)WebRequest.Create(agsServerURL);
                var rasterStorespostData = "parentPath=/rasterStores"; //required
                rasterStorespostData += "&token=" + token; //optional, default
                rasterStorespostData += "&f=json"; //optional, default
                var rasterStoresdata = Encoding.ASCII.GetBytes(rasterStorespostData);
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = rasterStoresdata.Length;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(delegate { return true; });

                using (var stream = request.GetRequestStream())
                {
                    stream.Write(rasterStoresdata, 0, rasterStoresdata.Length);
                }

                var rasterStoresresponse = (HttpWebResponse)request.GetResponse();
                var rasterStoresresponseString = new StreamReader(rasterStoresresponse.GetResponseStream()).ReadToEnd();

                JObject rasterStoresrss = JObject.Parse(bigDataFileSharesresponseString);

                rasterStoresitems = (JArray)rasterStoresrss["items"];
                ///==========/rasterStores

                //loop through each finditems array result and create items for datagrid

                foreach (var item in bigDataFileSharesitems)
                {
                    //var dsName = item["path"].ToString();
                }

                foreach (var item in cloudStoresitems)
                {
                    //var dsName = item["path"].ToString();
                }

                foreach (var enterpriseDatabaseitemsitem in enterpriseDatabaseitems)
                {
                    var dsName = enterpriseDatabaseitemsitem["path"].ToString();
                    var isManagedDS = enterpriseDatabaseitemsitem["info"]["isManaged"].ToString();
                    bool DSManaged = false;
                    if (isManagedDS.ToUpper() == "TRUE")
                    {
                        DSManaged = true;
                    }
                    var machines = enterpriseDatabasesrss["items"].SelectMany(j => j["info"]["machines"]);
                    var machineName = "";
                    foreach (var mnItem in machines)
                    {
                        machineName = mnItem["name"].ToString();
                        break;
                    }

                    DataGridViewRow DSrow = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                    DSrow.Cells[2].Value = "ArcGIS_Data_Store";
                    DSrow.Cells[3].Value = "Managed Database";
                    AGSDS_dataGridView.Rows.Add(DSrow);

                }

                foreach (var fileSharesitemsitem in fileSharesitems)
                {
                    var dsName = fileSharesitemsitem["path"].ToString();
                    var dsType = fileSharesitemsitem["type"].ToString();


                    DataGridViewRow DSrow = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                    DSrow.Cells[2].Value = dsName.Split('/')[dsName.Split('/').Length - 1];
                    DSrow.Cells[3].Value = "Folder";
                    AGSDS_dataGridView.Rows.Add(DSrow);
                }

                foreach (var nosqlDatabasesitemsitem in nosqlDatabasesitems)
                {
                    var dsName = nosqlDatabasesitemsitem["path"].ToString();
                    var isManagedDS = nosqlDatabasesitemsitem["info"]["isManaged"].ToString();
                    bool DSManaged = false;
                    if (isManagedDS.ToUpper() == "TRUE")
                    {
                        DSManaged = true;
                    }
                    var dsFeatureDS = nosqlDatabasesitemsitem["info"]["dsFeature"].ToString();
                    
                    var machines = nosqlDatabasesrss["items"].SelectMany(j => j["info"]["machines"]);
                    var machineName = "";
                    foreach (var mnItem in machines)
                    {
                        machineName = mnItem["name"].ToString();
                        break;
                    }

                    DataGridViewRow DSrow = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                    DSrow.Cells[2].Value = "ArcGIS_Data_Store";
                    if (dsFeatureDS == "tileCache")
                    {
                        DSrow.Cells[3].Value = "Tile Cache";
                    }
                    else
                    {
                        DSrow.Cells[3].Value = dsFeatureDS;
                    }
                    AGSDS_dataGridView.Rows.Add(DSrow);
                }

                foreach (var item in rasterStoresitems)
                {
                    //var dsName = item["path"].ToString();
                }


                //DataGridViewRow row = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                //row.Cells[2].Value = "My Datastore name";
                //row.Cells[3].Value = "Folder";
                //AGSDS_dataGridView.Rows.Add(row);







                AGSDS_dataGridView.AllowUserToAddRows = false;
                AGSDS_dataGridView.Visible = true;

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
