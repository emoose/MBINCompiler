using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7B423F05942EB5E, NameHash = 0x382AC51563627203)]
    public class GcRewardCommunicatorMessage : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20A FailureMessageBusy;
        /* 0x20 */ public NMSString0x20A FailureMessageNotInShip;
        /* 0x40 */ public GcPlayerCommunicatorMessage Comms;
    }
}
