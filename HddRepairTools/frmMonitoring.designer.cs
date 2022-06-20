namespace HddRepairTools
{
    partial class frmMonitoring
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.mon7 = new System.Windows.Forms.TextBox();
            this.mon6 = new System.Windows.Forms.TextBox();
            this.mon5 = new System.Windows.Forms.TextBox();
            this.mon4 = new System.Windows.Forms.TextBox();
            this.mon3 = new System.Windows.Forms.TextBox();
            this.mon2 = new System.Windows.Forms.TextBox();
            this.mon1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(13, 143);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 13);
            this.label18.TabIndex = 88;
            this.label18.Text = "Status";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(13, 123);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 13);
            this.label19.TabIndex = 87;
            this.label19.Text = "Device";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(13, 103);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(66, 13);
            this.label20.TabIndex = 86;
            this.label20.Text = "CylinderHigh";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(13, 83);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(64, 13);
            this.label21.TabIndex = 85;
            this.label21.Text = "CylinderLow";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(13, 63);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(75, 13);
            this.label22.TabIndex = 84;
            this.label22.Text = "SectorNumber";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(13, 43);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 13);
            this.label23.TabIndex = 83;
            this.label23.Text = "SectorCount";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(13, 23);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(29, 13);
            this.label24.TabIndex = 82;
            this.label24.Text = "Error";
            // 
            // mon7
            // 
            this.mon7.Location = new System.Drawing.Point(100, 140);
            this.mon7.Margin = new System.Windows.Forms.Padding(4);
            this.mon7.Name = "mon7";
            this.mon7.Size = new System.Drawing.Size(41, 20);
            this.mon7.TabIndex = 81;
            this.mon7.Text = "00";
            // 
            // mon6
            // 
            this.mon6.Location = new System.Drawing.Point(100, 120);
            this.mon6.Margin = new System.Windows.Forms.Padding(4);
            this.mon6.Name = "mon6";
            this.mon6.Size = new System.Drawing.Size(41, 20);
            this.mon6.TabIndex = 80;
            this.mon6.Text = "00";
            // 
            // mon5
            // 
            this.mon5.Location = new System.Drawing.Point(100, 100);
            this.mon5.Margin = new System.Windows.Forms.Padding(4);
            this.mon5.Name = "mon5";
            this.mon5.Size = new System.Drawing.Size(41, 20);
            this.mon5.TabIndex = 79;
            this.mon5.Text = "00";
            // 
            // mon4
            // 
            this.mon4.Location = new System.Drawing.Point(100, 80);
            this.mon4.Margin = new System.Windows.Forms.Padding(4);
            this.mon4.Name = "mon4";
            this.mon4.Size = new System.Drawing.Size(41, 20);
            this.mon4.TabIndex = 78;
            this.mon4.Text = "00";
            // 
            // mon3
            // 
            this.mon3.Location = new System.Drawing.Point(100, 60);
            this.mon3.Margin = new System.Windows.Forms.Padding(4);
            this.mon3.Name = "mon3";
            this.mon3.Size = new System.Drawing.Size(41, 20);
            this.mon3.TabIndex = 77;
            this.mon3.Text = "00";
            // 
            // mon2
            // 
            this.mon2.Location = new System.Drawing.Point(100, 40);
            this.mon2.Margin = new System.Windows.Forms.Padding(4);
            this.mon2.Name = "mon2";
            this.mon2.Size = new System.Drawing.Size(41, 20);
            this.mon2.TabIndex = 76;
            this.mon2.Text = "00";
            // 
            // mon1
            // 
            this.mon1.Location = new System.Drawing.Point(100, 20);
            this.mon1.Margin = new System.Windows.Forms.Padding(4);
            this.mon1.Name = "mon1";
            this.mon1.Size = new System.Drawing.Size(42, 20);
            this.mon1.TabIndex = 75;
            this.mon1.Text = "00";
            // 
            // frmMonitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(161, 194);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.mon7);
            this.Controls.Add(this.mon6);
            this.Controls.Add(this.mon5);
            this.Controls.Add(this.mon4);
            this.Controls.Add(this.mon3);
            this.Controls.Add(this.mon2);
            this.Controls.Add(this.mon1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmMonitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMonitoring_FormClosing);
            this.Load += new System.EventHandler(this.frmMonitoring_Load);
            this.Shown += new System.EventHandler(this.frmMonitoring_Shown);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.frmMonitoring_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMonitoring_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMonitoring_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMonitoring_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox mon7;
        private System.Windows.Forms.TextBox mon6;
        private System.Windows.Forms.TextBox mon5;
        private System.Windows.Forms.TextBox mon4;
        private System.Windows.Forms.TextBox mon3;
        private System.Windows.Forms.TextBox mon2;
        private System.Windows.Forms.TextBox mon1;
    }
}