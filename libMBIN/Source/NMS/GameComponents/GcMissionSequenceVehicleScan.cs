using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x120, GUID = 0x6F4C4C313902695A)]
    public class GcMissionSequenceVehicleScan : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x00 */ public string Message;
        [NMS(Size = 0x20)]
        /* 0x80 */ public string ScanEventID;
        [NMS(Size = 0x80)]
        /* 0xA0 */ public string DebugText;
    }
}
