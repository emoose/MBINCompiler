using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A7AAA1BDEE5FD13, NameHash = 0x8E6FF744E499EB49)]
    public class GcRepShopItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 ProductID;
        /* 0x10 */ public int AmountForSale;
        /* 0x14 */ public float PriceMul;
        /* 0x18 */ public GcCurrency Currency;
        /* 0x1C */ public int RepLevelRequired;
        /* 0x20 */ public List<NMSString0x10> AltIDs;
    }
}
