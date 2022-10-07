using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD746AFF35025FAAD, NameHash = 0xD04C1E382833D93A)]
    public class GcModelExplosionRules : NMSTemplate
    {
        /* 0x00 */ public List<GcModelExplosionRule> Rules;
        // size: 0x9
        public enum UseRulesEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(UseRulesEnum))]
        /* 0x10 */ public bool[] UseRules;
        // size: 0x9
        public enum ShipSalvageDisplayScalesEnum {
            Freighter,
            Dropship,
            Fighter,
            Scientific,
            Shuttle,
            PlayerFreighter,
            Royal,
            Alien,
            Sail
        }
        [NMS(Size = 0x9, EnumType = typeof(ShipSalvageDisplayScalesEnum))]
        /* 0x1C */ public float[] ShipSalvageDisplayScales;
    }
}
