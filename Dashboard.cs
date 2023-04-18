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
using Guna.UI2.WinForms;
using spacey.Auth;
using spacey.Properties;

namespace spacey
{
    public partial class Dashboard : Form
    {
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        // Two example methods can be used to hide other pages and show one ( you can add more by adding more UserControls )
        public void hs(UserControl a, UserControl b, UserControl c, UserControl d)
        {
            a.Show();
            b.Hide();
            c.Hide();
            d.Hide();
            
        }

        // Quickly Hide all forms ( you can add more by adding more UserControls )
        public void ha(UserControl a, UserControl b, UserControl c, UserControl d)
        {
            a.Hide();
            b.Hide();
            c.Hide();
            d.Hide();
        }

        public void cm2(Guna2Button a, Guna2Button b, Guna2Button c, Guna2Button d)
        {
            // A is made checked, the rest are made unchecked (Dynamic Toggling)
            a.Checked = true;
            b.Checked = false;
            c.Checked = false;
            d.Checked = false;
        }

        public Dashboard()
        {
            
            InitializeComponent();
            settings1.Hide();
            userCTsp1.Show();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            userCTsp1.Show();
            settings1.Hide();
            cm2(buttonA, buttonB, buttonC, buttonD);
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            userCTsp1.Hide();
            settings1.Show();
            cm2(buttonB, buttonA, buttonC, buttonD);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            userCTsp1.Hide();
            settings1.Hide();
            cm2(buttonC, buttonB, buttonA, buttonD);
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            userCTsp1.Hide();
            settings1.Hide();
            cm2(buttonD, buttonB, buttonC, buttonA);
        }

        private void settings1_Load(object sender, EventArgs e)
        {

        }

        private void userCTsp1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
