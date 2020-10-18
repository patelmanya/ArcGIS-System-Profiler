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
            InitializeComponent();
            textBox2.Text = "";
            textBox2.PasswordChar = '*';
            //textBox4.Text = "";
            textBox4.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            agsEnterpriseUserName = textBox3.Text;
            agsEnterprisePassword = textBox4.Text;
            StepsConfirmationForm sCnFm = new StepsConfirmationForm();
            sCnFm.Show();
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
    }
}
