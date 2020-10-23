using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace ArcGIS_System_Profiler
{
    public partial class LaunchForm : Form
    {
        //Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public LaunchForm()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);
            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            OpenChildForm(new InitialForm());
        }

        public void OpenChildForm(Form chidlForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = chidlForm;
            chidlForm.TopLevel = false;
            chidlForm.FormBorderStyle = FormBorderStyle.None;
            chidlForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(chidlForm);
            panelDesktop.Tag = chidlForm;
            chidlForm.BringToFront();
            chidlForm.Show();
            currentStepLabel.Text = chidlForm.Text;
            lbl_loggedInUser.Text = globalVariables.agsEntUserName;

        }

        private struct RGBCOlors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 16, 51);

        }

        //Methods
        private void ActivateButton(object sender, Color color)
        {
            if (sender != null)
            {
                DisableButton();
                currentBtn = (IconButton)sender;
                currentBtn.BackColor = Color.FromArgb(37, 36, 31);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;
                //Left Border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                //add to the title bar the current step title
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = currentBtn.IconColor;
            }
        }

        //disable the button
        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(31, 30, 68);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }

        }

        public void btn_Home_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color1);
            //OpenChildForm(new InitialForm());
            OpenChildForm(new Home());
        }

        private void btn_Tasks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color2);
            OpenChildForm(new StepsConfirmationForm());
        }

        private void btn_Services_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color3);
            OpenChildForm(new FederatedEnv());
        }

        private void btn_HealthChecks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color4);
            OpenChildForm(new ScreenCaptureForm());
        }

        private void btn_PortChecks_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color5);
            OpenChildForm(new PortCheckForm());
        }

        private void btn_Publish_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBCOlors.color6);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            //add to the title bar the current step title
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.White;
            OpenChildForm(new InitialForm());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);



        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void globalTimer1_Tick(object sender, EventArgs e)
        {
            globalProgressBar1.Value = globalProgressBar1.Value + 10;
            if (globalProgressBar1.Value > 99)
            {
                this.Hide();
                globalVariables.globalForm.globalTimer1.Enabled = false;
                globalVariables.globalForm.btn_Tasks.PerformClick();
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
