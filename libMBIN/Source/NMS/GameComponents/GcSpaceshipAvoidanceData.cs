namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x4BE1B6BC289E2D1C, NameHash = 0xE607B9EEA91E2AD5)]
    public class GcSpaceshipAvoidanceData : NMSTemplate
    {
        /* 0x00 */ public int NumRays;
        /* 0x04 */ public float RayMinRange;
        /* 0x08 */ public float RaySpeedTime;
        /* 0x0C */ public float Force;
        /* 0x10 */ public float StartRadiusMultiplier;
        /* 0x14 */ public float EndRadiusMultiplier;
        /* 0x18 */ public float SpeedInterp;
        /* 0x1C */ public float SpeedInterpMinSpeed;
        /* 0x20 */ public float SpeedInterpRange;
    }
}
