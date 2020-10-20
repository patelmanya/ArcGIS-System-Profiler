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
            globalVariables._move = new MakeMovable(this);
            globalVariables._move.SetMovable(rightPanel);
            globalVariables._move.SetMovable(topPanel);
            globalVariables._move.SetMovable(leftPanel);
            globalVariables._move.SetMovable(bottomPanel);
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Create the ToolTip and associate with the Form container.
            ToolTip toolTip1 = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip1.AutoPopDelay = 5000;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 500;
            // Force the ToolTip text to be displayed whether or not the form is active.
            toolTip1.ShowAlways = true;

            // Set up the ToolTip text for the Button and Checkbox.
            toolTip1.SetToolTip(this.btn_agsEnt, "My button1");
            toolTip1.SetToolTip(this.checkBox1, "My checkBox1");
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
           
            globalVariables.agsEntUserName = txtPortalUserName.Text;
            globalVariables.agsEntUserPassword = txtPortalPassword.Text;
            agsEnterpriseUserName = txtPortalUserName.Text;
            agsEnterprisePassword = txtPortalPassword.Text;
            timer1.Enabled = true;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = progressBar1.Value + 10;
            if (progressBar1.Value>99)
            {
                this.Hide();
                //StepsConfirmationForm sCnFm = new StepsConfirmationForm();
                //sCnFm.Show();
                timer1.Enabled = false;
                PortCheckForm pCF = new PortCheckForm();
                pCF.ShowDialog();
                //Page2 pg2 = new Page2();
                //pg2.ShowDialog();
                
            }
        }
    }
}
