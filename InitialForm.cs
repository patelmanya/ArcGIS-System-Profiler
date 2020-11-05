﻿using Newtonsoft.Json.Linq;
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
            panel1.BackColor = globalVariables.themeColor;
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
                if (txtBx_PortalHostName.Text != "" && txtBx_ServerHostName.Text != "")
                {
                    globalVariables.global_portalHostname = txtBx_PortalHostName.Text;
                    globalVariables.global_serverHostname = txtBx_ServerHostName.Text;
                    globalVariables.global_datastoreHostname = txtBx_DataStoreHostName.Text;
                    globalVariables.portalInstanceName = txtBx_PortalInstance.Text;
                    globalVariables.agsServerInstanceName = txtBx_ServerInstance.Text;
                    globalVariables.agsEntUserName = txtPortalUserName.Text;
                    globalVariables.agsEntUserPassword = txtPortalPassword.Text;
                    string token = "";
                    globalVariables gV = new globalVariables();
                    token = gV.GetToken();
                    if (token != "")
                    {
                        lbl_LoginStatus.Text = "Login successful";
                        lbl_LoginStatus.Visible = true;

                        if (Form.ModifierKeys == Keys.Control)
                        {
                            //this is the flag for debugging and is only activated when Ctrl + Click is used for the login screen.
                            globalVariables.loggingEnabled = true;

                            globalVariables.globalForm.btnSystemValidation.Visible = true;
                            globalVariables.globalForm.btnSystemValidation.PerformClick();
                        }
                        else
                        {
                            globalVariables.globalForm.btn_Tasks.PerformClick();
                        }
                       
                       
                    }
                    else
                    {
                        lbl_LoginStatus.Text = "Login failed";
                        lbl_LoginStatus.Visible = true;
                    }
                }
                else
                {
                    if (txtBx_PortalHostName.Text.Trim() == String.Empty)
                    {
                        errorProvider1.SetError(txtBx_PortalHostName, "Portal Host name is also required");
                    }
                    if (txtBx_ServerHostName.Text.Trim() == String.Empty)
                    {
                        errorProvider1.SetError(txtBx_ServerHostName, "Server Host name is also required");
                    }
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - btn_agsEnt_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
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
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - chkBx_Server_CheckedChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
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
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - chkBx_DataStore_CheckedChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
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
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - btn_EditInstanceName_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
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
            catch (Exception)
            {

                //MessageBox.Show("Error generating token. Please check the parameters, URL, instance, credentials, etc" + ex.Message.ToString());
            }
            return tokenStr;
        }

        private void txtBx_PortalHostName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBx_PortalHostName.Text))
                {

                    //txtBx_PortalHostName.Focus();
                    errorProvider1.SetError(txtBx_PortalHostName, "Portal host name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtBx_PortalHostName, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtBx_PortalHostName_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtBx_ServerHostName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBx_ServerHostName.Text))
                {

                    //txtBx_ServerHostName.Focus();
                    errorProvider1.SetError(txtBx_ServerHostName, "Server host name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtBx_ServerHostName, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtBx_ServerHostName_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtPortalUserName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPortalUserName.Text))
                {

                    //txtPortalUserName.Focus();
                    errorProvider1.SetError(txtPortalUserName, "User name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtPortalUserName, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtPortalUserName_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtPortalPassword_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPortalPassword.Text))
                {

                    //txtPortalPassword.Focus();
                    errorProvider1.SetError(txtPortalPassword, "User name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtPortalPassword, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtPortalPassword_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtBx_PortalInstance_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtPortalPassword.Text))
                {

                    //txtBx_PortalInstance.Focus();
                    txtBx_PortalInstance.Text = "portal";
                    errorProvider1.SetError(txtBx_PortalInstance, "portal instance name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtBx_PortalInstance, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtBx_PortalInstance_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtBx_ServerInstance_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBx_ServerInstance.Text))
                {

                    //txtBx_ServerInstance.Focus();
                    txtBx_ServerInstance.Text = "server";
                    errorProvider1.SetError(txtBx_ServerInstance, "Server instance name is required!");
                }
                else
                {

                    errorProvider1.SetError(txtBx_ServerInstance, "");
                }

            }
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtBx_ServerInstance_Validating: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

        private void txtBx_PortalHostName_TextChanged(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                string errMsg = "InitialForm.cs - txtBx_PortalHostName_TextChanged: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
