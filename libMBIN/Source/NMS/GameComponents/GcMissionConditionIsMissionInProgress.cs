using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 10, Alignment = 0x8, GUID = 0x0A3387EE10E7D102C)]
    public class GcMissionConditionIsMissionInProgress : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x0 */ public string MissionID;
    }
}
