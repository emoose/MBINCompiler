namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9136E5530A583E47, NameHash = 0xD0217E81661C9C1D)]
    public class GcBackgroundSpaceEncounterSpawnConditions : NMSTemplate
    {
        /* 0x0 */ public bool NeedsEmptySystem;
        /* 0x1 */ public bool NeedsAbandonedSystem;
        /* 0x2 */ public bool NeedsPirateSystem;
        /* 0x3 */ public bool NeedsAsteroidField;
    }
}
