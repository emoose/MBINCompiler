using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x264EC1C6AC353F1A, NameHash = 0x552AE513)]
    public class GcMessageNPCGameTableEvent : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public long GameTableLocatorAttachmentPtr;
        [NMS(Index = 2)]
        /* 0x08 */ public float EventScale;
        [NMS(Index = 0)]
        /* 0x0C */ public GcGameTableNPCEventTrigger Trigger;
        [NMS(Index = 1)]
        /* 0x10 */ public GcGameTableNPCEventTriggerOwner TriggerOwner;
    }
}
