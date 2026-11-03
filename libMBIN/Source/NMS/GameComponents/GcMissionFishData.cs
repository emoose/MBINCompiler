using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B05EC0A728F4F4D, NameHash = 0x3F175026)]
    public class GcMissionFishData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public List<NMSString0x10> SpecificFish;
        [NMS(Index = 1)]
        /* 0x10 */ public GcItemQuality Quality;
        [NMS(Index = 2)]
        /* 0x14 */ public GcFishSize Size;
        [NMS(Index = 3)]
        /* 0x18 */ public GcFishingTime Time;
        [NMS(Index = 4, Size = 0x11, EnumType = typeof(GcBiomeType.BiomeEnum))]
        /* 0x1C */ public bool[] Biome;
        [NMS(Index = 5)]
        /* 0x2D */ public bool NeedsStorm;
    }
}
