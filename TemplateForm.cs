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
    public partial class TemplateForm : Form
    {
        public TemplateForm()
        {
            InitializeComponent();
            globalVariables.iconFlag = "HOME";
            globalVariables._move = new MakeMovable(this);
            globalVariables._move.SetMovable(rightPanel);
            globalVariables._move.SetMovable(topPanel);
            globalVariables._move.SetMovable(leftPanel);
            globalVariables._move.SetMovable(bottomPanel);            
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            //current step panel to show the current step
            panelCurrentStep.Height = btn_Home.Height;
            panelCurrentStep.Top = btn_Home.Top;
            if (globalVariables.iconFlag == "HOME")
            {
                //current step panel to show the current step
                panelCurrentStep.Height = btn_Home.Height;
                panelCurrentStep.Top = btn_Home.Top;
                InitialForm frm = new InitialForm();
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Visible = true;
                formContainer.Controls.Add(frm);
                btn_Tasks.Enabled = true;
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            //set the icon flag for changing the form in the container in the template
            globalVariables.iconFlag = "HOME";

            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
            }
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            timer1.Enabled = true;

            //current step panel to show the current step
            panelCurrentStep.Height = btn_Home.Height;
            panelCurrentStep.Top = btn_Home.Top;
            formContainer.Controls.RemoveAt(0);
            InitialForm frm = new InitialForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            formContainer.Controls.Add(frm);
            btn_Tasks.Enabled = true;
        }

        private void btn_Tasks_Click(object sender, EventArgs e)
        {
            //set the icon flag for changing the form in the container in the template
            globalVariables.iconFlag = "TASKS";

            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
            }
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            timer1.Enabled = true;

            //current step panel to show the current step
            panelCurrentStep.Height = btn_Tasks.Height;
            panelCurrentStep.Top = btn_Tasks.Top;
            btn_Configuration.Enabled = true;
        }

        private void btn_Configuration_Click(object sender, EventArgs e)
        {
            //set the icon flag for changing the form in the container in the template
            globalVariables.iconFlag = "CONFIG";

            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
            }
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            timer1.Enabled = true;

            //current step panel to show the current step
            panelCurrentStep.Height = btn_Configuration.Height;
            panelCurrentStep.Top = btn_Configuration.Top;
            btn_HealthChecks.Enabled = true;
        }

        private void btn_HealthChecks_Click(object sender, EventArgs e)
        {
            //set the icon flag for changing the form in the container in the template
            globalVariables.iconFlag = "HEALTH";

            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
            }
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            timer1.Enabled = true;

            //current step panel to show the current step
            panelCurrentStep.Height = btn_HealthChecks.Height;
            panelCurrentStep.Top = btn_HealthChecks.Top;
            btn_Publish.Enabled = true;
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            //set the icon flag for changing the form in the container in the template
            globalVariables.iconFlag = "PUBLISH";

            if (!progressBar1.Visible)
            {
                progressBar1.Visible = true;
            }
            if (progressBar1.Value != 0)
            {
                progressBar1.Value = 0;
            }
            timer1.Enabled = true;

            //current step panel to show the current step
            panelCurrentStep.Height = btn_Publish.Height;
            panelCurrentStep.Top = btn_Publish.Top;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value > 99)
            {

                timer1.Enabled = false;
                progressBar1.Visible = false;
                if (globalVariables.iconFlag == "HOME")
                {
                    //current step panel to show the current step
                    panelCurrentStep.Height = btn_Home.Height;
                    panelCurrentStep.Top = btn_Home.Top;
                    formContainer.Controls.RemoveAt(0);
                    InitialForm frm = new InitialForm();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Visible = true;
                    formContainer.Controls.Add(frm);
                }
                else if (globalVariables.iconFlag == "TASKS")
                {
                    //current step panel to show the current step
                    panelCurrentStep.Height = btn_Tasks.Height;
                    panelCurrentStep.Top = btn_Tasks.Top;
                    formContainer.Controls.RemoveAt(0);
                    StepsConfirmationForm frm = new StepsConfirmationForm();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Visible = true;
                    formContainer.Controls.Add(frm);
                }
                else if (globalVariables.iconFlag == "CONFIG")
                {
                    //current step panel to show the current step
                    panelCurrentStep.Height = btn_Configuration.Height;
                    panelCurrentStep.Top = btn_Configuration.Top;
                    formContainer.Controls.RemoveAt(0);
                    FederatedEnv frm = new FederatedEnv();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Visible = true;
                    formContainer.Controls.Add(frm);
                }
                else if (globalVariables.iconFlag == "HEALTH")
                {
                    //current step panel to show the current step
                    panelCurrentStep.Height = btn_HealthChecks.Height;
                    panelCurrentStep.Top = btn_HealthChecks.Top;
                    formContainer.Controls.RemoveAt(0);
                    ScreenCaptureForm frm = new ScreenCaptureForm();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Visible = true;
                    formContainer.Controls.Add(frm);
                }
                else if (globalVariables.iconFlag == "PUBLISH")
                {
                    //current step panel to show the current step
                    panelCurrentStep.Height = btn_Publish.Height;
                    panelCurrentStep.Top = btn_Publish.Top;
                    formContainer.Controls.RemoveAt(0);
                    InitialForm frm = new InitialForm();
                    frm.TopLevel = false;
                    frm.FormBorderStyle = FormBorderStyle.None;
                    frm.Dock = DockStyle.Fill;
                    frm.Visible = true;
                    formContainer.Controls.Add(frm);
                }

            }
        }
    }
}
