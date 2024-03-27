namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0xC6CBA4BB1305622B, NameHash = 0x38D7F8085AD4CE3)]
    public class TkCreatureTailJoints : NMSTemplate
    {
        /* 0x00 */ public NMSString0x20 StartJoint;
        /* 0x20 */ public NMSString0x20 EndJoint;
        /* 0x40 */ public float InterpSpeedHead;
        /* 0x44 */ public float InterpSpeedTail;
        /* 0x48 */ public float PullSpeedMin;
        /* 0x4C */ public float PullSpeedMax;
        /* 0x50 */ public float StrengthX;
        /* 0x54 */ public float StrengthY;
        /* 0x58 */ public float StrengthZ;
        /* 0x5C */ public float SwimPhaseOffset;
    }
}
