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
    public partial class TasksInclude : Form
    {
        public TasksInclude()
        {
            InitializeComponent();
            if (globalVariables.portsTaskIncluded)
            {
                toggleButtonPortsChecks.ToggleState = ToggleButton.ToggleButtonState.ON;
            }
            if (globalVariables.HealthChecksTaskIncluded)
            {
                toggleButtonHealthChecks.ToggleState = ToggleButton.ToggleButtonState.ON;
            }
            if (globalVariables.DataStoreValidateTaskIncluded)
            {
                toggleButtonValidateDS.ToggleState = ToggleButton.ToggleButtonState.ON;
            }
            if (globalVariables.PublishTaskIncluded)
            {
                toggleButtonPublishService.ToggleState = ToggleButton.ToggleButtonState.ON;
            }
            if (globalVariables.ServicesTaskIncluded)
            {
                toggleButtonAGSServReport.ToggleState = ToggleButton.ToggleButtonState.ON;
            }
        }

        private void btn_agsServer_Click(object sender, EventArgs e)
        {
            try
            {

                if (globalVariables.portsTaskIncluded == false && globalVariables.HealthChecksTaskIncluded == false && globalVariables.DataStoreValidateTaskIncluded == false && globalVariables.PublishTaskIncluded == false && globalVariables.ServicesTaskIncluded == false)
                {
                    MessageBox.Show("No tasks have been selected to generate the report.");
                    //return;
                }
                else
                {
                    if (globalVariables.portsTaskIncluded)
                    {
                        globalVariables.stepsCounter = ""; 
                        globalVariables.globalForm.btn_PortChecks.PerformClick();
                    }
                    else if (globalVariables.HealthChecksTaskIncluded)
                    {
                        globalVariables.globalForm.btn_HealthChecks.PerformClick();
                    }
                    else if (globalVariables.DataStoreValidateTaskIncluded)
                    {
                        globalVariables.globalForm.btnDataStoreValidate.PerformClick();
                    }
                    else if (globalVariables.PublishTaskIncluded)
                    {
                        globalVariables.globalForm.btn_Publish.PerformClick();
                    }
                    else if (globalVariables.ServicesTaskIncluded)
                    {
                        globalVariables.globalForm.btn_Services.PerformClick();
                    }
                    
                }

            }
            catch (Exception ex)
            {
                string errMsg = "TasksInclude.cs - btn_agsServer_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }

    }
}
