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
            //webBrowser1.Url = new Uri(FederatedEnv.selectedSserviceURL);
            webBrowser1.Navigate(FederatedEnv.selectedSserviceURL);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1024, 728);
            webBrowser1.DrawToBitmap(bmp, new Rectangle(webBrowser1.Location.X, webBrowser1.Location.Y, webBrowser1.Width, webBrowser1.Height));
            bmp.Save("D:/temp/myfileButton2.jpg");
        }
    }
}
