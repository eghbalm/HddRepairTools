using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace HddRepairTools
{
    public enum MEDIA_TYPE
    {
        Unknown,
        F5_1Pt2_512,
        F3_1Pt44_512,
        F3_2Pt88_512,
        F3_20Pt8_512,
        F3_720_512,
        F5_360_512,
        F5_320_512,
        F5_320_1024,
        F5_180_512,
        F5_160_512,
        RemovableMedia,
        FixedMedia,
        F3_120M_512,
        F3_640_512,
        F5_640_512,
        F5_720_512,
        F3_1Pt2_512,
        F3_1Pt23_1024,
        F5_1Pt23_1024,
        F3_128Mb_512,
        F3_230Mb_512,
        F8_256_128,
        F3_200Mb_512,
        F3_240M_512,
        F3_32M_512
    };

    [StructLayout(LayoutKind.Sequential)]
    public class IDSECTOR
    {    
        public short GenConfig;//0
        public short NumberCylinders;//1
        public short Reserved_2;//2
        public short NumberHeads;//3
        public short BytesPerTrack;//4
        public short BytesPerSector;//5
        public short SectorsPerTrack;//6
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 6)]
        public byte[] VendorUnique;//7-9
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
        public char[] SerialNumber;//10-19
        public short BufferClass;//20
        public short BufferSize;//21
        public short ECCSize;//22
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public char[] FirmwareRevision;//23-26
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 40)]
        public char[] ModelNumber;//27-46
        public short MoreVendorUnique;//47
        public short DoubleWordIO;//48
        public short Capabilities;//49
        public short Reserved_50;//50
        public short PIOTiming;//51
        public short DMATiming;//52
        public short BS;//53
        public short NumberCurrentCyls;//54
        public short NumberCurrentHeads;//55
        public short NumberCurrentSectorsPerTrack;//56
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] CurrentSectorCapacity;//57-58
        public short MultipleSectorCapacity;//59
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] TotalAddressableSectors;//60-61
        public short SingleWordDMA;//62
        public short MultiWordDMA;//63
        public short PIO_Transfer_Modes;//64
        public short MinimumMultiwordDMAtransfer;//65
        public short Multiword_DMA_Transfer;//66
        public short MinimumPIO;//67
        public short MinimumPIO_IORDY;//68
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] Reserved_69_74;
        public short Queue_depth;//75
        public short Serial_ATA_capabilities;//76
        public short future_Serial_ATA_definition;//77
        public short Serial_ATA_features_supported;//78
        public short Serial_ATA_features_enabled;//79
        public short MajorVersionNumber;//80
        public short MinorVersionNumber;//81
        public short CommandSetSupported;//82
        public short CommandSetsSupported;//83
        public short CommandSetsSupported_extension;//84
        public short Command_set_enabled;//85
        public short Command_sets_enabled;//86
        public short Command_sets_enable_extension;//87
        public short Ultra_DMA_support; //88
        public short Security_erase_time;//89
        public short Enhanced_security_erase_time;//90
        public short Reserved_91;//91
        public short Master_password_revision_code;//92
        public short Hardware_Reset_Value;//93
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 12)]
        public byte[] Reserved_95_99;//95-99
        public UInt64 Total_LBA_Sectors;//100-103
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] Reserved_104_107;//104-107
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] WWN;//108-111
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
        public byte[] Reserved_112_127;//112-127
        public short SecurityStatus;//128
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 62)]
        public byte[] VendorSpecific_129_159;//129-159
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 190)]
        public byte[] Reserved160_254;//160-254
        public short Integrity_Word;//255
    }
   
}
