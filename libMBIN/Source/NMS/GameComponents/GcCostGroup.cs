using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xFFA05D47FCFE6523, NameHash = 0x7C18FEA6826DCAF8)]
    public class GcCostGroup : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Text;
        /* 0x20 */ public GcMissionConditionTest Test;
        /* 0x28 */ public List<NMSTemplate> Costs;
    }
}
