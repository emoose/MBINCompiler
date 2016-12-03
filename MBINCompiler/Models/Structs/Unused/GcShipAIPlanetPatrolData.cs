namespace MBINCompiler.Models.Structs
{
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        /* 0x000 */ public string Squad;
        /* 0x010 */ public float PlayerOffset;
        /* 0x014 */ public float PlayerFalloff;
        /* 0x018 */ public float PathOffset;
        /* 0x01C */ public float WaypointDistance;
        /* 0x020 */ public float PathSpeed;
        /* 0x024 */ public float AlongPathForce;
		/* 0x028 */ public float ToPathForce;
		/* 0x02C */ public float BrakeForce;
		/* 0x030 */ public float AlignForce;
    }
}
