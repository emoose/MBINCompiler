using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x830, GUID = 0xBB6A74EA89F6BCC)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcNameGeneratorWord> NameGeneratorWordList;     // a guess for now...
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3)]
        /* 0x420 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x7F8 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x82C */ public byte[] EndPadding;
    }
}
