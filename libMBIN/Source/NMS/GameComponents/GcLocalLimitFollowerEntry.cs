namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x703C6388C7380944, NameHash = 0x50926458)]
    public class GcLocalLimitFollowerEntry : NMSTemplate
    {
        [NMS(Index = 4)]
        /* 0x000 */ public float MaxAngleX;
        [NMS(Index = 7)]
        /* 0x004 */ public float MaxAngleY;
        [NMS(Index = 10)]
        /* 0x008 */ public float MaxAngleZ;
        [NMS(Index = 3)]
        /* 0x00C */ public float MinAngleX;
        [NMS(Index = 6)]
        /* 0x010 */ public float MinAngleY;
        [NMS(Index = 9)]
        /* 0x014 */ public float MinAngleZ;
        [NMS(Index = 1)]
        /* 0x018 */ public NMSString0x100 FollowedJoint;
        [NMS(Index = 0)]
        /* 0x118 */ public NMSString0x100 FollowingJoint;
        [NMS(Index = 2)]
        /* 0x218 */ public bool LimitAngleX;
        [NMS(Index = 5)]
        /* 0x219 */ public bool LimitAngleY;
        [NMS(Index = 8)]
        /* 0x21A */ public bool LimitAngleZ;
    }
}
