using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x10, GUID = 0x6A9DDB8006A4E264)]
    public class GcAtlasSendSubmitContribution : NMSTemplate
    {
        /* 0x00 */ public ulong ClientUserdata;
        /* 0x08 */ public int MissionIndex;
        /* 0x0C */ public int Contribution;
    }
}
