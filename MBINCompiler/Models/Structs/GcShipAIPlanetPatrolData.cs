namespace MBINCompiler.Models.Structs
{
    public class GcShipAIPlanetPatrolData : NMSTemplate
    {
        [NMS(Size = 0x10)]
        public string Squad;

        public float PlayerOffset;
        public float PlayerFalloff;
        public float PathOffset;
        public float WaypointDistance;
        public float PathSpeed;
        public float AlongPathForce;
        public float ToPathForce;
        public float BrakeForce;
        public float AlignForce;

        [NMS(Size = 4, Ignore = true)]
        public byte[] Padding34;
    }
}
