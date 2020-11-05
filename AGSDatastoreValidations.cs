using Microsoft.Office.Interop.Outlook;
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
            btn_ValidateDataStores.Enabled = false;
        }

        private void btn_GetDataStores_Click(object sender, EventArgs e)
        {
            try
            {
                btn_ValidateDataStores.Enabled = false;
                AGSDS_dataGridView.Rows.Clear();
                AGSDS_dataGridView.Rows.Add();
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

                JObject rasterStoresrss = JObject.Parse(rasterStoresresponseString);

                rasterStoresitems = (JArray)rasterStoresrss["items"];
                ///==========/rasterStores

                //set to the global variables.
                globalVariables.globalbigDataFileSharesitems = bigDataFileSharesitems;
                globalVariables.globalcloudStoresitems = cloudStoresitems;
                globalVariables.globalenterpriseDatabaseitems = enterpriseDatabaseitems;
                globalVariables.globalfileSharesitems = fileSharesitems;
                globalVariables.globalnosqlDatabasesitems = nosqlDatabasesitems;
                globalVariables.globalrasterStoresitems = rasterStoresitems;

                //loop through each finditems array result and create items for datagrid

                foreach (var item in bigDataFileSharesitems)
                {
                    //var dsName = item["path"].ToString();
                }

                foreach (var cloudStoresitemsitem in cloudStoresitems)
                {
                    var dsName = cloudStoresitemsitem["path"].ToString();
                    var providerStr = cloudStoresitemsitem["provider"].ToString();

                    DataGridViewRow DSrow = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                    DSrow.Cells[2].Value = dsName.Split('/')[dsName.Split('/').Length - 1];
                    if (providerStr == "amazon")
                    {
                        DSrow.Cells[3].Value = "Amazon Cloud Store";
                    }
                    else
                    {
                        DSrow.Cells[3].Value = "Cloud Store";
                    }
                    AGSDS_dataGridView.Rows.Add(DSrow);
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
                    if (DSManaged)
                    {
                        DSrow.Cells[3].Value = "Managed Database";
                    }
                    else
                    {
                        DSrow.Cells[3].Value = "Database";
                    }
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

                foreach (var rasterStoresitemsitem in rasterStoresitems)
                {
                    var dsName = rasterStoresitemsitem["path"].ToString();
                    var dsType = rasterStoresitemsitem["type"].ToString();


                    DataGridViewRow DSrow = (DataGridViewRow)AGSDS_dataGridView.Rows[0].Clone();
                    DSrow.Cells[2].Value = dsName.Split('/')[dsName.Split('/').Length - 1];
                    if (dsType == "rasterStore")
                    {
                        DSrow.Cells[3].Value = "Raster Store";
                    }
                    else
                    {
                        DSrow.Cells[3].Value = "";
                    }
                    AGSDS_dataGridView.Rows.Add(DSrow);
                }

                AGSDS_dataGridView.Rows.RemoveAt(0);
                AGSDS_dataGridView.AllowUserToAddRows = false;
                AGSDS_dataGridView.Visible = true;
                btn_ValidateDataStores.Enabled = true;
            }
            catch (System.Exception ex)
            {
                string errMsg = "AGSDataStoreValidations.cs - btn_GetDataStores_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_NextStep_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.btn_Services.PerformClick();

            }
            catch (System.Exception ex)
            {
                string errMsg = "AGSDataStoreValidations.cs - btn_NextStep_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void btn_ValidateDataStores_Click(object sender, EventArgs e)
        {
            try
            {
                //get selected datastores 
                foreach (DataGridViewRow row in AGSDS_dataGridView.Rows)
                {
                    bool isSelected = Convert.ToBoolean(row.Cells["checkBoxCol_Service"].Value);
                    if (isSelected)
                    {
                        string dataStoreName = row.Cells["Service_Name"].Value.ToString();
                        string dataStoreType = row.Cells["Service_Type"].Value.ToString();
                        string selectedDataStore = dataStoreName + "_" + dataStoreType;
                        foreach (var item in globalVariables.globalbigDataFileSharesitems)
                        {
                            //var dsName = item["path"].ToString();
                        }

                        foreach (var cloudStoresitemsitem in globalVariables.globalcloudStoresitems)
                        {
                            var dsName = cloudStoresitemsitem["path"].ToString();
                            var providerStr = cloudStoresitemsitem["provider"].ToString();
                            var typeStr = "";
                            if (providerStr == "amazon")
                            {
                                typeStr = "Amazon Cloud Store";
                            }
                            else
                            {
                                typeStr = "Cloud Store";
                            }
                            //Service_Type
                            if (selectedDataStore == (dsName.Split('/')[dsName.Split('/').Length - 1]).ToString() + "_" + typeStr.ToString())
                            {
                                //validate
                            }

                        }

                        foreach (var enterpriseDatabaseitemsitem in globalVariables.globalenterpriseDatabaseitems)
                        {
                            var dsName = enterpriseDatabaseitemsitem["path"].ToString();
                            var isManagedDS = enterpriseDatabaseitemsitem["info"]["isManaged"].ToString();
                            bool DSManaged = false;
                            if (isManagedDS.ToUpper() == "TRUE")
                            {
                                DSManaged = true;
                            }
                            var machines = enterpriseDatabaseitemsitem["items"].SelectMany(j => j["info"]["machines"]);
                            var machineName = "";
                            foreach (var mnItem in machines)
                            {
                                machineName = mnItem["name"].ToString();
                                break;
                            }
                            var typeStr = "";
                            if (DSManaged)
                            {
                                typeStr = "Managed Database";
                            }
                            else
                            {
                                typeStr = "Database";
                            }

                            //Service_Type
                            if (selectedDataStore == (dsName.Split('/')[dsName.Split('/').Length - 1]).ToString() + "_" + typeStr.ToString())
                            {
                                //validate
                            }
                        }

                        foreach (var fileSharesitemsitem in globalVariables.globalfileSharesitems)
                        {
                            var dsName = fileSharesitemsitem["path"].ToString();
                            //var dsType = fileSharesitemsitem["type"].ToString();
                            if (selectedDataStore == (dsName.Split('/')[dsName.Split('/').Length - 1]).ToString() + "_Folder")
                            {
                                //validate
                            }
                        }

                        foreach (var nosqlDatabasesitemsitem in globalVariables.globalnosqlDatabasesitems)
                        {
                            var dsName = nosqlDatabasesitemsitem["path"].ToString();
                            var isManagedDS = nosqlDatabasesitemsitem["info"]["isManaged"].ToString();
                            bool DSManaged = false;
                            if (isManagedDS.ToUpper() == "TRUE")
                            {
                                DSManaged = true;
                            }
                            var dsFeatureDS = nosqlDatabasesitemsitem["info"]["dsFeature"].ToString();

                            var machines = globalVariables.globalnosqlDatabasesitems.SelectMany(j => j["info"]["machines"]);
                            var machineName = "";
                            foreach (var mnItem in machines)
                            {
                                machineName = mnItem["name"].ToString();
                                break;
                            }


                            var typeStr = "";
                            if (dsFeatureDS == "tileCache")
                            {
                                typeStr = "Tile Cache";
                            }
                            else
                            {
                                typeStr = dsFeatureDS;
                            }
                            if (selectedDataStore == ("ArcGIS_Data_Store" + "_" + typeStr.ToString()))
                            {
                                //validate
                            }

                        }

                        foreach (var rasterStoresitemsitem in globalVariables.globalrasterStoresitems)
                        {
                            var dsName = rasterStoresitemsitem["path"].ToString();
                            var dsType = rasterStoresitemsitem["type"].ToString();

                            var typeStr = "";
                            if (dsType == "rasterStore")
                            {
                                typeStr = "Raster Store";
                            }
                            else
                            {
                                typeStr = "";
                            }

                            if (selectedDataStore == (dsName.Split('/')[dsName.Split('/').Length - 1]).ToString() + "_" + typeStr.ToString())
                            {
                                //validate
                            }
                        }

                    }

                }

            }
            catch (System.Exception ex)
            {
                string errMsg = "AGSDataStoreValidations.cs - btn_ValidateDataStores_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in AGSDS_dataGridView.Rows)
                {
                    row.Cells["checkBoxCol_Service"].Value = true;
                }
            }
            catch (System.Exception ex)
            {
                string errMsg = "AGSDataStoreValidations.cs - button1_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in AGSDS_dataGridView.Rows)
                {
                    row.Cells["checkBoxCol_Service"].Value = false;
                }
            }
            catch (System.Exception ex)
            {
                string errMsg = "AGSDataStoreValidations.cs - button2_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
