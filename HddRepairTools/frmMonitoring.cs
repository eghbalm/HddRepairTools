using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HddRepairTools
{
    public unsafe partial class frmMonitoring : Form
    {
        PortIo pi;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public frmMonitoring(PortIo p)
        {
            pi = p;
            InitializeComponent();
        }
        private string getNormalCount(string str)
        {
            string str1 = "";

            if (str.Length > 2)
            {
                str1 = str.Substring(str.Length - 2, 2);
            }
            else
            {
                str1 = str;
            }
            if (str1.Length == 1)
            {
                str1 = "0" + str1;
            }
            return str1;
        }
        private void Monitorings()
        {
            uint Features;
            uint SectorCount;
            uint SectorNumber;
            uint CylinderLow;
            uint CylinderHigh;
            uint DriveHead;
            uint Command;
            Features = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 1), &Features, 1);
            mon1.Text = getNormalCount(Features.ToString("x"));
            SectorCount = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 2), &SectorCount, 1);
            mon2.Text =  getNormalCount(SectorCount.ToString("x"));
            SectorNumber = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 3), &SectorNumber, 1);
            mon3.Text =  getNormalCount(SectorNumber.ToString("x"));
            CylinderLow = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 4), &CylinderLow, 1);
            mon4.Text =  getNormalCount(CylinderLow.ToString("x"));
            CylinderHigh = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 5), &CylinderHigh, 1);
            mon5.Text =  getNormalCount(CylinderHigh.ToString("x"));
            DriveHead = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 6), &DriveHead, 1);
            mon6.Text =  getNormalCount(DriveHead.ToString("x"));
            Command = 0;
            pi.WI.GetPortValue((UInt16)(pi.GetPortIO() + 7), &Command, 1);
            mon7.Text = getNormalCount(Command.ToString("x"));
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            Monitorings();
        }
        private void frmMonitoring_Shown(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void frmMonitoring_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }
        private void frmMonitoring_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        private void frmMonitoring_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void frmMonitoring_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void frmMonitoring_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void frmMonitoring_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }


    }
}
