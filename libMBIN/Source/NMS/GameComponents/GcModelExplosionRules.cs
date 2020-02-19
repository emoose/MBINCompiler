using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x38, GUID = 0x15D9B1C6608A7093, NameHash = 0xD04C1E382833D93A)]
    public class GcModelExplosionRules : NMSTemplate
    {
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x10 */ public bool[] UseRules;
        [NMS(Size = 0x8, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        /* 0x18 */ public float[] ShipSalvageDisplayScales;
    }
}
