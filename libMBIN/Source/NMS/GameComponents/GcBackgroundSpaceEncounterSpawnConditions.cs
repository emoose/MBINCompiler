namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x755095622B67798F, NameHash = 0xD0217E81661C9C1D)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        /* 0x0 */ public bool NeedsEmptySystem;
        /* 0x1 */ public bool NeedsAbandonedSystem;
        /* 0x2 */ public bool NeedsPirateSystem;
        /* 0x3 */ public bool NeedsAsteroidField;
        /* 0x4 */ public bool NeedsNearbyCorruptWorld;
        /* 0x8 */ public NMSString0x10 NeedsMissionActive;
    }
}
