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
    public partial class StepsConfirmationForm : Form
    {


        public StepsConfirmationForm()
        {
            try
            {
                InitializeComponent();
                panel1.BackColor = globalVariables.themeColor;
                panel2.BackColor = globalVariables.themeColor;
                panel3.BackColor = globalVariables.themeColor;
                checkedListBox1.BackColor = globalVariables.themeColor;

                int checkedItems = checkedListBox1.CheckedItems.Count;
                checkedListBox1.Items.Add("Portal System Health Check", CheckState.Checked);
                checkedListBox1.Items.Add("ArcGIS Server Health Check", CheckState.Checked);
                checkedListBox1.Items.Add("Validate ArcGIS Data Stores", CheckState.Checked);
                checkedListBox1.Items.Add("Validate Federation", CheckState.Checked);
                checkedListBox1.Items.Add("ArcGIS Server services user selected", CheckState.Checked);
                checkedListBox1.Items.Add("Publishing Map Service", CheckState.Checked);
                checkedListBox1.Items.Add("Publishing Geo Processing Service", CheckState.Checked);
                checkedListBox1.Items.Add("Publishing Cached Map Service", CheckState.Checked);
                checkedListBox1.Items.Add("Generating Web Map in ArcGIS Enterprise", CheckState.Checked);
                checkedListBox1.Items.Add("Web Application Creation", CheckState.Checked);
                checkedListBox1.Items.Add("Hosted Layers", CheckState.Checked);
                checkedListBox1.Items.Add("External access (Manual step)", CheckState.Checked);
                checkedListBox1.Items.Add("Dashboard (Manual step)", CheckState.Checked);
                checkedListBox1.Items.Add("Analysis tools (Manual step)", CheckState.Checked);
                checkedListBox1.Items.Add("Security check - ArcGIS Server secured services", CheckState.Checked);
                checkedListBox1.Items.Add("Security check - Portal security", CheckState.Checked);
                checkedListBox1.Items.Add("Security check - External access", CheckState.Checked);
                checkedListBox1.Items.Add("Security check - AD Authentication", CheckState.Checked);
                checkedListBox1.Items.Add("Enterprise Geodatabase - Database connection", CheckState.Checked);
                checkedListBox1.Items.Add("License Management (Manual step) - ArcGIS Pro", CheckState.Checked);
                checkedListBox1.Items.Add("License Management (Manual step) - ArcGIS Desktop (Borrow/Return license)", CheckState.Checked);
            }
            catch (Exception ex)
            {
                string errMsg = "StepsConfirmationForm.cs - StepsConfirmationForm InitializeComponent: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
            }
        }


        private void btn_agsServer_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.stepsCounter = checkedListBox1.CheckedIndices.Count.ToString();
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
