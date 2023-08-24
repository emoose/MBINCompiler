using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x68EAE24C2E8728C5, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryLayout Layout;
        /* 0x020 */ public GcInventoryContainer Store;
        /* 0x180 */ public GcInWorldUIScreenData ScreenData;
        /* 0x1B0 */ public GcSeed Seed;
        /* 0x1C0 */ public GcCharacterCustomisationData CustomisationData;
        /* 0x208 */ public NMSString0x20 Name;
        /* 0x228 */ public bool IsLarge;
        /* 0x22C */ public int PrimaryMode;
        /* 0x230 */ public int SecondaryMode;
        /* 0x234 */ public bool UseLegacyColours;
        /* 0x238 */ public GcResourceElement Resource;
    }
}
