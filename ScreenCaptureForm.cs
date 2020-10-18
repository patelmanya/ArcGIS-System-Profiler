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
        Bitmap serverBMP = new Bitmap(1024, 728);
        Bitmap portalBMP = new Bitmap(1024, 728);

        public ScreenCaptureForm()
        {
            InitializeComponent();
            labelStep.Text = labelStep.Text + globalVariables.stepsCounter;
            webBrowser1.Navigate(globalVariables.portalCheckURL);
            //btnPortalCheck.Visible = false;
            btnNextStep.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(1024, 728);
            //img1 = new Bitmap(imgName[0]);
            bmp = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            //webBrowser1.DrawToBitmap(bmp, new Rectangle(webBrowser1.Location.X, webBrowser1.Location.Y, webBrowser1.Width, webBrowser1.Height));
            bmp.Save("C:/temp/myfileButton2.jpg");
            string imagePath = "C:/temp/myfileButton2.jpg";


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

            //Range docRange = docobj.Range();
            Range docRange = docobj.Bookmarks.get_Item(ref objEndOfDocument).Range;
            // Create an InlineShape in the InlineShapes collection where the picture should be added later
            // It is used to get automatically scaled sizes.
            InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(imagePath);
            float scaledWidth = autoScaledInlineShape.Width;
            float scaledHeight = autoScaledInlineShape.Height;
            autoScaledInlineShape.Delete();

            // Create a new Shape and fill it with the picture
            Shape newShape = docobj.Shapes.AddShape(1, 0, 0, scaledWidth, scaledHeight);
            newShape.Fill.UserPicture(imagePath);

            // Convert the Shape to an InlineShape and optional disable Border
            InlineShape finalInlineShape = newShape.ConvertToInlineShape();
            //finalInlineShape.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;

            // Cut the range of the InlineShape to clipboard
            finalInlineShape.Range.Cut();

            // And paste it to the target Range
            docRange.Paste();
            // docobj.SaveAs2(@"c:\temp\test.docx");
            //appobj.Quit();

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

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> Images = new List<string>();
            Images.Add(@"C:\temp\images\1.jpg");
            Images.Add(@"C:\temp\images\2.jpg");
            Images.Add(@"C:\temp\images\3.jpg");

            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            Document wordDoc = wordApp.Documents.Add();
            Range docRange = wordDoc.Range();

            float mHeight = 0;
            for (int i = 0; i <= Images.Count - 1; i++)
            {
                // Create an InlineShape in the InlineShapes collection where the picture should be added later
                // It is used to get automatically scaled sizes.
                InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(Images[i]);
                float scaledWidth = autoScaledInlineShape.Width;
                float scaledHeight = autoScaledInlineShape.Height;
                mHeight += scaledHeight;
                autoScaledInlineShape.Delete();

                // Create a new Shape and fill it with the picture
                Shape newShape = wordDoc.Shapes.AddShape(1, 0, 0, scaledWidth, mHeight);
                newShape.Fill.UserPicture(Images[i]);

                // Convert the Shape to an InlineShape and optional disable Border
                InlineShape finalInlineShape = newShape.ConvertToInlineShape();
                //finalInlineShape.Line.Visible = Microsoft.Office.Core.MsoTriState.msoFalse;

                // Cut the range of the InlineShape to clipboard
                finalInlineShape.Range.Cut();

                // And paste it to the target Range
                docRange.Paste();
                //object oPageBreak = Microsoft.Office.Interop.Word.WdBreakType.wdPageBreak;
                //para.Range.InsertParagraphAfter();
                //docRange.InsertBreak(ref oPageBreak);
            }
        }

        private void btnPortalCheck_Click(object sender, EventArgs e)
        {
            webBrowser1.Visible = true;
            webBrowser1.Navigate(globalVariables.portalCheckURL);
            btnServerCheck.Enabled = true;

        }

        private void btnServerCheck_Click(object sender, EventArgs e)
        {
            portalBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            globalVariables.ImageList.Add("C:/temp/myPortalCheck_" + fileName + ".jpg");
            portalBMP.Save("C:/temp/myPortalCheck_" + fileName + ".jpg");

            webBrowser1.Navigate(globalVariables.ArcGISServerCheckURL);
            btnNextStep.Enabled = true;

        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            serverBMP = new Bitmap(Utilities.CaptureWindow(webBrowser1.Handle));
            string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
            globalVariables.ImageList.Add("C:/temp/myServerCheck_" + fileName + ".jpg");
            serverBMP.Save("C:/temp/myServerCheck_" + fileName + ".jpg");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://minint-4ja7213.services.esriaustralia.com.au/arcgis/manager/site.html");
        }
    }
}
