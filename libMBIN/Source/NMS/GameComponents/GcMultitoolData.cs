using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC092FFBBEDDE625C, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryLayout Layout;
        /* 0x020 */ public GcInventoryContainer Store;
        /* 0x180 */ public GcInWorldUIScreenData ScreenData;
        /* 0x1B0 */ public GcSeed Seed;
        /* 0x1C0 */ public NMSString0x20 Name;
        /* 0x1E0 */ public bool IsLarge;
        /* 0x1E4 */ public int PrimaryMode;
        /* 0x1E8 */ public int SecondaryMode;
        /* 0x1EC */ public bool UseLegacyColours;
        /* 0x1F0 */ public GcResourceElement Resource;
    }
}
