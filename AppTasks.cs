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
    public partial class AppTasks : Form
    {
        public AppTasks()
        {
            InitializeComponent();
        }

        private void btn_agsServer_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.stepsCounter = "";
                //globalVariables.globalForm.btn_HealthChecks.PerformClick();
                globalVariables.globalForm.btn_PortChecks.PerformClick();
            }
            catch (Exception ex)
            {
                string errMsg = "StepsConfirmationForm.cs - btn_agsServer_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }
    }
}
