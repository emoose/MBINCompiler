namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x4D99FFC8B020A397, NameHash = 0x23B0CB2EF86A7A9A)]
    public class TkShearWindOctaveData : NMSTemplate
    {
        /* 0x00 */ public float MinStrength;
        /* 0x04 */ public float MaxStrength;
        /* 0x08 */ public float StrengthVariationFreq;
        /* 0x0C */ public float WaveSize;
        /* 0x10 */ public float WaveFrequency;
    }
}
