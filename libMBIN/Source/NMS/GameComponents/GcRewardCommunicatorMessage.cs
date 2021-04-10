using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x1D8, GUID = 0xA4CCC2F6A734A389, NameHash = 0x382AC51563627203)]
    public class GcRewardCommunicatorMessage : NMSTemplate
    {
        [NMS(Size = 0x80)]
        /* 0x000 */ public string Message;
        [NMS(Size = 0x80)]
        /* 0x080 */ public string VRMessage;
        [NMS(Size = 0x80)]
        /* 0x100 */ public string OSDMessage;
        /* 0x180 */ public GcPlayerCommunicatorMessage Comms;
        /* 0x1D0 */ public bool AutoOpen;
        [NMS(Size = 0x7, Ignore = true)]
        /* 0x1D1 */ public byte[] EndPadding;
    }
}
