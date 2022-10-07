namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x41793B4468575F6D, NameHash = 0x4A16D2127CA95139)]
    public class GcItemPriceModifiers : NMSTemplate
    {
        /* 0x00 */ public float SpaceStationMarkup;
        /* 0x04 */ public float LowPriceMod;
        /* 0x08 */ public float HighPriceMod;
        /* 0x0C */ public float BuyBaseMarkup;
        /* 0x10 */ public float BuyMarkupMod;
    }
}
