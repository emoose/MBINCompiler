using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x237BE1FB5877A276, NameHash = 0x72703AC399E3162F)]
    public class GcRewardDestructRarities : NMSTemplate
    {
        // size: 0x3
        public enum RaritiesEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(RaritiesEnum))]
        /* 0x0 */ public GcRewardDestructEntry[] Rarities;
    }
}
