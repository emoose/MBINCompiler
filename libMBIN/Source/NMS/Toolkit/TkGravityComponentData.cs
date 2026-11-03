namespace libMBIN.NMS.Toolkit
{
    [NMS(GUID = 0x51F3C7940B7E0D2D, NameHash = 0x41722F61)]
    public class TkGravityComponentData : NMSTemplate
    {
        [NMS(Index = 3)]
        /* 0x00 */ public Vector3f OverrideBounds;
        [NMS(Index = 1)]
        /* 0x10 */ public float FalloffRadius;
        [NMS(Index = 0)]
        /* 0x14 */ public float Strength;
        [NMS(Index = 2)]
        /* 0x18 */ public bool MoveWithParent;
    }
}
