namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0x27BC3B6A2294B4C9, NameHash = 0x8A8D7D07807BE9DC)]
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
        /* 0x20 */ public NMSString0x10 MustAffordCostID;
        // size: 0x2
        public enum DistanceCheckTypeEnum : uint {
            Radius,
            BoundingBox,
        }
        /* 0x30 */ public DistanceCheckTypeEnum DistanceCheckType;
        /* 0x34 */ public bool Inverse;
        /* 0x35 */ public bool OnlyForLocalPlayer;
        /* 0x36 */ public bool IncludeAllPhysics;
        /* 0x37 */ public bool IncludeMobileNPCs;
        /* 0x38 */ public bool TeleporterCountsAsPlayer;
    }
}
