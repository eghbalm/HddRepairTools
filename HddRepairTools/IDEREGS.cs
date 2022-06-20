using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HddRepairTools
{
    public class IDEREGS
    {
        public UInt32 Features;
        public UInt32 SectorCount;
        public UInt32 SectorNumber;
        public UInt32 CylinderLow;
        public UInt32 CylinderHigh;
        public UInt32 DriveHead;
        public UInt32 Command;
        public UInt32 Reserved;
        public IDEREGS()
        {
            Features = 0x00;
            SectorCount = 0x00;
            SectorNumber = 0x00;
            CylinderLow = 0x00;
            CylinderHigh = 0x00;
            DriveHead = 0x00;
            Command = 0x00;
            Reserved = 0x00;
        }
        public IDEREGS(UInt32 features, UInt32 sectorCount, UInt32 sectorNumber, UInt32 cylinderLow, UInt32 cylinderHigh, UInt32 driveHead, UInt32 command)
        {
            Features = features;
            SectorCount = sectorCount;
            SectorNumber = sectorNumber;
            CylinderLow = cylinderLow;
            CylinderHigh = cylinderHigh;
            DriveHead = driveHead;
            Command = command;
            Reserved = 0x00;
        }
    }
}
