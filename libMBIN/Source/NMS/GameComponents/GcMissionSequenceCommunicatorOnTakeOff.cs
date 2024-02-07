using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xC459E65422C781C6, NameHash = 0x8667E548FE078CD2)]
    public class GcMissionSequenceCommunicatorOnTakeOff : NMSTemplate
    {
        /* 0x00 */ public NMSString0x80 Message;
        /* 0x80 */ public GcPlayerCommunicatorMessage Comms;
        /* 0xD8 */ public NMSString0x80 DebugText;
    }
}
