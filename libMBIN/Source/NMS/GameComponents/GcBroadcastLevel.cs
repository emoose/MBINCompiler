namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3BCCD8E73F2DF785, NameHash = 0x788C67D6B87C29E3)]
    public class GcBroadcastLevel : NMSTemplate
    {
        // size: 0x3
        public enum BroadcastLevelEnum : uint {
            Scene,
            LocalModel,
            Local,
        }
        /* 0x0 */ public BroadcastLevelEnum BroadcastLevel;
    }
}
