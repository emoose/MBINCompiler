using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5DEF8A009E7701A2, NameHash = 0x91295D57)]
    public class GcFrigateTraitData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public NMSString0x20A DisplayName;
        [NMS(Index = 0)]
        /* 0x20 */ public NMSString0x10 ID;
        [NMS(Index = 4, Size = 0xB, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x30 */ public int[] ChanceOfBeingOffered;
        [NMS(Index = 2)]
        /* 0x5C */ public GcFrigateStatType FrigateStatType;
        [NMS(Index = 3)]
        /* 0x60 */ public GcFrigateTraitStrength Strength;
    }
}
