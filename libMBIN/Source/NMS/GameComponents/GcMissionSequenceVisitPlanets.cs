using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xF52E36B8E52DCB81, NameHash = 0xA6EC06362FCAD424)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public List<GcBiomeType> PlanetTypesToWatch;
        /* 0x90 */ public bool MustAlsoDiscover;
        /* 0x94 */ public int NumberOfEachToDiscover;
        /* 0x98 */ public bool TakeNumberFromSeasonalData;
        /* 0x99 */ public NMSString0x80 DebugText;
    }
}
