using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x70, GUID = 0x306E8557E0A11798, NameHash = 0x9465A52B8A2F9FD9)]
    public class GcMessagePetBehaviourEvent : NMSTemplate
    {
        [NMS(Size = 0x10)]
        /* 0x00 */ public string BehaviourEvent;
        [NMS(Size = 0x20)]
        /* 0x10 */ public string UserData;
        /* 0x30 */ public GcPetBehaviours ForceBehaviour;
        /* 0x34 */ public GcAlienMood Mood;
        /* 0x40 */ public Vector3f Position;
        /* 0x50 */ public Vector3f Direction;
        // There are 0x10 empty bytes at the end?? Something is weird here...
        [NMS(Size = 0x10, Ignore = true)]
        /* 0x60 */ public byte[] EndPadding;
    }
}
