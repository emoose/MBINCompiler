using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2BDC1A5A7798CA8D, NameHash = 0xDF5512FA05691ED2)]
    public class GcInteractionActivationCost : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 SubstanceId;
        /* 0x10 */ public List<NMSString0x10> AltIds;
        /* 0x20 */ public int Cost;
        /* 0x24 */ public bool Repeat;
        /* 0x28 */ public NMSString0x10 RequiredTech;
        /* 0x38 */ public List<int> OnlyChargeDuringSeasons;
    }
}
