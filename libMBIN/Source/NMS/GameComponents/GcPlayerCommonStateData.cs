using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7177110DFC9D0A2D, NameHash = 0x4C060D5780D187B4)]
    public class GcPlayerCommonStateData : NMSTemplate
    {
        /* 0x0000 */ public NMSString0x80 SaveName;
        /* 0x0080 */ public ulong TotalPlayTime;
        /* 0x0088 */ public bool UsesThirdPersonCharacterCam;
        /* 0x0089 */ public bool UsesThirdPersonVehicleCam;
        /* 0x008A */ public bool UsesThirdPersonShipCam;
        /* 0x0090 */ public GcPhotoModeSettings PhotoModeSettings;
        /* 0x00E0 */ public GcByteBeatLibraryData ByteBeatLibrary;
        /* 0x1AE8 */ public GcSeasonalGameModeData SeasonData;
        /* 0x5300 */ public GcSeasonStateData SeasonState;
        /* 0x54B8 */ public GcSeasonTransferInventoryData SeasonTransferInventoryData;
        /* 0x5638 */ public List<NMSString0x10> EarnedSeasonSpecialRewards;
    }
}
