using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x36B82D25F9A1E453, NameHash = 0x342750A176F374A4)]
    public class GcGroupCondition : NMSTemplate
    {
        /* 0x00 */ public List<NMSTemplate> Conditions;
        /* 0x10 */ public bool ORConditions;
    }
}
