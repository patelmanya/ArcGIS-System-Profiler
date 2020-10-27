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
                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Report generation started.\r\n";
                servicesReportFilesGenerator();
                //access the global variables and generate report and create word document and delete all files created by the program
                //such as 
                //health check images
                //port checks
                //services report HTML files
                //int counter = 0;
                //for (counter = 0; counter < 10; counter++)
                //{
                //    txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + RandomString(counter) + "\r\n";
                //}

                Microsoft.Office.Interop.Word.Table tbl;
                Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
                wordApp.Visible = false;
                Document wordDoc = wordApp.Documents.Add(globalVariables.reportTemplateFileName);

                //ArcGIS Portal Health Check
                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Portal Health Check screens & status\r\n";
                tbl = findTable(wordApp.ActiveDocument, "ArcGIS Portal Health Check");
                Range docRange = tbl.Cell(1, 1).Range;
                InlineShape autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[0]);

                //ArcGIS Server Health Check
                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Server Health Check screens & status\r\n";
                tbl = findTable(wordApp.ActiveDocument, "ArcGIS Server Health Check");
                docRange = tbl.Cell(1, 1).Range;
                autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[1]);

                //add the file object for the selected services and generate report
                //ArcGIS Server Health Check
                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Services Reports & status\r\n";
                tbl = findTable(wordApp.ActiveDocument, "ArcGIS Services Report");
                docRange = tbl.Cell(1, 1).Range;
                
                if (globalVariables.generateReportListDoc.Count > 0)
                {
                    var loopcounter = 0;
                    foreach (string objArr in globalVariables.generateReportListDoc)
                    {
                        docRange.InsertFile(objArr);
                        loopcounter = loopcounter + 1;
                        docRange = tbl.Cell(loopcounter, 1).Range;
                    }

                }

                tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                Marshal.ReleaseComObject(tbl); 

                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Writing to report complete\r\n";

                string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                wordDoc.SaveAs2(@"C:\temp\GeneratedReport_" + fileName + ".docx");

                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Report generation completed.\r\n";
                txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Report located at: C:\\temp\\GeneratedReport_" + fileName + ".docx\r\n";

                object missing = Type.Missing;
                object saveChanges = WdSaveOptions.wdSaveChanges;
                wordDoc.Close(saveChanges, missing, missing);
                 
                Marshal.ReleaseComObject(docRange);
                Marshal.ReleaseComObject(wordDoc);

                for (int i = 0; i < globalVariables.ImageList.Count; i++)
                {
                    if (File.Exists(globalVariables.ImageList[i]))
                    {
                        File.Delete(globalVariables.ImageList[i]);
                    }
                }

                //delete the file if it exists
                if (globalVariables.generateReportListDoc.Count > 0)
                {
                    foreach (string objArr in globalVariables.generateReportListDoc)
                    {
                        //delete the file if it exists
                        if (File.Exists(objArr))
                        {
                            File.Delete(objArr);
                        }
                    }

                }

                globalVariables.globalForm.loadingIconPic.Visible = false;
              
                MessageBox.Show("Report generation completed. Thank you for using the application!");
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        //private void servicesReportFilesGenerator(Microsoft.Office.Interop.Word.Document rdoc, Range docRangeLoc, Microsoft.Office.Interop.Word.Table rtbl)
        private void servicesReportFilesGenerator()
        {
            try
            {
                globalVariables.generateReportListDoc.Clear();
                if (globalVariables.generateReportList.Count > 0)
                {
                    foreach (string objArr in globalVariables.generateReportList)
                    {

                        object objMissing = System.Reflection.Missing.Value;
                        object objEndOfDocument = "\\endofdoc";
                        Microsoft.Office.Interop.Word._Application appobj;
                        appobj = new Microsoft.Office.Interop.Word.Application();
                        appobj.Visible = false;
                        Document doc = appobj.Documents.Add();
                        Range rng = appobj.ActiveDocument.Range(0, 0);
                        rng.Text = "";

                        object missing = Type.Missing;
                        ContentControl contentControl = doc.ContentControls.Add(WdContentControlType.wdContentControlRichText, ref missing);
                        contentControl.Title = "";
                        contentControl.Range.InsertFile(objArr, ref missing, ref missing, ref missing, ref missing);
                        string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                        doc.SaveAs2(@"C:\temp\GeneratedServicesReport_" + fileName + ".docx");
                        globalVariables.generateReportListDoc.Add("C:\\temp\\GeneratedServicesReport_" + fileName + ".docx");
                        
                        object saveChanges = WdSaveOptions.wdSaveChanges;
                        doc.Close(saveChanges, missing, missing);
                        Marshal.ReleaseComObject(doc);
                        Marshal.ReleaseComObject(appobj);

                        //delete the file if it exists
                        if (File.Exists(objArr))
                        {
                            File.Delete(objArr);
                        }
                    }
                }
                if (globalVariables.generateReportListDoc.Count > 0)
                {
                    //foreach (string objArr in globalVariables.generateReportListDoc)
                    //{
                    //    object missing = Type.Missing;

                    //    docRangeLoc.InsertFile(objArr, ref missing, ref missing, ref missing, ref missing);
                    //}

                }

            }
            catch (Exception ex)
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
