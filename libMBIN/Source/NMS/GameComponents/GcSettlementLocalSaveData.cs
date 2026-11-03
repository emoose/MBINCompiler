using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x5037993F707B2329, NameHash = 0x94C95B89)]
    public class GcSettlementLocalSaveData : NMSTemplate
    {
        [NMS(Index = 2, Size = 0x30)]
        /* 0x000 */ public ulong[] BuildingSeeds;
        [NMS(Index = 3)]
        /* 0x180 */ public GcByteBeatJukeboxData ByteBeatJukebox;
        [NMS(Index = 6, Size = 0x3)]
        /* 0x288 */ public GcSettlementTowerPowerTimestamps[] TowerPowerTimeStamps;
        [NMS(Index = 0)]
        /* 0x300 */ public ulong Seed;
        [NMS(Index = 1, Size = 0x30)]
        /* 0x308 */ public int[] Buildings;
        [NMS(Index = 5)]
        /* 0x3C8 */ public bool HasScannedToReveal;
        [NMS(Index = 4)]
        /* 0x3C9 */ public bool RequiresStatConversion;
    }
}
