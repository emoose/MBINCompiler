using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x2B0, GUID = 0x5E0E25484FBF35DB, NameHash = 0x732552199A3AE45E)]
    public class GcPersistentBase : NMSTemplate
    {
        /* 0x000 */ public int BaseVersion;
        /* 0x004 */ public int OriginalBaseVersion;
        /* 0x008 */ public ulong GalacticAddress;
        /* 0x010 */ public Vector3f Position;
        /* 0x020 */ public Vector3f Forward;
        /* 0x030 */ public ulong UserData;
        /* 0x038 */ public ulong LastUpdateTimestamp;
        /* 0x040 */ public List<GcPersistentBaseEntry> Objects;

        [NMS(Size = 0x40)]
        /* 0x050 */ public string RID;
        /* 0x090 */ public GcDiscoveryOwner Owner;
        [NMS(Size = 0x40)]
        /* 0x194 */ public string Name;
        /* 0x1D4 */ public GcPersistentBaseTypes BaseType;
        [NMS(Size = 0x40)]
        /* 0x1D8 */ public string LastEditedById;
        [NMS(Size = 0x40)]
        /* 0x218 */ public string LastEditedByUsername;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x258 */ public byte[] Padding0x258;
        /* 0x260 */ public Vector3f ScreenshotAt;
        /* 0x270 */ public Vector3f ScreenshotPos;
        /* 0x280 */ public GcGameMode GameMode;
        [NMS(Size = 0x20)]
        /* 0x284 */ public string PlatformToken;
        /* 0x2A4 */ public bool IsReported;
        /* 0x2A5 */ public bool IsFeatured;
        [NMS(Size = 0xA, Ignore = true)]
        /* 0x2A6 */ public byte[] EndPadding;
    }
}
