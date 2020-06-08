using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x40, GUID = 0x1BEA8E7774A5394D, NameHash = 0x4EDC167332F6B824)]
    public class GcSeasonalMilestone : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string NotificationSequence;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string Description;
        [NMS(Size = 0x10)]
        /* 0x30 */ public string Reward;
    }
}
