using NPOI.XWPF.UserModel;
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
    public partial class StartPage : Form
    {
        public StartPage()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            globalVariables.global_PreCheckFormFlag = true;
            globalVariables.globalForm.btnSystemValidation.Visible = true;
            globalVariables.globalForm.btnSystemValidation.PerformClick();
            
            
            XWPFDocument doc = new XWPFDocument();
            XWPFParagraph p1 = doc.CreateParagraph();
             
            XWPFRun r1 = p1.CreateRun();
            
            r1.SetText("The quick brown fox");
           
            r1.SetUnderline(UnderlinePatterns.DotDotDash);
           
            XWPFParagraph p2 = doc.CreateParagraph(); 
            XWPFRun r2 = p2.CreateRun();
            r2.SetText("jumped over the lazy dog");
           
            XWPFRun r3 = p2.CreateRun();
            r3.SetText("and went away");
            


            XWPFParagraph p3 = doc.CreateParagraph();
            
             


            XWPFRun r4 = p3.CreateRun();
            
            r4.SetText("To be, or not to be: that is the question: "
                    + "Whether 'tis nobler in the mind to suffer "
                    + "The slings and arrows of outrageous fortune, "
                    + "Or to take arms against a sea of troubles, "
                    + "And by opposing end them? To die: to sleep; ");
            r4.AddBreak(BreakType.PAGE);
            r4.SetText("No more; and by a sleep to say we end "
                    + "The heart-ache and the thousand natural shocks "
                    + "That flesh is heir to, 'tis a consummation "
                    + "Devoutly to be wish'd. To die, to sleep; "
                    + "To sleep: perchance to dream: ay, there's the rub; "
                    + ".......");
            
            //This would imply that this break shall be treated as a simple line break, and break the line after that word:

            XWPFRun r5 = p3.CreateRun();
            
            r5.SetText("For in that sleep of death what dreams may come");
            r5.AddCarriageReturn();
            r5.SetText("When we have shuffled off this mortal coil,"
                    + "Must give us pause: there's the respect"
                    + "That makes calamity of so long life;");
            r5.AddBreak();
            r5.SetText("For who would bear the whips and scorns of time,"
                    + "The oppressor's wrong, the proud man's contumely,");

            r5.AddBreak(BreakClear.ALL);
            r5.SetText("The pangs of despised love, the law's delay,"
                    + "The insolence of office and the spurns" + ".......");

            FileStream out1 = new FileStream("simple.docx", FileMode.Create);
            doc.Write(out1);
            out1.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            globalVariables.global_PostCheckFormFlag = true;
            globalVariables.globalForm.btn_Home.Visible = true;
            globalVariables.globalForm.btn_Home.PerformClick();
        }
    }
}
