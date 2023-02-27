namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x3AA04401A1C10893, NameHash = 0x8A8D7D07807BE9DC)]
    public class GcPlayerNearbyEvent : NMSTemplate
    {
        // size: 0x6
        public enum RequirePlayerActionEnum : uint {
            None,
            Fire,
            InShip,
            OnFoot,
            OnFootOutside,
            Upload,
        }
        /* 0x00 */ public RequirePlayerActionEnum RequirePlayerAction;
        /* 0x04 */ public float Distance;
        /* 0x08 */ public float Angle;
        /* 0x0C */ public bool AnglePlayerRelative;
        /* 0x10 */ public float AngleOffset;
        /* 0x14 */ public bool AngleReflected;
        /* 0x18 */ public float AngleMinDistance;
        // size: 0x2
        public enum DistanceCheckTypeEnum : uint {
            Radius,
            BoundingBox,
        }
        /* 0x1C */ public DistanceCheckTypeEnum DistanceCheckType;
        /* 0x20 */ public bool Inverse;
        /* 0x21 */ public bool OnlyForLocalPlayer;
        /* 0x22 */ public bool IncludeAllPhysics;
        /* 0x23 */ public bool IncludeMobileNPCs;
        /* 0x24 */ public bool TeleporterCountsAsPlayer;
    }
}
