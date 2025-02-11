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
    public partial class Detail : UserControl
    {
        public Detail()
        {
            InitializeComponent();
        }

        private void Detail_Load(object sender, EventArgs e)
        {
            timer_per.Start();
            lbl_name.Text = Environment.MachineName;
            lbl_user.Text = Environment.UserName;
            lbl_version.Text = Environment.Version.ToString();
            lbl_os.Text = Environment.OSVersion.ToString();
            lbl_os_plat.Text = Environment.OSVersion.Platform.ToString();
            lbl_core.Text = Environment.ProcessorCount.ToString();
            lbl_bit.Text = Environment.Is64BitOperatingSystem.ToString();
            lbl_proc_bit.Text = Environment.Is64BitProcess.ToString();
        }

        private void timer_per_Tick(object sender, EventArgs e)
        {
            float fcpu = CPU.NextValue();
            float dram = RAM.NextValue();
            circle_cpu.Value = (int)fcpu;
            circle_ram.Value = (int)dram;
        }
    }
}
