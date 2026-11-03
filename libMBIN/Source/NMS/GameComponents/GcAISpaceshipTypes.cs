namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x9A8514074A937619, NameHash = 0xDA426786)]
    public class GcAISpaceshipTypes : NMSTemplate
    {
        // size: 0x8
        public enum ShipTypeEnum : uint {
            None,
            Pirate,
            Police,
            Trader,
            Freighter,
            PlayerSquadron,
            DefenceForce,
            SwarmDrone,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ShipTypeEnum ShipType;
    }
}
