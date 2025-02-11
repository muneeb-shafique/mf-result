using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class About : UserControl
    {
        public About()
        {
            InitializeComponent();
        }

        private void btn_fb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.facebook.com/Muneeb-Faizan-Corporation-100786452409177");
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://www.instagram.com/Muneeb-Faizan-Corporation-100786452409177");
        }

        private void btn_web_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"https://muneebfaizancorporation.tk/");
        }
    }
}
