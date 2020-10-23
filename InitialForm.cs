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
    public partial class InitialForm : Form
    {
        public static string agsEnterpriseUserName = "";
        public static string agsEnterprisePassword = "";

        public InitialForm()
        {
            //this.CenterToParent();
            InitializeComponent();
            txtAGSServerPassword.Text = "";
            txtAGSServerPassword.PasswordChar = '*';
            //textBox4.Text = "";
            txtPortalPassword.PasswordChar = '*';
        }


        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel_Server.Visible = true;
            btn_agsEnt.Visible = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel_Server.Visible = false;
            btn_agsEnt.Visible = true;
        }


        private void btn_agsServer_Click(object sender, EventArgs e)
        {
            this.Hide();
            globalVariables.agsServerUserName = txtAGSServerUserName.Text;
            globalVariables.agsServerUserPassword = txtAGSServerPassword.Text;
            agsEnterpriseUserName = txtPortalUserName.Text;
            agsEnterprisePassword = txtPortalPassword.Text;
            StepsConfirmationForm sCnFm = new StepsConfirmationForm();
            sCnFm.Show();
        }

        private void btn_agsEnt_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtBx_PortalHostName.Text != "")
                {
                    globalVariables.global_portalHostname = txtBx_PortalHostName.Text;
                    globalVariables.global_serverHostname = txtBx_ServerHostName.Text;
                    globalVariables.global_datastoreHostname = txtBx_DataStoreHostName.Text;
                    globalVariables.portalInstanceName = txtBx_PortalInstance.Text;
                    globalVariables.agsServerInstanceName = txtBx_ServerInstance.Text;
                    globalVariables.agsEntUserName = txtPortalUserName.Text;
                    globalVariables.agsEntUserPassword = txtPortalPassword.Text;
                    string token = "";
                    token = GetToken();
                    if (token != "")
                    {
                        lbl_LoginStatus.Text = "Login successful";
                        lbl_LoginStatus.Visible = true;
                        LaunchForm lForm = new LaunchForm();
                        //lForm.updateLoggedInUser();
                        globalVariables.globalForm.btn_Tasks.PerformClick();
                        //lForm.lbl_LoginUser.Text = "Logged in as: " + globalVariables.agsEntUserName;
                        //lForm.lbl_LoginUser.Visible = true;
                    }
                    else
                    {
                        lbl_LoginStatus.Text = "Login failed";
                        lbl_LoginStatus.Visible = true;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private void chkBx_Server_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBx_PortalHostName.Text != "" && chkBx_Server.Checked)
                {
                    txtBx_ServerHostName.Text = txtBx_PortalHostName.Text;
                }
                else
                {
                    txtBx_ServerHostName.Text = "";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkBx_DataStore_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtBx_PortalHostName.Text != "" && chkBx_DataStore.Checked)
                {
                    txtBx_DataStoreHostName.Text = txtBx_PortalHostName.Text;
                }
                else
                {
                    txtBx_DataStoreHostName.Text = "";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_EditInstanceName_Click(object sender, EventArgs e)
        {
            try
            {
                if (btn_EditInstanceName.Text == "Edit")
                {
                    txtBx_PortalInstance.Enabled = true;
                    txtBx_ServerInstance.Enabled = true;
                    btn_EditInstanceName.Text = "Update";
                }
                else if (btn_EditInstanceName.Text == "Update")
                {
                    globalVariables.agsServerInstanceName = txtBx_ServerInstance.Text;
                    globalVariables.portalInstanceName = txtBx_PortalInstance.Text;
                    txtBx_PortalInstance.Enabled = false;
                    txtBx_ServerInstance.Enabled = false;
                    btn_EditInstanceName.Text = "Edit";
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private string GetToken()
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

                //MessageBox.Show("Error generating token. Please check the parameters, URL, instance, credentials, etc" + ex.Message.ToString());
            }
            return tokenStr;
        }
    }
}
