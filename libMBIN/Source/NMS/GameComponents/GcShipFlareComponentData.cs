namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEBF801966BC366D0, NameHash = 0x6C078BF2)]
    public class GcShipFlareComponentData : NMSTemplate
    {
        // size: 0x1
        public enum FlareTypeEnum : uint {
            Default,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public FlareTypeEnum FlareType;
    }
}
