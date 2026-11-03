using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xB0334F47C8974CC1, NameHash = 0xD5360DDC)]
    public class GcPoliceSpawnWaveData : NMSTemplate
    {
        [NMS(Index = 0)]
        /* 0x000 */ public GcAIShipSpawnData ShipData;
        [NMS(Index = 1, Size = 0x4)]
        /* 0x160 */ public int[] MaxCountsForFireteamSize;
    }
}
