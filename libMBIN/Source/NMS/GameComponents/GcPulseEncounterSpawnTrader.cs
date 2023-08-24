using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD1014F22A244874, NameHash = 0x61E014828AD14CD)]
    public class GcPulseEncounterSpawnTrader : NMSTemplate
    {
        /* 0x000 */ public GcResourceElement CustomShipResource;
        /* 0x2A8 */ public bool UseSystemSeedForResource;
        /* 0x2A9 */ public bool UseCustomMessage;
        /* 0x2B0 */ public NMSString0x20A CustomHailOSD;
        /* 0x2D0 */ public bool WarpOutOnCombatStart;
        /* 0x2D4 */ public GcRealityCommonFactions ShipTrailFactionOverride;
        /* 0x2D8 */ public GcPlayerCommunicatorMessage HailingMessage;
    }
}
