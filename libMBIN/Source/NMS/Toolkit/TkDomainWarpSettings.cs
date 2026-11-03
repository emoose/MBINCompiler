namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x5C3C9C335970B5E7, NameHash = 0x1E41D395)]
    public class TkDomainWarpSettings : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public float FeatureSize;
        [NMS(Index = 4)]
        /* 0x04 */ public float FractalGain;
        [NMS(Index = 3)]
        /* 0x08 */ public float FractalLacunarity;
        [NMS(Index = 2)]
        /* 0x0C */ public int FractalOctaves;
        [NMS(Index = 5)]
        /* 0x10 */ public float FractalWeightedStrength;
        [NMS(Index = 1)]
        /* 0x14 */ public float WarpAmplitude;
    }
}
