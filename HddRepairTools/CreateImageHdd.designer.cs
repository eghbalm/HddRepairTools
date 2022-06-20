namespace HddRepairTools
{
    partial class CreateImageHdd
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
            this.pbMon = new System.Windows.Forms.ProgressBar();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cbLen = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pbMon
            // 
            this.pbMon.Location = new System.Drawing.Point(4, 79);
            this.pbMon.Name = "pbMon";
            this.pbMon.Size = new System.Drawing.Size(551, 15);
            this.pbMon.TabIndex = 0;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(377, 47);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 23);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "CreateImage";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(494, 46);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(61, 23);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "MinLBA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "MaxLBA";
            // 
            // tbMin
            // 
            this.tbMin.Location = new System.Drawing.Point(90, 48);
            this.tbMin.Name = "tbMin";
            this.tbMin.Size = new System.Drawing.Size(86, 20);
            this.tbMin.TabIndex = 12;
            this.tbMin.Text = "0";
            this.tbMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMin_KeyPress);
            this.tbMin.Leave += new System.EventHandler(this.tbMinMax_Leave);
            // 
            // tbMax
            // 
            this.tbMax.Location = new System.Drawing.Point(274, 49);
            this.tbMax.Name = "tbMax";
            this.tbMax.Size = new System.Drawing.Size(86, 20);
            this.tbMax.TabIndex = 13;
            this.tbMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMax_KeyPress);
            this.tbMax.Leave += new System.EventHandler(this.tbMinMax_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "FileName";
            // 
            // tbFName
            // 
            this.tbFName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbFName.Location = new System.Drawing.Point(75, 15);
            this.tbFName.Name = "tbFName";
            this.tbFName.ReadOnly = true;
            this.tbFName.Size = new System.Drawing.Size(285, 20);
            this.tbFName.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(366, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "....";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            "65536"});
            this.cbLen.Location = new System.Drawing.Point(473, 18);
            this.cbLen.Name = "cbLen";
            this.cbLen.Size = new System.Drawing.Size(70, 21);
            this.cbLen.TabIndex = 19;
            this.cbLen.Text = "1";
            this.cbLen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbLen_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(418, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Length";
            // 
            // CreateImageHdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 106);
            this.Controls.Add(this.cbLen);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbFName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMax);
            this.Controls.Add(this.tbMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.pbMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "CreateImageHdd";
            this.Text = "EraseHdd";
            this.Load += new System.EventHandler(this.CreateImageHdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar pbMon;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbLen;
        private System.Windows.Forms.Label label5;
    }
}