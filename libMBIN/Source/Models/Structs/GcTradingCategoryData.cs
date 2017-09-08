namespace libMBIN.Models.Structs
{
    public class GcTradingCategoryData : NMSTemplate       // size: 0xCC
    {
        [NMS(Size = 0x40)]
        /* 0x00 */ public string Name;
        /* 0x40 */ public TkTextureResource Icon;
        /* 0xC4 */ public float ProductMultiplierChangePer100;
        /* 0xC8 */ public float SubstanceMultiplierChangePer100;
    }
}
