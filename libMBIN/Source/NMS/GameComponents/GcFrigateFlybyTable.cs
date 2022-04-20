using System;
using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x10, GUID = 0x7023211B438D118F, NameHash = 0x13017671947A0ACE)]
    public class GcFrigateFlybyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcFrigateFlybyLayout> Entries;
    }
}
