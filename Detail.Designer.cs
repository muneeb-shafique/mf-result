namespace SignUpDemo
{
    partial class Detail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail));
            this.pc_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_name = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_user = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_version = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_os = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_os_plat = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel8 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_core = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_bit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel7 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbl_proc_bit = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.circle_ram = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.circle_cpu = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.timer_per = new System.Windows.Forms.Timer(this.components);
            this.CPU = new System.Diagnostics.PerformanceCounter();
            this.RAM = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pc_name
            // 
            this.pc_name.AutoSize = true;
            this.pc_name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pc_name.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.pc_name.Location = new System.Drawing.Point(24, 88);
            this.pc_name.Name = "pc_name";
            this.pc_name.Size = new System.Drawing.Size(189, 25);
            this.pc_name.TabIndex = 0;
            this.pc_name.Text = "Computer Name:";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_name.Location = new System.Drawing.Point(219, 89);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(192, 24);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Computer Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "PC DETAILS";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_user.Location = new System.Drawing.Point(219, 126);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(192, 24);
            this.lbl_user.TabIndex = 4;
            this.lbl_user.Text = "Computer Name:";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(83, 125);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(130, 25);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "User Name:";
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_version.Location = new System.Drawing.Point(219, 162);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(192, 24);
            this.lbl_version.TabIndex = 6;
            this.lbl_version.Text = "Computer Name:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(12, 162);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(201, 25);
            this.bunifuCustomLabel4.TabIndex = 5;
            this.bunifuCustomLabel4.Text = "Computer Version:\r\n";
            // 
            // lbl_os
            // 
            this.lbl_os.AutoSize = true;
            this.lbl_os.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_os.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_os.Location = new System.Drawing.Point(219, 199);
            this.lbl_os.Name = "lbl_os";
            this.lbl_os.Size = new System.Drawing.Size(192, 24);
            this.lbl_os.TabIndex = 8;
            this.lbl_os.Text = "Computer Name:";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(23, 199);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(190, 25);
            this.bunifuCustomLabel6.TabIndex = 7;
            this.bunifuCustomLabel6.Text = "Operating Sytem:";
            // 
            // lbl_os_plat
            // 
            this.lbl_os_plat.AutoSize = true;
            this.lbl_os_plat.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_os_plat.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_os_plat.Location = new System.Drawing.Point(219, 235);
            this.lbl_os_plat.Name = "lbl_os_plat";
            this.lbl_os_plat.Size = new System.Drawing.Size(192, 24);
            this.lbl_os_plat.TabIndex = 10;
            this.lbl_os_plat.Text = "Computer Name:";
            // 
            // bunifuCustomLabel8
            // 
            this.bunifuCustomLabel8.AutoSize = true;
            this.bunifuCustomLabel8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel8.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel8.Location = new System.Drawing.Point(77, 234);
            this.bunifuCustomLabel8.Name = "bunifuCustomLabel8";
            this.bunifuCustomLabel8.Size = new System.Drawing.Size(136, 25);
            this.bunifuCustomLabel8.TabIndex = 9;
            this.bunifuCustomLabel8.Text = "OS Platform:";
            // 
            // lbl_core
            // 
            this.lbl_core.AutoSize = true;
            this.lbl_core.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_core.Location = new System.Drawing.Point(219, 269);
            this.lbl_core.Name = "lbl_core";
            this.lbl_core.Size = new System.Drawing.Size(192, 24);
            this.lbl_core.TabIndex = 12;
            this.lbl_core.Text = "Computer Name:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(35, 269);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(178, 25);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "Processor Cores:";
            // 
            // lbl_bit
            // 
            this.lbl_bit.AutoSize = true;
            this.lbl_bit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_bit.Location = new System.Drawing.Point(219, 304);
            this.lbl_bit.Name = "lbl_bit";
            this.lbl_bit.Size = new System.Drawing.Size(192, 24);
            this.lbl_bit.TabIndex = 14;
            this.lbl_bit.Text = "Computer Name:";
            // 
            // bunifuCustomLabel7
            // 
            this.bunifuCustomLabel7.AutoSize = true;
            this.bunifuCustomLabel7.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel7.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel7.Location = new System.Drawing.Point(107, 304);
            this.bunifuCustomLabel7.Name = "bunifuCustomLabel7";
            this.bunifuCustomLabel7.Size = new System.Drawing.Size(106, 25);
            this.bunifuCustomLabel7.TabIndex = 13;
            this.bunifuCustomLabel7.Text = "64 Bit OS:";
            // 
            // lbl_proc_bit
            // 
            this.lbl_proc_bit.AutoSize = true;
            this.lbl_proc_bit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_proc_bit.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_proc_bit.Location = new System.Drawing.Point(219, 339);
            this.lbl_proc_bit.Name = "lbl_proc_bit";
            this.lbl_proc_bit.Size = new System.Drawing.Size(192, 24);
            this.lbl_proc_bit.TabIndex = 16;
            this.lbl_proc_bit.Text = "Computer Name:";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel9.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(40, 339);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(173, 25);
            this.bunifuCustomLabel9.TabIndex = 15;
            this.bunifuCustomLabel9.Text = "64 Bit Processor:\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label2.Location = new System.Drawing.Point(22, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(303, 38);
            this.label2.TabIndex = 17;
            this.label2.Text = "PC PERFORMANCE";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(37, 461);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(130, 25);
            this.bunifuCustomLabel3.TabIndex = 19;
            this.bunifuCustomLabel3.Text = "CPU Usage:";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(199, 461);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(135, 25);
            this.bunifuCustomLabel5.TabIndex = 21;
            this.bunifuCustomLabel5.Text = "RAM Usage:";
            // 
            // circle_ram
            // 
            this.circle_ram.AllowDrop = true;
            this.circle_ram.animated = false;
            this.circle_ram.animationIterval = 5;
            this.circle_ram.animationSpeed = 300;
            this.circle_ram.BackColor = System.Drawing.Color.Transparent;
            this.circle_ram.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_ram.BackgroundImage")));
            this.circle_ram.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle_ram.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.circle_ram.LabelVisible = true;
            this.circle_ram.LineProgressThickness = 8;
            this.circle_ram.LineThickness = 5;
            this.circle_ram.Location = new System.Drawing.Point(213, 493);
            this.circle_ram.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.circle_ram.MaxValue = 100;
            this.circle_ram.Name = "circle_ram";
            this.circle_ram.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle_ram.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.circle_ram.Size = new System.Drawing.Size(104, 104);
            this.circle_ram.TabIndex = 20;
            this.circle_ram.Value = 0;
            // 
            // circle_cpu
            // 
            this.circle_cpu.AllowDrop = true;
            this.circle_cpu.animated = false;
            this.circle_cpu.animationIterval = 5;
            this.circle_cpu.animationSpeed = 300;
            this.circle_cpu.BackColor = System.Drawing.Color.Transparent;
            this.circle_cpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("circle_cpu.BackgroundImage")));
            this.circle_cpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.circle_cpu.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.circle_cpu.LabelVisible = true;
            this.circle_cpu.LineProgressThickness = 8;
            this.circle_cpu.LineThickness = 5;
            this.circle_cpu.Location = new System.Drawing.Point(47, 493);
            this.circle_cpu.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.circle_cpu.MaxValue = 100;
            this.circle_cpu.Name = "circle_cpu";
            this.circle_cpu.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.circle_cpu.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.circle_cpu.Size = new System.Drawing.Size(104, 104);
            this.circle_cpu.TabIndex = 22;
            this.circle_cpu.Value = 10;
            // 
            // timer_per
            // 
            this.timer_per.Tick += new System.EventHandler(this.timer_per_Tick);
            // 
            // CPU
            // 
            this.CPU.CategoryName = "Processor";
            this.CPU.CounterName = "% Processor Time";
            this.CPU.InstanceName = "_Total";
            // 
            // RAM
            // 
            this.RAM.CategoryName = "Memory";
            this.RAM.CounterName = "% Committed Bytes In Use";
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.circle_cpu);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.circle_ram);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_proc_bit);
            this.Controls.Add(this.bunifuCustomLabel9);
            this.Controls.Add(this.lbl_bit);
            this.Controls.Add(this.bunifuCustomLabel7);
            this.Controls.Add(this.lbl_core);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.lbl_os_plat);
            this.Controls.Add(this.bunifuCustomLabel8);
            this.Controls.Add(this.lbl_os);
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.pc_name);
            this.Name = "Detail";
            this.Size = new System.Drawing.Size(700, 622);
            this.Load += new System.EventHandler(this.Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel pc_name;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_name;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_user;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_version;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_os;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_os_plat;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel8;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_core;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_bit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel7;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl_proc_bit;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel9;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle_ram;
        private Bunifu.Framework.UI.BunifuCircleProgressbar circle_cpu;
        private System.Windows.Forms.Timer timer_per;
        private System.Diagnostics.PerformanceCounter CPU;
        private System.Diagnostics.PerformanceCounter RAM;
    }
}
