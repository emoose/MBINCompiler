using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x8, GUID = 0x839C25A4CCA9B9FA)]
    public class GcMissionConditionWaitForTime : NMSTemplate
    {
        public ulong WaitTimeInSeconds;
    }
}
