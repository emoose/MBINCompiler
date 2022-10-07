namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x460A5242E45C4AF8, NameHash = 0x436337B25B8F877E)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        /* 0x00 */ public int MaxToSpawn;
        /* 0x04 */ public float InitialTakeoffDelay;
        /* 0x08 */ public Vector2f SequenceTakeoffDelay;
        /* 0x10 */ public int ChanceToDelayLaunch;
    }
}
