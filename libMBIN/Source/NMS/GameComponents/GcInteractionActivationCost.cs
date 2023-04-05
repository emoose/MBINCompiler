using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4591D915DCDF9DB1, NameHash = 0xDF5512FA05691ED2)]
    public class GcInteractionActivationCost : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SubstanceId;
        /* 0x10 */ public List<NMSString0x10> AltIds;
        /* 0x20 */ public int Cost;
        /* 0x24 */ public bool Repeat;
        /* 0x28 */ public NMSString0x10 RequiredTech;
        /* 0x38 */ public NMSString0x10 UseCostID;
        /* 0x48 */ public NMSString0x10 StartMissionOnCantAfford;
        /* 0x58 */ public List<int> OnlyChargeDuringSeasons;
    }
}
