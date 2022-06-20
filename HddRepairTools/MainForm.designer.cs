namespace HddRepairTools
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbMCR = new System.Windows.Forms.Label();
            this.lbMC = new System.Windows.Forms.Label();
            this.lbBBK = new System.Windows.Forms.Label();
            this.lbUNC = new System.Windows.Forms.Label();
            this.lbIDNF = new System.Windows.Forms.Label();
            this.lbABRT = new System.Windows.Forms.Label();
            this.lbTONF = new System.Windows.Forms.Label();
            this.lbAMNF = new System.Windows.Forms.Label();
            this.lbBsy = new System.Windows.Forms.Label();
            this.lbDrdy = new System.Windows.Forms.Label();
            this.lbDf = new System.Windows.Forms.Label();
            this.lbDsc = new System.Windows.Forms.Label();
            this.lbDrq = new System.Windows.Forms.Label();
            this.lbCorr = new System.Windows.Forms.Label();
            this.lbIdx = new System.Windows.Forms.Label();
            this.lbEror = new System.Windows.Forms.Label();
            this.tmMain = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hDDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seagateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleCommandToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loopCommandsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.createImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wipeHddToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sofTResetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitoringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbMCR);
            this.panel1.Controls.Add(this.lbMC);
            this.panel1.Controls.Add(this.lbBBK);
            this.panel1.Controls.Add(this.lbUNC);
            this.panel1.Controls.Add(this.lbIDNF);
            this.panel1.Controls.Add(this.lbABRT);
            this.panel1.Controls.Add(this.lbTONF);
            this.panel1.Controls.Add(this.lbAMNF);
            this.panel1.Controls.Add(this.lbBsy);
            this.panel1.Controls.Add(this.lbDrdy);
            this.panel1.Controls.Add(this.lbDf);
            this.panel1.Controls.Add(this.lbDsc);
            this.panel1.Controls.Add(this.lbDrq);
            this.panel1.Controls.Add(this.lbCorr);
            this.panel1.Controls.Add(this.lbIdx);
            this.panel1.Controls.Add(this.lbEror);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.panel1.Location = new System.Drawing.Point(13, 35);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(683, 43);
            this.panel1.TabIndex = 29;
            // 
            // lbMCR
            // 
            this.lbMCR.BackColor = System.Drawing.Color.DarkGray;
            this.lbMCR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbMCR.ForeColor = System.Drawing.Color.White;
            this.lbMCR.Location = new System.Drawing.Point(474, 10);
            this.lbMCR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMCR.Name = "lbMCR";
            this.lbMCR.Size = new System.Drawing.Size(36, 20);
            this.lbMCR.TabIndex = 41;
            this.lbMCR.Text = "MCR";
            this.lbMCR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMC
            // 
            this.lbMC.BackColor = System.Drawing.Color.DarkGray;
            this.lbMC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbMC.ForeColor = System.Drawing.Color.White;
            this.lbMC.Location = new System.Drawing.Point(562, 10);
            this.lbMC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMC.Name = "lbMC";
            this.lbMC.Size = new System.Drawing.Size(36, 20);
            this.lbMC.TabIndex = 40;
            this.lbMC.Text = "MC";
            this.lbMC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBBK
            // 
            this.lbBBK.BackColor = System.Drawing.Color.DarkGray;
            this.lbBBK.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBBK.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbBBK.ForeColor = System.Drawing.Color.White;
            this.lbBBK.Location = new System.Drawing.Point(643, 10);
            this.lbBBK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBBK.Name = "lbBBK";
            this.lbBBK.Size = new System.Drawing.Size(36, 20);
            this.lbBBK.TabIndex = 35;
            this.lbBBK.Text = "BBK";
            this.lbBBK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbUNC
            // 
            this.lbUNC.BackColor = System.Drawing.Color.DarkGray;
            this.lbUNC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbUNC.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbUNC.ForeColor = System.Drawing.Color.White;
            this.lbUNC.Location = new System.Drawing.Point(603, 10);
            this.lbUNC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUNC.Name = "lbUNC";
            this.lbUNC.Size = new System.Drawing.Size(36, 20);
            this.lbUNC.TabIndex = 34;
            this.lbUNC.Text = "UNC";
            this.lbUNC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIDNF
            // 
            this.lbIDNF.BackColor = System.Drawing.Color.DarkGray;
            this.lbIDNF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIDNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbIDNF.ForeColor = System.Drawing.Color.White;
            this.lbIDNF.Location = new System.Drawing.Point(520, 10);
            this.lbIDNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIDNF.Name = "lbIDNF";
            this.lbIDNF.Size = new System.Drawing.Size(36, 20);
            this.lbIDNF.TabIndex = 33;
            this.lbIDNF.Text = "IDNF";
            this.lbIDNF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbABRT
            // 
            this.lbABRT.BackColor = System.Drawing.Color.DarkGray;
            this.lbABRT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbABRT.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbABRT.ForeColor = System.Drawing.Color.White;
            this.lbABRT.Location = new System.Drawing.Point(430, 10);
            this.lbABRT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbABRT.Name = "lbABRT";
            this.lbABRT.Size = new System.Drawing.Size(36, 20);
            this.lbABRT.TabIndex = 36;
            this.lbABRT.Text = "ABRT";
            this.lbABRT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTONF
            // 
            this.lbTONF.BackColor = System.Drawing.Color.DarkGray;
            this.lbTONF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTONF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbTONF.ForeColor = System.Drawing.Color.White;
            this.lbTONF.Location = new System.Drawing.Point(390, 10);
            this.lbTONF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTONF.Name = "lbTONF";
            this.lbTONF.Size = new System.Drawing.Size(36, 20);
            this.lbTONF.TabIndex = 39;
            this.lbTONF.Text = "TONF";
            this.lbTONF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAMNF
            // 
            this.lbAMNF.BackColor = System.Drawing.Color.DarkGray;
            this.lbAMNF.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAMNF.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbAMNF.ForeColor = System.Drawing.Color.White;
            this.lbAMNF.Location = new System.Drawing.Point(350, 10);
            this.lbAMNF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAMNF.Name = "lbAMNF";
            this.lbAMNF.Size = new System.Drawing.Size(36, 20);
            this.lbAMNF.TabIndex = 38;
            this.lbAMNF.Text = "AMNF";
            this.lbAMNF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBsy
            // 
            this.lbBsy.BackColor = System.Drawing.Color.DarkGray;
            this.lbBsy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbBsy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbBsy.ForeColor = System.Drawing.Color.White;
            this.lbBsy.Location = new System.Drawing.Point(290, 10);
            this.lbBsy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbBsy.Name = "lbBsy";
            this.lbBsy.Size = new System.Drawing.Size(36, 20);
            this.lbBsy.TabIndex = 37;
            this.lbBsy.Text = "BSY";
            this.lbBsy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDrdy
            // 
            this.lbDrdy.BackColor = System.Drawing.Color.DarkGray;
            this.lbDrdy.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDrdy.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDrdy.ForeColor = System.Drawing.Color.White;
            this.lbDrdy.Location = new System.Drawing.Point(250, 10);
            this.lbDrdy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrdy.Name = "lbDrdy";
            this.lbDrdy.Size = new System.Drawing.Size(36, 20);
            this.lbDrdy.TabIndex = 28;
            this.lbDrdy.Text = "DRDY";
            this.lbDrdy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDf
            // 
            this.lbDf.BackColor = System.Drawing.Color.DarkGray;
            this.lbDf.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDf.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDf.ForeColor = System.Drawing.Color.White;
            this.lbDf.Location = new System.Drawing.Point(210, 10);
            this.lbDf.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDf.Name = "lbDf";
            this.lbDf.Size = new System.Drawing.Size(36, 20);
            this.lbDf.TabIndex = 27;
            this.lbDf.Text = "DF";
            this.lbDf.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDsc
            // 
            this.lbDsc.BackColor = System.Drawing.Color.DarkGray;
            this.lbDsc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDsc.ForeColor = System.Drawing.Color.White;
            this.lbDsc.Location = new System.Drawing.Point(170, 10);
            this.lbDsc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDsc.Name = "lbDsc";
            this.lbDsc.Size = new System.Drawing.Size(36, 20);
            this.lbDsc.TabIndex = 26;
            this.lbDsc.Text = "DSC";
            this.lbDsc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbDrq
            // 
            this.lbDrq.BackColor = System.Drawing.Color.DarkGray;
            this.lbDrq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbDrq.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbDrq.ForeColor = System.Drawing.Color.White;
            this.lbDrq.Location = new System.Drawing.Point(130, 10);
            this.lbDrq.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDrq.Name = "lbDrq";
            this.lbDrq.Size = new System.Drawing.Size(36, 20);
            this.lbDrq.TabIndex = 29;
            this.lbDrq.Text = "DRQ";
            this.lbDrq.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCorr
            // 
            this.lbCorr.BackColor = System.Drawing.Color.DarkGray;
            this.lbCorr.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCorr.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbCorr.ForeColor = System.Drawing.Color.White;
            this.lbCorr.Location = new System.Drawing.Point(90, 10);
            this.lbCorr.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCorr.Name = "lbCorr";
            this.lbCorr.Size = new System.Drawing.Size(36, 20);
            this.lbCorr.TabIndex = 32;
            this.lbCorr.Text = "CORR";
            this.lbCorr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbIdx
            // 
            this.lbIdx.BackColor = System.Drawing.Color.DarkGray;
            this.lbIdx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbIdx.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbIdx.ForeColor = System.Drawing.Color.White;
            this.lbIdx.Location = new System.Drawing.Point(50, 10);
            this.lbIdx.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIdx.Name = "lbIdx";
            this.lbIdx.Size = new System.Drawing.Size(36, 20);
            this.lbIdx.TabIndex = 31;
            this.lbIdx.Text = "IDX";
            this.lbIdx.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbEror
            // 
            this.lbEror.BackColor = System.Drawing.Color.DarkGray;
            this.lbEror.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbEror.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbEror.ForeColor = System.Drawing.Color.White;
            this.lbEror.Location = new System.Drawing.Point(10, 10);
            this.lbEror.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEror.Name = "lbEror";
            this.lbEror.Size = new System.Drawing.Size(36, 20);
            this.lbEror.TabIndex = 30;
            this.lbEror.Text = "ERR";
            this.lbEror.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmMain
            // 
            this.tmMain.Enabled = true;
            this.tmMain.Tick += new System.EventHandler(this.tmMain_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.hDDToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 30;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.setPortToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // setPortToolStripMenuItem
            // 
            this.setPortToolStripMenuItem.Name = "setPortToolStripMenuItem";
            this.setPortToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.setPortToolStripMenuItem.Text = "Set_Ports";
            this.setPortToolStripMenuItem.Click += new System.EventHandler(this.setPortToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // hDDToolStripMenuItem
            // 
            this.hDDToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seagateToolStripMenuItem,
            this.singleCommandToolStripMenuItem1,
            this.loopCommandsToolStripMenuItem1,
            this.createImageToolStripMenuItem,
            this.wipeHddToolStripMenuItem,
            this.sofTResetToolStripMenuItem});
            this.hDDToolStripMenuItem.Name = "hDDToolStripMenuItem";
            this.hDDToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.hDDToolStripMenuItem.Text = "HDD";
            // 
            // seagateToolStripMenuItem
            // 
            this.seagateToolStripMenuItem.Name = "seagateToolStripMenuItem";
            this.seagateToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.seagateToolStripMenuItem.Text = "Script";
            this.seagateToolStripMenuItem.Click += new System.EventHandler(this.seagateToolStripMenuItem_Click);
            // 
            // singleCommandToolStripMenuItem1
            // 
            this.singleCommandToolStripMenuItem1.Name = "singleCommandToolStripMenuItem1";
            this.singleCommandToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.singleCommandToolStripMenuItem1.Text = "SingleCommand";
            this.singleCommandToolStripMenuItem1.Click += new System.EventHandler(this.singleCommandToolStripMenuItem_Click);
            // 
            // loopCommandsToolStripMenuItem1
            // 
            this.loopCommandsToolStripMenuItem1.Name = "loopCommandsToolStripMenuItem1";
            this.loopCommandsToolStripMenuItem1.Size = new System.Drawing.Size(163, 22);
            this.loopCommandsToolStripMenuItem1.Text = "LoopCommands";
            this.loopCommandsToolStripMenuItem1.Click += new System.EventHandler(this.loopCommandsToolStripMenuItem_Click);
            // 
            // createImageToolStripMenuItem
            // 
            this.createImageToolStripMenuItem.Name = "createImageToolStripMenuItem";
            this.createImageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.createImageToolStripMenuItem.Text = "CreateImage";
            this.createImageToolStripMenuItem.Click += new System.EventHandler(this.createImageToolStripMenuItem_Click);
            // 
            // wipeHddToolStripMenuItem
            // 
            this.wipeHddToolStripMenuItem.Name = "wipeHddToolStripMenuItem";
            this.wipeHddToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.wipeHddToolStripMenuItem.Text = "Wipe Hdd";
            this.wipeHddToolStripMenuItem.Click += new System.EventHandler(this.wipeHddToolStripMenuItem_Click);
            // 
            // sofTResetToolStripMenuItem
            // 
            this.sofTResetToolStripMenuItem.Name = "sofTResetToolStripMenuItem";
            this.sofTResetToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.sofTResetToolStripMenuItem.Text = "Soft Reset";
            this.sofTResetToolStripMenuItem.Click += new System.EventHandler(this.sofTResetToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monitoringToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // monitoringToolStripMenuItem
            // 
            this.monitoringToolStripMenuItem.Name = "monitoringToolStripMenuItem";
            this.monitoringToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monitoringToolStripMenuItem.Text = "Monitoring";
            this.monitoringToolStripMenuItem.Click += new System.EventHandler(this.monitoringToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 92);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "HddRepairTools";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbBBK;
        private System.Windows.Forms.Label lbUNC;
        private System.Windows.Forms.Label lbIDNF;
        private System.Windows.Forms.Label lbABRT;
        private System.Windows.Forms.Label lbTONF;
        private System.Windows.Forms.Label lbAMNF;
        private System.Windows.Forms.Label lbBsy;
        private System.Windows.Forms.Label lbDrdy;
        private System.Windows.Forms.Label lbDf;
        private System.Windows.Forms.Label lbDsc;
        private System.Windows.Forms.Label lbDrq;
        private System.Windows.Forms.Label lbCorr;
        private System.Windows.Forms.Label lbIdx;
        private System.Windows.Forms.Label lbEror;
        private System.Windows.Forms.Timer tmMain;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hDDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seagateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sofTResetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitoringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleCommandToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loopCommandsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem wipeHddToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setPortToolStripMenuItem;
        private System.Windows.Forms.Label lbMC;
        private System.Windows.Forms.Label lbMCR;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

    }
}

