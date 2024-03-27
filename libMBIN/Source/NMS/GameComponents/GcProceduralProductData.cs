using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x66F45FF706744E95, NameHash = 0xC449167C8DE081CD)]
    public class GcProceduralProductData : NMSTemplate
    {
        /* 0x000 */ public GcNameGeneratorWord NameGeneratorBase;
        /* 0x028 */ public List<GcProceduralProductWord> NameGeneratorWordList;
        /* 0x038 */ public int NameGeneratorLegacyRolls;
        /* 0x040 */ public GcProductData Product;
        [NMS(Size = 0x3, EnumType = typeof(GcRarity.RarityEnum))]
        /* 0x470 */ public GcProductProceduralOnlyData[] ProceduralData;
        /* 0x848 */ public GcBiomeList PerBiomeDropWeights;
        /* 0x8C8 */ public NMSString0x20 DeployableProductID;
        /* 0x8E8 */ public bool RecordsStat;
    }
}
