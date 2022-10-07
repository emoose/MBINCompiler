namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x44C32992EA40A1A0, NameHash = 0x8CBF91F9F8428E08)]
    public class GcAISpaceshipTypes : NMSTemplate
    {
        // size: 0x7
        public enum ShipTypeEnum {
            None,
            Pirate,
            Police,
            Trader,
            Freighter,
            PlayerSquadron,
            DefenceForce
        }
        /* 0x0 */ public ShipTypeEnum ShipType;
    }
}
