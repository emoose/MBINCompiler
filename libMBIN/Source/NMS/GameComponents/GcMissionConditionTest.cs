using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0x0EA3C8CC4592D4410)]
    public class GcMissionConditionTest : NMSTemplate
    {
		public enum ConditionTestEnum { AnyFalse, AllFalse, AnyTrue, AllTrue }
		public ConditionTestEnum ConditionTest;
    }
}
