using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using spacey.Auth;


namespace spacey
{
    public partial class Form1 : Form


    {

        public static api KeyAuthApp = new api(
            name: "Spoofer", //Application Name
            ownerid: "y1AtiTgOl0", // Ownerid
            secret: "8aae3705aaf2b16468d136bd87a3f346c12615f230732f774f5c655530acc95d", // Application Secret
            version: "1.0" // Application Version (Default 1.0)
        );


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


        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;


        public Form1()
        {
            InitializeComponent();
            KeyAuthApp.init();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 14, 14));

            erTxt.Text = ""; // Hides Error Text
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void regB_Click(object sender, EventArgs e)
        {
            Thread regThread = new Thread(() =>
            {
                Reg rg = new Reg();
                rg.Location = this.Location;
                rg.StartPosition = FormStartPosition.Manual;
                rg.ShowDialog();
            });

            regThread.Start();
            this.Hide();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (userTxt.Text == "" || psdTxt.Text == "")
            {
                erTxt.Text = "Please fill out all fields.";
            }

            if (userTxt.Text != "" || psdTxt.Text != "")
            {
                Task.Run(() =>
                {
                    KeyAuthApp.login(userTxt.Text, psdTxt.Text);
                }).ContinueWith((task) =>
                {
                    if (KeyAuthApp.response.success)
                    {
                        // Update UI controls on the UI thread
                        this.Invoke(new Action(() =>
                        {
                            Dashboard dhb = new Dashboard();
                            dhb.Show();
                            this.Hide();
                        }));
                    }
                    else
                    {
                        // Update UI controls on the UI thread
                        this.Invoke(new Action(() =>
                        {
                            erTxt.Text = KeyAuthApp.response.message;
                        }));
                    }
                });
            }

        }

        private void userTxt_TextChanged(object sender, EventArgs e)
        {
            if (erTxt.Text != "")
            {
                erTxt.Text = "";
            }
        }
    }
}
