using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x2823AE055070AEBD, NameHash = 0xBE42E310FC94C8E3)]
    public class GcCreatureWeirdMovementData : NMSTemplate
    {
        // size: 0x3
        public enum MoveModeEnum {
            Roll,
            Float,
            Drill,
        }
        /* 0x000 */ public MoveModeEnum MoveMode;
        /* 0x004 */ public NMSString0x100 Node;
        /* 0x104 */ public float BobSpeed;
        /* 0x108 */ public float BobAmount;
        /* 0x10C */ public float SpinSpeed;
        /* 0x110 */ public float JumpAngle;
        /* 0x118 */ public List<NMSString0x100> FeetNames;
    }
}
