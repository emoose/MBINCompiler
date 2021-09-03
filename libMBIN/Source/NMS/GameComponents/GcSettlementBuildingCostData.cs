using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xAA8C15FCCE08DE5C, NameHash = 0x1746DC1EE79AD525)]
    public class GcSettlementBuildingCostData : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> Products;
        /* 0x10 */ public List<NMSString0x10> Substances;
        /* 0x20 */ public int AmountMin;
        /* 0x24 */ public int AmountMax;
        /* 0x28 */ public GcCurrency Currency;
    }
}
