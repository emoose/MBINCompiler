using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2B8FF3141B08E3FD, NameHash = 0xC152744D)]
    public class GcSettlementJobGiftDetails : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x00 */ public NMSString0x20A GiftItemLoc;
        [NMS(Index = 2)]
        /* 0x20 */ public List<NMSString0x10> PotentialGiftItems;
        [NMS(Index = 1)]
        /* 0x30 */ public int GiftAmount;
        [NMS(Index = 6)]
        /* 0x34 */ public GcProceduralProductCategory ProcProductType;
        [NMS(Index = 5)]
        /* 0x38 */ public bool GiveProcProduct;
        [NMS(Index = 4)]
        /* 0x39 */ public bool GiveStanding;
        [NMS(Index = 3)]
        /* 0x3A */ public bool GiveWords;
    }
}
