namespace HddRepairTools
{
    partial class frmATACommand
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
            this.btnSaveBuffer = new System.Windows.Forms.Button();
            this.btnFileToBuffer = new System.Windows.Forms.Button();
            this.btnFileToHDD = new System.Windows.Forms.Button();
            this.btnBufferToHDD = new System.Windows.Forms.Button();
            this.btnHDDToFile = new System.Windows.Forms.Button();
            this.btnHDDToBuffer = new System.Windows.Forms.Button();
            this.btnSendCmd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtres = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCmd = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDev = new System.Windows.Forms.TextBox();
            this.txtHight = new System.Windows.Forms.TextBox();
            this.txtMid = new System.Windows.Forms.TextBox();
            this.txtLow = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtFet = new System.Windows.Forms.TextBox();
            this.btnShowBuffer = new System.Windows.Forms.Button();
            this.btnClearBuf = new System.Windows.Forms.Button();
            this.lblbuf = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveBuffer
            // 
            this.btnSaveBuffer.Location = new System.Drawing.Point(153, 120);
            this.btnSaveBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveBuffer.Name = "btnSaveBuffer";
            this.btnSaveBuffer.Size = new System.Drawing.Size(102, 28);
            this.btnSaveBuffer.TabIndex = 69;
            this.btnSaveBuffer.Text = "SaveBuffer";
            this.btnSaveBuffer.UseVisualStyleBackColor = true;
            this.btnSaveBuffer.Click += new System.EventHandler(this.btnSaveBuffer_Click);
            // 
            // btnFileToBuffer
            // 
            this.btnFileToBuffer.Location = new System.Drawing.Point(153, 229);
            this.btnFileToBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.btnFileToBuffer.Name = "btnFileToBuffer";
            this.btnFileToBuffer.Size = new System.Drawing.Size(102, 28);
            this.btnFileToBuffer.TabIndex = 68;
            this.btnFileToBuffer.Text = "FileToBuffer";
            this.btnFileToBuffer.UseVisualStyleBackColor = true;
            this.btnFileToBuffer.Click += new System.EventHandler(this.btnFileToBuffer_Click);
            // 
            // btnFileToHDD
            // 
            this.btnFileToHDD.Location = new System.Drawing.Point(153, 193);
            this.btnFileToHDD.Margin = new System.Windows.Forms.Padding(4);
            this.btnFileToHDD.Name = "btnFileToHDD";
            this.btnFileToHDD.Size = new System.Drawing.Size(102, 28);
            this.btnFileToHDD.TabIndex = 67;
            this.btnFileToHDD.Text = "FileToHDD";
            this.btnFileToHDD.UseVisualStyleBackColor = true;
            this.btnFileToHDD.Click += new System.EventHandler(this.btnFileToHDD_Click);
            // 
            // btnBufferToHDD
            // 
            this.btnBufferToHDD.Location = new System.Drawing.Point(153, 83);
            this.btnBufferToHDD.Margin = new System.Windows.Forms.Padding(4);
            this.btnBufferToHDD.Name = "btnBufferToHDD";
            this.btnBufferToHDD.Size = new System.Drawing.Size(102, 28);
            this.btnBufferToHDD.TabIndex = 72;
            this.btnBufferToHDD.Text = "BufferToHDD";
            this.btnBufferToHDD.UseVisualStyleBackColor = true;
            this.btnBufferToHDD.Click += new System.EventHandler(this.btnBufferToHDD_Click);
            // 
            // btnHDDToFile
            // 
            this.btnHDDToFile.Location = new System.Drawing.Point(153, 157);
            this.btnHDDToFile.Margin = new System.Windows.Forms.Padding(4);
            this.btnHDDToFile.Name = "btnHDDToFile";
            this.btnHDDToFile.Size = new System.Drawing.Size(102, 28);
            this.btnHDDToFile.TabIndex = 71;
            this.btnHDDToFile.Text = "HDDToFile";
            this.btnHDDToFile.UseVisualStyleBackColor = true;
            this.btnHDDToFile.Click += new System.EventHandler(this.btnHDDToFile_Click);
            // 
            // btnHDDToBuffer
            // 
            this.btnHDDToBuffer.Location = new System.Drawing.Point(153, 47);
            this.btnHDDToBuffer.Margin = new System.Windows.Forms.Padding(4);
            this.btnHDDToBuffer.Name = "btnHDDToBuffer";
            this.btnHDDToBuffer.Size = new System.Drawing.Size(102, 28);
            this.btnHDDToBuffer.TabIndex = 70;
            this.btnHDDToBuffer.Text = "HDDToBuffer";
            this.btnHDDToBuffer.UseVisualStyleBackColor = true;
            this.btnHDDToBuffer.Click += new System.EventHandler(this.btnHDDToBuffer_Click);
            // 
            // btnSendCmd
            // 
            this.btnSendCmd.Location = new System.Drawing.Point(153, 13);
            this.btnSendCmd.Margin = new System.Windows.Forms.Padding(4);
            this.btnSendCmd.Name = "btnSendCmd";
            this.btnSendCmd.Size = new System.Drawing.Size(102, 28);
            this.btnSendCmd.TabIndex = 66;
            this.btnSendCmd.Text = "Send";
            this.btnSendCmd.UseVisualStyleBackColor = true;
            this.btnSendCmd.Click += new System.EventHandler(this.btnSendCmd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 205);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Reserved";
            // 
            // txtres
            // 
            this.txtres.Location = new System.Drawing.Point(110, 205);
            this.txtres.Margin = new System.Windows.Forms.Padding(4);
            this.txtres.Name = "txtres";
            this.txtres.Size = new System.Drawing.Size(35, 20);
            this.txtres.TabIndex = 64;
            this.txtres.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 179);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Cmd";
            // 
            // txtCmd
            // 
            this.txtCmd.Location = new System.Drawing.Point(110, 179);
            this.txtCmd.Margin = new System.Windows.Forms.Padding(4);
            this.txtCmd.Name = "txtCmd";
            this.txtCmd.Size = new System.Drawing.Size(35, 20);
            this.txtCmd.TabIndex = 62;
            this.txtCmd.Text = "ec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 152);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Device";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "CylinderHigh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "CylinderLow";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 58;
            this.label3.Text = "SectorNum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "SectorCount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 56;
            this.label1.Text = "Feature";
            // 
            // txtDev
            // 
            this.txtDev.Location = new System.Drawing.Point(110, 152);
            this.txtDev.Margin = new System.Windows.Forms.Padding(4);
            this.txtDev.Name = "txtDev";
            this.txtDev.Size = new System.Drawing.Size(35, 20);
            this.txtDev.TabIndex = 55;
            this.txtDev.Text = "e0";
            // 
            // txtHight
            // 
            this.txtHight.Location = new System.Drawing.Point(110, 125);
            this.txtHight.Margin = new System.Windows.Forms.Padding(4);
            this.txtHight.Name = "txtHight";
            this.txtHight.Size = new System.Drawing.Size(35, 20);
            this.txtHight.TabIndex = 54;
            this.txtHight.Text = "0000";
            // 
            // txtMid
            // 
            this.txtMid.Location = new System.Drawing.Point(110, 101);
            this.txtMid.Margin = new System.Windows.Forms.Padding(4);
            this.txtMid.Name = "txtMid";
            this.txtMid.Size = new System.Drawing.Size(35, 20);
            this.txtMid.TabIndex = 53;
            this.txtMid.Text = "0000";
            // 
            // txtLow
            // 
            this.txtLow.Location = new System.Drawing.Point(110, 75);
            this.txtLow.Margin = new System.Windows.Forms.Padding(4);
            this.txtLow.Name = "txtLow";
            this.txtLow.Size = new System.Drawing.Size(35, 20);
            this.txtLow.TabIndex = 52;
            this.txtLow.Text = "0000";
            // 
            // txtSec
            // 
            this.txtSec.Location = new System.Drawing.Point(110, 50);
            this.txtSec.Margin = new System.Windows.Forms.Padding(4);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(35, 20);
            this.txtSec.TabIndex = 51;
            this.txtSec.Text = "0010";
            // 
            // txtFet
            // 
            this.txtFet.Location = new System.Drawing.Point(110, 25);
            this.txtFet.Margin = new System.Windows.Forms.Padding(4);
            this.txtFet.Name = "txtFet";
            this.txtFet.Size = new System.Drawing.Size(35, 20);
            this.txtFet.TabIndex = 50;
            this.txtFet.Text = "0000";
            // 
            // btnShowBuffer
            // 
            this.btnShowBuffer.Location = new System.Drawing.Point(153, 265);
            this.btnShowBuffer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowBuffer.Name = "btnShowBuffer";
            this.btnShowBuffer.Size = new System.Drawing.Size(102, 28);
            this.btnShowBuffer.TabIndex = 74;
            this.btnShowBuffer.Text = "ViewBuffer";
            this.btnShowBuffer.UseVisualStyleBackColor = true;
            this.btnShowBuffer.Click += new System.EventHandler(this.btnShowBuffer_Click);
            // 
            // btnClearBuf
            // 
            this.btnClearBuf.Location = new System.Drawing.Point(153, 302);
            this.btnClearBuf.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearBuf.Name = "btnClearBuf";
            this.btnClearBuf.Size = new System.Drawing.Size(102, 28);
            this.btnClearBuf.TabIndex = 73;
            this.btnClearBuf.Text = "ClearBuffer";
            this.btnClearBuf.UseVisualStyleBackColor = true;
            this.btnClearBuf.Click += new System.EventHandler(this.btnClearBuf_Click);
            // 
            // lblbuf
            // 
            this.lblbuf.AutoSize = true;
            this.lblbuf.Location = new System.Drawing.Point(71, 293);
            this.lblbuf.Name = "lblbuf";
            this.lblbuf.Size = new System.Drawing.Size(13, 13);
            this.lblbuf.TabIndex = 76;
            this.lblbuf.Text = "0";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(23, 293);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(35, 13);
            this.label27.TabIndex = 75;
            this.label27.Text = "Buffer";
            // 
            // frmATACommand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 354);
            this.Controls.Add(this.lblbuf);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.btnShowBuffer);
            this.Controls.Add(this.btnClearBuf);
            this.Controls.Add(this.btnSaveBuffer);
            this.Controls.Add(this.btnFileToBuffer);
            this.Controls.Add(this.btnFileToHDD);
            this.Controls.Add(this.btnBufferToHDD);
            this.Controls.Add(this.btnHDDToFile);
            this.Controls.Add(this.btnHDDToBuffer);
            this.Controls.Add(this.btnSendCmd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtres);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDev);
            this.Controls.Add(this.txtHight);
            this.Controls.Add(this.txtMid);
            this.Controls.Add(this.txtLow);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtFet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmATACommand";
            this.Text = "ATACommand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmATACommand_FormClosing);
            this.Load += new System.EventHandler(this.frmATACommand_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveBuffer;
        private System.Windows.Forms.Button btnFileToBuffer;
        private System.Windows.Forms.Button btnFileToHDD;
        private System.Windows.Forms.Button btnBufferToHDD;
        private System.Windows.Forms.Button btnHDDToFile;
        private System.Windows.Forms.Button btnHDDToBuffer;
        private System.Windows.Forms.Button btnSendCmd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtres;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCmd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDev;
        private System.Windows.Forms.TextBox txtHight;
        private System.Windows.Forms.TextBox txtMid;
        private System.Windows.Forms.TextBox txtLow;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtFet;
        private System.Windows.Forms.Button btnShowBuffer;
        private System.Windows.Forms.Button btnClearBuf;
        private System.Windows.Forms.Label lblbuf;
        private System.Windows.Forms.Label label27;
    }
}