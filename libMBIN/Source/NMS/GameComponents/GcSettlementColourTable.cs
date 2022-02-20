using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x20, GUID = 0xFC68DE12DB070C98, NameHash = 0x4EF075AF93525886)]
    public class GcSettlementColourTable : NMSTemplate
    {
        /* 0x00 */ public List<GcSettlementColourPalette> SettlementColourPalettes;
        /* 0x10 */ public List<NMSString0x10> DecorationPartIds;
    }
}
