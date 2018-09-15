using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(GUID = 0xFEB265C930EFAC22)]
    public class GcCostMissionComplete : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Cost;
    }
}
