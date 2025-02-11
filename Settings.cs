using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SignUpDemo
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void btn_detail_Click(object sender, EventArgs e)
        {
            tran.HideSync(about);
            tran.ShowSync(detail);

        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            tran.HideSync(detail);
            tran.ShowSync(about);
        }
    }
}
