namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x460A5242E45C4AF8)]
    public class GcSolarSystemTraderSpawnData : NMSTemplate     // in global?
    {
        public int MaxToSpawn;                      // 3
        public float InitialTakeoffDelay;           // 40400000h
        public Vector2f SequenceTakeoffDelay;       // 40400000h
        public int ChanceToDelayLaunch;             // 40A00000h
    }
}
