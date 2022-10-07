namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xEA3C8CC4592D4410, NameHash = 0xC1BECA54193DD3FB)]
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
