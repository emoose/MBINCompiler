namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4A9EA671BB4E86D8, NameHash = 0x436337B25B8F877E)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        /* 0x00 */ public int MaxToSpawn;
        /* 0x04 */ public float InitialTakeoffDelay;
        /* 0x08 */ public Vector2f SequenceTakeoffDelay;
        /* 0x10 */ public int ChanceToDelayLaunch;
    }
}
