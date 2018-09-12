namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x0EA3C8CC4592D4410)]
    public class GcMissionConditionTest : NMSTemplate
    {
		public enum ConditionTestEnum { AnyFalse, AllFalse, AnyTrue, AllTrue }
		public ConditionTestEnum ConditionTest;
    }
}
