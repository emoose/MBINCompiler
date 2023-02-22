using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3FC636475190B910, NameHash = 0x40F7E71C83A33DA0)]
    public class GcMessageNPCBehaviourEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BehaviourEvent;
        /* 0x10 */ public NMSString0x10 UserData;
        /* 0x20 */ public GcNPCTriggerTypes InteractionTrigger;
        /* 0x24 */ public int InteractionSubType;
        /* 0x30 */ public Vector3f Position;
        /* 0x40 */ public GcNodeID SourceNode;
    }
}
