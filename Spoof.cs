using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spacey     
{
    public partial class userCTsp : UserControl
    {

   
        public userCTsp()
        {
            InitializeComponent();
            label3.ForeColor = Color.FromArgb(255, 18, 20, 22);
        }




        public async Task spFAsync(string f )
        {
            if (f == "a")
            {
                spBtn.Text = "Spoofing";
                Application.UseWaitCursor = true;
                label3.ForeColor = Color.FromArgb(255, 125, 137, 149);
                label3.Text = "HeX: Started SPOOF";
                await Task.Delay(2000);
                label3.Text = "HeX: Started HeX SPOOF\nHeX: SPOOFED GPU";
                spBtn.Text = "Spoof";
                Application.UseWaitCursor = false;
            }
        }


        private void Spoof_Load(object sender, EventArgs e)
        {

        }

        private void spBtn_Click(object sender, EventArgs e)
        {
            spFAsync("a");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void mdCheck_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
