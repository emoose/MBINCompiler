namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x871776ED760BBC4, NameHash = 0xBEB7D85C)]
    public class GcMissionConditionTest : NMSTemplate
    {
        // size: 0x4
        public enum ConditionTestEnum : uint {
            AnyFalse,
            AllFalse,
            AnyTrue,
            AllTrue,
        }
        [NMS(Index = 0)]
        /* 0x0 */ public ConditionTestEnum ConditionTest;
    }
}
