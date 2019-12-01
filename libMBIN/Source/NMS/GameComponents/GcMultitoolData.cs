using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1C0, GUID = 0x17629525A1046D19, NameHash = 0x2AF78E5732410B4F)]
    public class GcMultitoolData : NMSTemplate
    {
        /* 0x000 */ public GcInventoryLayout Layout;
        /* 0x020 */ public GcInventoryContainer Store;
        /* 0x180 */ public GcSeed Seed;
        [NMS(Size = 0x20)]
        /* 0x190 */ public string Name;
        /* 0x1B0 */ public bool IsLarge;
        /* 0x1B4 */ public int PrimaryMode;
        /* 0x1B8 */ public int SecondaryMode;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x1BC */ public byte[] EndPadding;

    }
}
