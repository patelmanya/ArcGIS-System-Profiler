﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ArcGIS_System_Profiler
{
    public partial class LaunchForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public LaunchForm()
        {
            //WinAPI.AnimateWindow(this.Handle, 2000, WinAPI.HOR_NEGATIVE);
            InitPage iPage = new InitPage();
            iPage.ShowDialog();
            //iPage.initpageTimer.Enabled = true;
            //iPage.initPageprogressBar.Value = 0;
            //iPage.initPageprogressBar.Value = iPage.initPageprogressBar.Value + 5;
            //if (iPage.initPageprogressBar.Value > 99)
            //{
            //    iPage.initpageTimer.Enabled = false;
            //    iPage.Close();
            //}


            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            //btn_Home.PerformClick();
            //OpenChildForm(new InitialForm());
            Load += Form1_Shown;
            //panelLoadingIconBartimer.Enabled = true;
        }

        private void Form1_Shown(Object sender, EventArgs e)
        {
            btn_Home.PerformClick();
        }

        public void OpenChildForm(Form chidlForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = chidlForm;
            chidlForm.TopLevel = false;
            chidlForm.FormBorderStyle = FormBorderStyle.None;
            chidlForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(chidlForm);
            panelDesktop.Tag = chidlForm;
            chidlForm.BringToFront();
            chidlForm.Show();
            currentStepLabel.Text = chidlForm.Text;
            lbl_loggedInUser.Text = globalVariables.agsEntUserName;
            if (globalVariables.agsEntUserName != "")
            {
                lbl_LoginUser.Text = "Logged in as: " + globalVariables.agsEntUserName;
                lbl_LoginUser.Visible = true;
            }

        }

        private struct RGBCOlors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(249, 118, 176);

        }

        //Methods
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 31);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //add to the title bar the current step title
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = currentBtn.IconColor;
            }
        }

        //disable the button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //currentBtn.BackColor = Color.FromArgb(51, 44, 53);
                currentBtn.BackColor = globalVariables.themeColor;
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        public void updateLoggedInUser()
        {

            lbl_LoginUser.Text = "Logged in as: " + globalVariables.agsEntUserName;
            //lbl_LoginUser.Visible = true;
            btn_Tasks.PerformClick();
        }

        public void btn_Home_Click(object sender, EventArgs e)
        {
            btnSetTheme.Visible = true;
            ActivateButton(sender, RGBCOlors.color1);
            OpenChildForm(new InitialForm());
        }

        public void btn_Tasks_Click(object sender, EventArgs e)
        {
            btnSetTheme.Visible = false;
            ActivateButton(sender, RGBCOlors.color2);
            //OpenChildForm(new StepsConfirmationForm());
            //OpenChildForm(new AppTasks());
            OpenChildForm(new TasksInclude());            
        }
 

        public void btn_Services_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color3);
            OpenChildForm(new GetServicesInfoForm());
        }


        private void btn_AGOLServices_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color3);
            OpenChildForm(new AGOLReport());
        }

        public void btn_HealthChecks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color4);
            OpenChildForm(new HealthChecksForm());
        }

        public void btn_PortChecks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new PortCheckForm());
        }

        public void btn_Publish_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color6);
            OpenChildForm(new PublishServicesForm());
        }

        public void btnCreateReport_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new GenerateReport());
        }


        private void btnDataStoreValidate_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new AGSDatastoreValidations());
        }

        private void btnSystemValidation_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new SystemVerification());
        }

        private void errorButton_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new ErrorLogger());
        }

        public void iconButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //add to the title bar the current step title
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            globalVariables.themeColor = Color.FromArgb(51, 44, 53);
            btnSetTheme.Visible = true;

            panelTitleBar.BackColor = globalVariables.themeColor;
            panelMenu.BackColor = globalVariables.themeColor;
            panelShadow.BackColor = globalVariables.themeColor;
            panel1.BackColor = globalVariables.themeColor;
            panel2.BackColor = globalVariables.themeColor;
            panelDesktop.BackColor = globalVariables.themeColor;
            panelDesktop.BackColor = globalVariables.themeColor;
            panelLogo.BackColor = globalVariables.themeColor;
            panelSlider.BackColor = globalVariables.themeColor;

            btn_Home.BackColor = globalVariables.themeColor;
            btnSystemValidation.BackColor = globalVariables.themeColor;
            btn_Tasks.BackColor = globalVariables.themeColor;
            btn_Services.BackColor = globalVariables.themeColor;
            btn_Publish.BackColor = globalVariables.themeColor;
            btn_PortChecks.BackColor = globalVariables.themeColor;
            btnCreateReport.BackColor = globalVariables.themeColor;
            btnDataStoreValidate.BackColor = globalVariables.themeColor;
            btnSetTheme.BackColor = globalVariables.themeColor;
            btn_HealthChecks.BackColor = globalVariables.themeColor;

            btn_Tasks.BackColor = globalVariables.themeColor;
            btn_Tasks.ForeColor = Color.White;
            btn_Tasks.TextAlign = ContentAlignment.MiddleLeft;
            btn_Tasks.IconColor = Color.White;
            btn_Tasks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Tasks.ImageAlign = ContentAlignment.MiddleLeft;

            btnSystemValidation.BackColor = globalVariables.themeColor;
            btnSystemValidation.ForeColor = Color.White;
            btnSystemValidation.TextAlign = ContentAlignment.MiddleLeft;
            btnSystemValidation.IconColor = Color.White;
            btnSystemValidation.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSystemValidation.ImageAlign = ContentAlignment.MiddleLeft;

            btn_HealthChecks.BackColor = globalVariables.themeColor;
            btn_HealthChecks.ForeColor = Color.White;
            btn_HealthChecks.TextAlign = ContentAlignment.MiddleLeft;
            btn_HealthChecks.IconColor = Color.White;
            btn_HealthChecks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_HealthChecks.ImageAlign = ContentAlignment.MiddleLeft;

            btn_PortChecks.BackColor = globalVariables.themeColor;
            btn_PortChecks.ForeColor = Color.White;
            btn_PortChecks.TextAlign = ContentAlignment.MiddleLeft;
            btn_PortChecks.IconColor = Color.White;
            btn_PortChecks.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_PortChecks.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Services.BackColor = globalVariables.themeColor;
            btn_Services.ForeColor = Color.White;
            btn_Services.TextAlign = ContentAlignment.MiddleLeft;
            btn_Services.IconColor = Color.White;
            btn_Services.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Services.ImageAlign = ContentAlignment.MiddleLeft;

            btn_Publish.BackColor = globalVariables.themeColor;
            btn_Publish.ForeColor = Color.White;
            btn_Publish.TextAlign = ContentAlignment.MiddleLeft;
            btn_Publish.IconColor = Color.White;
            btn_Publish.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_Publish.ImageAlign = ContentAlignment.MiddleLeft;

            btnCreateReport.BackColor = globalVariables.themeColor;
            btnCreateReport.ForeColor = Color.White;
            btnCreateReport.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateReport.IconColor = Color.White;
            btnCreateReport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCreateReport.ImageAlign = ContentAlignment.MiddleLeft;

            btnDataStoreValidate.BackColor = globalVariables.themeColor;
            btnDataStoreValidate.ForeColor = Color.White;
            btnDataStoreValidate.TextAlign = ContentAlignment.MiddleLeft;
            btnDataStoreValidate.IconColor = Color.White;
            btnDataStoreValidate.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDataStoreValidate.ImageAlign = ContentAlignment.MiddleLeft;

            btnSetTheme.BackColor = globalVariables.themeColor;
            btnSetTheme.ForeColor = Color.White;
            btnSetTheme.TextAlign = ContentAlignment.MiddleLeft;
            btnSetTheme.IconColor = Color.White;
            btnSetTheme.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSetTheme.ImageAlign = ContentAlignment.MiddleLeft;

            btnSystemValidation.Visible = false;
            //OpenChildForm(new InitialForm());
            globalVariables.globalForm.btn_Tasks.Visible = false;
            globalVariables.globalForm.btn_PortChecks.Visible = false;
            globalVariables.globalForm.btn_HealthChecks.Visible = false;
            globalVariables.globalForm.btnDataStoreValidate.Visible = false;
            globalVariables.globalForm.btn_Publish.Visible = false;
            globalVariables.globalForm.btn_AGOLServices.Visible = false;
            globalVariables.globalForm.btn_Services.Visible = false;
            globalVariables.globalForm.btnCreateReport.Visible = false;
            globalVariables.globalForm.btnSystemValidation.Visible = false;
            globalVariables.portsTaskIncluded = false;
            globalVariables.HealthChecksTaskIncluded = false;
            globalVariables.DataStoreValidateTaskIncluded = false;
            globalVariables.PublishTaskIncluded = false;
            globalVariables.ServicesTaskIncluded = false;
            btn_Home.PerformClick();
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void globalTimer1_Tick(object sender, EventArgs e)
        {
            globalProgressBar1.Value = globalProgressBar1.Value + 10;
            if (globalProgressBar1.Value > 99)
            {
                this.Hide();
                globalVariables.globalForm.globalTimer1.Enabled = false;
                globalVariables.globalForm.btn_Tasks.PerformClick();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            globalVariables gv = new globalVariables();
            gv.onErrorClearGeneratedFiles("Application Closed by user.");
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnSetTheme_Click(object sender, EventArgs e)
        {
            //colorDialog1.ShowDialog();

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //Properties.Settings.Default.FormsBackgroundColor = colorDialog1.Color;
                //Properties.Settings.Default.Save(); 
                globalVariables.themeColor = colorDialog1.Color;
                panelTitleBar.BackColor = globalVariables.themeColor;
                panelMenu.BackColor = globalVariables.themeColor;
                panelShadow.BackColor = globalVariables.themeColor;
                panel1.BackColor = globalVariables.themeColor;
                panel2.BackColor = globalVariables.themeColor;
                panelDesktop.BackColor = globalVariables.themeColor;
                panelDesktop.BackColor = globalVariables.themeColor;
                panelLogo.BackColor = globalVariables.themeColor;
                panelSlider.BackColor = globalVariables.themeColor;

                btn_Home.BackColor = globalVariables.themeColor;
                btnSystemValidation.BackColor = globalVariables.themeColor;
                btn_Tasks.BackColor = globalVariables.themeColor;
                btn_Services.BackColor = globalVariables.themeColor;
                btn_Publish.BackColor = globalVariables.themeColor;
                btn_PortChecks.BackColor = globalVariables.themeColor;
                btnCreateReport.BackColor = globalVariables.themeColor;
                btnDataStoreValidate.BackColor = globalVariables.themeColor;
                btnSetTheme.BackColor = globalVariables.themeColor;
                btn_HealthChecks.BackColor = globalVariables.themeColor;

                InitialForm iForm = new InitialForm();
                OpenChildForm(new InitialForm());
                //iForm.BackColor = globalVariables.themeColor; 

            }
        }

        private void panelLoadingIconBartimer_Tick(object sender, EventArgs e)
        {
            //panelLoadingIconBar.Location = new Point(panelLoadingIconBar.Location.X  + 100, panelLoadingIconBar.Location.Y);

            //if (panelLoadingIconBar.Location.X > 1500)
            //{
            //    panelLoadingIconBar.Location = new Point(0, 0);
            //}
        }

        private void btn_PortChecks_VisibleChanged(object sender, EventArgs e)
        {
            //if (btn_PortChecks.Visible == true)
            //{
            //    if (btn_PortChecks.Parent == null)
            //        return;

            //    var index = btn_PortChecks.Parent.Controls.GetChildIndex(btn_Tasks);
            //    if (index <= btn_PortChecks.Parent.Controls.Count)
            //        btn_PortChecks.Parent.Controls.SetChildIndex(btn_PortChecks, index);
            //}
            btn_PortChecks.Parent.Controls.SetChildIndex(btn_PortChecks, btn_PortChecks.Parent.Controls.GetChildIndex(btn_Tasks) - 1);
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

        private void btn_HealthChecks_VisibleChanged(object sender, EventArgs e)
        {
            //if (btn_HealthChecks.Visible == true)
            //{
            //    if (btn_HealthChecks.Parent == null)
            //        return;

            //    var index = btn_HealthChecks.Parent.Controls.GetChildIndex(btn_Tasks);

            //    if (btn_PortChecks.Visible)
            //    {
            //        index = btn_HealthChecks.Parent.Controls.GetChildIndex(btn_PortChecks);
            //        if (index <= btn_HealthChecks.Parent.Controls.Count)
            //            btn_HealthChecks.Parent.Controls.SetChildIndex(btn_HealthChecks, index-1);
            //    }
            //    else
            //    {
            //        if (index <= btn_HealthChecks.Parent.Controls.Count)
            //            btn_HealthChecks.Parent.Controls.SetChildIndex(btn_HealthChecks, index - 1);
            //    }


            //}
            btn_HealthChecks.Parent.Controls.SetChildIndex(btn_HealthChecks, btn_HealthChecks.Parent.Controls.GetChildIndex(btn_PortChecks) - 1);
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

        private void btnDataStoreValidate_VisibleChanged(object sender, EventArgs e)
        {
            //if (btnDataStoreValidate.Visible == true)
            //{
            //    if (btnDataStoreValidate.Parent == null)
            //        return;

            //    var index = btnDataStoreValidate.Parent.Controls.GetChildIndex(btn_Tasks);

            //    if (btn_HealthChecks.Visible)
            //    {
            //        index = btnDataStoreValidate.Parent.Controls.GetChildIndex(btn_HealthChecks);
            //        if (index <= btnDataStoreValidate.Parent.Controls.Count)
            //            btnDataStoreValidate.Parent.Controls.SetChildIndex(btnDataStoreValidate, index - 1);
            //    }
            //    else
            //    {
            //        if (index <= btnDataStoreValidate.Parent.Controls.Count)
            //            btnDataStoreValidate.Parent.Controls.SetChildIndex(btnDataStoreValidate, index - 1);
            //    }
            //}
            if (btn_HealthChecks.Parent.Controls.GetChildIndex(btn_HealthChecks) > 0)
            {
                btnDataStoreValidate.Parent.Controls.SetChildIndex(btnDataStoreValidate, btnDataStoreValidate.Parent.Controls.GetChildIndex(btn_HealthChecks) - 1); 
            }
            else
            {
                btnDataStoreValidate.Parent.Controls.SetChildIndex(btnDataStoreValidate, btnDataStoreValidate.Parent.Controls.GetChildIndex(btn_HealthChecks));
            }
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

        private void btn_Publish_VisibleChanged(object sender, EventArgs e)
        {
            //if (btn_Publish.Visible == true)
            //{
            //    if (btn_Publish.Parent == null)
            //        return;

            //    var index = btn_Publish.Parent.Controls.GetChildIndex(btn_Tasks);


            //    if (btnDataStoreValidate.Visible)
            //    {
            //        index = btn_Publish.Parent.Controls.GetChildIndex(btnDataStoreValidate);
            //        if (index <= btn_Publish.Parent.Controls.Count)
            //            btn_Publish.Parent.Controls.SetChildIndex(btn_Publish, index - 1);
            //    }
            //    else
            //    {
            //        if (index <= btn_Publish.Parent.Controls.Count)
            //            btn_Publish.Parent.Controls.SetChildIndex(btn_Publish, index - 1);
            //    }

            //}
            if (btn_Publish.Parent.Controls.GetChildIndex(btnDataStoreValidate) > 0)
            {
                btn_Publish.Parent.Controls.SetChildIndex(btn_Publish, btn_Publish.Parent.Controls.GetChildIndex(btnDataStoreValidate) - 1);
            }
            else
            {
                btn_Publish.Parent.Controls.SetChildIndex(btn_Publish, btn_Publish.Parent.Controls.GetChildIndex(btnDataStoreValidate));
            }
            
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

        private void btn_Services_VisibleChanged(object sender, EventArgs e)
        {
            //if (btn_Services.Visible == true)
            //{
            //    if (btn_Services.Parent == null)
            //        return;

            //    var index = btn_Services.Parent.Controls.GetChildIndex(btn_Tasks);

            //    if (btn_Publish.Visible)
            //    {
            //        index = btn_Services.Parent.Controls.GetChildIndex(btn_Publish);
            //        if (index <= btn_Services.Parent.Controls.Count)
            //            btn_Services.Parent.Controls.SetChildIndex(btn_Services, index - 1);
            //    }
            //    else
            //    {
            //        if (index <= btn_Services.Parent.Controls.Count)
            //            btn_Services.Parent.Controls.SetChildIndex(btn_Services, index - 1);
            //    }
            //}
            if (btn_Services.Parent.Controls.GetChildIndex(btn_Publish) > 0)
            {
                btn_Services.Parent.Controls.SetChildIndex(btn_Services, btn_Services.Parent.Controls.GetChildIndex(btn_Publish) - 1);
            }
            else
            {
                btn_Services.Parent.Controls.SetChildIndex(btn_Services, btn_Services.Parent.Controls.GetChildIndex(btn_Publish));
            }
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

        private void btnCreateReport_VisibleChanged(object sender, EventArgs e)
        {
            //if (btnCreateReport.Visible == true)
            //{
            //    if (btnCreateReport.Parent == null)
            //        return;

            //    var index = btnCreateReport.Parent.Controls.GetChildIndex(btn_Tasks);
            //    if (btn_Services.Visible)
            //    {
            //        index = btnCreateReport.Parent.Controls.GetChildIndex(btn_Services);
            //        if (index <= btnCreateReport.Parent.Controls.Count)
            //            btnCreateReport.Parent.Controls.SetChildIndex(btnCreateReport, index - 1);
            //    }
            //    else
            //    {
            //        if (index <= btnCreateReport.Parent.Controls.Count)
            //            btnCreateReport.Parent.Controls.SetChildIndex(btnCreateReport, index - 1);
            //    }

            //}
            if (btnCreateReport.Parent.Controls.GetChildIndex(btn_Services) > 0)
            {
                btnCreateReport.Parent.Controls.SetChildIndex(btnCreateReport, btnCreateReport.Parent.Controls.GetChildIndex(btn_Services) - 1);
            }
            else
            {
                btnCreateReport.Parent.Controls.SetChildIndex(btnCreateReport, btnCreateReport.Parent.Controls.GetChildIndex(btn_Services));
            }
            btn_Tasks.Parent.Controls.SetChildIndex(btn_Tasks, btn_Tasks.Parent.Controls.GetChildIndex(btn_Home) - 1);
        }

       
    }
}
