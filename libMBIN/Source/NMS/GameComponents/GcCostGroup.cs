using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x24B9F5EACBDAE065, NameHash = 0x7C18FEA6826DCAF8)]
    public class GcCostGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public int TakeTextFromIndex;
        /* 0x24 */ public int HideOptionIfCantAffordIndex;
        /* 0x28 */ public GcMissionConditionTest Test;
        /* 0x30 */ public List<NMSTemplate> Costs;
    }
}
