using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7AA39AA605D99EBD, NameHash = 0x3A526CC4024569BA)]
    public class GcFrigateTraitData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ID;
        /* 0x10 */ public NMSString0x20A DisplayName;
        /* 0x30 */ public GcFrigateStatType FrigateStatType;
        /* 0x34 */ public GcFrigateTraitStrength Strength;
        [NMS(Size = 0x9, EnumType = typeof(GcFrigateClass.FrigateClassEnum))]
        /* 0x38 */ public int[] ChanceOfBeingOffered;
    }
}
