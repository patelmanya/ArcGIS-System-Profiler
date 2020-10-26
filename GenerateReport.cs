using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                wordApp.Visible = true;
                Document wordDoc = wordApp.Documents.Add(@"C:\temp\DataTemplate.dotx");
                tbl = findTable(wordApp.ActiveDocument, "Company List");

                //Add two columns
                if (tbl.Columns.Count == 1)
                {
                    //1 Column
                    tbl.Columns.Add();
                    //2 Columns
                    tbl.Columns.Add();

                    //pretty basic logic...what happens if the table template had 2 columns?
                    //with my code...nothing...which would be a problem.
                    //it's a sample, so make of it what you wish.
                }

                //We need a counter...
                int i = 1;
                //And a table header
                tbl.Cell(i, 1).Range.Text = "Contact Name";
                tbl.Cell(i, 2).Range.Text = "Phone Number";
                tbl.Cell(i, 3).Range.Text = "Email Address";
                tbl.Rows.Add();
                tbl.Cell(i, 1).Range.Text = "FullName";
                tbl.Cell(i, 2).Range.Text = "MobileTelephoneNumber";
                tbl.Cell(i, 3).Range.Text = "Email1Addess";

                tbl.AutoFitBehavior(Microsoft.Office.Interop.Word.WdAutoFitBehavior.wdAutoFitContent);
                Marshal.ReleaseComObject(tbl);
                wordDoc.SaveAs2(@"C:\temp\GeneratedReport.docx");
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
