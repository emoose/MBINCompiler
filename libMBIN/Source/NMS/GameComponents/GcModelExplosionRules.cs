using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0x15D9B1C6608A7093, NameHash = 0xD04C1E382833D93A)]
    // In global??
    public class GcModelExplosionRules : NMSTemplate
    {
        public List<GcModelExplosionRule> Rules;
        [NMS(Size = 0x7, EnumType = typeof(GcSpaceshipClasses.ShipClassEnum))]
        public float[] ShipSalvageDisplayScales;
        [NMS(Size = 0x4, Ignore = true)]
        public byte[] EndPadding;
    }
}
