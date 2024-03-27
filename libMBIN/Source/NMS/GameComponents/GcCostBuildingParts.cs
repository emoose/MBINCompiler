using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x96F0AF27135C9BEA, NameHash = 0x61447A1079C43833)]
    public class GcCostBuildingParts : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A Description;
        /* 0x20 */ public List<GcBuildingCostPartCount> RequiredParts;
    }
}
