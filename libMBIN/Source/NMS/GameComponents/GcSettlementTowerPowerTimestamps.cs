using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD78B9DD340B99F99, NameHash = 0xA6D02AE4)]
    public class GcSettlementTowerPowerTimestamps : NMSTemplate
    {
        [NMS(Index = 1, Size = 0x4, EnumType = typeof(GcSettlementTowerPower.SettlementTowerPowerEnum))]
        /* 0x00 */ public ulong[] TimeStamps;
        [NMS(Index = 0)]
        /* 0x20 */ public sbyte ClusterIndex;
    }
}
