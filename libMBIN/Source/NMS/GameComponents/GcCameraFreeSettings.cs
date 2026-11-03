namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x42F6706DED75D47E, NameHash = 0xEA54A974)]
    public class GcCameraFreeSettings : NMSTemplate
    {
        [NMS(Index = 7)]
        /* 0x00 */ public Vector3f InitialOffset;
        [NMS(Index = 6)]
        /* 0x10 */ public Vector3f Offset;
        [NMS(Index = 5)]
        /* 0x20 */ public float CollisionRadius;
        [NMS(Index = 2)]
        /* 0x24 */ public float MaxDistance;
        [NMS(Index = 4)]
        /* 0x28 */ public float MaxDistanceClampBuffer;
        [NMS(Index = 3)]
        /* 0x2C */ public float MaxDistanceClampForce;
        [NMS(Index = 0)]
        /* 0x30 */ public float MoveSpeed;
        [NMS(Index = 1)]
        /* 0x34 */ public float TurnSpeed;
    }
}
