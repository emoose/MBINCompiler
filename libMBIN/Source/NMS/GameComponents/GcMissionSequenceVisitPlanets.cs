using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB1D6B88D4EAC0FE5, NameHash = 0xA6EC06362FCAD424)]
    public class GcMissionSequenceVisitPlanets : NMSTemplate
    {
        /* 0x000 */ public NMSString0x80 Message;
        /* 0x080 */ public NMSString0x80 MessageOnIncompletePlanet;
        /* 0x100 */ public List<GcBiomeType> PlanetTypesToWatch;
        /* 0x110 */ public bool MustAlsoDiscover;
        /* 0x111 */ public bool MustAlsoTakePhoto;
        /* 0x114 */ public int NumberOfEachToDiscover;
        /* 0x118 */ public bool TakeNumberFromSeasonalData;
        /* 0x119 */ public NMSString0x80 DebugText;
    }
}
