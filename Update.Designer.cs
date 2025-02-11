namespace SignUpDemo
{
    partial class Update
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_up = new System.Windows.Forms.Label();
            this.prog_update = new Bunifu.Framework.UI.BunifuProgressBar();
            this.lbl_per = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_up = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_cancel = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(14, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Status:";
            // 
            // lbl_up
            // 
            this.lbl_up.AutoSize = true;
            this.lbl_up.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_up.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_up.Location = new System.Drawing.Point(97, 56);
            this.lbl_up.Name = "lbl_up";
            this.lbl_up.Size = new System.Drawing.Size(97, 24);
            this.lbl_up.TabIndex = 1;
            this.lbl_up.Text = "Stopped";
            // 
            // prog_update
            // 
            this.prog_update.BackColor = System.Drawing.Color.Silver;
            this.prog_update.BorderRadius = 5;
            this.prog_update.Location = new System.Drawing.Point(13, 90);
            this.prog_update.MaximumValue = 100;
            this.prog_update.Name = "prog_update";
            this.prog_update.ProgressColor = System.Drawing.Color.DarkSlateBlue;
            this.prog_update.Size = new System.Drawing.Size(431, 31);
            this.prog_update.TabIndex = 2;
            this.prog_update.Value = 0;
            // 
            // lbl_per
            // 
            this.lbl_per.AutoSize = true;
            this.lbl_per.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_per.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.lbl_per.Location = new System.Drawing.Point(127, 132);
            this.lbl_per.Name = "lbl_per";
            this.lbl_per.Size = new System.Drawing.Size(180, 24);
            this.lbl_per.TabIndex = 3;
            this.lbl_per.Text = "Downloaded 0%";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 36);
            this.label4.TabIndex = 4;
            this.label4.Text = "Update Program";
            // 
            // btn_up
            // 
            this.btn_up.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_up.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_up.BorderRadius = 7;
            this.btn_up.ButtonText = "Update";
            this.btn_up.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_up.DisabledColor = System.Drawing.Color.Gray;
            this.btn_up.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_up.Iconimage = null;
            this.btn_up.Iconimage_right = null;
            this.btn_up.Iconimage_right_Selected = null;
            this.btn_up.Iconimage_Selected = null;
            this.btn_up.IconMarginLeft = 0;
            this.btn_up.IconMarginRight = 0;
            this.btn_up.IconRightVisible = true;
            this.btn_up.IconRightZoom = 0D;
            this.btn_up.IconVisible = true;
            this.btn_up.IconZoom = 90D;
            this.btn_up.IsTab = false;
            this.btn_up.Location = new System.Drawing.Point(360, 12);
            this.btn_up.Name = "btn_up";
            this.btn_up.Normalcolor = System.Drawing.Color.DarkSlateBlue;
            this.btn_up.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.btn_up.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_up.selected = false;
            this.btn_up.Size = new System.Drawing.Size(87, 33);
            this.btn_up.TabIndex = 5;
            this.btn_up.Text = "Update";
            this.btn_up.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_up.Textcolor = System.Drawing.Color.White;
            this.btn_up.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_cancel.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancel.BorderRadius = 7;
            this.btn_cancel.ButtonText = "Cancel";
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DisabledColor = System.Drawing.Color.Gray;
            this.btn_cancel.Enabled = false;
            this.btn_cancel.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_cancel.Iconimage = null;
            this.btn_cancel.Iconimage_right = null;
            this.btn_cancel.Iconimage_right_Selected = null;
            this.btn_cancel.Iconimage_Selected = null;
            this.btn_cancel.IconMarginLeft = 0;
            this.btn_cancel.IconMarginRight = 0;
            this.btn_cancel.IconRightVisible = true;
            this.btn_cancel.IconRightZoom = 0D;
            this.btn_cancel.IconVisible = true;
            this.btn_cancel.IconZoom = 90D;
            this.btn_cancel.IsTab = false;
            this.btn_cancel.Location = new System.Drawing.Point(270, 12);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Normalcolor = System.Drawing.Color.DarkSlateBlue;
            this.btn_cancel.OnHovercolor = System.Drawing.Color.SlateBlue;
            this.btn_cancel.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_cancel.selected = false;
            this.btn_cancel.Size = new System.Drawing.Size(84, 33);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_cancel.Textcolor = System.Drawing.Color.White;
            this.btn_cancel.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 171);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_up);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_per);
            this.Controls.Add(this.prog_update);
            this.Controls.Add(this.lbl_up);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Update";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.Load += new System.EventHandler(this.Update_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_up;
        private Bunifu.Framework.UI.BunifuProgressBar prog_update;
        private System.Windows.Forms.Label lbl_per;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btn_up;
        private Bunifu.Framework.UI.BunifuFlatButton btn_cancel;
    }
}