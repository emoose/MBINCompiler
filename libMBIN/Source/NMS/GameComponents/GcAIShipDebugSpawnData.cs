namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xD616A0433497617, NameHash = 0xDFA8A7A9DD3ACC08)]
    public class GcAIShipDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public Vector3f Facing;
        /* 0x20 */ public Vector3f Up;
        /* 0x30 */ public Vector3f FlightDir;
        /* 0x40 */ public float Speed;
        /* 0x44 */ public float IgnitionDelay;
        /* 0x48 */ public float TakeOffDelay;
        /* 0x4C */ public float HoverTime;
        /* 0x50 */ public float HoverHeight;
        /* 0x54 */ public float WarpOutTime;
        /* 0x58 */ public bool Wingman;
        /* 0x59 */ public NMSString0x80 SpecificModel;
        /* 0xE0 */ public GcSeed Seed;
    }
}
