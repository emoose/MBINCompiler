using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x805BE04CC0D02E63, NameHash = 0x7208477F)]
    public class GcFishSizeProbabilityBiomeOverride : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcFishSize.FishSizeEnum))]
        /* 0x00 */ public GcFishSizeProbability[] SizeWeights;
        [NMS(Index = 0)]
        /* 0x40 */ public GcBiomeType Biome;
    }
}
