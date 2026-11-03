using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x722050D88B60EB0C, NameHash = 0x52BE77F8)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        [NMS(Index = 5)]
        /* 0x00 */ public NMSString0x10 NeedsMissionActive;
        [NMS(Index = 7)]
        /* 0x10 */ public GcGalaxyStarTypes NeedsStarType;
        [NMS(Index = 1)]
        /* 0x14 */ public bool NeedsAbandonedSystem;
        [NMS(Index = 3)]
        /* 0x15 */ public bool NeedsAsteroidField;
        [NMS(Index = 0)]
        /* 0x16 */ public bool NeedsEmptySystem;
        [NMS(Index = 4)]
        /* 0x17 */ public bool NeedsNearbyCorruptWorld;
        [NMS(Index = 2)]
        /* 0x18 */ public bool NeedsPirateSystem;
        [NMS(Index = 6)]
        /* 0x19 */ public bool UseStarType;
    }
}
