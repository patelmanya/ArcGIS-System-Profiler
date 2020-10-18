using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

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

            object objMissing = System.Reflection.Missing.Value;
            object objEndOfDocument = "\\endofdoc";
            Microsoft.Office.Interop.Word._Application appobj;
            Microsoft.Office.Interop.Word._Document docobj;
            appobj = new Microsoft.Office.Interop.Word.Application();
            appobj.Visible = true;
            docobj = appobj.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Word.Table tableObj;
            Microsoft.Office.Interop.Word.Range RangeofWord = docobj.Bookmarks.get_Item(ref objEndOfDocument).Range;
            tableObj = docobj.Tables.Add(RangeofWord, 3, 4, ref objMissing, ref objMissing);
            tableObj.Range.ParagraphFormat.SpaceAfter = 8;
            string str;
            for (i = 0; i <= 3; i++)
                for (j = 0; j <= 4; j++)
                {
                    str = "Row" + i + "Column" + j;
                    tableObj.Cell(i, j).Range.Text = str;
                }


            tableObj.Rows[1].Range.Font.Bold = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            object objMissing = System.Reflection.Missing.Value;
            object objEndOfDocument = "\\endofdoc";
            Microsoft.Office.Interop.Word._Application appobj;
            Microsoft.Office.Interop.Word._Document docobj;
            appobj = new Microsoft.Office.Interop.Word.Application();
            appobj.Visible = true;
            docobj = appobj.Documents.Add(ref objMissing, ref objMissing, ref objMissing, ref objMissing);
            int i = 0;
            int j = 0;
            Microsoft.Office.Interop.Word.Table tableObj;
            Microsoft.Office.Interop.Word.Range RangeofWord = docobj.Bookmarks.get_Item(ref objEndOfDocument).Range;
            tableObj = docobj.Tables.Add(RangeofWord, 3, 4, ref objMissing, ref objMissing);
            tableObj.Range.ParagraphFormat.SpaceAfter = 8;
            string str;
            for (i = 0; i <= 3; i++)
                for (j = 0; j <= 4; j++)
                {
                    str = "Row" + i + "Column" + j;
                    tableObj.Cell(i, j).Range.Text = str;
                }


            tableObj.Rows[1].Range.Font.Bold = 1;
            //this.Close();
        }
    }
}
