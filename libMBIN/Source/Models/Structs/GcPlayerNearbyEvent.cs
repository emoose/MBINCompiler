namespace libMBIN.Models.Structs
{
    public class GcPlayerNearbyEvent : NMSTemplate      // size: 0x24
    {
        public int RequirePlayerAction;
        public string[] RequirePlayerActionValues()
        {
            return new[] { "None", "Fire", "InShip", "OnFoot", "OnFootOutside", "Upload" };
        }
        public float Distance;
        public float Angle;
        public bool AnglePlayerRelative;
        public float AngleOffset;
        public bool AngleReflected;
        public float AngleMinDistance;
        public int DistanceCheckType;
        public string[] DistanceCheckTypeValues()
        {
            return new[] { "Radius", "BoundingBox" };
        }
        public bool Inverse;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding21;
    }
}
