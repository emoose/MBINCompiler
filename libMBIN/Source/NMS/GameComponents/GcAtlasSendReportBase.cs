using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0xB0, GUID = 0xC169B8462CFC2AA, NameHash = 0x6F1ACEDC735249A3)]
    public class GcAtlasSendReportBase : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x08 */ public byte[] Padding8;
        /* 0x10 */ public List<byte> Image;  // Just a dummy type. This will be the actual image data.
        [NMS(Size = 0x40)]
        /* 0x20 */ public string RID;
        /* 0x60 */ public ulong UniverseAddress;
        [NMS(Size = 0x20)]
        /* 0x68 */ public string RL;
        [NMS(Size = 0x40)]
        /* 0x88 */ public string RC;
        /* 0xA8 */ public GcGameMode GameMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0xAC */ public byte[] EndPadding;
    }
}
