using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArcGIS_System_Profiler
{
    public partial class ErrorLogger : Form
    {
        public ErrorLogger()
        {
            InitializeComponent(); 

            string[] lines = System.IO.File.ReadAllLines(globalVariables.strFileName);
            foreach (string line in lines)
            {
                // Use a tab to indent each line of the file.
                richTextBox1.Text += ("\t" + line);
            }

           
        }
    }
}
