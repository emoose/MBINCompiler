using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x623E7EFDADF80C4D, NameHash = 0xEF9D92B5E5974FCC)]
    public class GcPoliceSpawnWaveData : NMSTemplate
    {
        /* 0x000 */ public GcAIShipSpawnData ShipData;
        [NMS(Size = 0x4)]
        /* 0x1A8 */ public int[] MaxCountsForFireteamSize;
    }
}
