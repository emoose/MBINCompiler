using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x18, GUID = 0x924CF80466FFBE44, NameHash = 0x14E2334CC95303F7)]
    public class GcAtlasSendSubmitContributionActual : NMSTemplate
    {
        /* 0x00 */ public GcAtlasShared SharedData;  // Note: This is pretty much a dummy.
        /* 0x10 */ public int MissionIndex;
        /* 0x14 */ public int Contribution;
    }
}
