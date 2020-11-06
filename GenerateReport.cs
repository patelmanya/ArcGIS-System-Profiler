using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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
            btnOpenReport.Visible = false;
            panel1.BackColor = globalVariables.themeColor;
            panel2.BackColor = globalVariables.themeColor;
            txtBx_GenRepStatus.BackColor = globalVariables.themeColor;

        }

        private void btn_GenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                btnOpenReport.Visible = false;
                if (File.Exists(globalVariables.generatedFinalReportName))
                {
                    File.Delete(globalVariables.generatedFinalReportName);
                    globalVariables.generatedFinalReportName = "";
                    txtBx_GenRepStatus.Text = "";
                }

                globalVariables.globalForm.loadingIconPic.Visible = true;
                txtBx_GenRepStatus.AppendText("Report generation started.\r\n");
                //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Report generation started.\r\n";
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
                Range docRange;
                InlineShape autoScaledInlineShape;
                //ArcGIS Portal Health Check
                if (globalVariables.ImageList.Count > 0)
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Portal Health Check screens & status\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Portal Health Check screens & status\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Portal Health Check");
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                    if (tbl.Columns.Count == 1)
                    {
                        tbl.Columns.Add();
                        tbl.Columns.Add();
                        tbl.Columns.Add();
                        tbl.Columns.Add();
                    }
                    int i = 1;
                    //And a table header
                    tbl.Cell(i, 1).Range.Text = "Test Ref.";
                    tbl.Cell(i, 2).Range.Text = "Test Name";
                    tbl.Cell(i, 3).Range.Text = "Test Description";
                    tbl.Cell(i, 4).Range.Text = "Pass Criteria";
                    tbl.Cell(i, 5).Range.Text = "Result";
                    tbl.Rows.Add();
                    i = 2;
                    tbl.Cell(i, 1).Range.Text = "4.1.1.1";
                    tbl.Cell(i, 2).Range.Text = "Portal Health Check";
                    tbl.Cell(i, 3).Range.Text = "Navigate to the Portal Health Check URL as per the instructions here";
                    tbl.Cell(i, 4).Range.Text = "JSON Response \r\n { \"status\": \"success\"}";
                    tbl.Cell(i, 5).Range.Text = "Pass";
                    tbl.Rows.Add();
                    i = 3;
                    tbl.Rows[i].Cells[1].Merge(tbl.Rows[i].Cells[2]); //merging Col 1 & Col 2
                    tbl.Rows[i].Cells[1].Merge(tbl.Rows[i].Cells[2]); // merging merged Col1, 2 & Col 3
                    tbl.Rows[i].Cells[1].Merge(tbl.Rows[i].Cells[2]); // merging merged Col1, 2, 3 & Col 4
                    tbl.Rows[i].Cells[1].Merge(tbl.Rows[i].Cells[2]); // merging merged Col1, 2, 3, 4 & Col 5
                    docRange = tbl.Cell(i, 1).Range;
                    autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[0]);
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                }

                //ArcGIS Server Health Check
                if (globalVariables.ImageList.Count > 1)
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Server Health Check screens & status\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Server Health Check screens & status\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Server Health Check");
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                    docRange = tbl.Cell(1, 1).Range;
                    autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.ImageList[1]); 
                }

                //ArcGIS Datastore Status
                if (globalVariables.DataStoreImageList.Count > 0)
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Datastore screens & status\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Datastore screens & status\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Datastore Status");
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                    docRange = tbl.Cell(1, 1).Range;
                    autoScaledInlineShape = docRange.InlineShapes.AddPicture(globalVariables.DataStoreImageList[0]);
                    
                }


                //ports checks

                //add only the closed one from the globalVariables.portsList
                if (globalVariables.portsList.Count > 0)
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Port status\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Port status\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Port Status List");
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                    if (tbl.Columns.Count == 1)
                    {
                        tbl.Columns.Add();
                        tbl.Columns.Add();
                        tbl.Columns.Add();
                    }
                    int i = 1;
                    //And a table header
                    tbl.Cell(i, 1).Range.Text = "Port Number";
                    tbl.Cell(i, 2).Range.Text = "Port Type";
                    tbl.Cell(i, 3).Range.Text = "Port Description";
                    tbl.Cell(i, 4).Range.Text = "Port Status";
                    var loopcounter = 2;
                    foreach (Dictionary<string, object> obj in globalVariables.portsList)
                    {

                        if (obj["description"].ToString().Contains("ArcGIS"))
                        {
                            tbl.Rows.Add();
                            tbl.Cell(loopcounter, 1).Range.Text = obj["portNo"].ToString();
                            tbl.Cell(loopcounter, 2).Range.Text = obj["protocol"].ToString();
                            tbl.Cell(loopcounter, 3).Range.Text = obj["description"].ToString();
                            tbl.Cell(loopcounter, 4).Range.Text = obj["status"].ToString();
                            loopcounter += 1;
                        }

                    }
                    
                }

                //add the file object for the selected services and generate report
                //ArcGIS Server Health Check
                if (globalVariables.generateReportListDoc.Count > 0)
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Services Reports & status\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Services Reports & status\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Services Report");

                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);

                    if (tbl.Columns.Count == 1)
                    {
                        //1 Column
                        tbl.Columns.Add();
                        tbl.Columns.Add();

                        //pretty basic logic...what happens if the table template had 2 columns?
                        //with my code...nothing...which would be a problem.
                        //it's a sample, so make of it what you wish.
                    }

                    int i = 1;
                    //And a table header

                    tbl.Cell(i, 1).Range.Text = "Report File";
                    tbl.Cell(i, 2).Range.Text = "Sr No.";
                    tbl.Cell(i, 3).Range.Text = "Service Name";

                    var fileSrNoCounter = 1;
                    if (globalVariables.generateReportListDoc.Count > 0)
                    {
                        var loopcounter = 2;
                        foreach (string objArr in globalVariables.generateReportListDoc)
                        {
                            tbl.Rows.Add();

                            string processingServiceName = "";
                            foreach (Dictionary<string, object> obj in globalVariables.generateReportListServiceName)
                            {
                                if (obj["reportFileName"].ToString() == objArr)
                                {
                                    processingServiceName = obj["serviceName"].ToString();
                                    break;
                                }
                            }
                            txtBx_GenRepStatus.AppendText("Appending Service report file as object: " + processingServiceName + "\r\n");
                            //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending Service report file as object: " + processingServiceName + "\r\n";
                            StringCollection pathsService = new StringCollection();
                            pathsService.Add(objArr);
                            Clipboard.SetFileDropList(pathsService);
                            if (Clipboard.GetDataObject() == null)
                            {
                                continue;
                            }
                            Icon ic = ArcGIS_System_Profiler.Properties.Resources.report;

                            tbl.Cell(loopcounter, 1).Range.PasteSpecial(Link: false, DisplayAsIcon: true, IconFileName: globalVariables.globalReportIcon, IconLabel: "Service Report");
                            //tbl.Cell(loopcounter, 1).Range.PasteSpecial(Link: false, DisplayAsIcon: true, IconFileName: @"C:\temp\images\IconData.ico", IconLabel: "Service Report");
                            tbl.Cell(loopcounter, 2).Range.Text = fileSrNoCounter.ToString();
                            fileSrNoCounter += 1;
                            tbl.Cell(loopcounter, 3).Range.Text = processingServiceName;
                            Clipboard.Clear();
                            loopcounter += 1;
                        }
                    }
                    
                }


                //ArcGIS Services Detailed Report
                if (globalVariables.agsServerServicesReportName != "")
                {
                    txtBx_GenRepStatus.AppendText("Appending ArcGIS Services Detailed Report\r\n");
                    //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Appending ArcGIS Services Detailed Report\r\n";
                    tbl = findTable(wordApp.ActiveDocument, "ArcGIS Services Detailed Report");
                    tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                    if (tbl.Columns.Count == 1)
                    {
                        //1 Column
                        tbl.Columns.Add();
                    }

                    int i = 1;
                    //And a table header
                    tbl.Cell(i, 1).Range.Text = "Report";
                    tbl.Cell(i, 2).Range.Text = "Name";


                    tbl.Rows.Add();
                    StringCollection paths = new StringCollection();
                    paths.Add(globalVariables.agsServerServicesReportName);
                    if (Clipboard.GetDataObject() != null)
                    {
                        Clipboard.SetFileDropList(paths);
                    }
                    
                    tbl.Cell(2, 1).Range.PasteSpecial(Link: false, DisplayAsIcon: true, IconFileName: globalVariables.globalReportIcon, IconLabel: "Service Report");
                    //tbl.Cell(2, 1).Range.PasteSpecial(Link: false, DisplayAsIcon: true, IconFileName: @"C:\temp\images\report.ico", IconLabel: "Service Report");
                    tbl.Cell(2, 2).Range.Text = "ArcGIS Server Services Report";
                    //tbl.Cell(1, 2).Range.PasteSpecial(Link: false, DisplayAsIcon: true, IconFileName: @"C:\temp\images\report.ico");
                    Clipboard.Clear();
                    
                }
                txtBx_GenRepStatus.AppendText("Writing to report complete\r\n");
                //txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Writing to report complete\r\n";

                string fileName = string.Format("{0:yyyy-MM-dd_HH-mm-ss-fff}", DateTime.Now);
                wordDoc.SaveAs2(globalVariables.globalFilePath + "\\GeneratedReport_" + fileName + ".docx");
                txtBx_GenRepStatus.AppendText("Report generation completed.\r\n");
                //txtBx_GenRepStatus.Text += "Report generation completed.\r\n";
                txtBx_GenRepStatus.AppendText("Report located at: " + globalVariables.globalFilePath + "\\GeneratedReport_" + fileName + ".docx\r\n");
                txtBx_GenRepStatus.SelectionStart = txtBx_GenRepStatus.TextLength;
                txtBx_GenRepStatus.ScrollToCaret();
                //txtBx_GenRepStatus.Text += "Report located at: " + globalVariables.globalFilePath + "\\GeneratedReport_" + fileName + ".docx\r\n";
                globalVariables.generatedFinalReportName = globalVariables.globalFilePath + "\\GeneratedReport_" + fileName + ".docx";
                btnOpenReport.Visible = true;
                object missing = Type.Missing;
                object saveChanges = WdSaveOptions.wdSaveChanges;
                wordDoc.Close(saveChanges, missing, missing);

                wordApp.Quit();
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(wordDoc);
                System.Runtime.InteropServices.Marshal.FinalReleaseComObject(wordApp);


                globalVariables.globalForm.loadingIconPic.Visible = false;

                // MessageBox.Show("Report generation completed. Thank you for using the application!");
            }
            catch (Exception ex)
            {
                string errMsg = "GenerateReport.cs - btn_GenerateReport_Click: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
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
                        doc.SaveAs2(globalVariables.globalFilePath + "\\GeneratedServicesReport_" + fileName + ".docx");
                        globalVariables.generateReportListDoc.Add(globalVariables.globalFilePath + "\\GeneratedServicesReport_" + fileName + ".docx");
                        string processingServiceName = "";
                        foreach (Dictionary<string, object> obj in globalVariables.generateReportListServiceName)
                        {
                            if (obj["reportFileName"].ToString() == objArr)
                            {
                                processingServiceName = obj["serviceName"].ToString();
                                obj["reportFileName"] = globalVariables.globalFilePath + "\\GeneratedServicesReport_" + fileName + ".docx";
                                break;
                            }
                        }
                        txtBx_GenRepStatus.Text = txtBx_GenRepStatus.Text + "Converting to Service report file for ArcGIS Server service: " + processingServiceName + "\r\n";
                        object saveChanges = WdSaveOptions.wdSaveChanges;
                        doc.Close(saveChanges, missing, missing);
                        appobj.Quit();
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(doc);
                        System.Runtime.InteropServices.Marshal.FinalReleaseComObject(appobj);

                        ////delete the file if it exists
                        //if (File.Exists(objArr))
                        //{
                        //    //File.Delete(objArr);
                        //}
                    }
                }

            }
            catch (Exception ex)
            {
                string errMsg = "GenerateReport.cs - servicesReportFilesGenerator: " + ex.Message.ToString();
                globalVariables gv = new globalVariables();
                globalVariables.loggingEnabled = true; gv.onErrorClearGeneratedFiles(errMsg);
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


        private void btnOpenReport_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            wordApp.Visible = true;
            Document wordDoc = wordApp.Documents.Add(globalVariables.generatedFinalReportName);

        }
    }
}
