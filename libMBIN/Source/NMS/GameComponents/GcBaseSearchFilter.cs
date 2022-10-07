using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x92125C1B9D01E7D3, NameHash = 0x53636362EAB448BF)]
    public class GcBaseSearchFilter : NMSTemplate
    {
        /* 0x00 */ public bool OnCurrentPlanet;
        /* 0x01 */ public bool InCurrentSystem;
        /* 0x02 */ public bool IsOverlapping;
        /* 0x08 */ public ulong OnSpecificPlanet;
        /* 0x10 */ public ulong InSpecificSystem;
        /* 0x18 */ public NMSString0x20A OnSpecificPlanetScanEvent;
        /* 0x38 */ public List<GcPersistentBaseTypes> MatchingTypes;
        /* 0x48 */ public GcBasePartSearchFilter BasePartFilter;
        /* 0x90 */ public int ContainsMinParts;
        /* 0x94 */ public int ContainsMaxParts;
    }
}
