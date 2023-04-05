using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xAD5C422AB3BBA1A8, NameHash = 0x4EF075AF93525886)]
    public class GcSettlementColourTable : NMSTemplate
    {
        /* 0x00 */ public List<GcSettlementColourPalette> SettlementColourPalettes;
        /* 0x10 */ public List<NMSString0x10> DecorationPartIds;
    }
}
