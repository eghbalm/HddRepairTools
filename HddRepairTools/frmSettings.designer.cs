namespace HddRepairTools
{
    partial class frmSettings
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.lblwait = new System.Windows.Forms.Label();
            this.waitNum = new System.Windows.Forms.TextBox();
            this.LBA28 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbWD = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(230, 124);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(4);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(72, 24);
            this.btnSettings.TabIndex = 36;
            this.btnSettings.Text = "Save";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // lblwait
            // 
            this.lblwait.AutoSize = true;
            this.lblwait.Location = new System.Drawing.Point(13, 52);
            this.lblwait.Name = "lblwait";
            this.lblwait.Size = new System.Drawing.Size(97, 13);
            this.lblwait.TabIndex = 59;
            this.lblwait.Text = "WaitBusyTime(MS)";
            // 
            // waitNum
            // 
            this.waitNum.Location = new System.Drawing.Point(139, 49);
            this.waitNum.Name = "waitNum";
            this.waitNum.Size = new System.Drawing.Size(163, 20);
            this.waitNum.TabIndex = 58;
            this.waitNum.Text = "100000";
            this.waitNum.TextChanged += new System.EventHandler(this.waitNum_TextChanged);
            // 
            // LBA28
            // 
            this.LBA28.AutoSize = true;
            this.LBA28.Location = new System.Drawing.Point(120, 89);
            this.LBA28.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBA28.Name = "LBA28";
            this.LBA28.Size = new System.Drawing.Size(58, 17);
            this.LBA28.TabIndex = 57;
            this.LBA28.Text = "LBA28";
            this.LBA28.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "WorkDir";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(272, 12);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(30, 23);
            this.btnBrowse.TabIndex = 62;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // lbWD
            // 
            this.lbWD.AutoSize = true;
            this.lbWD.Location = new System.Drawing.Point(4, 5);
            this.lbWD.Name = "lbWD";
            this.lbWD.Size = new System.Drawing.Size(0, 13);
            this.lbWD.TabIndex = 0;
            this.lbWD.MouseHover += new System.EventHandler(this.lbWD_MouseHover);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbWD);
            this.panel1.Location = new System.Drawing.Point(60, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 23);
            this.panel1.TabIndex = 63;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(16, 125);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 64;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 160);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblwait);
            this.Controls.Add(this.waitNum);
            this.Controls.Add(this.LBA28);
            this.Controls.Add(this.btnSettings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "frmSettings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label lblwait;
        private System.Windows.Forms.TextBox waitNum;
        private System.Windows.Forms.CheckBox LBA28;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lbWD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
    }
}