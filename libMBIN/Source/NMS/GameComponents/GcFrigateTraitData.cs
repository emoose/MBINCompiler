using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB182431F45859CBA, NameHash = 0x3A526CC4024569BA)]
    public class GcFrigateTraitData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A DisplayName;
        /* 0x30 */ public GcFrigateStatType FrigateStatType;
        /* 0x34 */ public GcFrigateTraitStrength Strength;
        // size: 0x8
        public enum ChanceOfBeingOfferedEnum {
            Combat,
            Exploration,
            Mining,
            Diplomacy,
            Support,
            Normandy,
            DeepSpace,
            DeepSpaceCommon
        }
        [NMS(Size = 0x8, EnumType = typeof(ChanceOfBeingOfferedEnum))]
        /* 0x38 */ public int[] ChanceOfBeingOffered;
    }
}
