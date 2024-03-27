using System;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2D148480DFB092DA, NameHash = 0x1B2443FC607CC2A)]
    public class GcRegionHotspotTypes : NMSTemplate
    {
        // size: 0x6
        [Flags]
        public enum HotspotTypeEnum : uint {
            Power = 0x1,
            Mineral1 = 0x2,
            Mineral2 = 0x4,
            Mineral3 = 0x8,
            Gas1 = 0x10,
            Gas2 = 0x20,
        }
        /* 0x0 */ public HotspotTypeEnum HotspotType;
    }
}
