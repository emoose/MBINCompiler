using System.Collections.Generic;
using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8C0, GUID = 0xF669A3A10258DF92, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        [NMS(Size = 0x4, Ignore = true)]
        /* 0x03C */ public byte[] Padding3C;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x440 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x818 */ public GcBiomeList PerBiomeDropWeights;
        [NMS(Size = 0x20)]
        /* 0x898 */ public string DeployableProductID;
        [NMS(Size = 0x8, Ignore = true)]
        /* 0x8B8 */ public byte[] EndPadding;
    }
}
