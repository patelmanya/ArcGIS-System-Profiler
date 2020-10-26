using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class GenerateReport : Form
    {
        public GenerateReport()
        {
            InitializeComponent();
        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                globalVariables.globalForm.loadingIconPic.Visible = true;
                //access the global variables and generate report and create word document and delete all files created by the program
                //such as 
                //health check images
                //port checks
                //services report HTML files
                int counter = 0;
                for (counter = 0; counter < 10; counter++)
                {
                    txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + RandomString(counter) + "\r\n";
                }

                Microsoft.Office.Interop.Word.Table tbl;
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false;
                Document wordDoc = wordApp.Documents.Add(@"C:\temp\Report_TemplateNEW2.dotx");
                
                //ArcGIS Portal Health Check
                tbl = findTable(wordApp.ActiveDocument, "ArcGIS Portal Health Check");
                Range docRange = tbl.Cell(1, 1).Range; 
                InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[0]);

                //ArcGIS Server Health Check
                tbl = findTable(wordApp.ActiveDocument, "ArcGIS Server Health Check");
                docRange = tbl.Cell(1, 1).Range;
                autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[1]);


                tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                Marshal.ReleaseComObject(tbl);
                string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                wordDoc.SaveAs2(@"C:\temp\GeneratedReport_"  + fileName + ".docx");

                for (int i = 0; i < globalVariables.ImageList.Count; i++)
                {
                    if (File.Exists(globalVariables.ImageList[i]))
                    {
                        File.Delete(globalVariables.ImageList[i]);
                    } 
                }
                globalVariables.globalForm.loadingIconPic.Visible = false;
                MessageBox.Show("Report generation completed. Thank you for using the application!");
            }
            catch (Exception)
            {

                throw;
            }
        }

        private Microsoft.Office.Interop.Word.Table findTable(Microsoft.Office.Interop.Word.Document doc, string searchText)
        {
            if (doc.Tables.Count > 0)
            {
                int iCount = 1;
                Microsoft.Office.Interop.Word.Table tbl;
                do
                {
                    tbl = (Microsoft.Office.Interop.Word.Table)doc.Tables[iCount];
                    //Select first cell and check it's value
                    string header = tbl.Cell(1, 1).Range.Text;
                    if (header.Contains(searchText))
                    {
                        return tbl;
                    }
                    iCount++;
                    Marshal.ReleaseComObject(tbl);
                } while (iCount < doc.Tables.Count + 1);
            }
            return null;
        }

        private Microsoft.Office.Interop.Word.Table getTableByBookmarkName(Microsoft.Office.Interop.Word.Document doc, string bookmarkName)
        {
            Microsoft.Office.Interop.Word.Table tbl = doc.Bookmarks[bookmarkName].Range.Tables[1];
            if (tbl != null)
                return tbl;
            else
                return null;
        }

        private static Random random = new Random((int)DateTime.Now.Ticks);//thanks to McAden
        private string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
    }
}
