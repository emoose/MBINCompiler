namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xACFC6629DFF3384E, NameHash = 0xEC05D45E23EDDB7A)]
    public class GcPetTraitMoodModifier : NMSTemplate
    {
        /* 0x0 */ public float TraitMin;
        /* 0x4 */ public float TraitMax;
        /* 0x8 */ public float MoodIncreaseMultiplierMin;
        /* 0xC */ public float MoodIncreaseMultiplierMax;
    }
}
