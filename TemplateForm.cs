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
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value > 99)
            {
                
                timer1.Enabled = false;
                progressBar1.Visible = false;
                //PortCheckForm pCF = new PortCheckForm();
                //pCF.ShowDialog();

            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
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
            InitialForm frm = new InitialForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Visible = true;
            formContainer.Controls.Add(frm);
        }

        private void btn_Tasks_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_Configuration_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_HealthChecks_Click(object sender, EventArgs e)
        {
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
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
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
    }
}
