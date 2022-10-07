namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x6093D382214F692D, NameHash = 0xB7FEFB0DFC120BF4)]
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        /* 0x00 */ public NMSString0x10 Squad;
        /* 0x10 */ public float PlayerOffset;
        /* 0x14 */ public float PlayerFalloff;
        /* 0x18 */ public float PathOffset;
        /* 0x1C */ public float WaypointDistance;
        /* 0x20 */ public float PathSpeed;
        /* 0x24 */ public float AlongPathForce;
        /* 0x28 */ public float ToPathForce;
        /* 0x2C */ public float BrakeForce;
        /* 0x30 */ public float AlignForce;
    }
}
