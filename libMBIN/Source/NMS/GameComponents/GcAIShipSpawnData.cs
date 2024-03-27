using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xBEFE1C3015A6B9AA, NameHash = 0x35C91009067A6431)]
    public class GcAIShipSpawnData : NMSTemplate
    {
        /* 0x000 */ public NMSString0x20A Message;
        /* 0x020 */ public NMSString0x20A CombatMessage;
        /* 0x040 */ public NMSString0x20A OSDMessage;
        /* 0x060 */ public TkInputEnum Shortcut;
        /* 0x064 */ public bool WarpIn;
        /* 0x068 */ public GcAISpaceshipRoles Role;
        /* 0x06C */ public float MinRange;
        /* 0x070 */ public Vector2f Scale;
        /* 0x078 */ public NMSString0x10 Reward;
        /* 0x088 */ public NMSString0x20A RewardMessage;
        /* 0x0A8 */ public GcAIShipSpawnMarkerData MarkerData;
        /* 0x168 */ public bool AttackFreighter;
        /* 0x170 */ public NMSString0x10 AttackDefinition;
        /* 0x180 */ public Vector2f Spread;
        /* 0x190 */ public Vector3f OffsetSphereOffset;
        /* 0x1A0 */ public Vector2f Count;
        /* 0x1A8 */ public Vector2f StartTime;
        // size: 0x3
        public enum SpawnShapeEnum : uint {
            Sphere,
            Cone,
            OffsetSphere,
        }
        /* 0x1B0 */ public SpawnShapeEnum SpawnShape;
        /* 0x1B8 */ public GcShipAIPerformanceArray Performances;
        /* 0x1C8 */ public List<GcAIShipSpawnData> ChildSpawns;
    }
}
