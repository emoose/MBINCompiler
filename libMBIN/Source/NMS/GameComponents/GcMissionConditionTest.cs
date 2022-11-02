namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3F1642161707CBD3, NameHash = 0xC1BECA54193DD3FB)]
    public class GcMissionConditionTest : NMSTemplate
    {
        // size: 0x4
        public enum ConditionTestEnum {
            AnyFalse,
            AllFalse,
            AnyTrue,
            AllTrue
        }
        /* 0x0 */ public ConditionTestEnum ConditionTest;
    }
}
