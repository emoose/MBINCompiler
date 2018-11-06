using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
	[NMS(Size = 0x24, Alignment = 0x4, GUID = 0x3BD123ED9F9C4AAE)]
    public class GcPlayerNearbyEvent : NMSTemplate
    {
		public enum RequirePlayerActionEnum { None, Fire, InShip, OnFoot, OnFootOutside, Upload }
		public RequirePlayerActionEnum RequirePlayerAction;
        public float Distance;
        public float Angle;
        public bool AnglePlayerRelative;
        public float AngleOffset;
        public bool AngleReflected;
        public float AngleMinDistance;
		public enum DistanceCheckTypeEnum { Radius, BoundingBox }
		public DistanceCheckTypeEnum DistanceCheckType;
        public bool Inverse;

        [NMS(Size = 3, Ignore = true)]
        public byte[] Padding21;
    }
}
