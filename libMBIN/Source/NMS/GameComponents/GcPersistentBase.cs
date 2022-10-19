using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xE27CE1A9C1BDC8D, NameHash = 0x732552199A3AE45E)]
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
        /* 0x050 */ public NMSString0x40 RID;
        /* 0x090 */ public GcDiscoveryOwner Owner;
        /* 0x194 */ public NMSString0x40 Name;
        /* 0x1D4 */ public GcPersistentBaseTypes BaseType;
        /* 0x1D8 */ public NMSString0x40 LastEditedById;
        /* 0x218 */ public NMSString0x40 LastEditedByUsername;
        /* 0x260 */ public Vector3f ScreenshotAt;
        /* 0x270 */ public Vector3f ScreenshotPos;
        /* 0x280 */ public GcGameMode GameMode;
        /* 0x284 */ public GcPersistentBaseDifficultyData Difficulty;
        /* 0x28C */ public NMSString0x20 PlatformToken;
        /* 0x2AC */ public bool IsReported;
        /* 0x2AD */ public bool IsFeatured;
        /* 0x2B0 */ public GcBaseAutoPowerSetting AutoPowerSetting;
    }
}
