namespace HddRepairTools
{
    partial class EraseHdd
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
            this.pbErase = new System.Windows.Forms.ProgressBar();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbCylander = new System.Windows.Forms.Label();
            this.tbCylander = new System.Windows.Forms.Label();
            this.lbHead = new System.Windows.Forms.Label();
            this.lbFW = new System.Windows.Forms.Label();
            this.lbSN = new System.Windows.Forms.Label();
            this.lbModel = new System.Windows.Forms.Label();
            this.tbHead = new System.Windows.Forms.Label();
            this.tbFW = new System.Windows.Forms.Label();
            this.tbSN = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCMD = new System.Windows.Forms.ComboBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbEmpty = new System.Windows.Forms.RadioButton();
            this.rbSN = new System.Windows.Forms.RadioButton();
            this.rbRandom = new System.Windows.Forms.RadioButton();
            this.rbByte = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.tbByte = new System.Windows.Forms.TextBox();
            this.lbPercent = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbErase
            // 
            this.pbErase.Location = new System.Drawing.Point(15, 219);
            this.pbErase.Name = "pbErase";
            this.pbErase.Size = new System.Drawing.Size(520, 15);
            this.pbErase.TabIndex = 0;
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(203, 244);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(61, 23);
            this.btnErase.TabIndex = 1;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(270, 244);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.lbCylander);
            this.groupBox1.Controls.Add(this.tbCylander);
            this.groupBox1.Controls.Add(this.lbHead);
            this.groupBox1.Controls.Add(this.lbFW);
            this.groupBox1.Controls.Add(this.lbSN);
            this.groupBox1.Controls.Add(this.lbModel);
            this.groupBox1.Controls.Add(this.tbHead);
            this.groupBox1.Controls.Add(this.tbFW);
            this.groupBox1.Controls.Add(this.tbSN);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(254, 119);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // lbCylander
            // 
            this.lbCylander.AutoSize = true;
            this.lbCylander.Location = new System.Drawing.Point(6, 74);
            this.lbCylander.Name = "lbCylander";
            this.lbCylander.Size = new System.Drawing.Size(57, 13);
            this.lbCylander.TabIndex = 35;
            this.lbCylander.Text = "Cylander : ";
            // 
            // tbCylander
            // 
            this.tbCylander.AutoSize = true;
            this.tbCylander.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbCylander.Location = new System.Drawing.Point(62, 74);
            this.tbCylander.Name = "tbCylander";
            this.tbCylander.Size = new System.Drawing.Size(37, 13);
            this.tbCylander.TabIndex = 34;
            this.tbCylander.Text = "          ";
            // 
            // lbHead
            // 
            this.lbHead.AutoSize = true;
            this.lbHead.Location = new System.Drawing.Point(5, 53);
            this.lbHead.Name = "lbHead";
            this.lbHead.Size = new System.Drawing.Size(58, 13);
            this.lbHead.TabIndex = 33;
            this.lbHead.Text = "HeadNO : ";
            // 
            // lbFW
            // 
            this.lbFW.AutoSize = true;
            this.lbFW.Location = new System.Drawing.Point(6, 96);
            this.lbFW.Name = "lbFW";
            this.lbFW.Size = new System.Drawing.Size(33, 13);
            this.lbFW.TabIndex = 32;
            this.lbFW.Text = "FW : ";
            // 
            // lbSN
            // 
            this.lbSN.AutoSize = true;
            this.lbSN.Location = new System.Drawing.Point(6, 34);
            this.lbSN.Name = "lbSN";
            this.lbSN.Size = new System.Drawing.Size(42, 13);
            this.lbSN.TabIndex = 31;
            this.lbSN.Text = "Serial : ";
            // 
            // lbModel
            // 
            this.lbModel.AutoSize = true;
            this.lbModel.Location = new System.Drawing.Point(6, 16);
            this.lbModel.Name = "lbModel";
            this.lbModel.Size = new System.Drawing.Size(45, 13);
            this.lbModel.TabIndex = 30;
            this.lbModel.Text = "Model : ";
            // 
            // tbHead
            // 
            this.tbHead.AutoSize = true;
            this.tbHead.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbHead.Location = new System.Drawing.Point(62, 53);
            this.tbHead.Name = "tbHead";
            this.tbHead.Size = new System.Drawing.Size(37, 13);
            this.tbHead.TabIndex = 29;
            this.tbHead.Text = "          ";
            // 
            // tbFW
            // 
            this.tbFW.AutoSize = true;
            this.tbFW.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbFW.Location = new System.Drawing.Point(62, 96);
            this.tbFW.Name = "tbFW";
            this.tbFW.Size = new System.Drawing.Size(37, 13);
            this.tbFW.TabIndex = 28;
            this.tbFW.Text = "          ";
            // 
            // tbSN
            // 
            this.tbSN.AutoSize = true;
            this.tbSN.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbSN.Location = new System.Drawing.Point(62, 34);
            this.tbSN.Name = "tbSN";
            this.tbSN.Size = new System.Drawing.Size(37, 13);
            this.tbSN.TabIndex = 27;
            this.tbSN.Text = "          ";
            // 
            // tbModel
            // 
            this.tbModel.AutoSize = true;
            this.tbModel.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.tbModel.Location = new System.Drawing.Point(62, 16);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(37, 13);
            this.tbModel.TabIndex = 26;
            this.tbModel.Text = "          ";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbCMD);
            this.groupBox2.Controls.Add(this.tbMax);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbMin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbLen);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(271, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 119);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Option";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "Command";
            // 
            // cbCMD
            // 
            this.cbCMD.FormattingEnabled = true;
            this.cbCMD.Items.AddRange(new object[] {
            "34",
            "30"});
            this.cbCMD.Location = new System.Drawing.Point(83, 88);
            this.cbCMD.Name = "cbCMD";
            this.cbCMD.Size = new System.Drawing.Size(53, 21);
            this.cbCMD.TabIndex = 26;
            this.cbCMD.Text = "34";
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(83, 62);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(86, 20);
            this.tbMax.TabIndex = 25;
            this.tbMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinMaxKeypress);
            this.tbMax.Leave += new System.EventHandler(this.tbMinMax_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "MaxLBA";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(83, 40);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(86, 20);
            this.tbMin.TabIndex = 23;
            this.tbMin.Text = "0";
            this.tbMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MinMaxKeypress);
            this.tbMin.Leave += new System.EventHandler(this.tbMinMax_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "MinLBA";
            // 
            // cbLen
            // 
            this.cbLen.FormattingEnabled = true;
            this.cbLen.Items.AddRange(new object[] {
            "1",
            "16",
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "4096",
            "65536"});
            this.cbLen.Location = new System.Drawing.Point(83, 17);
            this.cbLen.Name = "cbLen";
            this.cbLen.Size = new System.Drawing.Size(103, 21);
            this.cbLen.TabIndex = 19;
            this.cbLen.Text = "1";
            this.cbLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Length";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.rbEmpty);
            this.groupBox3.Controls.Add(this.rbSN);
            this.groupBox3.Controls.Add(this.rbRandom);
            this.groupBox3.Controls.Add(this.rbByte);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.tbByte);
            this.groupBox3.Location = new System.Drawing.Point(16, 137);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(516, 76);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Write Pattern ";
            // 
            // rbEmpty
            // 
            this.rbEmpty.AutoSize = true;
            this.rbEmpty.Checked = true;
            this.rbEmpty.Location = new System.Drawing.Point(6, 30);
            this.rbEmpty.Name = "rbEmpty";
            this.rbEmpty.Size = new System.Drawing.Size(109, 17);
            this.rbEmpty.TabIndex = 33;
            this.rbEmpty.TabStop = true;
            this.rbEmpty.Text = "Empty data(zeros)";
            this.rbEmpty.UseVisualStyleBackColor = true;
            this.rbEmpty.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbSN
            // 
            this.rbSN.AutoSize = true;
            this.rbSN.Location = new System.Drawing.Point(121, 30);
            this.rbSN.Name = "rbSN";
            this.rbSN.Size = new System.Drawing.Size(94, 17);
            this.rbSN.TabIndex = 32;
            this.rbSN.Text = "Sector number";
            this.rbSN.UseVisualStyleBackColor = true;
            this.rbSN.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbRandom
            // 
            this.rbRandom.AutoSize = true;
            this.rbRandom.Location = new System.Drawing.Point(221, 30);
            this.rbRandom.Name = "rbRandom";
            this.rbRandom.Size = new System.Drawing.Size(89, 17);
            this.rbRandom.TabIndex = 31;
            this.rbRandom.Text = "Random data";
            this.rbRandom.UseVisualStyleBackColor = true;
            this.rbRandom.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // rbByte
            // 
            this.rbByte.AutoSize = true;
            this.rbByte.Location = new System.Drawing.Point(321, 30);
            this.rbByte.Name = "rbByte";
            this.rbByte.Size = new System.Drawing.Size(46, 17);
            this.rbByte.TabIndex = 30;
            this.rbByte.Text = "Byte";
            this.rbByte.UseVisualStyleBackColor = true;
            this.rbByte.CheckedChanged += new System.EventHandler(this.rb_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "WriteByte";
            // 
            // tbByte
            // 
            this.tbByte.Enabled = false;
            this.tbByte.Location = new System.Drawing.Point(447, 29);
            this.tbByte.Name = "tbByte";
            this.tbByte.Size = new System.Drawing.Size(39, 20);
            this.tbByte.TabIndex = 28;
            this.tbByte.Text = "FF";
            this.tbByte.TextChanged += new System.EventHandler(this.tbByte_TextChanged);
            this.tbByte.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbByte_KeyPress);
            // 
            // lbPercent
            // 
            this.lbPercent.AutoSize = true;
            this.lbPercent.BackColor = System.Drawing.Color.Transparent;
            this.lbPercent.Location = new System.Drawing.Point(260, 221);
            this.lbPercent.Name = "lbPercent";
            this.lbPercent.Size = new System.Drawing.Size(24, 13);
            this.lbPercent.TabIndex = 28;
            this.lbPercent.Text = "0 %";
            // 
            // EraseHdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 281);
            this.Controls.Add(this.lbPercent);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.pbErase);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "EraseHdd";
            this.Text = "EraseHdd";
            this.Load += new System.EventHandler(this.EraseHdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbErase;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbHead;
        private System.Windows.Forms.Label lbFW;
        private System.Windows.Forms.Label lbSN;
        private System.Windows.Forms.Label lbModel;
        private System.Windows.Forms.Label tbHead;
        private System.Windows.Forms.Label tbFW;
        private System.Windows.Forms.Label tbSN;
        private System.Windows.Forms.Label tbModel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbLen;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbByte;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbSN;
        private System.Windows.Forms.RadioButton rbRandom;
        private System.Windows.Forms.RadioButton rbByte;
        private System.Windows.Forms.RadioButton rbEmpty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCMD;
        private System.Windows.Forms.Label lbCylander;
        private System.Windows.Forms.Label tbCylander;
        private System.Windows.Forms.Label lbPercent;
    }
}