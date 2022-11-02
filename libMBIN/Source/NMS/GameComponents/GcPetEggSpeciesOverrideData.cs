namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5933CBCC07E5645D, NameHash = 0x66A7186A5DDD202A)]
    public class GcPetEggSpeciesOverrideData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 CreatureID;
        /* 0x10 */ public bool CanChangeGrowth;
        /* 0x11 */ public bool CanChangeAccessories;
        /* 0x12 */ public bool CanChangeColour;
        /* 0x13 */ public bool CanChangeTraits;
        /* 0x14 */ public float MinScaleOverride;
        /* 0x18 */ public float MaxScaleOverride;
    }
}
