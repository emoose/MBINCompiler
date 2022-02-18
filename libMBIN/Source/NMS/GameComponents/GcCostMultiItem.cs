using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x30, GUID = 0xAADEC9ADF54D1CEC, NameHash = 0x8753450A435B1BC5)]
    public class GcCostMultiItem : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A DisplayLocID;
        /* 0x20 */ public List<GcItemAmountCostPair> ItemList;
    }
}
