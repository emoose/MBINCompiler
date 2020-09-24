using System.Collections.Generic;

using libMBIN.NMS.Toolkit;
using libMBIN.NMS.GameComponents;

namespace libMBIN.NMS.GameComponents
{
    [NMS(Size = 0x60, GUID = 0x5DBF8F3AB3C11E33, NameHash = 0x1D427C136EB50E9D)]
    public class GcNPCDebugSpawnData : NMSTemplate
    {
        /* 0x00 */ public Vector3f Position;
        /* 0x10 */ public Vector3f Facing;
        /* 0x20 */ public Vector3f up;
        /* 0x30 */ public bool FollowWaypoints;
        /* 0x34 */ public float InitialDelay;
        /* 0x38 */ public List<Vector4f> Waypoints;
        /* 0x48 */ public bool Run;
        /* 0x4C */ public GcAlienRace Race;
        /* 0x50 */ public GcSeed Seed;
    }
}
