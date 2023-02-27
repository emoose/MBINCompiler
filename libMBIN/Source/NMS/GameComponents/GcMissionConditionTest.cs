namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x30816B6D0D302F6E, NameHash = 0xC1BECA54193DD3FB)]
    public class GcMissionConditionTest : NMSTemplate
    {
        // size: 0x4
        public enum ConditionTestEnum : uint {
            AnyFalse,
            AllFalse,
            AnyTrue,
            AllTrue,
        }
        /* 0x0 */ public ConditionTestEnum ConditionTest;
    }
}
