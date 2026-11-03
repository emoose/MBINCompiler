namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x834C6B94739EC662, NameHash = 0xB21C5F1F)]
    public class GcBroadcastLevel : NMSTemplate
    {
        // size: 0x3
        public enum BroadcastLevelEnum : uint {
            Scene,
            LocalModel,
            Local,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public BroadcastLevelEnum BroadcastLevel;
    }
}
