namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x7F779F4D2F6BD0FD, NameHash = 0xC455782DFAD32032)]
    public class GcBoidData : NMSTemplate
    {
        /* 0x00 */ public float Coherence;
        /* 0x04 */ public float Alignment;
        /* 0x08 */ public float Separation;
        /* 0x0C */ public float Spacing;
        /* 0x10 */ public float Follow;
        /* 0x14 */ public float DirectionBrake;
        /* 0x18 */ public float MaxSpeed;
        /* 0x1C */ public float InitTime;
        /* 0x20 */ public float InitOffset;
        /* 0x24 */ public float InitFacingOffset;
        /* 0x28 */ public float LeadTime;
    }
}
