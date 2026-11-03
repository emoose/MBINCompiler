using libMBIN.NMS.GameComponents;
using System.Collections.Generic;

namespace libMBIN.NMS.GameComponents
{
    [NMS(GUID = 0xA8F1BB4300E03C53, NameHash = 0x85001767)]
    public class GcDebugCamera : NMSTemplate
    {
        [NMS(Index = 2)]
        /* 0x00 */ public List<GcDebugCameraEntry> Waypoints;
        [NMS(Index = 0)]
        /* 0x10 */ public float BaseSpeed;
        [NMS(Index = 3)]
        /* 0x14 */ public int CurrentWaypoint;
        [NMS(Index = 4)]
        /* 0x18 */ public float CurrentWaypointProgress;
        [NMS(Index = 1)]
        /* 0x1C */ public float Smoothing;
    }
}
