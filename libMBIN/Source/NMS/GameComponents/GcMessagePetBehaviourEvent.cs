using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7757C19A4CB59A6A, NameHash = 0x9465A52B8A2F9FD9)]
    public class GcMessagePetBehaviourEvent : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 BehaviourEvent;
        /* 0x10 */ public NMSString0x20A UserData;
        /* 0x30 */ public GcPetBehaviours ForceBehaviour;
        /* 0x34 */ public GcAlienMood Mood;
        /* 0x40 */ public Vector3f Position;
        /* 0x50 */ public Vector3f Direction;
        /* 0x60 */ public GcNodeID SourceNode;
    }
}
