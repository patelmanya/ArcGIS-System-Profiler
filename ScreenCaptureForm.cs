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
    public partial class ScreenCaptureForm : Form
    {
        public ScreenCaptureForm()
        {
            InitializeComponent();
            labelStep.Text = labelStep.Text + globalVariables.stepsCounter;
            webBrowser1.Navigate(globalVariables.selectedSserviceURL);
            button3.Visible = false;
            button2.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(globalVariables.selectedSserviceURL);
            button3.Visible = false;
            button2.Enabled = true;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1024, 728);
            //img1 = new Bitmap(imgName[0]);
            bmp = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            //webBrowser1.DrawToBitmap(bmp, new Rectangle(webBrowser1.Location.X, webBrowser1.Location.Y, webBrowser1.Width, webBrowser1.Height));
            bmp.Save("C:/temp/myfileButton2.jpg");
        }
    }
}
