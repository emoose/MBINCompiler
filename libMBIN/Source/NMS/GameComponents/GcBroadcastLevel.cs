namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x756EC450B41A3FA5, NameHash = 0x788C67D6B87C29E3)]
    public class GcBroadcastLevel : NMSTemplate
    {
        // size: 0x3
        public enum BroadcastLevelEnum {
            Scene,
            LocalModel,
            Local,
        }
        /* 0x0 */ public BroadcastLevelEnum BroadcastLevel;
    }
}
