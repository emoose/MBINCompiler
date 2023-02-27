using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC1F1ACCCA4FC2658, NameHash = 0x13017671947A0ACE)]
    public class GcFrigateFlybyTable : NMSTemplate
    {
        /* 0x0 */ public List<GcFrigateFlybyLayout> Entries;
    }
}
