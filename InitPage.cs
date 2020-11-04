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
    public partial class InitPage : Form
    {
        public InitPage()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            initpageTimer.Enabled = true;
            initPageprogressBar.Value = 0;
        }

        private void initpageTimer_Tick(object sender, EventArgs e)
        {  
            initPageprogressBar.Value = initPageprogressBar.Value + 5;
            if (initPageprogressBar.Value > 99)
            {
                initpageTimer.Enabled = false;
                this.Close();
            }
        }
    }
}
