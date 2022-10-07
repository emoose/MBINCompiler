using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x591C500E877541C8, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryLayout Layout;
        /* 0x020 */ public GcInventoryContainer Store;
        /* 0x178 */ public GcSeed Seed;
        /* 0x188 */ public NMSString0x20 Name;
        /* 0x1A8 */ public bool IsLarge;
        /* 0x1AC */ public int PrimaryMode;
        /* 0x1B0 */ public int SecondaryMode;
        /* 0x1B4 */ public bool UseLegacyColours;
        /* 0x1B8 */ public GcResourceElement Resource;
    }
}
