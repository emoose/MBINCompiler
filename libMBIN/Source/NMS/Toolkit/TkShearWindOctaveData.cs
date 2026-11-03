namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xA809DEF94D02F48E, NameHash = 0xAF905FAD)]
    public class TkShearWindOctaveData : NMSTemplate
    {
        [NMS(Index = 1)]
        /* 0x00 */ public float MaxStrength;
        [NMS(Index = 0)]
        /* 0x04 */ public float MinStrength;
        [NMS(Index = 2)]
        /* 0x08 */ public float StrengthVariationFreq;
        [NMS(Index = 4)]
        /* 0x0C */ public float WaveFrequency;
        [NMS(Index = 3)]
        /* 0x10 */ public float WaveSize;
    }
}
