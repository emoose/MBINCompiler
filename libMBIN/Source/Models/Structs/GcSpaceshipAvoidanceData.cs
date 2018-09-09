namespace libMBIN.Models.Structs
{
	[NMS(GUID = 0x4BE1B6BC289E2D1C)]
    public class GcSpaceshipAvoidanceData : NMSTemplate
    {
        public int NumRays;
        public float RayMinRange;
        public float RaySpeedTime;
        public float Force;
        public float StartRadiusMultiplier;
        public float EndRadiusMultiplier;
        public float SpeedInterp;
        public float SpeedInterpMinSpeed;
        public float SpeedInterpRange;
    }
}
