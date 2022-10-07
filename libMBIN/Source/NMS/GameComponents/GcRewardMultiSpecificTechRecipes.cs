using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9BFC41781EFDBF3, NameHash = 0x345E30DE4D2B5AAC)]
    public class GcRewardMultiSpecificTechRecipes : NMSTemplate
    {
        /* 0x00 */ public List<NMSString0x10> TechIds;
        /* 0x10 */ public NMSString0x10 DisplayTechId;
        /* 0x20 */ public NMSString0x20A SetName;
        /* 0x40 */ public bool Silent;
    }
}
