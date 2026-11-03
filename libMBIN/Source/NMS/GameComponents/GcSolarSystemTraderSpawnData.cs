namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3E496A6D3A2971BF, NameHash = 0x13819499)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate
    {
        [NMS(Index = 2, MxmlName = "Sequence Takeoff Delay")]
        /* 0x00 */ public Vector2f SequenceTakeoffDelay;
        [NMS(Index = 3)]
        /* 0x08 */ public int ChanceToDelayLaunch;
        [NMS(Index = 1, MxmlName = "Initial Takeoff Delay")]
        /* 0x0C */ public float InitialTakeoffDelay;
        [NMS(Index = 0)]
        /* 0x10 */ public int MaxToSpawn;
    }
}
