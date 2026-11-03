using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3B0A8A39310D1D08, NameHash = 0xAB03C4C5)]
    public class GcHazardZoneComponentData : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x00 */ public NMSString0x20A OSDOnEntry;
        [NMS(Index = 5)]
        /* 0x20 */ public List<GcImpactCombatEffectData> CombatEffectsOnEntry;
        [NMS(Index = 3)]
        /* 0x30 */ public NMSString0x10 DamageOnEntry;
        [NMS(Index = 1)]
        /* 0x40 */ public float HazardStrength;
        [NMS(Index = 0)]
        /* 0x44 */ public GcPlayerHazardType HazardType;
        [NMS(Index = 2)]
        /* 0x48 */ public float Radius;
    }
}
