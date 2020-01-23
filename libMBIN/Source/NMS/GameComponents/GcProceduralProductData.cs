using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x850, GUID = 0x1BD7B95BCD6CDDFC, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3)]
        /* 0x440 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x818 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x84C */ public byte[] EndPadding;
    }
}
