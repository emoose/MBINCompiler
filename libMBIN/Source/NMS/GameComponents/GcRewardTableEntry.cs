using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5C2DDDAB461EB03C, NameHash = 0x29C1A8399A70F9A7)]
    public class GcRewardTableEntry : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Id;
        // size: 0x3
        public enum RaritiesEnum {
            Common,
            Uncommon,
            Rare
        }
        [NMS(Size = 0x3, EnumType = typeof(RaritiesEnum))]
        /* 0x10 */ public GcRewardTableCategory[] Rarities;
    }
}
