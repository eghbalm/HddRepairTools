namespace HddRepairTools
{
    partial class frmPortList
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
            this.gvPorts = new System.Windows.Forms.DataGridView();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSet = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbSerial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.Slaver = new System.Windows.Forms.CheckBox();
            this.tbBaseaddr = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gvPorts)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvPorts
            // 
            this.gvPorts.AllowUserToAddRows = false;
            this.gvPorts.AllowUserToDeleteRows = false;
            this.gvPorts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPorts.Location = new System.Drawing.Point(13, 14);
            this.gvPorts.MultiSelect = false;
            this.gvPorts.Name = "gvPorts";
            this.gvPorts.ReadOnly = true;
            this.gvPorts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvPorts.Size = new System.Drawing.Size(906, 248);
            this.gvPorts.TabIndex = 6;
            this.gvPorts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvPorts_CellClick);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(832, 268);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(87, 27);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(739, 268);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(87, 27);
            this.btnSet.TabIndex = 4;
            this.btnSet.Text = "SetPort";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.tbSerial);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.tbModel);
            this.panel1.Controls.Add(this.Slaver);
            this.panel1.Controls.Add(this.tbBaseaddr);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.gvPorts);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnSet);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 308);
            this.panel1.TabIndex = 1;
            // 
            // tbSerial
            // 
            this.tbSerial.Location = new System.Drawing.Point(521, 272);
            this.tbSerial.Name = "tbSerial";
            this.tbSerial.Size = new System.Drawing.Size(135, 20);
            this.tbSerial.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serial : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Model : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(664, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 27);
            this.button1.TabIndex = 11;
            this.button1.Text = "Identity";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(290, 274);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(170, 20);
            this.tbModel.TabIndex = 10;
            // 
            // Slaver
            // 
            this.Slaver.AutoSize = true;
            this.Slaver.Location = new System.Drawing.Point(179, 274);
            this.Slaver.Name = "Slaver";
            this.Slaver.Size = new System.Drawing.Size(56, 17);
            this.Slaver.TabIndex = 9;
            this.Slaver.Text = "Slaver";
            this.Slaver.UseVisualStyleBackColor = true;
            // 
            // tbBaseaddr
            // 
            this.tbBaseaddr.Location = new System.Drawing.Point(85, 272);
            this.tbBaseaddr.Name = "tbBaseaddr";
            this.tbBaseaddr.Size = new System.Drawing.Size(88, 20);
            this.tbBaseaddr.TabIndex = 8;
            this.tbBaseaddr.Text = "0000";
            this.tbBaseaddr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBaseaddr_KeyPress);
            this.tbBaseaddr.Leave += new System.EventHandler(this.tbBaseaddr_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "baseAdress";
            // 
            // frmPortList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 323);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmPortList";
            this.Text = "frmPortList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPortList_FormClosing);
            this.Load += new System.EventHandler(this.frmPortList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvPorts)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gvPorts;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbBaseaddr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Slaver;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSerial;
        private System.Windows.Forms.Label label3;
    }
}