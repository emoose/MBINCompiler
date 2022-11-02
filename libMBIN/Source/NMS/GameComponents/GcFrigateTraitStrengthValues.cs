namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x10E27EC7E986E972, NameHash = 0xED358CC87699CBEA)]
    public class GcFrigateTraitStrengthValues : NMSTemplate
    {
        [NMS(Size = 0xA, EnumType = typeof(GcFrigateTraitStrength.FrigateTraitStrengthEnum))]
        /* 0x00 */ public int[] StatAlteration;
        /* 0x28 */ public NMSString0x20A StatLocID;
        /* 0x48 */ public bool StatDisplaysPositive;
    }
}
