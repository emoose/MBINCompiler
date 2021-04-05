using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x120, GUID = 0x0000000000000000, NameHash = 0xA6EC06362FCAD424)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        /* 0x080 */ public List<GcBiomeType> PlanetTypesToWatch;
        /* 0x090 */ public bool MustAlsoDiscover;
        /* 0x094 */ public int NumberOfEachToDiscover;
        /* 0x098 */ public bool TakeNumberFromSeasonalData;
        [NMS(Size = 0x80)]
        /* 0x099 */ public string DebugText;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x119 */ public byte[] EndPadding;
    }
}
